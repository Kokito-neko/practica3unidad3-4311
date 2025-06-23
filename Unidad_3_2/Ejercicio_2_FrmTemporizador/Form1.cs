namespace Ejercicio_2_FrmTemporizador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Botón presionado");

        }
        int tiempoRestante;

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            int minutos = (int)nudMinutos.Value;
            int segundos = (int)nudSegundos.Value;
            tiempoRestante = (minutos * 60) + segundos;

            if (tiempoRestante > 0)
            {
                Temporizador.Start();
            }
            else
            {
                MessageBox.Show("Configura un tiempo mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;

            if (tiempoRestante <= 0)
            {
                Temporizador.Stop();
                MessageBox.Show("¡Tiempo agotado!", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }

