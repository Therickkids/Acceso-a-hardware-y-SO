using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Management;
/*
 *Julian Manrique Cuervo
 *23/09/2024
 *Herramientas De Programacion_II
 */

namespace acceso_hardware_SO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerNumeroSerieDisco_Click(object sender, EventArgs e)
        {
            string cUnidad = "C:"; // Unidad de ejemplo
            MessageBox.Show(ObtenerNumeroSerieDisco(cUnidad));
        }

        private void btnContarUnidadesDisco_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Número de unidades de disco: " + nContarUnidadesDisco().ToString());
        }

        private void btnObtenerInventario_Click(object sender, EventArgs e)
        {
            ObtenerInventarioSistema();
        }

        private void btnObtenerMacAddress_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MAC Address: " + ObtenerMacAddress());
        }

        private void btnAccesoRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("regedit.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el Editor del Registro: {ex.Message}");
            }
        }

        private void btnObtenerProcesosActivos_Click(object sender, EventArgs e)
        {
            MostrarProcesosActivos(dataGridView1); // Llamar a la función que llena el DataGridView
        }

        private void btnMatarProceso_Click(object sender, EventArgs e)
        {
            // Matar todos los procesos activos
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    int nIdProceso = Convert.ToInt32(row.Cells["ProcessID"].Value);
                    Process.GetProcessById(nIdProceso).Kill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al matar el proceso con ID {row.Cells["ProcessID"].Value}: {ex.Message}");
                }
            }
            // Actualizar el DataGridView después de matar los procesos
            MostrarProcesosActivos(dataGridView1);
        }

        // Aquí van las funciones previamente definidas

        public string ObtenerNumeroSerieDisco(string cUnidad)
        {
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject oDisco in oSearcher.Get())
            {
                return oDisco["SerialNumber"].ToString();
            }
            return "No se encontró el número de serie.";
        }

        public int nContarUnidadesDisco()
        {
            return DriveInfo.GetDrives().Length;
        }

        public void ObtenerInventarioSistema()
        {
            // Obtener información del procesador
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject oProcessor in oSearcher.Get())
            {
                MessageBox.Show("Procesador: " + oProcessor["Name"]);
            }

            // Obtener información de la RAM
            oSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject oMemoria in oSearcher.Get())
            {
                MessageBox.Show("RAM: " + (Convert.ToInt64(oMemoria["Capacity"]) / (1024 * 1024 * 1024)) + " GB");
            }

            // Obtener información de las tarjetas de red (NIC)
            oSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE NetEnabled = true");
            foreach (ManagementObject oNIC in oSearcher.Get())
            {
                MessageBox.Show("NIC: " + oNIC["Name"]);
            }

            // Obtener información de los parches instalados (HotFixes)
            oSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_QuickFixEngineering");
            foreach (ManagementObject oPatch in oSearcher.Get())
            {
                MessageBox.Show("Patch: " + oPatch["HotFixID"]);
            }
        }

        public string ObtenerMacAddress()
        {
            foreach (NetworkInterface oNIC in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (oNIC.OperationalStatus == OperationalStatus.Up)
                {
                    return oNIC.GetPhysicalAddress().ToString();
                }
            }
            return "No se encontró MAC Address.";
        }

        // Mostrar los procesos activos en el DataGridView
        public void MostrarProcesosActivos(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("ProcessID", "ID Proceso");
            dgv.Columns.Add("ProcessName", "Nombre del Proceso");
            dgv.Columns.Add("MemoryUsage", "Memoria (MB)");

            Process[] procesos = Process.GetProcesses();
            foreach (Process proceso in procesos)
            {
                string memoriaUso = (proceso.WorkingSet64 / (1024 * 1024)).ToString();
                dgv.Rows.Add(proceso.Id, proceso.ProcessName, memoriaUso);
            }
        }

        public void MatarProceso(int nId)
        {
            try
            {
                Process.GetProcessById(nId).Kill();
            }
            catch (Exception oEx)
            {
                MessageBox.Show($"Error al matar el proceso: {oEx.Message}");
            }
        }
    }
}
