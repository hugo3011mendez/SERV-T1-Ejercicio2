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

        private void btnView_Click(object sender, EventArgs e)
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
            try
            {
                // Guardo lo que el usuario ha introducido en la 2a TextBox
                int pid = Convert.ToInt32(txtPID.Text);

                // Y consigo el proceso en cuestión a partir de su ID
                Process proceso = Process.GetProcessById(pid);

                txtInfo.Text = ""; // Reinicio el texto que contiene la TextBox de información

                // Empiezo a mostrar la info del proceso
                txtInfo.AppendText("Nombre del proceso : " + proceso.ProcessName + Environment.NewLine);
                txtInfo.AppendText("Título de la ventana principal : " + proceso.MainWindowTitle + Environment.NewLine);
                txtInfo.AppendText("Momento en el que se inició el proceso : " + proceso.StartTime + Environment.NewLine);
                txtInfo.AppendText(Environment.NewLine);
                txtInfo.AppendText("----- HILOS -----" + Environment.NewLine + Environment.NewLine);

                // Guardo en una variable los hilos del proceso en cuestión y los recorro
                ProcessThreadCollection hilos = proceso.Threads;
                foreach (ProcessThread h in hilos)
                {
                    // Muestro la info de sus hilos
                    txtInfo.AppendText("ID del hilo : " + h.Id + Environment.NewLine);
                    txtInfo.AppendText("Estado del hilo : " + h.ThreadState + Environment.NewLine);
                    txtInfo.AppendText("Momento en el que se inició el hilo : " + h.StartTime + Environment.NewLine);
                    txtInfo.AppendText("Nivel de prioridad del hilo : " + h.PriorityLevel + Environment.NewLine);
                    txtInfo.AppendText("Tiempo total que el hilo ha estado usando el CPU : " + h.TotalProcessorTime + Environment.NewLine);
                    txtInfo.AppendText(Environment.NewLine + Environment.NewLine); // Hago un par de saltos de línea para dar separación entre la info de un hilo y otro
                }
            }
            catch (Exception)
            {
                txtInfo.Text = "Has escrito mal el PID del proceso que quieres buscar";   
            }
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
