using System;
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

            //setting the background colour for the application.
            BackColor = bkg;

            gameForm.BackColor = elementColor;
            gameForm.ForeColor = textColor;
            description.BackColor = elementColor;
            description.ForeColor = elementColor;

            game.ForeColor = textColor;

            dbConnect();

        }

        //this is fired when something is selected from an item is selected from ListBox.
        private void gameForm_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            game.Text = gameForm.SelectedItem.ToString();
            msg("Yes!");

            //try to add to the description
            try
            {
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

                    

                    //Getting the platform column
                    String platform = reader["Platform"].ToString();
                    Console.WriteLine("Platform: " + platform);
                    description.Items.Add(platform);

                    //Getting the Genre of the game
                    String genre = reader["Genre"].ToString();
                    Console.WriteLine("Genre: " + genre);

                    //printing the age rating of the game.
                    String age = reader["AgeRating"].ToString();
                    Console.WriteLine("Age rating: " + age + "\n\n");


                }
            } catch
            {
                
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

            gameForm.Items.Add("Hello");
        }

        //function that disconnects with the server
        public void dbDisconnect()
        {
            connection.Close();
        }


    }
}
