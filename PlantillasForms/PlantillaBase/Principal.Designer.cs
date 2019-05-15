namespace Principal
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btPrincipal = new System.Windows.Forms.Button();
            this.panelNotificacionesSuperior.SuspendLayout();
            this.panelAvisosInfoerior.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNotificaciones
            // 
            this.labelNotificaciones.Visible = false;
            // 
            // btInfoBase
            // 
            this.btInfoBase.Location = new System.Drawing.Point(4, 56);
            this.btInfoBase.Size = new System.Drawing.Size(134, 23);
            this.btInfoBase.Click += new System.EventHandler(this.btInfoBase_Click);
            // 
            // btPrincipal
            // 
            this.btPrincipal.Location = new System.Drawing.Point(4, 85);
            this.btPrincipal.Name = "btPrincipal";
            this.btPrincipal.Size = new System.Drawing.Size(134, 23);
            this.btPrincipal.TabIndex = 3;
            this.btPrincipal.Text = "Boton PPAL";
            this.btPrincipal.UseVisualStyleBackColor = true;
            this.btPrincipal.Click += new System.EventHandler(this.btPrincipal_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btPrincipal);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Controls.SetChildIndex(this.panelNotificacionesSuperior, 0);
            this.Controls.SetChildIndex(this.panelAvisosInfoerior, 0);
            this.Controls.SetChildIndex(this.btInfoBase, 0);
            this.Controls.SetChildIndex(this.btPrincipal, 0);
            this.panelNotificacionesSuperior.ResumeLayout(false);
            this.panelAvisosInfoerior.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btPrincipal;
    }
}
