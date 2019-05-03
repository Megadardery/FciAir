using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    
    class DBMS
    {
        private SqlConnection co;

        /// <summary>
        /// Establish a new instance of the Data Base Management System communicator.
        /// This starts the connection to the DataSource "localhost" and to the database "FciAir"
        /// </summary>
        public DBMS()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.IntegratedSecurity = true;

            builder.DataSource = "localhost";
            builder.InitialCatalog = "FciAir";

            co = new SqlConnection();
            co.ConnectionString = builder.ConnectionString;

        
            co.Open();
    
    
        }
        public static void CreateDatabase()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.IntegratedSecurity = true;

            builder.DataSource = "localhost";

            using (var myco = new SqlConnection())
            {
                myco.ConnectionString = builder.ConnectionString;
                myco.Open();
                using (var cmd = new SqlCommand(Properties.Resources.createDatabase, myco))
                    cmd.ExecuteNonQuery();
                using (var cmd = new SqlCommand(Properties.Resources.createDatabaseTables, myco))
                    cmd.ExecuteNonQuery();

                myco.Close();
            }
        }
        public void CloseConnection()
        {
            co.Close();
            co.Dispose();
        }
        public bool CheckPassword(int ID, string pass)
        {
            string query = $"SELECT AdminID FROM Admins WHERE AdminID = @ID AND Password = @pass";
            using (var cmd = new SqlCommand(query, co))
            {
                SqlDataReader reader = null;
                try
                {
                    cmd.Parameters.Add(new SqlParameter("@ID", ID));
                    cmd.Parameters.Add(new SqlParameter("@pass", HashPassword(pass)));
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                        return true;
                    else
                        return false;
                }
                finally
                {
                    reader.Close();
                }
            }
        }
        public int LoginAs(string mytype, string username, string pass)
        {
            string query = $"SELECT {mytype}ID FROM {mytype}s WHERE Username = @username AND Password = @pass";
            using (var cmd = new SqlCommand(query, co))
            {
                SqlDataReader reader = null;
                try
                {
                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    cmd.Parameters.Add(new SqlParameter("@pass", HashPassword(pass)));
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                        return (int)reader.GetValue(0);
                    else
                        return -1;
                }
                finally
                {
                    reader.Close();
                }
            }
        }
        public int LoginAdmin(string username, string pass)
        {
            return LoginAs("Admin", username, pass);
        }
        public int LoginCustomer(string username, string pass)
        {
            return LoginAs("Customer", username, pass);
        }
        public List<List<object>> GetTableData(string tablename,string where = "1=1", string what = "*")
        {
            var ret = new List<List<object>>();
            string query = $"SELECT {what} FROM {tablename} WHERE {where}";
            using (var cmd = new SqlCommand(query, co))
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var row = new List<object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                        row.Add(reader.GetValue(i));

                    ret.Add(row);
                }
                reader.Close();

            }
            return ret;

        }
        public List<List<object>> SearchBy(string tablename, string whereLeft, string whereRight, string what = "*")
        {
            var ret = new List<List<object>>();
            string query = $"SELECT {what} FROM {tablename} WHERE {whereLeft} = @whereRight";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@whereRight", whereRight));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var row = new List<object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                        row.Add(reader.GetValue(i));

                    ret.Add(row);
                }
                reader.Close();

            }
            return ret;

        }

        public List<string> GetTableColumns(string tablename , string what = "*")
        {
            var ret = new List<string>();
            string query = $"SELECT {what} FROM {tablename} WHERE 1=2";
            using (var cmd = new SqlCommand(query, co))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    ret.Add(reader.GetName(i));
                }
                reader.Close();
            }
            return ret;
        }
        
        public void InsertAdmin(string fName, string lName, string username, string pass)
        {
            string query = $"INSERT INTO Admins VALUES(@fName, @lName, @username, @pass)";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@fName", fName));
                cmd.Parameters.Add(new SqlParameter("@lName", lName));
                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.Parameters.Add(new SqlParameter("@pass", HashPassword(pass)));
                cmd.ExecuteNonQuery();
                
            }
        }
        public void InsertAircraft(int adminID, int maxSeat, string model)
        {
            string query = $"INSERT INTO Aircrafts VALUES(@adminID, @maxSeat, @model)";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@adminID", adminID));
                cmd.Parameters.Add(new SqlParameter("@maxSeat", maxSeat));
                cmd.Parameters.Add(new SqlParameter("@model", model));
                cmd.ExecuteNonQuery();
            }
        }
        public void InsertCustomer(string fName, string lName, string passPort, string nationality, DateTime birthdate, string username, string pass)
        {
            string query = $"INSERT INTO Customers VALUES(@fName, @lName, @passPort, @nationality, @birthdate, @username, @pass)";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@fName", fName));
                cmd.Parameters.Add(new SqlParameter("@lName", lName));
                cmd.Parameters.Add(new SqlParameter("@passPort", passPort));
                cmd.Parameters.Add(new SqlParameter("@nationality", nationality));
                cmd.Parameters.Add(new SqlParameter("@birthdate", birthdate));
                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.Parameters.Add(new SqlParameter("@pass", HashPassword(pass)));
                cmd.ExecuteNonQuery();
            }
        }
        public void InsertFlight(int airID, DateTime depart, DateTime arrive, int seat, string source, string destination)
        {
            string query = $"INSERT INTO Flights VALUES(@airID, @depart, @arrive, @seat, @source, @destination)";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@airID", airID));
                cmd.Parameters.Add(new SqlParameter("@depart", depart));
                cmd.Parameters.Add(new SqlParameter("@arrive", arrive));
                cmd.Parameters.Add(new SqlParameter("@seat", seat));
                cmd.Parameters.Add(new SqlParameter("@source", source));
                cmd.Parameters.Add(new SqlParameter("@destination", destination));
                cmd.ExecuteNonQuery();
            }
        }


        public void InsertMonitor(int admin, int flight)
        {
            string query = $"INSERT INTO Monitor VALUES(@admin, @flight)";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@admin", admin));
                cmd.Parameters.Add(new SqlParameter("@flight", flight));
                cmd.ExecuteNonQuery();
            }
        }
     
        public void InsertTicket(int flightID, int customerID, string Class, DateTime book)
        {
            string query = $"INSERT INTO Tickets VALUES (@flightID, @customerID, @Class, @book)";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@flightID", flightID));
                cmd.Parameters.Add(new SqlParameter("@customerID", customerID));
                cmd.Parameters.Add(new SqlParameter("@Class", Class));
                cmd.Parameters.Add(new SqlParameter("@book", book));
                cmd.ExecuteNonQuery();
            }
        }


        public void UpdateAdmin(int ID,string fName, string lName,string userName,string pass)
        {
            string query = $"UPDATE Admins SET FirstName=@fName,LastName=@lName,Username=@userName,Password=@pass WHERE AdminID=@ID";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@fName", fName));
                cmd.Parameters.Add(new SqlParameter("@lName", lName));
                cmd.Parameters.Add(new SqlParameter("@userName", userName));
                cmd.Parameters.Add(new SqlParameter("@pass", HashPassword(pass)));
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                cmd.ExecuteNonQuery();
            }

        }

        public void UpdateFlight(int ID,int AirID, DateTime depart,DateTime arrive ,int seat,string source,string dest)
        {
            string query = $"UPDATE Flights SET DepartTime=@depart,ArriveTime=@arrive,RequiredSeats=@seat,Source=@source,Destination=@dest,AircraftID=@AirID WHERE FlightID=@ID";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@depart",depart ));
                cmd.Parameters.Add(new SqlParameter("@arrive",arrive ));
                cmd.Parameters.Add(new SqlParameter("@seat",seat ));
                cmd.Parameters.Add(new SqlParameter("@source",source ));
                cmd.Parameters.Add(new SqlParameter("@dest",dest ));
                cmd.Parameters.Add(new SqlParameter("@AirID",AirID ));
                cmd.Parameters.Add(new SqlParameter("@ID",ID ));
                cmd.ExecuteNonQuery();
            }

        }

        public void UpdateAirCraft(int ID,int adminID, int seat, string model,string pName, DateTime date,int salary)
        {
            string query = $"UPDATE Aircraft SET AdminID = @adminID, Model=@model, MaxSeat=@seat,PilotName = @pname, Birthdate = @date, Salary = @salary WHERE AircraftID=@ID";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@model",model ));
                cmd.Parameters.Add(new SqlParameter("@pName",pName ));
                cmd.Parameters.Add(new SqlParameter("@seat",seat ));
                cmd.Parameters.Add(new SqlParameter("@salary",salary ));
                cmd.Parameters.Add(new SqlParameter("@date",date ));
                cmd.Parameters.Add(new SqlParameter("@ID",ID ));
                cmd.Parameters.Add(new SqlParameter("@adminID",adminID ));
                cmd.ExecuteNonQuery();
            }

        }

        public void UpdateCustomer(int ID, int passport, string fName, string lName, string userName,string pass, string nationality, DateTime birth)
        {
            string query = $"UPDATE Customer SET Passport=@passport,FirstName=@fName,LastName=@lName,Password=@pass,Birthdate=@birth,Nationality=nationality,Userename=@userName WHERE CustomerID=@ID";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@passport", passport));
                cmd.Parameters.Add(new SqlParameter("@fName", fName));
                cmd.Parameters.Add(new SqlParameter("@lName", lName));
                cmd.Parameters.Add(new SqlParameter("@pass", HashPassword(pass)));
                cmd.Parameters.Add(new SqlParameter("@birth", birth));
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                cmd.Parameters.Add(new SqlParameter("@nationality", nationality));
                cmd.Parameters.Add(new SqlParameter("@userName", userName));
                cmd.ExecuteNonQuery();
            }

        }

        public bool CheckUsername(string table,string username)
        {
            string query = $"select username from {table} where Username=@username";
            using (var cmd = new SqlCommand(query, co))
            {
                SqlDataReader reader = null;
                try
                {
                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                        return true;
                    else
                        return false;
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        public void DeleteAircrafts(int[] idx)
        {
            string query = $"DELETE FROM Aircrafts WHERE AircraftID IN ({String.Join(",", idx)})";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMonitor(int adminID, int aircraftID) { 
            string query = $"DELETE FROM Monitor WHERE AdminID = {adminID} AND AircraftID = {aircraftID}";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteCustomer(int[] idx)
        {
            string query = $"DELETE FROM Customers WHERE CustomerID IN ({String.Join(",", idx)})";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteFlight(int[] idx)
        {
            string query = $"DELETE FROM Flights WHERE FlightID IN ({String.Join(",", idx)})";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Use the MD5 algorithm to hash the given password to a 256 bit (32 characters) hashed code.
        /// </summary>
        /// <param name="pass">The password to be hashed</param>
        /// <returns>a string representing the uppercase hexadecimal representation of the MD5 Hash.</returns>
        public string HashPassword(string pass)
        {
            byte[] passBytes = System.Text.Encoding.UTF8.GetBytes(pass);
            byte[] hash = MD5.Create().ComputeHash(passBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));  //Convert the bytes to their HEX representation
            }
            Console.WriteLine(sb);
            return sb.ToString();

        }

        public enum SqlErrorNumber
        {
            ForeignKeyViolation = 547,      //either a reference to something that doesn't exist
                                            //attempt to delete something that is referenced

            Duplication = 2627,             //a primary key (or any unique attribute) already exists
            Truncation = 8152,              //data is too long to be stored in the corresponding attribute
            NotInteger = 245,               //supplied string is not integer
            Unknown = 0                     //Other types of errors

            /*
             * Other interesting error codes
            * 213 :     Column name or number of supplied values does not match table definition.
            * 206 :     Operand type clash: int is incompatible with date
            * 241 :     Conversion failed when converting date and/or time from character string.
            * 245 :     Conversion failed when converting the varchar value to data type int.
            * 515 :     Cannot insert the value NULL into column
            */

        }

        public static SqlErrorNumber ParseException(SqlException t)
        {
            switch (t.Number)
            {
                case (int)SqlErrorNumber.ForeignKeyViolation:
                    return SqlErrorNumber.ForeignKeyViolation;
                case (int)SqlErrorNumber.Duplication:
                    return SqlErrorNumber.Duplication;
                case (int)SqlErrorNumber.Truncation:
                    return SqlErrorNumber.Truncation;
                case (int)SqlErrorNumber.NotInteger:
                    return SqlErrorNumber.NotInteger;
                default:
                    return SqlErrorNumber.Unknown;
            }
        }
    }
}
