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

        //the form that created this form.
        Form1 sent;

        //Constructor that takes in the connection, and the Form1 that created it so we can update it's table when we press confirm.
        public AddGame(SqlConnection thisConnection, Form1 thisSent)
        {
            InitializeComponent();

            connection = thisConnection;

            //setting sent to be what was sent through via constructor.
            sent = thisSent;

        }

        //when the confirm button is pressed we want to add what the user has typed to the database.
        private void confirm_Click(object sender, EventArgs e)
        {
            String xml = "INSERT INTO Games (Games, Platform, Genre, AgeRating, Description, Stock, Pricer) VALUES ('" + textBox1.Text + "','" +
                platformBox.Text + "','" + genreBox.Text + "','" +
                ageRatingBox.Text + "','" + descriptionBox.Text + "','" +
                stockBox.Text + "','" + priceBox.Text + "');";

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
                    completed.Text = "completed";
                    addGame();
                }


                //command.ExecuteNonQuery();
            } catch (Exception error)
            {
                Console.WriteLine(error);
                completed.Text = error.ToString();
            }
            this.Close();
                 
        }

        //adding the new game to the list.
        private void addGame()
        {
            //sending the ID from the game that the user just added to the database.
            String gameXML = "SELECT ID FROM Games WHERE Games = '" + textBox1.Text + "'";


            try
            {
                SqlCommand command = new SqlCommand(gameXML, connection);


                //completed.Text = gameXML;
                SqlDataReader reader = command.ExecuteReader();
                //setting ID to blank incase we can't find something.
                String ID = "";


                //reading from the database.
                while (reader.Read())
                {
                    //setting ID to be what we found.
                    ID = reader["ID"].ToString();
                    //Printing the ID.
                    completed.Text = ID;
                    Console.WriteLine("ID: " + ID);

                }

                reader.Close();
                //checking to see if the ID is not empty, if it's not we will send the ID.
                if (!ID.Equals(""))
                    //false as we are not updating an existing element.
                    sent.dbUpdated(ID);

            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        //when the exit button is pressed, close this form.
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
