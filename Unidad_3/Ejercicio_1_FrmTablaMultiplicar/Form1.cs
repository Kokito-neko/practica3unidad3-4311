namespace Ejercicio_1_FrmTablaMultiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();

            if (int.TryParse(txtNumero.Text, out int numero))
            {
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    lstTabla.Items.Add($"{numero} x {i} = {resultado}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
