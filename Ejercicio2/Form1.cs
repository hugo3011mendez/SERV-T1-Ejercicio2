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
            txtInfo.AppendText(String.Format("{0,-8}{1,-21}{2,-13}", "PID", "Nombre", "Titulo de ventana") + Environment.NewLine);

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
                txtInfo.AppendText(String.Format("{0,-8}{1,-21}{2,-13}", procesosEnEjecucion[i].Id, nombre, titulo) + Environment.NewLine);
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

                // Guardo en una variable los módulos del proceso
                ProcessModuleCollection modulos = proceso.Modules;

                txtInfo.AppendText(Environment.NewLine + Environment.NewLine + "----- Módulos -----" + Environment.NewLine + Environment.NewLine);
                foreach (ProcessModule modulo in modulos)
                {
                    txtInfo.AppendText(modulo.ModuleName + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                // Reinicio los TextBox y muestro el mensaje de error
                txtInfo.Text = "";
                txtPID.Text = "";

                if (ex is FormatException)
                {
                    MessageBox.Show("Has escrito mal el PID del proceso que quieres buscar");
                }
                else if (ex is OverflowException)
                {
                    MessageBox.Show("Has escrito un número demasiado grande!");
                }
                else if (ex is ArgumentException)
                {
                    MessageBox.Show("No se ha encontrado el proceso con el PID especificado");
                }
                else if (ex is Win32Exception)
                {
                    MessageBox.Show("No se tienen los permisos necesarios para ver la información este proceso");
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardo lo que el usuario ha introducido en la TextBox y obtengo el proceso indicado
                int pid = Convert.ToInt32(txtPID.Text);
                Process proceso = Process.GetProcessById(pid);

                proceso.CloseMainWindow(); // Lanzo la petición de cierre al proceso

                txtInfo.Text = "Petición de cierre al proceso "+ proceso.ProcessName +" enviada correctamente";
            }
            catch (Exception ex)
            {
                txtPID.Text = "";

                if (ex is FormatException)
                {
                    MessageBox.Show("Has escrito mal el PID del proceso que quieres buscar");
                }
                else if (ex is OverflowException)
                {
                    MessageBox.Show("Has escrito un número demasiado grande!");
                }
                else if (ex is ArgumentException)
                {
                    MessageBox.Show("No se ha encontrado el proceso con el PID especificado");
                }
                else if (ex is Win32Exception)
                {
                    MessageBox.Show("No se tienen los permisos necesarios para cerrar este proceso");
                }

            }
        }


        private void btnKill_Click(object sender, EventArgs e)
        {
            try
            {
                // Guardo lo que el usuario ha introducido en la TextBox y obtengo el proceso indicado
                int pid = Convert.ToInt32(txtPID.Text);
                Process proceso = Process.GetProcessById(pid);

                proceso.Kill(); // Detengo el proceso

                txtInfo.Text = "Proceso detenido correctamente";
            }
            catch (Exception ex)
            {
                txtPID.Text = "";

                if (ex is FormatException)
                {
                    MessageBox.Show("Has escrito mal el PID del proceso que quieres buscar");
                }
                else if (ex is OverflowException)
                {
                    MessageBox.Show("Has escrito un número demasiado grande!");
                }
                else if (ex is ArgumentException)
                {
                    MessageBox.Show("No se ha encontrado el proceso con el PID especificado");
                }
                else if (ex is Win32Exception)
                {
                    MessageBox.Show("No se tienen los permisos necesarios para matar a este proceso");
                }
            }
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                String nombre = txtPID.Text;
                Process proceso = Process.Start(nombre); // Lanzo directamente el proceso con los caracteres que contiene el TextBox como parámetro
            }
            catch (Exception ex)
            {
                txtPID.Text = "";

                if (ex is FormatException)
                {
                    MessageBox.Show("Has escrito mal el nombre o el path del proceso que quieres ejecutar, el formato no coincide");
                }
                else if (ex is InvalidOperationException)
                {
                    MessageBox.Show("El TextBox está vacío! Escribe el nombre de un proceso para ejecutarlo");
                }
                else if (ex is Win32Exception)
                {
                    MessageBox.Show("No se ha encontrado el proceso con el nombre que has especificado o no tienes los permisos suficientes");
                }

            }
        }
    }
}
