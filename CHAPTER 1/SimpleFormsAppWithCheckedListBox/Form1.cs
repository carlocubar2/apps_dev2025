namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] movies = { "Sakamoto Days", "Solo leveling", "Stranger Things" };
            chcklstbox.Items.AddRange(movies);
            chcklstbox.CheckOnClick = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chcklstbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clrbtn_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            foreach (var item in chcklstbox.Items)
            {
                bool isSelected = chcklstbox.GetItemChecked(chcklstbox.Items.IndexOf(item));
                if (isSelected && !lstbox.Items.Contains(item))
                {
                    lstbox.Items.Add(item);
                }
            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (lstbox.Items.Count >= 0)
            {
                lstbox.Items.Remove(lstbox.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             lstbox.Items.Clear();
        }
    }
}
