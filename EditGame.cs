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
    public partial class EditGame : Form
    {

        //the connection to the database which will be sent from Form1
        SqlConnection connection;

        //the Form which created this.
        Form1 sent;

        //the text for all the default values.
        String sGame, sPlatform, sGenre, sAge, sDescription, sID;

        //when the edit button is pressed we want to update the database for the name.
        private void edit_Click(object sender, EventArgs e)
        {
            String SQL = "UPDATE Games SET Games = '" + gameBox.Text.Trim() + "', Platform = '" + platformBox.Text.Trim() + "', Genre = '" + genreBox.Text.Trim()
                + "', AgeRating = '" + ageBox.Text.Trim() + "', Description = '" + descriptionBox.Text + "' WHERE ID = '" + sID + "';";

            results.Text = SQL;

            try
            {
                //creating a connection to the DB.
                SqlCommand command = new SqlCommand(SQL, connection);

                int theResult = command.ExecuteNonQuery();

                //if theResult is < 0 then no rows have been effected thus it has failed.
                if(theResult < 0)
                {
                    results.Text = "We have failed...";
                } else
                {
                    results.Text = "We have succeeded";
                    //removing the old element from the array, and adding the new one.
                    editGame();
                    sent.removeFromListBox(sGame);
                    //editGame();
                }


            } catch (Exception error)
            {
                Console.WriteLine(error.ToString());
                //results.Text = error.ToString();
            }

            this.Close();
        }
        //Editing one of the games.
        private void editGame()
        {
            //sending the ID from the game that the user just added to the database.
            String gameXML = "SELECT ID FROM Games WHERE Games = '" + gameBox.Text.Trim() + "'";
            results.Text = gameXML;

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
                    Console.WriteLine("ID: " + ID);
                    results.Text = "ID";

                }

                reader.Close();
                //checking to see if the ID is not empty, if it's not we will send the ID.
                if (!ID.Equals(""))
                    sent.dbUpdated(ID);

            }
            catch (Exception error)
            {
                Console.WriteLine("SQL:" + gameXML + " error: " + error);
                results.Text = "SQL:" + gameXML + " error: " + error;
            }
        }

        //Constructor that takes in all the inmputs.
        public EditGame(SqlConnection thisConnection, Form1 thisSent, String thisGame, String thisPlatform,
            String thisGenre, String thisAge, String thisDescription, String thisID)
        {
            InitializeComponent();

            connection = thisConnection;
            sent = thisSent;

            sGame = thisGame;
            sPlatform = thisPlatform;
            sGenre = thisGenre;
            sAge = thisAge;
            sDescription = thisDescription;
            sID = thisID;

            //try to parse the age to an int.
            try
            {
                int iAge = Int16.Parse(sAge);
                ageBox.Value = iAge;
            } catch (Exception error)
            {
                Console.WriteLine(error);
                ageBox.Value = 3;
            }

            //setting the default values for the boxes.
            gameBox.Text = sGame;
            platformBox.Text = sPlatform;
            genreBox.Text = sGenre;
            descriptionBox.Text = sDescription;

        }
    }
}
