namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi Rohith");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string str = "Name:" + textBox1.Text;
            str += "\nFather's Name:" + textBox2.Text;
            str += "\nDate of Birth:" + dateTimePicker1.Text;
            str += "\nPreferences in Life:" + comboBox1.Text;
            MessageBox.Show(str);
        }
    }
}
