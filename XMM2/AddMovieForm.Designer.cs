namespace XMM2
{
    partial class AddMovieForm
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
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.pictureTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(72, 112);
            this.genreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(161, 22);
            this.genreTextBox.TabIndex = 69;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(72, 150);
            this.lengthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(161, 22);
            this.lengthTextBox.TabIndex = 68;
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.Location = new System.Drawing.Point(72, 189);
            this.pictureTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.Size = new System.Drawing.Size(161, 22);
            this.pictureTextBox.TabIndex = 67;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(72, 226);
            this.ratingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(161, 22);
            this.ratingTextBox.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "Rating:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Picture:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Genre:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(72, 75);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(161, 22);
            this.yearTextBox.TabIndex = 60;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(72, 36);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(161, 22);
            this.titleTextBox.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Title:";
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(72, 269);
            this.addMovieButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(161, 44);
            this.addMovieButton.TabIndex = 70;
            this.addMovieButton.Text = "Add movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 339);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.pictureTextBox);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMovieForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox pictureTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addMovieButton;
    }
}