namespace metodoGrafico
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt1.Text, "[^0-9]"))
            {
                MessageBox.Show("por favor solo ingresar numeros");
                txt1.Text = txt1.Text.Remove(txt1.Text.Length - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ecuaciones = Int32.Parse(txt1.Text);
            MessageBox.Show(ecuaciones.ToString());
            this.Hide();
            va.vari = ecuaciones;
           variablesAgregar v1= new variablesAgregar();
            v1.Show();

        }
    }
}