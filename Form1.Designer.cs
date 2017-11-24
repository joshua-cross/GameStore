
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Drawing;


namespace TheGameShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;




        
        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {

            connection.Close();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameForm = new System.Windows.Forms.ListBox();
            this.game = new System.Windows.Forms.Label();
            this.platformText = new System.Windows.Forms.Label();
            this.addGame = new System.Windows.Forms.Button();
            this.editGame = new System.Windows.Forms.Button();
            this.deleteGame = new System.Windows.Forms.Button();
            this.recieve = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameForm
            // 
            this.gameForm.FormattingEnabled = true;
            this.gameForm.ItemHeight = 25;
            this.gameForm.Location = new System.Drawing.Point(231, 36);
            this.gameForm.Margin = new System.Windows.Forms.Padding(6);
            this.gameForm.Name = "gameForm";
            this.gameForm.Size = new System.Drawing.Size(482, 679);
            this.gameForm.TabIndex = 0;
            this.gameForm.SelectedIndexChanged += new System.EventHandler(this.gameForm_SelectedIndexChanged);
            // 
            // game
            // 
            this.game.AutoSize = true;
            this.game.BackColor = System.Drawing.Color.Transparent;
            this.game.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game.Location = new System.Drawing.Point(776, 36);
            this.game.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(145, 55);
            this.game.TabIndex = 1;
            this.game.Text = "game";
            // 
            // platformText
            // 
            this.platformText.AutoSize = true;
            this.platformText.Location = new System.Drawing.Point(781, 106);
            this.platformText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.platformText.Name = "platformText";
            this.platformText.Size = new System.Drawing.Size(0, 25);
            this.platformText.TabIndex = 2;
            // 
            // addGame
            // 
            this.addGame.Location = new System.Drawing.Point(231, 734);
            this.addGame.Name = "addGame";
            this.addGame.Size = new System.Drawing.Size(130, 52);
            this.addGame.TabIndex = 3;
            this.addGame.Text = "Add Game";
            this.addGame.UseVisualStyleBackColor = true;
            this.addGame.Click += new System.EventHandler(this.addGame_Click);
            // 
            // editGame
            // 
            this.editGame.Location = new System.Drawing.Point(409, 734);
            this.editGame.Name = "editGame";
            this.editGame.Size = new System.Drawing.Size(126, 52);
            this.editGame.TabIndex = 4;
            this.editGame.Text = "Edit Game";
            this.editGame.UseVisualStyleBackColor = true;
            this.editGame.Click += new System.EventHandler(this.editGame_Click);
            // 
            // deleteGame
            // 
            this.deleteGame.Location = new System.Drawing.Point(587, 734);
            this.deleteGame.Name = "deleteGame";
            this.deleteGame.Size = new System.Drawing.Size(126, 52);
            this.deleteGame.TabIndex = 5;
            this.deleteGame.Text = "Remove";
            this.deleteGame.UseVisualStyleBackColor = true;
            this.deleteGame.Click += new System.EventHandler(this.deleteGame_Click);
            // 
            // recieve
            // 
            this.recieve.AutoSize = true;
            this.recieve.Location = new System.Drawing.Point(235, 789);
            this.recieve.Name = "recieve";
            this.recieve.Size = new System.Drawing.Size(126, 25);
            this.recieve.TabIndex = 6;
            this.recieve.Text = "recieved ID:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 80);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(210, 31);
            this.searchBox.TabIndex = 7;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchText
            // 
            this.searchText.AutoSize = true;
            this.searchText.Location = new System.Drawing.Point(12, 52);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(86, 25);
            this.searchText.TabIndex = 8;
            this.searchText.Text = "Search:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 820);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.recieve);
            this.Controls.Add(this.deleteGame);
            this.Controls.Add(this.editGame);
            this.Controls.Add(this.addGame);
            this.Controls.Add(this.platformText);
            this.Controls.Add(this.game);
            this.Controls.Add(this.gameForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gameForm;
        private Label game;
        private Label platformText;
        private Button addGame;
        private Button editGame;
        private Button deleteGame;
        private Label recieve;
        private TextBox searchBox;
        private Label searchText;
    }
}

