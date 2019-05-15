using System;
using System.Windows.Forms;

namespace Base
{
    public partial class FormBase : Form
    {

        private const string TITULO = "PLANTILLA BÁSICA";

        public FormBase()
        {
            InitializeComponent();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            SetPropiedadesEspecificas();
        }

        private void SetPropiedadesEspecificas()
        {

        }

        protected void btInfoBase_Click(object sender, EventArgs e)
        {
            labelNotificaciones.Text = TITULO + ": Boton base ";
        }
    }

}
