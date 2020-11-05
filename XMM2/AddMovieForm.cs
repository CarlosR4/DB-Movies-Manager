using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMM2
{
    public partial class AddMovieForm : Form
    {
        public AddMovieForm()
        {
            InitializeComponent();
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            int year = int.Parse(yearTextBox.Text);
            string genre = genreTextBox.Text;
            string length = lengthTextBox.Text;
            string picture = pictureTextBox.Text;
            int rating = int.Parse(ratingTextBox.Text);
        }
    }
}
