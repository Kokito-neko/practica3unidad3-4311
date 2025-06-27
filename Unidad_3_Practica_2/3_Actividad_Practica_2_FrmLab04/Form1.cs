using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3_Actividad_Practica_2_FrmLab04.Controllers;
using _3_Actividad_Practica_2_FrmLab04.Entities;

namespace _3_Actividad_Practica_2_FrmLab04
{
    public partial class Form1 : Form
    {
        private AlumnoController alumnoController = new AlumnoController();


        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAlumnos(Alumno[] alumnos)
        {
            dgAlumnos.DataSource = null;
            dgAlumnos.DataSource = alumnos;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPromedio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Alumno alumno = new Alumno
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Promedio = double.Parse(tbPromedio.Text)
            };

            alumnoController.Registrar(alumno);

            MostrarAlumnos(alumnoController.ListarTodo());

            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            tbCodigo.Clear();
            tbNombre.Clear();
            tbPromedio.Clear();
            tbBuscar.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar");
                return;
            }

            string codigo = dgAlumnos.SelectedRows[0].Cells[0].Value.ToString();

            alumnoController.Eliminar(codigo);

            MostrarAlumnos(alumnoController.ListarTodo());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            MostrarAlumnos(alumnoController.ObtenerOrdenadosPorPromedio());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese el código a buscar");
                return;
            }

            string Codigo = tbBuscar.Text.Trim();

            MostrarAlumnos(alumnoController.BuscarPorCodigo(Codigo));
            string codigo = tbBuscar.Text.Trim();
            Alumno[] resultado = alumnoController.BuscarPorCodigo(codigo);

            if (resultado.Length == 0)
            {
                MessageBox.Show("No se encontró ningún alumno con ese código");
                MostrarAlumnos(alumnoController.ListarTodo());
            }
            else
            {
                MostrarAlumnos(resultado);
            }


        }
    }
}
