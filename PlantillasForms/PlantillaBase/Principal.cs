using Base;
using System;

namespace Principal
{
    public partial class Principal : FormBase
    {
        private const string TITULO = "FORMULARIO PRINCIPAL ";

        public Principal()
        {
            InitializeComponent();

            TestCampos();
        }

         private void btInfoBase_Click(object sender, EventArgs e)
        {
            labelNotificaciones.Text = TITULO + ": Boton base ";
        }

        private void btPrincipal_Click(object sender, EventArgs e)
        {
            labelNotificaciones.Text = TITULO + ": Boton Principal ";
        }

        
        private void TestCampos()
        {
            labelNotificaciones.Text = "TESTEANDO notificaciones";
            labelAvisos.Text = "TESTEANDO avisos";
        }

    }
}
