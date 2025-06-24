namespace Ejercicio_6_FrmNumeroPerfecto
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
            if (int.TryParse(mtbPerfecto.Text, out int numero) && numero > 0)
            {
                int suma = 0;

                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                        suma += i;
                }

                if (suma == numero)
                {
                    MessageBox.Show($"{numero} es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{numero} no es un número perfecto.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }
}
