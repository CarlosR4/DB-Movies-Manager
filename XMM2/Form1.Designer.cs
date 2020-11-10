namespace XMM2
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
            this.components = new System.ComponentModel.Container();
            this.moviesListView = new System.Windows.Forms.ListView();
            this.moviePictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.modifyMovieButton = new System.Windows.Forms.Button();
            this.modifyMemberButton = new System.Windows.Forms.Button();
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.pictureTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.movieSearchButton = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.memberPictureBox = new System.Windows.Forms.PictureBox();
            this.memberListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.modifyGenre = new System.Windows.Forms.Button();
            this.genreListBox = new System.Windows.Forms.ListBox();
            this.actorsListBox = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.movieImageList = new System.Windows.Forms.ImageList(this.components);
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.membersImageList = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesListView
            // 
            this.moviesListView.HideSelection = false;
            this.moviesListView.Location = new System.Drawing.Point(12, 12);
            this.moviesListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moviesListView.Name = "moviesListView";
            this.moviesListView.Size = new System.Drawing.Size(415, 365);
            this.moviesListView.TabIndex = 0;
            this.moviesListView.UseCompatibleStateImageBehavior = false;
            this.moviesListView.SelectedIndexChanged += new System.EventHandler(this.MoviesListView_SelectedIndexChanged);
            // 
            // moviePictureBox
            // 
            this.moviePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moviePictureBox.Location = new System.Drawing.Point(447, 12);
            this.moviePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moviePictureBox.Name = "moviePictureBox";
            this.moviePictureBox.Size = new System.Drawing.Size(339, 313);
            this.moviePictureBox.TabIndex = 1;
            this.moviePictureBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1101, 607);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 49);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(508, 496);
            this.addMovieButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(153, 44);
            this.addMovieButton.TabIndex = 3;
            this.addMovieButton.Text = "Add movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(667, 394);
            this.addMemberButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(152, 44);
            this.addMemberButton.TabIndex = 4;
            this.addMemberButton.Text = "Add member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click_1);
            // 
            // modifyMovieButton
            // 
            this.modifyMovieButton.Location = new System.Drawing.Point(508, 553);
            this.modifyMovieButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyMovieButton.Name = "modifyMovieButton";
            this.modifyMovieButton.Size = new System.Drawing.Size(153, 44);
            this.modifyMovieButton.TabIndex = 5;
            this.modifyMovieButton.Text = "Modify movie";
            this.modifyMovieButton.UseVisualStyleBackColor = true;
            this.modifyMovieButton.Click += new System.EventHandler(this.ModifyMovieButton_Click);
            // 
            // modifyMemberButton
            // 
            this.modifyMemberButton.Location = new System.Drawing.Point(667, 444);
            this.modifyMemberButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyMemberButton.Name = "modifyMemberButton";
            this.modifyMemberButton.Size = new System.Drawing.Size(152, 44);
            this.modifyMemberButton.TabIndex = 6;
            this.modifyMemberButton.Text = "Modify member";
            this.modifyMemberButton.UseVisualStyleBackColor = true;
            this.modifyMemberButton.Click += new System.EventHandler(this.modifyMemberButton_Click);
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Location = new System.Drawing.Point(508, 609);
            this.deleteMovieButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(153, 44);
            this.deleteMovieButton.TabIndex = 7;
            this.deleteMovieButton.Text = "Delete movie";
            this.deleteMovieButton.UseVisualStyleBackColor = true;
            this.deleteMovieButton.Click += new System.EventHandler(this.DeleteMovieButton_Click);
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.Location = new System.Drawing.Point(667, 496);
            this.deleteMemberButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(152, 44);
            this.deleteMemberButton.TabIndex = 8;
            this.deleteMemberButton.Text = "Delete member";
            this.deleteMemberButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Enabled = false;
            this.titleTextBox.Location = new System.Drawing.Point(91, 393);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(161, 22);
            this.titleTextBox.TabIndex = 13;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Enabled = false;
            this.yearTextBox.Location = new System.Drawing.Point(91, 432);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(161, 22);
            this.yearTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Length:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Picture:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 587);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rating:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Member:";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Enabled = false;
            this.ratingTextBox.Location = new System.Drawing.Point(91, 583);
            this.ratingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(161, 22);
            this.ratingTextBox.TabIndex = 21;
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.Enabled = false;
            this.pictureTextBox.Location = new System.Drawing.Point(91, 546);
            this.pictureTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.Size = new System.Drawing.Size(161, 22);
            this.pictureTextBox.TabIndex = 23;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Enabled = false;
            this.lengthTextBox.Location = new System.Drawing.Point(91, 507);
            this.lengthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(161, 22);
            this.lengthTextBox.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(995, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Member:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1113, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Sort by:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1009, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "Genre:";
            // 
            // movieSearchButton
            // 
            this.movieSearchButton.Location = new System.Drawing.Point(1101, 464);
            this.movieSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movieSearchButton.Name = "movieSearchButton";
            this.movieSearchButton.Size = new System.Drawing.Size(152, 25);
            this.movieSearchButton.TabIndex = 36;
            this.movieSearchButton.Text = "Search";
            this.movieSearchButton.UseVisualStyleBackColor = true;
            this.movieSearchButton.Click += new System.EventHandler(this.movieSearchButton_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(917, 433);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(335, 22);
            this.textBox8.TabIndex = 37;
            // 
            // memberPictureBox
            // 
            this.memberPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memberPictureBox.Location = new System.Drawing.Point(804, 12);
            this.memberPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memberPictureBox.Name = "memberPictureBox";
            this.memberPictureBox.Size = new System.Drawing.Size(199, 184);
            this.memberPictureBox.TabIndex = 40;
            this.memberPictureBox.TabStop = false;
            // 
            // memberListBox
            // 
            this.memberListBox.FormattingEnabled = true;
            this.memberListBox.ItemHeight = 16;
            this.memberListBox.Location = new System.Drawing.Point(328, 394);
            this.memberListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memberListBox.Name = "memberListBox";
            this.memberListBox.Size = new System.Drawing.Size(152, 260);
            this.memberListBox.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(840, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Member Info";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(816, 279);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(823, 321);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 44;
            this.label16.Text = "DOB:";
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(508, 393);
            this.addGenreButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(153, 44);
            this.addGenreButton.TabIndex = 47;
            this.addGenreButton.Text = "Add genre";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.AddGenreButton_Click);
            // 
            // modifyGenre
            // 
            this.modifyGenre.Location = new System.Drawing.Point(508, 444);
            this.modifyGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyGenre.Name = "modifyGenre";
            this.modifyGenre.Size = new System.Drawing.Size(153, 44);
            this.modifyGenre.TabIndex = 48;
            this.modifyGenre.Text = "Modify genre";
            this.modifyGenre.UseVisualStyleBackColor = true;
            // 
            // genreListBox
            // 
            this.genreListBox.FormattingEnabled = true;
            this.genreListBox.ItemHeight = 16;
            this.genreListBox.Items.AddRange(new object[] {
            "ALL"});
            this.genreListBox.Location = new System.Drawing.Point(1069, 48);
            this.genreListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genreListBox.Name = "genreListBox";
            this.genreListBox.Size = new System.Drawing.Size(184, 148);
            this.genreListBox.TabIndex = 53;
            this.genreListBox.SelectedIndexChanged += new System.EventHandler(this.GenreListBox_SelectedIndexChanged);
            // 
            // actorsListBox
            // 
            this.actorsListBox.FormattingEnabled = true;
            this.actorsListBox.ItemHeight = 16;
            this.actorsListBox.Location = new System.Drawing.Point(1068, 233);
            this.actorsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actorsListBox.Name = "actorsListBox";
            this.actorsListBox.Size = new System.Drawing.Size(184, 148);
            this.actorsListBox.TabIndex = 54;
            this.actorsListBox.SelectedIndexChanged += new System.EventHandler(this.actorsListBox_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(831, 404);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 17);
            this.label19.TabIndex = 55;
            this.label19.Text = "Search by:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Movie",
            "Member"});
            this.comboBox1.Location = new System.Drawing.Point(917, 396);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 24);
            this.comboBox1.TabIndex = 56;
            // 
            // movieImageList
            // 
            this.movieImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.movieImageList.ImageSize = new System.Drawing.Size(255, 255);
            this.movieImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Enabled = false;
            this.genreTextBox.Location = new System.Drawing.Point(91, 469);
            this.genreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(161, 22);
            this.genreTextBox.TabIndex = 57;
            // 
            // membersImageList
            // 
            this.membersImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.membersImageList.ImageSize = new System.Drawing.Size(150, 150);
            this.membersImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(823, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "Type:";
            // 
            // label17
            // 
            this.label17.Enabled = false;
            this.label17.Location = new System.Drawing.Point(873, 276);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(184, 22);
            this.label17.TabIndex = 59;
            // 
            // label18
            // 
            this.label18.Enabled = false;
            this.label18.Location = new System.Drawing.Point(873, 318);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(184, 22);
            this.label18.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(873, 358);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 22);
            this.label10.TabIndex = 61;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 663);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.actorsListBox);
            this.Controls.Add(this.genreListBox);
            this.Controls.Add(this.modifyGenre);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberListBox);
            this.Controls.Add(this.memberPictureBox);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.movieSearchButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.pictureTextBox);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteMemberButton);
            this.Controls.Add(this.deleteMovieButton);
            this.Controls.Add(this.modifyMemberButton);
            this.Controls.Add(this.modifyMovieButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.moviePictureBox);
            this.Controls.Add(this.moviesListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Movie Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView moviesListView;
        private System.Windows.Forms.PictureBox moviePictureBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button modifyMovieButton;
        private System.Windows.Forms.Button modifyMemberButton;
        private System.Windows.Forms.Button deleteMovieButton;
        private System.Windows.Forms.Button deleteMemberButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox pictureTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button movieSearchButton;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.PictureBox memberPictureBox;
        private System.Windows.Forms.ListBox memberListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button modifyGenre;
        private System.Windows.Forms.ListBox genreListBox;
        private System.Windows.Forms.ListBox actorsListBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ImageList movieImageList;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.ImageList membersImageList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox label17;
        private System.Windows.Forms.TextBox label18;
        private System.Windows.Forms.TextBox label10;
    }
}

