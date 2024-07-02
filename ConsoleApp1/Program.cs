using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using CCXCommon;
class Program
{
    static async Task Main(string[] args)
    {
        //DateTime currentDate = DateTime.Now;
        //Console.WriteLine("Local Time: " + currentDate);
        //// Specify the desired time zone (Mountain Standard Time)
        //string timeZoneId = "Mountain Standard Time";
        //TimeZoneInfo mountainZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        //// Convert the local time to the desired time zone
        //DateTime mountainTime = TimeZoneInfo.ConvertTime(currentDate, mountainZone);
        //Console.WriteLine("Mountain Time: " + mountainTime);
        ClassLibrary1.Class1 a = new ClassLibrary1.Class1(); 
        Console.WriteLine(a.sum(1,2));

    }

    private static void testMethod()
    {
        string server = @"CCX-SQL-STG-02.WINDSI.GHX.COM\EXPERT01";
        string database = "ItemStagingCenter";
        string userID = "ccnet_app";
        string password = "trubadelo";

        string ConnectionString = @"Server={0};Database={1};uid={2};pwd={3}; Max Pool Size = 150;TrustServerCertificate=True;Encrypt=True;";
        ConnectionString = String.Format(ConnectionString, server, database, userID, password);

        using (var connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "INSERT INTO PriceSyncReport_IncomingFileQueue (InputFileName, InputFileS3URL, ProviderEID, StatusID, CreatedOn) VALUES (@InputFileName, @InputFileS3URL,@ProviderEID, @StatusID, @CreatedOn)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@InputFileName", "text");
                command.Parameters.AddWithValue("@InputFileS3URL", "text");
                command.Parameters.AddWithValue("@ProviderEID", "121");
                command.Parameters.AddWithValue("@StatusID", 1);
                command.Parameters.AddWithValue("@CreatedOn", DateTime.Now);

                int rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
}
