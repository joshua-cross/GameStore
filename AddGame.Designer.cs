namespace TheGameShop
{
    partial class AddGame
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ageRatingBox = new System.Windows.Forms.NumericUpDown();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.gameName = new System.Windows.Forms.Label();
            this.platform = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.completed = new System.Windows.Forms.Label();
            this.platformBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.Label();
            this.stockBox = new System.Windows.Forms.NumericUpDown();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageRatingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(101, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 26);
            this.textBox1.TabIndex = 0;
            // 
            // ageRatingBox
            // 
            this.ageRatingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageRatingBox.Location = new System.Drawing.Point(101, 135);
            this.ageRatingBox.Name = "ageRatingBox";
            this.ageRatingBox.Size = new System.Drawing.Size(171, 26);
            this.ageRatingBox.TabIndex = 2;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(101, 167);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(171, 245);
            this.descriptionBox.TabIndex = 4;
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.Location = new System.Drawing.Point(7, 38);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(57, 20);
            this.gameName.TabIndex = 5;
            this.gameName.Text = "Game:";
            // 
            // platform
            // 
            this.platform.AutoSize = true;
            this.platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platform.Location = new System.Drawing.Point(7, 70);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(72, 20);
            this.platform.TabIndex = 6;
            this.platform.Text = "Platform:";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.Location = new System.Drawing.Point(7, 104);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(62, 20);
            this.genre.TabIndex = 7;
            this.genre.Text = "Genre: ";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(-2, 137);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(90, 20);
            this.age.TabIndex = 8;
            this.age.Text = "Age rating: ";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(-2, 168);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(97, 20);
            this.description.TabIndex = 9;
            this.description.Text = "Description: ";
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(197, 565);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 29);
            this.confirm.TabIndex = 10;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // completed
            // 
            this.completed.AutoSize = true;
            this.completed.Location = new System.Drawing.Point(13, 607);
            this.completed.Name = "completed";
            this.completed.Size = new System.Drawing.Size(49, 13);
            this.completed.TabIndex = 11;
            this.completed.Text = "waiting...";
            // 
            // platformBox
            // 
            this.platformBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformBox.Location = new System.Drawing.Point(101, 70);
            this.platformBox.Name = "platformBox";
            this.platformBox.Size = new System.Drawing.Size(171, 26);
            this.platformBox.TabIndex = 12;
            // 
            // genreBox
            // 
            this.genreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreBox.Location = new System.Drawing.Point(101, 104);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(171, 26);
            this.genreBox.TabIndex = 13;
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.Location = new System.Drawing.Point(4, 418);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(58, 20);
            this.stock.TabIndex = 15;
            this.stock.Text = "Stock: ";
            // 
            // stockBox
            // 
            this.stockBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockBox.Location = new System.Drawing.Point(101, 418);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(171, 26);
            this.stockBox.TabIndex = 16;
            // 
            // priceBox
            // 
            this.priceBox.DecimalPlaces = 2;
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.priceBox.Location = new System.Drawing.Point(101, 450);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(171, 26);
            this.priceBox.TabIndex = 17;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(7, 452);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(52, 20);
            this.price.TabIndex = 18;
            this.price.Text = "Price: ";
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 631);
            this.Controls.Add(this.price);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.stockBox);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.platformBox);
            this.Controls.Add(this.completed);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.description);
            this.Controls.Add(this.age);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.ageRatingBox);
            this.Controls.Add(this.textBox1);
            this.Name = "AddGame";
            this.Text = "AddGame";
            ((System.ComponentModel.ISupportInitialize)(this.ageRatingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown ageRatingBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label platform;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label completed;
        private System.Windows.Forms.TextBox platformBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.NumericUpDown stockBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.Label price;
    }
}