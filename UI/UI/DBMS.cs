using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UI
{
    
    class DBMS
    {
        private SqlConnection co;
        private SqlConnectionStringBuilder builder;
        /// <summary>
        /// Establish a new instance of the Data Base Management System communicator.
        /// This starts the connection to the DataSource "localhost" and to the database "FciAir"
        /// </summary>
        public DBMS()
        {
            builder = new SqlConnectionStringBuilder();
            builder.IntegratedSecurity = true;

            builder.DataSource = "localhost";

            co = new SqlConnection();
            co.ConnectionString = builder.ConnectionString;
        }
        /// <summary>
        /// Tries to open the connection
        /// </summary>
        public void OpenConnection()
        {
            co.Open();
        }
        public void SwitchToFci()
        {
            co.ChangeDatabase("FciAir");
        }
        /// <summary>
        /// Closes the connection to the server and the database.
        /// </summary>
        public void CloseConnection()
        {
            co.Close();
            co.Dispose();
        }

        /// <summary>
        /// Runs the sql query to create the FciAir database.
        /// </summary>
        public void CreateDatabase()
        {
            try
            {
                using (var cmd = new SqlCommand(Properties.Resources.CreateDatabaseInitial, co))
                    cmd.ExecuteNonQuery();
                using (var cmd = new SqlCommand(Properties.Resources.createDatabase, co))
                    cmd.ExecuteNonQuery();
            }
            catch { }
        }

        #region Admin/Customer Password Checking

        private bool CheckPasswordOf(string mytype, int ID, string pass)
        {
            string query = $"SELECT {mytype}ID FROM {mytype}s WHERE {mytype}ID = @ID AND Password = @pass";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                cmd.Parameters.Add(new SqlParameter("@pass", HashPassword(pass)));

                //if the result set is empty.. ie. the password is incorrect 'ExecuteScalar' returns null
                return cmd.ExecuteScalar() != null;
            }
        }

        /// <summary>
        /// Checks if the Admin with the specified ID has the specified password
        /// </summary>
        /// <returns>True if the password is correct, False otherwise</returns>
        public bool CheckPasswordAdmin(int ID, string pass)
        {
            return CheckPasswordOf("Admin", ID, pass);
        }

        /// <summary>
        /// Checks if the Customer with the specified ID has the specified password
        /// </summary>
        /// <returns>True if the password is correct, False otherwise</returns>
        public bool CheckPasswordCustomer(int ID, string pass)
        {
            return CheckPasswordOf("Customer", ID, pass);
        }


        #endregion

        #region Admin/Customer Login
        private int LoginAs(string mytype, string username, string pass)
        {
            string query = $"SELECT {mytype}ID FROM {mytype}s WHERE Username = @username AND Password = @pass";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.Parameters.Add(new SqlParameter("@pass", HashPassword(pass)));

                object ret = cmd.ExecuteScalar();
                if (ret == null)
                    return -1;
                else
                    return (int)ret;
            }
        }
        /// <summary>
        /// Login the admin with the specified username and password
        /// </summary>
        /// <returns>The AdminID of the user if successful, -1 if not.</returns>
        public int LoginAdmin(string username, string pass)
        {
            return LoginAs("Admin", username, pass);
        }
        /// <summary>
        /// Login the customer with the specified username and password
        /// </summary>
        /// <returns>The CustomerID of the user if successful, -1 if not.</returns>
        public int LoginCustomer(string username, string pass)
        {
            return LoginAs("Customer", username, pass);
        }
        #endregion

        #region Fetch Data
        private List<List<object>> GetTableData(string tablename, string where, string what, SqlParameter[] param)
        {
            var ret = new List<List<object>>();
            string query = $"SELECT {what} FROM {tablename} WHERE {where}";
            using (var cmd = new SqlCommand(query, co))
            {
                if (param != null) cmd.Parameters.AddRange(param);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new List<object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                            row.Add(reader.GetValue(i));

                        ret.Add(row);
                    }
                }
            }
            return ret;
        }

        public List<List<object>> GetTableData(string tablename, string where = "1=1", string what = "*")
        {
            return GetTableData(tablename, where, what, null);
        }
        public List<List<object>> SearchBy(string tablename, string whereLeft, string whereRight, string what = "*")
        {
            return GetTableData(tablename, $"{whereLeft} = @whereRight", what,
                new SqlParameter[] { new SqlParameter("@whereRight", whereRight) });
        }

        public List<List<object>> SearchByTime(string tablename, string whereLeft, DateTime from, DateTime to, string what = "*")
        {
            return GetTableData(tablename, $"{whereLeft} >= @from AND {whereLeft} <= @to", what,
               new SqlParameter[] { new SqlParameter("@from", from),
                                    new SqlParameter("@to", to) });
        }

        public List<string> GetTableColumns(string tablename , string what = "*")
        {
            var ret = new List<string>();
            string query = $"SELECT {what} FROM {tablename} WHERE 1=2";
            using (var cmd = new SqlCommand(query, co))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        ret.Add(reader.GetName(i));
                }
            }
            return ret;
        }
        #endregion

        #region Inserts

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
        public void InsertAircraft(int adminID, int maxSeat, string model, string pName, DateTime date, int salary)
        {
            string query = $"INSERT INTO Aircrafts VALUES(@adminID, @maxSeat, @model, @pName, @date, @salary)";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@adminID", adminID));
                cmd.Parameters.Add(new SqlParameter("@maxSeat", maxSeat));
                cmd.Parameters.Add(new SqlParameter("@model", model));
                cmd.Parameters.Add(new SqlParameter("@pName", pName));
                cmd.Parameters.Add(new SqlParameter("@date", date));
                cmd.Parameters.Add(new SqlParameter("@salary", salary));
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

        public void InsertTicket(int flightID, int price, string ageGroup, int customerID, string Clas, DateTime book)
        {
            string query = $"INSERT INTO Tickets VALUES (@flightID, @customerID, @price, @ageGroup, @Clas, @book)";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@flightID", flightID));
                cmd.Parameters.Add(new SqlParameter("@customerID", customerID));
                cmd.Parameters.Add(new SqlParameter("@price", price));
                cmd.Parameters.Add(new SqlParameter("@ageGroup", ageGroup));
                cmd.Parameters.Add(new SqlParameter("@Clas", Clas));
                cmd.Parameters.Add(new SqlParameter("@book", book));
                cmd.ExecuteNonQuery();
            }
        }


        #endregion

        #region Updates

        public void UpdateAdmin(int ID, string fName, string lName, string userName, string pass)
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

        public void UpdateFlight(int ID, int AirID, DateTime depart, DateTime arrive, int seat, string source, string dest)
        {
            string query = $"UPDATE Flights SET DepartTime=@depart,ArriveTime=@arrive,RequiredSeats=@seat,Source=@source,Destination=@dest,AircraftID=@AirID WHERE FlightID=@ID";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@depart", depart));
                cmd.Parameters.Add(new SqlParameter("@arrive", arrive));
                cmd.Parameters.Add(new SqlParameter("@seat", seat));
                cmd.Parameters.Add(new SqlParameter("@source", source));
                cmd.Parameters.Add(new SqlParameter("@dest", dest));
                cmd.Parameters.Add(new SqlParameter("@AirID", AirID));
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                cmd.ExecuteNonQuery();
            }

        }

        public void UpdateAircraft(int ID, int adminID, int seat, string model, string pName, DateTime date, int salary)
        {
            string query = $"UPDATE Aircrafts SET AdminID = @adminID, Model=@model, MaxSeats=@seat,PilotName = @pname, Birthdate = @date, Salary = @salary WHERE AircraftID=@ID";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@model", model));
                cmd.Parameters.Add(new SqlParameter("@pName", pName));
                cmd.Parameters.Add(new SqlParameter("@seat", seat));
                cmd.Parameters.Add(new SqlParameter("@salary", salary));
                cmd.Parameters.Add(new SqlParameter("@date", date));
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                cmd.Parameters.Add(new SqlParameter("@adminID", adminID));
                cmd.ExecuteNonQuery();
            }

        }

        public void UpdateCustomer(int ID, string passport, string fName, string lName, string userName, string pass, string nationality, DateTime birth)
        {
            string query = $"UPDATE Customers SET Passport=@passport,FirstName=@fName,LastName=@lName,Password=@pass,Birthdate=@birth,Nationality=@nationality,Username=@userName WHERE CustomerID=@ID";
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

        #endregion

        #region Deletes
        public void DeleteAircrafts(int[] idx)
        {
            string query = $"DELETE FROM Aircrafts WHERE AircraftID IN ({String.Join(",", idx)})";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMonitor(int adminID, int flightID)
        {
            string query = $"DELETE FROM Monitor WHERE AdminID = {adminID} AND FlightID = {flightID}";
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
        public void DeleteTicket(int[] idx)
        {
            string query = $"DELEtE FROM Tickets WHERE TicketID IN ({String.Join(",", idx)})";
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
        #endregion


        public int GetFlightMaxSeats(int FlightID)
        {
            string query = $"SELECT MaxSeats FROM Aircrafts JOIN Flights ON Aircrafts.AircraftID = Flights.AircraftID WHERE FlightID = { FlightID }";
            using (var cmd = new SqlCommand(query, co))
            {
                return (int)cmd.ExecuteScalar();
            }
        }

        public int GetFlightReservedSeats(int FlightID)
        {
            //LEFT JOIN here because we need this function to return 0 if the flight does not have any reserved seats
            string query = $"SELECT COUNT(TicketID) FROM Flights LEFT JOIN Tickets ON Flights.FlightID = Tickets.FlightID WHERE Flights.FlightID = {FlightID} GROUP BY Flights.FlightID";
            using (var cmd = new SqlCommand(query, co))
            {
                return (int)cmd.ExecuteScalar();
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
            byte[] hash = System.Security.Cryptography.MD5.Create().ComputeHash(passBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));  //Convert the bytes to their HEX representation
            }
            return sb.ToString();
        }

        public enum SqlErrorNumber
        {
            ForeignKeyViolation = 547,      //either a reference to something that doesn't exist
                                            //attempt to delete something that is referenced

            Duplication = 2627,             //a primary key (or any unique attribute) already exists
            Truncation = 8152,              //data is too long to be stored in the corresponding attribute
            NotInteger = 245,               //supplied string is not integer
            Null = 515,                     //Cannot insert the value NULL into column
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
