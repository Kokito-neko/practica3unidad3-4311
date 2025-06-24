namespace Ejercicio_3_FrmConversorLongitud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void FrmConversorLongitud_Load(object sender, EventArgs e)
        {

            cmbOrigen.Items.AddRange(new string[] { "Metro", "Cent�metro", "Pulgada" });
            cmbDestino.Items.AddRange(new string[] { "Metro", "Cent�metro", "Pulgada" });
        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValor.Text, out double valor) &&
                cmbOrigen.SelectedItem != null && cmbDestino.SelectedItem != null)
            {
                string origen = cmbOrigen.SelectedItem.ToString();
                string destino = cmbDestino.SelectedItem.ToString();

                
                double valorEnMetros = origen switch
                {
                    "Metro" => valor,
                    "Cent�metro" => valor / 100,
                    "Pulgada" => valor * 0.0254,
                    _ => 0
                };

                
                double valorConvertido = destino switch
                {
                    "Metro" => valorEnMetros,
                    "Cent�metro" => valorEnMetros * 100,
                    "Pulgada" => valorEnMetros / 0.0254,
                    _ => 0
                };

                lblResultado.Text = $"Resultado: {valorConvertido:F2} {destino}";
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos con datos v�lidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

       
    }
    

