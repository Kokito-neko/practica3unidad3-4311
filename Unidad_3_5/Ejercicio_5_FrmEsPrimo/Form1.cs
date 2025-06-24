namespace Ejercicio_5_FrmEsPrimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            
        {
            if (int.TryParse(mtbNumero.Text, out int numero) && numero > 1)
            {
                bool esPrimo = true;

                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    MessageBox.Show($"{numero} es un número primo.");
                }
                else
                {
                    MessageBox.Show($"{numero} no es un número primo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido mayor que 1.");
            }
        }
    }
    }
}
