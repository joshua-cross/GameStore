﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Drawing;

namespace TheGameShop
{
    public partial class Form1 : Form
    {

        SqlConnection connection;

        //Strings for all the currently selected items, and setting them all to empty incase something goes wrong somewhere.
        String gameSelected, genreSelected, platformSelected, ageSelected, descriptionSelected, IDSelected, stockSelected, priceSelected = "";

        public Form1()
        {
            InitializeComponent();
        }


        //when the form is first created.
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            //the background color of the website.
            Color bkg = Color.FromArgb(25, 25, 25);
            //the color of elements such as gameForm.
            Color elementColor = Color.FromArgb(17, 17, 17);
            //the text colour on the application
            Color textColor = Color.FromArgb(255, 255, 255);
            //colour for the buttons on the page.
            Color buttonColor = Color.FromArgb(200, 41, 48);

            //how far we want the platformText to go before starting a new line.
            int wrap = contentPanel.Width - 25;

            //making it so when the text reaches the end of the screen in starts a new line (text wrapping).
            platformText.MaximumSize = new Size(wrap, 0);
            platformText.AutoSize = true;


            //game.ForeColor = textColor;

            //if nothings selected then we are going to hide the stock counter so the user cannot select it.
            if (gameForm.SelectedIndex == -1)
            {
                stockBox.Enabled = false;
                stockBox.Visible = false;
                confirm.Enabled = false;
                confirm.Visible = false;
                stock.Visible = false;
            }

            dbConnect();

        }

        //this is fired when something is selected from an item is selected from ListBox.
        private void gameForm_SelectedIndexChanged(object sender, System.EventArgs e)
        {


            //if the stockbox is still invisible then we want to change it to visible.
            if(stockBox.Visible == false && stockBox.Enabled == false)
            {
                stockBox.Enabled = true;
                stockBox.Visible = true;
                confirm.Enabled = true;
                confirm.Visible = true;
                stock.Visible = true;
            }

            try
            {
                game.Text = gameForm.SelectedItem.ToString();
                msg("Yes!");
            } catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }

