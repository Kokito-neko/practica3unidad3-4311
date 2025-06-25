namespace Ejercicio_8_FrmSumaConProgreso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
           
        
            if (int.TryParse(txtMaximo.Text, out int maximo) && maximo > 0)
            {
                int suma = 0;
                prgSuma.Value = 0;
                prgSuma.Maximum = maximo;
                lblResultado.Text = "";

                for (int i = 1; i <= maximo; i++)
                {
                    suma += i;
                    prgSuma.Value = i;
                    System.Threading.Thread.Sleep(20); // Simula trabajo
                    Application.DoEvents(); // Refresca visualmente la barra
                }

                lblResultado.Text = $"La suma de 1 hasta {maximo} es: {suma}";
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }

