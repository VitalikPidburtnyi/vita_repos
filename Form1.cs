namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("You didn't enter anything");
                
            }
            else if (int.TryParse(textBox.Text, out int value))
            {
                MessageBox.Show("You entered number " + textBox.Text);
                textBox.Text = "";
            }
            else
            {
                MessageBox.Show("Not a number");
                textBox.Text = "";
            }
        }
    }
}