namespace Ejercicio_7_FrmPrimosEnRango
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
        {
            lstPrimos.Items.Clear();

            if (int.TryParse(txtInicio.Text, out int inicio) && int.TryParse(txtFin.Text, out int fin) && inicio > 0 && fin >= inicio)
            {
                for (int num = inicio; num <= fin; num++)
                {
                    if (EsPrimo(num))
                        lstPrimos.Items.Add(num);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un rango válido de números positivos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
        }







        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}

    
