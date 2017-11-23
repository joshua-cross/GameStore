namespace TheGameShop
{
    partial class EditGame
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
            this.gameBox = new System.Windows.Forms.TextBox();
            this.platformBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.game = new System.Windows.Forms.Label();
            this.platform = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.ageRating = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBox
            // 
            this.gameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameBox.Location = new System.Drawing.Point(192, 72);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(173, 26);
            this.gameBox.TabIndex = 0;
            // 
            // platformBox
            // 
            this.platformBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformBox.Location = new System.Drawing.Point(192, 104);
            this.platformBox.Name = "platformBox";
            this.platformBox.Size = new System.Drawing.Size(173, 26);
            this.platformBox.TabIndex = 1;
            // 
            // genreBox
            // 
            this.genreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreBox.Location = new System.Drawing.Point(192, 136);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(173, 26);
            this.genreBox.TabIndex = 2;
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.Location = new System.Drawing.Point(192, 168);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(173, 26);
            this.ageBox.TabIndex = 3;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(192, 200);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(173, 275);
            this.descriptionBox.TabIndex = 4;
            // 
            // game
            // 
            this.game.AutoSize = true;
            this.game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game.Location = new System.Drawing.Point(12, 75);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(57, 20);
            this.game.TabIndex = 5;
            this.game.Text = "Game:";
            // 
            // platform
            // 
            this.platform.AutoSize = true;
            this.platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platform.Location = new System.Drawing.Point(12, 107);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(72, 20);
            this.platform.TabIndex = 6;
            this.platform.Text = "Platform:";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.Location = new System.Drawing.Point(12, 139);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(58, 20);
            this.genre.TabIndex = 7;
            this.genre.Text = "Genre:";
            // 
            // ageRating
            // 
            this.ageRating.AutoSize = true;
            this.ageRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageRating.Location = new System.Drawing.Point(12, 170);
            this.ageRating.Name = "ageRating";
            this.ageRating.Size = new System.Drawing.Size(86, 20);
            this.ageRating.TabIndex = 8;
            this.ageRating.Text = "Age rating:";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(12, 203);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(93, 20);
            this.description.TabIndex = 9;
            this.description.Text = "Description:";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(290, 492);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 10;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // results
            // 
            this.results.AutoSize = true;
            this.results.Location = new System.Drawing.Point(13, 519);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(40, 13);
            this.results.TabIndex = 11;
            this.results.Text = "Result:";
            // 
            // EditGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 544);
            this.Controls.Add(this.results);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.description);
            this.Controls.Add(this.ageRating);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.game);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.platformBox);
            this.Controls.Add(this.gameBox);
            this.Name = "EditGame";
            this.Text = "EditGame";
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gameBox;
        private System.Windows.Forms.TextBox platformBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.NumericUpDown ageBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label game;
        private System.Windows.Forms.Label platform;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label ageRating;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label results;
    }
}