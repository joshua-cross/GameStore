using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace TheGameShop
{
    public partial class AddGame : Form
    {
        //a connection (from the form1 class)
        SqlConnection connection;


        //Constructor that takes in the connection, and the Form1 that created it so we can update it's table when we press confirm.
        public AddGame(SqlConnection thisConnection)
        {
            InitializeComponent();

            connection = thisConnection;
        }

        //when the confirm button is pressed we want to add what the user has typed to the database.
        private void confirm_Click(object sender, EventArgs e)
        {
            String xml = "INSERT INTO Games (Games, Platform, Genre, AgeRating, Description) VALUES ('" + textBox1.Text + "','" +
                platformBox.Text + "','" + genreBox.Text + "','" +
                ageRatingBox.Text + "','" + descriptionBox.Text + "');";

            //completed.Text = xml;


            try
            {
                String query = "INSERT INTO dbo.SMS_PW (Games, Platform, Genre, AgeRating, Description) VALUES (@game, @platform, @genre, @ageRating, @description)";

                SqlCommand command = new SqlCommand(xml, connection);

                int result = command.ExecuteNonQuery();

                //if the result is less than 0 then we was not able to insert the new command into the database.
                if (result < 0)
                {
                    Console.WriteLine("Error inserting to database.");
                    completed.Text = "Something went wrong.";
                }
                //else we have effected 1 line which means it was added to the database.
                else
                {
                    completed.Text = "Complete.";
                }

                //command.ExecuteNonQuery();
            } catch (Exception error)
            {
                Console.WriteLine(error);
                completed.Text = error.ToString();
            }
                 
        }
    }
}
