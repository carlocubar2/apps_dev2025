namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            {
                string[] cuisineGenre = { "Filipino", "Chinese", "American", "Mexican" };
                cmb.Items.AddRange(cuisineGenre);

                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                cmb.SelectedIndex = 0;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] filipinoCuisineList = { "Adobo", "Sinigang", "Lechon", "Pancit" };
            string[] chineseCuisinelist = { "Huaiyang", "Shandong", "Sichuan", "Cantonese" };
            string[] americanCuisineList = { " Fried Chicken", "Grilled Cheese", "Cheeseburger", "Steak And Fries" };
            string[] mexicanCuisineList = { "tacos", "chimichangas", "pozole", "ceviche" };

            clb.Items.Clear();

            if (cmb.SelectedItem != null && cmb.SelectedItem.ToString()!.Contains("Filipino"))
            {
                clb.Items.AddRange(filipinoCuisineList);

            }
            else if (cmb.SelectedItem != null && cmb.SelectedItem.ToString()!.Contains("Chinese"))
            {
                clb.Items.AddRange(chineseCuisinelist);
            }
            else if (cmb.SelectedItem != null && cmb.SelectedItem.ToString()!.Contains("American"))
            {
                clb.Items.AddRange(americanCuisineList);

            }
            else if (cmb.SelectedItem != null && cmb.SelectedItem.ToString()!.Contains("Mexican"))
            {
                clb.Items.AddRange(mexicanCuisineList);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in clb.Items)
            {
                bool isSelected = clb.GetItemChecked(clb.Items.IndexOf(item));
                if (isSelected && !lb.Items.Contains(item))
                {
                    lb.Items.Add(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lb.Items.Count >= 1 && lb.SelectedItem != null)
            {
                lb.Items.Remove(lb.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lb.Items.Clear();
        }
    }
}

