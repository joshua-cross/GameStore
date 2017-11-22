
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
            this.SuspendLayout();
            // 
            // gameForm
            // 
            this.gameForm.FormattingEnabled = true;
            this.gameForm.ItemHeight = 25;
            this.gameForm.Location = new System.Drawing.Point(126, 33);
            this.gameForm.Margin = new System.Windows.Forms.Padding(6);
            this.gameForm.Name = "gameForm";
            this.gameForm.Size = new System.Drawing.Size(482, 729);
            this.gameForm.TabIndex = 0;
            this.gameForm.SelectedIndexChanged += new System.EventHandler(this.gameForm_SelectedIndexChanged);
            // 
            // game
            // 
            this.game.AutoSize = true;
            this.game.BackColor = System.Drawing.Color.Transparent;
            this.game.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game.Location = new System.Drawing.Point(671, 33);
            this.game.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(145, 55);
            this.game.TabIndex = 1;
            this.game.Text = "game";
            // 
            // platformText
            // 
            this.platformText.AutoSize = true;
            this.platformText.Location = new System.Drawing.Point(676, 103);
            this.platformText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.platformText.Name = "platformText";
            this.platformText.Size = new System.Drawing.Size(0, 25);
            this.platformText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 795);
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
    }
}

