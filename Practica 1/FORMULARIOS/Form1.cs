namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonC_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0, resultado = 0;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);

                if (radiosuma.Checked)
                {
                    resultado = a + b;
                    MessageBox.Show("El resultado de la suma es: " + resultado);
                }
                else if (radiorest.Checked)
                {
                    resultado = a - b;
                    MessageBox.Show("El resultado de la resta es: " + resultado);
                }
                else if (radiomultiplicacion.Checked)
                {
                    resultado = a * b;
                    MessageBox.Show("El resultado de la multiplicacion es: " + resultado);
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("error de conversion");

            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}