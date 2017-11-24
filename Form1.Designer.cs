
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
            try
            {
                connection.Close();
            } catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }

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
            this.searchText = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gameShop = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.confirm = new System.Windows.Forms.Button();
            this.stockBox = new System.Windows.Forms.NumericUpDown();
            this.panel8 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBox)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameForm
            // 
            this.gameForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gameForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameForm.ForeColor = System.Drawing.Color.White;
            this.gameForm.FormattingEnabled = true;
            this.gameForm.ItemHeight = 26;
            this.gameForm.Location = new System.Drawing.Point(49, 7);
            this.gameForm.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.gameForm.Name = "gameForm";
            this.gameForm.Size = new System.Drawing.Size(441, 598);
            this.gameForm.TabIndex = 0;
            this.gameForm.SelectedIndexChanged += new System.EventHandler(this.gameForm_SelectedIndexChanged);
            // 
            // game
            // 
            this.game.AutoSize = true;
            this.game.BackColor = System.Drawing.Color.Transparent;
            this.game.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(97)))));
            this.game.Location = new System.Drawing.Point(514, 40);
            this.game.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(145, 55);
            this.game.TabIndex = 1;
            this.game.Text = "game";
            // 
            // platformText
            // 
            this.platformText.AutoSize = true;
            this.platformText.Location = new System.Drawing.Point(14, 13);
            this.platformText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.platformText.Name = "platformText";
            this.platformText.Size = new System.Drawing.Size(0, 26);
            this.platformText.TabIndex = 2;
            // 
            // addGame
            // 
            this.addGame.FlatAppearance.BorderSize = 0;
            this.addGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGame.Location = new System.Drawing.Point(0, 138);
            this.addGame.Name = "addGame";
            this.addGame.Size = new System.Drawing.Size(297, 144);
            this.addGame.TabIndex = 3;
            this.addGame.Text = "Add Game";
            this.addGame.UseVisualStyleBackColor = true;
            this.addGame.Click += new System.EventHandler(this.addGame_Click);
            // 
            // editGame
            // 
            this.editGame.FlatAppearance.BorderSize = 0;
            this.editGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editGame.Location = new System.Drawing.Point(0, 288);
            this.editGame.Name = "editGame";
            this.editGame.Size = new System.Drawing.Size(297, 144);
            this.editGame.TabIndex = 4;
            this.editGame.Text = "Edit Game";
            this.editGame.UseVisualStyleBackColor = true;
            this.editGame.Click += new System.EventHandler(this.editGame_Click);
            // 
            // deleteGame
            // 
            this.deleteGame.FlatAppearance.BorderSize = 0;
            this.deleteGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGame.Location = new System.Drawing.Point(0, 438);
            this.deleteGame.Name = "deleteGame";
            this.deleteGame.Size = new System.Drawing.Size(297, 144);
            this.deleteGame.TabIndex = 5;
            this.deleteGame.Text = "Remove";
            this.deleteGame.UseVisualStyleBackColor = true;
            this.deleteGame.Click += new System.EventHandler(this.deleteGame_Click);
            // 
            // recieve
            // 
            this.recieve.AutoSize = true;
            this.recieve.Location = new System.Drawing.Point(1113, 624);
            this.recieve.Name = "recieve";
            this.recieve.Size = new System.Drawing.Size(113, 26);
            this.recieve.TabIndex = 6;
            this.recieve.Text = "recieved ID:";
            // 
            // searchText
            // 
            this.searchText.AutoSize = true;
            this.searchText.Location = new System.Drawing.Point(11, 54);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(77, 26);
            this.searchText.TabIndex = 8;
            this.searchText.Text = "Search:";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(14, 16);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(71, 26);
            this.stock.TabIndex = 9;
            this.stock.Text = "Stock: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.addGame);
            this.panel1.Controls.Add(this.editGame);
            this.panel1.Controls.Add(this.deleteGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 804);
            this.panel1.TabIndex = 12;
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(0, 590);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(297, 144);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(68)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.gameShop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 137);
            this.panel2.TabIndex = 0;
            // 
            // gameShop
            // 
            this.gameShop.AutoSize = true;
            this.gameShop.Font = new System.Drawing.Font("Corbel", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameShop.Location = new System.Drawing.Point(-2, 40);
            this.gameShop.Name = "gameShop";
            this.gameShop.Size = new System.Drawing.Size(306, 53);
            this.gameShop.TabIndex = 0;
            this.gameShop.Text = "The Game Shop";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.game);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(297, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1068, 137);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 137);
            this.panel4.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(40, 137);
            this.panel7.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Games";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.gameForm);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(297, 137);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(505, 667);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(40, 667);
            this.panel6.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.panel9);
            this.contentPanel.Controls.Add(this.platformText);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(802, 137);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(563, 667);
            this.contentPanel.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.confirm);
            this.panel9.Controls.Add(this.stockBox);
            this.panel9.Controls.Add(this.stock);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 615);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(563, 52);
            this.panel9.TabIndex = 3;
            // 
            // confirm
            // 
            this.confirm.FlatAppearance.BorderSize = 0;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Location = new System.Drawing.Point(418, 0);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(145, 52);
            this.confirm.TabIndex = 11;
            this.confirm.Text = "confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click_1);
            // 
            // stockBox
            // 
            this.stockBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.stockBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockBox.ForeColor = System.Drawing.Color.White;
            this.stockBox.Location = new System.Drawing.Point(91, 13);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(201, 29);
            this.stockBox.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.searchBox);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(40, 615);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(465, 52);
            this.panel8.TabIndex = 2;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(93, 13);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(350, 26);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1365, 804);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.recieve);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBox)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
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
        private Label searchText;
        private Label stock;
        private Panel panel1;
        private Panel panel2;
        private Label gameShop;
        private Button exit;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel7;
        private Label label1;
        private Panel panel6;
        private Panel contentPanel;
        private Panel panel9;
        private Button confirm;
        private NumericUpDown stockBox;
        private Panel panel8;
        private Label label2;
        private TextBox searchBox;
    }
}

