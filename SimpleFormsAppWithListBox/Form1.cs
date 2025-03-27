using System.Windows.Forms;

namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstBox.Items.Remove(lstBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbox.Text) && !lstBox.Items.Contains(txtbox.Text))
            {

                lstBox.Items.Add(txtbox.Text);
            }
        }
    }
}
