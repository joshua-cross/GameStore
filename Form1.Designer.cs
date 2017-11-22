
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
            this.description = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // gameForm
            // 
            this.gameForm.FormattingEnabled = true;
            this.gameForm.Location = new System.Drawing.Point(154, 10);
            this.gameForm.Name = "gameForm";
            this.gameForm.Size = new System.Drawing.Size(364, 615);
            this.gameForm.TabIndex = 0;
            this.gameForm.SelectedIndexChanged += new System.EventHandler(this.gameForm_SelectedIndexChanged);
            // 
            // game
            // 
            this.game.AutoSize = true;
            this.game.BackColor = System.Drawing.Color.Transparent;
            this.game.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game.Location = new System.Drawing.Point(542, 10);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(145, 55);
            this.game.TabIndex = 1;
            this.game.Text = "game";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(557, 84);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(511, 328);
            this.description.TabIndex = 2;
            this.description.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 637);
            this.Controls.Add(this.description);
            this.Controls.Add(this.game);
            this.Controls.Add(this.gameForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gameForm;
        private Label game;
        private ListView description;
    }
}