            //try to add to the description
            try
            {
                //Selecting the other columns from the database when the row contains the game.
                String SQL = "SELECT * FROM Games WHERE Games = '" + gameForm.SelectedItem.ToString().Trim() + "'";
                Console.WriteLine(SQL);

                //getting the title of games from the Games table.
                SqlCommand command = new SqlCommand(SQL, connection);



                SqlDataReader reader = command.ExecuteReader();

                //reading from the database.
                while (reader.Read())
                {
                    
                    //Getting the ID column.
                    String ID = reader["ID"].ToString();
                    //Printing the ID.
                    Console.WriteLine("ID: " + ID);

                    gameSelected = gameForm.SelectedItem.ToString();
                    platformSelected = reader["Platform"].ToString().Trim();
                    genreSelected = reader["Genre"].ToString().Trim();
                    ageSelected = reader["AgeRating"].ToString();
                    descriptionSelected = reader["Description"].ToString().Trim();
                    IDSelected = reader["ID"].ToString();
                    stockSelected = reader["Stock"].ToString();
                    priceSelected = reader["Pricer"].ToString();

                    stockBox.Text = stockSelected;

                    //Getting the platform column
                    String gameInfo = "Platform: " + reader["Platform"].ToString() + "\n";

                    //Getting the Genre of the game
                    gameInfo += "Genre: " + reader["Genre"].ToString() + "\n";
                    gameInfo += "Age rating: " + reader["AgeRating"].ToString() + "\n";
                    gameInfo += "Current Stock: " + reader["Stock"].ToString() + "\n";
                    gameInfo += "Current Price: £" + reader["Pricer"].ToString() + "\n";

                    String desc = "Description: " + reader["Description"].ToString().Trim();
                    //calling the reduceString fucntion that checks if the string is to large, and if it is then we'll reduce it.
                    gameInfo += reduceString(desc, 800);

                    platformText.Text = gameInfo;

                    Console.WriteLine("Testring");

                }

                reader.Close();


            }
            catch (Exception error)
            {
                platformText.Text = error.ToString();
            }


        }

        //function that takes a string and reduces it to the size given by the user.
        private String reduceString(String desc, int maxLength)
        {

            //if the user has given us an illegal string.
            if(desc.Length < 0)
            {
                //throwing an error to the user.
                throw new ArgumentOutOfRangeException("Length", "Length must be >= 0");
            }

            //if the user gives us a null string, return null.
            if(desc == null)
            {
                return null;
            }

            // if the user has provided an int that's to long, then we will reduce it to the maximum length.
            if(desc.Length > maxLength)
            {
                //the maximum length that the string can possibly be.
                maxLength = Math.Min(desc.Length, maxLength);
                //returning the trimmed string.
                return desc.Substring(0, maxLength) + "...";
            }
            //else we are already below this length, so return the string as it was.
            else
            {
                return desc;
            }

            
        }

        private void msg(String message)
        {
            Console.WriteLine(message);
        }

        public void dbConnect()
        {
            String connectionString = "Data Source=DESKTOP-MA119SL\\SQLEXPRESS;Initial Catalog=GameDatabase; Integrated Security=True";

            bool hasConnected = false;
            //Connecting to the database that was created in SQL Management Studio.
            connection = new SqlConnection(connectionString);

            connection.Open();

            System.Threading.Thread.Sleep(1000);



            try
            {

                Console.WriteLine("we're in \n");

                //getting the title of games from the Games table.
                SqlCommand command = new SqlCommand("SELECT * FROM Games", connection);



                SqlDataReader reader = command.ExecuteReader();

                //reading from the database.
                while (reader.Read())
                {
                    //Getting the ID column.
                    String ID = reader["ID"].ToString();
                    //Printing the ID.
                    Console.WriteLine("ID: " + ID);

                    //Getting the games column
                    String games = reader["Games"].ToString();
                    gameForm.Items.Add(games);
                    //Getting the platform column
                    String platform = reader["Platform"].ToString();
                    Console.WriteLine("Platform: " + platform);

                    //Getting the Genre of the game
                    String genre = reader["Genre"].ToString();
                    Console.WriteLine("Genre: " + genre);

                    //printing the age rating of the game.
                    String age = reader["AgeRating"].ToString();
                    Console.WriteLine("Age rating: " + age + "\n\n");


                }


                reader.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }

            //gameForm.Items.Add("Hello");
        }

        //when the confirm button is clicked we want to update the stock for the selected game.
        private void confirm_Click_1(object sender, EventArgs e)
        {
            String SQL = "UPDATE Games SET Stock = '" + stockBox.Text.ToString().Trim() + "' WHERE Games = '" + gameForm.SelectedItem.ToString().Trim() + "';";

            try
            {
                SqlCommand command = new SqlCommand(SQL, connection);


                //howm many rows have been effected.
                int result = command.ExecuteNonQuery();

                if (result < 0)
                {
                    Console.WriteLine("We have failed :(");
                }
                else
                {
                    Console.WriteLine("We have succedded :)");
                }


            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }

            //hiding the buttons as it has been updated.
            stockBox.Enabled = false;
            stockBox.Visible = false;
            confirm.Enabled = false;
            confirm.Visible = false;
            stock.Visible = false;
        }

        //when the exit button is pressed close the application.
        private void exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        //function that disconnects with the server
        public void dbDisconnect()
        {
            connection.Close();
        }

        //when the user types any letter in the search engine we will search the database for games that contain these characters.
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            //searchText.Text = searchBox.Text.ToString().Trim();

            //clearing all the items in the lsitbox.
            gameForm.Items.Clear();

            //checking to see if the seachtext is not empty.
            if(!searchBox.Text.ToString().Trim().Equals(""))
            {
                //String that contains the searching SQL.
                String sql = "SELECT Games FROM Games WHERE Games LIKE '" + searchBox.Text + "%' OR Genre LIKE '" + searchBox.Text + "%'"
                    + " OR Platform LIKE '" + searchBox.Text + "%';" ;
                //searchText.Text = sql;

                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        //adding all the games to the list.
                        String games = reader["Games"].ToString();
                        gameForm.Items.Add(games);
                    }

                    reader.Close();
                } catch (Exception error)
                {
                    searchText.Text = error.ToString();
                }
            }
            //if the search box is now empty we want to fill the array back up with all the values.
            else
            {
                //searchText.Text = "now empty";

                try
                {

                    Console.WriteLine("we're in \n");

                    //getting the title of games from the Games table.
                    SqlCommand command = new SqlCommand("SELECT Games FROM Games", connection);



                    SqlDataReader reader = command.ExecuteReader();

                    //reading from the database.
                    while (reader.Read())
                    {

                        //Getting the games column
                        String games = reader["Games"].ToString();
                        gameForm.Items.Add(games);



                    }


                    reader.Close();


                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                }
            }

            
        }

        //when the edit button is pressed we want to go the editGame page.
        private void editGame_Click(object sender, EventArgs e)
        {
            EditGame newForm = new EditGame(connection, this, gameSelected, platformSelected, genreSelected, ageSelected, descriptionSelected, IDSelected, stockSelected, priceSelected);

            newForm.Show();
        }

        //when the add game button is clicked we want to open the addGame form (sending over the connection).
        private void addGame_Click(object sender, EventArgs e)
        {
            AddGame newForm = new AddGame(connection, this);

            newForm.Show();
        }

        //when theres a change/ an addition to the database we want to update the listBox so we can see it.
        public void dbUpdated(String ID)
        {
            String xml = "SELECT Games FROM Games WHERE ID = '" + ID + "'";

            recieve.Text = "Recieved ID: " + ID;

            //trying to display all this information in the database.
            try
            {
                SqlCommand command = new SqlCommand(xml, connection);

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    //Getting the games column
                    String games = reader["Games"].ToString();
                    recieve.Text = "Game for ID: " + ID + " is: " + games;
                    gameForm.Items.Add(games);

                }

                reader.Close();
            } catch (Exception error)
            {
                Console.WriteLine(error);
                recieve.Text = error.ToString();
            }
        }

        //when the remove button is pressed we want to remove the specific row from the database.
        private void deleteGame_Click(object sender, EventArgs e)
        {
            //the name of the selected game.
            String selectedText = gameForm.SelectedItem.ToString().Trim();

            //the XML statement.
            String xml = "DELETE FROM Games WHERE Games = '" + selectedText + "'";

            try
            {
                SqlCommand command = new SqlCommand(xml, connection);

                int result = command.ExecuteNonQuery();

                //if the result is less than 0 then we was not able to insert the new command into the database.
                if (result < 0)
                {
                    Console.WriteLine("Error inserting to database.");
                    recieve.Text = "Something went wrong.";
                }
                //else we have effected 1 line which means it was added to the database.
                else
                {
                    recieve.Text = "completed";
                    removeFromListBox(selectedText);
                    

                }

               

                //command.ExecuteNonQuery();
            } 
            catch (Exception error)
            {
                Console.WriteLine(error);
                //recieve.Text = error.ToString();
            }
        }

        //function that removes the element from the list box.
        public void removeFromListBox(String toRemove)
        {
            recieve.Text = "removing: " + toRemove;

            //for each element in the array.
            for (int i = 0; i < gameForm.Items.Count; i = i + 1)
            {
                //if the current element is equals to the one we want to remove, then remove it.
                if (gameForm.Items[i].ToString().Trim().Equals(toRemove.Trim()))
                {
                    recieve.BackColor = Color.FromArgb(255, 255, 255);
                    gameForm.Items.RemoveAt(i);
                }
            }
        }
    }
}
