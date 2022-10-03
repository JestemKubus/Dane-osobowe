using System.Windows.Forms.Design;

namespace zgadywanka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
        }
        private void button1_Click(object sender, EventArgs e)
         {
            
            if (imie.Text == "" || nazwisko.Text == "")
            {
                MessageBox.Show("B³êdne dane ");
            }
            else
            {
                MessageBox.Show("Wprowadzone dane: " + imie.Text + " " + nazwisko.Text + " " + dateTimePicker1.Text);
            }    
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}