namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Database database;

        public Form1()
        {
            InitializeComponent();
            database = new Database();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(enterName.Text) && !listOfUsers.Items.Contains(enterName.Text))
            {
                listOfUsers.Items.Add(enterName.Text);
            }
        }

        private void CreateTable_Click(object sender, EventArgs e)
        {
            try
            {
                database.CreateTable("table");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Table already exists");
            }
        }

        private void AddToDatabase_Click(object sender, EventArgs e)
        {
            database.AddRow("users", listOfUsers.Items[0].ToString());
        }

        private void FindById_Click(object sender, EventArgs e)
        {
            string userName = database.FindById(int.Parse(enterId.Text));

            listOfUsers.Items.Clear();
            listOfUsers.Items.Add(userName);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
