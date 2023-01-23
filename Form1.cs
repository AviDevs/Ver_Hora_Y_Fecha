using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorialsYoutube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void horayfecha_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("hh:mm:ss");
            lblhora.Text = DateTime.Now.ToShortDateString();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            string descripcion = "Mi programa es una aplicación Para ver La hora y la Fecha Facil de Programar . \n\n Creado por: AviDevs \n Version: 1.0 \n Actualizacion #1 Sigueme En Youtube \n ";
            MessageBox.Show(descripcion, "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           
        }
    }
}
