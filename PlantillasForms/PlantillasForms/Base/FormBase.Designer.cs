namespace PlantillasForms
{
    partial class FormBase
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
            this.panelNotificacionesSuperior = new System.Windows.Forms.Panel();
            this.labelNotificaciones = new System.Windows.Forms.Label();
            this.panelAvisosInfoerior = new System.Windows.Forms.Panel();
            this.labelAvisos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelNotificacionesSuperior.SuspendLayout();
            this.panelAvisosInfoerior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNotificacionesSuperior
            // 
            this.panelNotificacionesSuperior.BackColor = System.Drawing.Color.Khaki;
            this.panelNotificacionesSuperior.Controls.Add(this.labelNotificaciones);
            this.panelNotificacionesSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNotificacionesSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelNotificacionesSuperior.Name = "panelNotificacionesSuperior";
            this.panelNotificacionesSuperior.Size = new System.Drawing.Size(684, 50);
            this.panelNotificacionesSuperior.TabIndex = 0;
            // 
            // labelNotificaciones
            // 
            this.labelNotificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotificaciones.Location = new System.Drawing.Point(0, 0);
            this.labelNotificaciones.Margin = new System.Windows.Forms.Padding(0);
            this.labelNotificaciones.Name = "labelNotificaciones";
            this.labelNotificaciones.Size = new System.Drawing.Size(684, 50);
            this.labelNotificaciones.TabIndex = 0;
            this.labelNotificaciones.Text = "label1";
            this.labelNotificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAvisosInfoerior
            // 
            this.panelAvisosInfoerior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAvisosInfoerior.Controls.Add(this.labelAvisos);
            this.panelAvisosInfoerior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAvisosInfoerior.Location = new System.Drawing.Point(0, 411);
            this.panelAvisosInfoerior.Name = "panelAvisosInfoerior";
            this.panelAvisosInfoerior.Size = new System.Drawing.Size(684, 50);
            this.panelAvisosInfoerior.TabIndex = 1;
            // 
            // labelAvisos
            // 
            this.labelAvisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAvisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvisos.Location = new System.Drawing.Point(0, 0);
            this.labelAvisos.Name = "labelAvisos";
            this.labelAvisos.Size = new System.Drawing.Size(684, 50);
            this.labelAvisos.TabIndex = 1;
            this.labelAvisos.Text = "SIN AVISOS";
            this.labelAvisos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelAvisosInfoerior);
            this.Controls.Add(this.panelNotificacionesSuperior);
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.panelNotificacionesSuperior.ResumeLayout(false);
            this.panelAvisosInfoerior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label labelNotificaciones;
        protected System.Windows.Forms.Panel panelNotificacionesSuperior;
        protected System.Windows.Forms.Panel panelAvisosInfoerior;
        protected System.Windows.Forms.Label labelAvisos;
        protected System.Windows.Forms.Button button1;
    }
}

