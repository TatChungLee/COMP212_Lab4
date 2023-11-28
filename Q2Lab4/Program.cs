using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Question 02 - Lab 04");

string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Onedrive\OneDrive - Centennial College\Sem 4\COMP212\Lab#4 Submission attached files Nov 16, 2023 741 PM\Lab04 - Solution Template\Lab04 - Solution Template\Q2Lab4\Database\Books.mdf';Integrated Security=True";



// Data Source=Database\Books.mdf";Integrated Security=True
// Invokes methods
Question2_1();
Question2_2();
Question2_3();

//1.Get a list of all the titles and the authors who wrote them. Sort the results by title. [2 marks]
void Question2_1()
{
    Console.WriteLine("1. Get a list of all the titles and the authors who wrote them. Sort the results by title\n------------------------------------------------------");
    string query = "SELECT t.Title, a.FirstName, a.LastName " +
        "FROM Titles t " +
        "JOIN AuthorISBN ai ON t.ISBN = ai.ISBN " +
        "JOIN Authors a ON ai.AuthorID = a.AuthorID " +
        "ORDER BY t.Title;";
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        SqlCommand command = new SqlCommand(query, connection);
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine("Title: {0}, Author: {1} {2}", reader["Title"], reader["FirstName"], reader["LastName"]);
        }
        reader.Close();
    }
    Console.WriteLine("------------------------------------------------------\n");
}

//2.Get a list of all the titles and the authors who wrote them. Sort the results by title.  Each title sort the authors alphabetically by last name, then first name[4 marks]
void Question2_2()
{
    Console.WriteLine("2. ...sort the authors alphabetically by last name, then first name\n------------------------------------------------------");
    string query = "SELECT t.Title, a.FirstName, a.LastName " +
      "FROM Titles t " +
      "JOIN AuthorISBN ai ON t.ISBN = ai.ISBN " +
      "JOIN Authors a ON ai.AuthorID = a.AuthorID " +
      "ORDER BY t.Title, a.FirstName, a.LastName;";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        SqlCommand command = new SqlCommand(query, connection);
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine("Title: {0}, Author: {1} {2}", reader["Title"], reader["FirstName"], reader["LastName"]);
        }
        reader.Close();
    }

    Console.WriteLine("------------------------------------------------------\n");
}



//3.Get a list of all the authors grouped by title, sorted by title; for a given title sort the author names alphabetically by last name then first name.[4 marks]
void Question2_3()
{
    Console.WriteLine("3.Get a list of all the authors grouped by title, sorted by title; for a given title sort the author names alphabetically by last name then first name." +
        "\n------------------------------------------------------");


    Console.WriteLine("------------------------------------------------------\n");
}
