namespace prySotoEtapa2
{
    partial class frmEtapa2
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
            this.btnCrearVehiculos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearVehiculos
            // 
            this.btnCrearVehiculos.Location = new System.Drawing.Point(189, 571);
            this.btnCrearVehiculos.Name = "btnCrearVehiculos";
            this.btnCrearVehiculos.Size = new System.Drawing.Size(251, 66);
            this.btnCrearVehiculos.TabIndex = 0;
            this.btnCrearVehiculos.Text = "CREAR";
            this.btnCrearVehiculos.UseVisualStyleBackColor = true;
            this.btnCrearVehiculos.Click += new System.EventHandler(this.btnCrearVehiculos_Click);
            // 
            // frmEtapa2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prySotoEtapa2.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 649);
            this.Controls.Add(this.btnCrearVehiculos);
            this.Name = "frmEtapa2";
            this.Text = "Etapa 2 : Crer Objetos de un Boton";
            this.Load += new System.EventHandler(this.frmEtapa2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearVehiculos;
    }
}

