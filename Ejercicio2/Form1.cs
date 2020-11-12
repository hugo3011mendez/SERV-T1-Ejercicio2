using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ejercicio2
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e) // Mostrará todos los procesos en ejecución con la siguiente información : PID ,Nombre y titulo de la ventana principal si lo tiene.Aparecerá en columnas bien alineado. Al dar formato, si un nombre o ttulo de ventana ocupa más que lo permitido debe “acortarse” y aparecer con puntos suspensivos.
        {
            // Elimino el texto que podía contener y le añado el índice alineado
            txtInfo.Text = "";
            txtInfo.AppendText("PID\tNombre\t\tTitulo de ventana" + Environment.NewLine);

            // Creo un array que contiene los procesos en ejecución y lo recorro
            Process[] procesosEnEjecucion = Process.GetProcesses();
            for (int i = 0; i < procesosEnEjecucion.Length; i++)
            {
                // Obtengo el nombre del proceso para guardarlo en una variable y controlar su visualización por su tamaño
                String nombre = procesosEnEjecucion[i].ProcessName;
                if (nombre.Length > 15)
                {
                    nombre = nombre.Substring(0, 10) + "...";
                }

                // Obtengo el título de la ventana principal del proceso para guardarlo en una variable y controlar su visualización por su tamaño
                String titulo = procesosEnEjecucion[i].MainWindowTitle;
                if (titulo.Length > 15)
                {
                    titulo = titulo.Substring(0, 15) + "...";
                }

                // Añado esas propiedades del proceso dentro una línea para el TextBox
                if (nombre.Length < 8)
                {
                    txtInfo.AppendText(procesosEnEjecucion[i].Id + "\t" + nombre + "\t\t" + titulo + Environment.NewLine);
                }
                else
                {
                    txtInfo.AppendText(procesosEnEjecucion[i].Id + "\t" + nombre + "\t" + titulo + Environment.NewLine);
                }
            }
        }


        private void btnInfo_Click(object sender, EventArgs e)
        {

        }


        private void btnClose_Click(object sender, EventArgs e)
        {

        }


        private void btnKill_Click(object sender, EventArgs e)
        {

        }


        private void btnRun_Click(object sender, EventArgs e)
        {

        }
    }
}
