namespace CallAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e, string id) //btnGet
        {
            var response = await RestHelper.Get(id);
            txtResponse.Text = RestHelper.BeautifyJson(response);
        }

        private async void button5_Click(object sender, EventArgs e) //put
        {
            var response = await RestHelper.PUT(txtName.Text, txtPrice.Text, txtQuantity.Text, txtID.Text);
            txtResponse.Text = RestHelper.BeautifyJson(response);
        }

        private async void button3_Click(object sender, EventArgs e) //btnGetAll
        {
            var response = await RestHelper.GetAll();
            txtResponse.Text = RestHelper.BeautifyJson(response);
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnDelete_Click(object sender, EventArgs e) //delete
        {
            string id = txtID.Text; // Assuming you have a TextBox named txtID
            var response = await RestHelper.Delete(id);
            txtResponse.Text = RestHelper.BeautifyJson(response);
        }
    }
}
