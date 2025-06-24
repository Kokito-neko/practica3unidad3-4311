namespace Ejercicio_4_FrmPalindromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
        
            string palabra = txtPalabra.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(palabra))
            {
                MessageBox.Show("Por favor, ingresa una palabra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Invertir la palabra
            string invertida = new string(palabra.Reverse().ToArray());

            if (palabra == invertida)
            {
                MessageBox.Show("¡Es un palíndromo!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No es un palíndromo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }

