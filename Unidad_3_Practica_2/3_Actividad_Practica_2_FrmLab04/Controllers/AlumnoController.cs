using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_Actividad_Practica_2_FrmLab04.Entities;

namespace _3_Actividad_Practica_2_FrmLab04.Controllers
{
    internal class AlumnoController
    {
        private Alumno[] alumnos = new Alumno[100];
        private int cont = 0;

        public Alumno[] ListarTodo()
        {
            return alumnos;
        }

        public void Registrar(Alumno alumno)
        {
            alumnos[cont] = alumno;
            cont++;
        }

        public void Eliminar(string codigo)
        {
            int posicion = Array.FindIndex(alumnos, alumno => alumno != null && alumno.Codigo == codigo);

            if (posicion != -1)
            {
                for (int i = posicion; i < cont - 1; i++)
                {
                    alumnos[i] = alumnos[i + 1];
                }
                alumnos[cont - 1] = null; // Limpia la última celda
                cont--;
            }
        }

        private class MetodoComparacion : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return 1;
                if (y == null) return -1;

                if (x.Promedio < y.Promedio) return -1;
                else if (x.Promedio == y.Promedio) return 0;
                else return 1;
            }

            public Alumno[] ordenar(Alumno[] lista, int cantidad)

            {
                Alumno[] copia = new Alumno[cantidad];
                Array.Copy(lista, copia, cantidad);
                Array.Sort(copia, new MetodoComparacion());
                return copia;
            }

        }

        public Alumno[] ObtenerOrdenadosPorPromedio()
        {
            MetodoComparacion metodo = new MetodoComparacion();
            return metodo.ordenar(alumnos, cont);
        }

        internal Alumno[] BuscarPorCodigo(string codigoParcial)
        {
            if (string.IsNullOrWhiteSpace(codigoParcial))
                return Array.Empty<Alumno>();

            return alumnos
                .Where(a =>
                    a != null &&
                    a.Codigo.ToLower().Contains(codigoParcial.Trim().ToLower())
                )
                .ToArray();
        }

    }
}
