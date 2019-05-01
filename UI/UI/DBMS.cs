using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace UI
{
    
    class DBMS
    {
       
        private SqlConnection co;
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

        public int loginAdmin(string username, string pass)
        {
            string query = $"SELECT AdminID FROM Admins WHERE Username = @username AND Password = @pass";
            using (var cmd = new SqlCommand(query, co))
            {
                SqlDataReader reader = null;
                try
                {
                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    cmd.Parameters.Add(new SqlParameter("@pass", pass));
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                        return (int)reader.GetValue(0);
                    else
                        return -1;
                }
                finally{
                    reader.Close();
                }
            }
        }

        public List<List<object>> GetTableData(string tablename, string where = "1=1")
        {
            var ret = new List<List<object>>();
            string query = $"SELECT * FROM {tablename} WHERE { where }";
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

    
        public List<string> GetTableColumns(string tablename)
        {
            var ret = new List<string>();
            string query = $"SELECT * FROM {tablename} WHERE 1=2";
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
                cmd.Parameters.Add(new SqlParameter("@pass", pass));
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
        public void InsertCustomer(string fName, string lName, int passPort, string nationality, DateTime birthdate, string username, string pass)
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
                cmd.Parameters.Add(new SqlParameter("@pass", pass));
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
        public void InsertPilot(int ID, string name, DateTime date, double salary)
        {
            string query = $"INSERT INTO Pilots VALUES (@ID, @name, @date, @salary)";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@date", date));
                cmd.Parameters.Add(new SqlParameter("@salary", salary));
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
                cmd.Parameters.Add(new SqlParameter("@pass", pass));
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

        public void UpdateCraft(int ID,int adminID,string model,string pName ,int seat,int salary,DateTime birth)
        {
            string query = $"UPDATE Aircraft,Pilots SET Model=@model,MaxSeat=@seat,RequiredSeat=@seat,Source=@source,Destination=@dest,AdminID=adminID WHERE AircraftID=@ID";
            using (var cmd = new SqlCommand(query, co))
            {
                cmd.Parameters.Add(new SqlParameter("@model",model ));
                cmd.Parameters.Add(new SqlParameter("@pName",pName ));
                cmd.Parameters.Add(new SqlParameter("@seat",seat ));
                cmd.Parameters.Add(new SqlParameter("@salary",salary ));
                cmd.Parameters.Add(new SqlParameter("@birth",birth ));
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
                cmd.Parameters.Add(new SqlParameter("@passport", passport));
                cmd.Parameters.Add(new SqlParameter("@pass", pass));
                cmd.Parameters.Add(new SqlParameter("@birth", birth));
                cmd.Parameters.Add(new SqlParameter("@ID", ID));
                cmd.Parameters.Add(new SqlParameter("@nationality", nationality));
                cmd.Parameters.Add(new SqlParameter("@userName", userName));
                cmd.ExecuteNonQuery();
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

    }
}
