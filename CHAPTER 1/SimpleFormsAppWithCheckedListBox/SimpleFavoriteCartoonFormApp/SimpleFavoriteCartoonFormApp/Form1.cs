using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = true;
            comboBox1.Items.Add("Spongebob");
            comboBox1.Items.Add("Patrick");
            comboBox1.Items.Add("Mr. Krabs");
            comboBox1.Items.Add("Sandy");
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSelect_Click_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a character!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedCharacter = comboBox1.SelectedItem.ToString();
            string imagePath = "";

            if (selectedCharacter == "Spongebob")
                imagePath = "spongebob.jpg";
            else if (selectedCharacter == "Patrick")
                imagePath = "patrick.jpg";
            else if (selectedCharacter == "Mr. Krabs")
                imagePath = "mrkrabs.jpg";
            else if (selectedCharacter == "Sandy")
                imagePath = "sandy.jpg";

            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Image not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
