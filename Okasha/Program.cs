using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


class DBMS
{
    public static List<List<string>> data;
    List<string> info;
    private SqlConnection co ;
    public DBMS(string name)
    {
        var builder = new SqlConnectionStringBuilder();
        builder.IntegratedSecurity = true;

        builder.DataSource = "localhost";
        builder.InitialCatalog = name;

        co = new SqlConnection();
        co.ConnectionString = builder.ConnectionString;
        co.Open();
    }
    private void addData(string query)
    {
        using (var cmd = new SqlCommand(query, co))
        {
            cmd.ExecuteNonQuery();
        }
    }

    private void readData(string query)
    {
        using (var cmd = new SqlCommand(query, co))
        {
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                int columnNymber = reader.FieldCount;

                while (reader.Read())
                {
                    for (int i = 0; i < columnNymber; i++)
                    {
                        Console.Write(reader.GetValue(i));
                      //  info.Add(reader.GetValue(i)+"");
                    }
                  //  data.Add(info);
                   // info.Clear();
                }
                reader.Close();
            }
            finally
            {
                Console.WriteLine("ay 7aga ");
            }

        }

    }

    public void tst()
    {
        string query = "select * from admins";
        readData(query);

    }
    public void insertAdmin(string fName,string lName,string username,string pass)
    {
        string query = $"Insert Into Admins Values('{fName}','{lName}','{username}','{pass}')";
        addData(query);
    }
    public void insertAircraft(int adminID,int maxSeat,string model)
    {
        string query = $"Insert Into Aircrafts Values({adminID},{maxSeat},'{model}')";
        addData(query);
    }
    public void insertCustomer(string fName,string lName,int passPort,string nationality,DateTime birthdate ,string username,string pass)
    {
        string query = $"Insert Into Customers Values('{fName}','{lName}',{passPort},'{nationality}','{birthdate.ToString("yyyyMMdd")}','{username}','{pass}')";
        addData(query);
    }
    public void insertFlight(int airID,DateTime depart,DateTime arrive,int seat,string source,string destination)
    {
        string query = $"Insert Into Flights Values({airID},'{depart.ToString("yyyyMMddHHmm")}','{arrive.ToString("yyyyMMddHHmm")}',{seat}.'{source}','{destination}')";
        addData(query);
    }
    public void insertMonitor(int admin, int flight)
    {
        string query = $"insert into Monitor values({admin},{flight})";
        addData(query);
    }
    public void insertPilot(int ID, string name, DateTime date, double salary)
    {
        string query = $"insert into Pilots values ({ID},'{name}','{date.ToString("yyyyMMddHHmm")}',{salary})";
        addData(query);
    }
    public void insertTicket(int flightID, int customerID,string Class,DateTime book)
    {
        string query = $"insert into Tickets values ({flightID},{customerID},'{Class}','{book.ToString("yyyyMMddHHmm")}'";
        addData(query);
    }

    public void deleteAircrafts(int[] idx)
    {
        string query = $"delete from Aircrafts where AircraftID in ({String.Join(",", idx)})";
        addData(query);
    }
    public void deleteCustomer(int[] idx)
    {
        string query = $"delete from Customers where CustomerID in ({String.Join(",", idx)})";
        addData(query);
        query=$"delete from Tickets where CustomerID in ({String.Join(",", idx)})";
        addData(query);
    }
    public void deleteFlight(int[] idx)
    {
        string query = $"delete from Flights where FlightID in ({String.Join(",", idx)})";
        addData(query);
    }

    
}



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DBMS query = new DBMS("FciAir");
            query.tst();
            Console.WriteLine("done ");
            Console.ReadKey();
        }
    }
}