using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlantillasForms
{
    public partial class Principal : PlantillasForms.FormBase
    {
        public Principal()
        {
            InitializeComponent();

            TestCampos();
        }






        private void TestCampos()
        {
            labelNotificaciones.Text = "TESTEANDO notificaciones";
            labelAvisos.Text= "TESTEANDO avisos";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelAvisos.Text = "ADIOS";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelAvisos.Text = "HOLA 2";
        }
    }
}
