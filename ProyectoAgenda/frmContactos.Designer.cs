
namespace ProyectoAgenda
{
    partial class frmContactos
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
            this.dtvContactos = new System.Windows.Forms.DataGridView();
            this.btnProbarConn = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnConsultaInactivos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvContactos
            // 
            this.dtvContactos.AllowUserToAddRows = false;
            this.dtvContactos.AllowUserToDeleteRows = false;
            this.dtvContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvContactos.Location = new System.Drawing.Point(12, 76);
            this.dtvContactos.Name = "dtvContactos";
            this.dtvContactos.ReadOnly = true;
            this.dtvContactos.Size = new System.Drawing.Size(732, 315);
            this.dtvContactos.TabIndex = 0;
            // 
            // btnProbarConn
            // 
            this.btnProbarConn.Location = new System.Drawing.Point(12, 47);
            this.btnProbarConn.Name = "btnProbarConn";
            this.btnProbarConn.Size = new System.Drawing.Size(126, 23);
            this.btnProbarConn.TabIndex = 1;
            this.btnProbarConn.Text = "Prueba conexión";
            this.btnProbarConn.UseVisualStyleBackColor = true;
            this.btnProbarConn.Click += new System.EventHandler(this.btnProbarConn_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(459, 47);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(117, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnConsultaInactivos
            // 
            this.btnConsultaInactivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultaInactivos.Location = new System.Drawing.Point(624, 397);
            this.btnConsultaInactivos.Name = "btnConsultaInactivos";
            this.btnConsultaInactivos.Size = new System.Drawing.Size(120, 23);
            this.btnConsultaInactivos.TabIndex = 3;
            this.btnConsultaInactivos.Text = "Consultar inactivos";
            this.btnConsultaInactivos.UseVisualStyleBackColor = true;
            this.btnConsultaInactivos.Click += new System.EventHandler(this.btnConsultaInactivos_Click);
            // 
            // frmContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Controls.Add(this.btnConsultaInactivos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnProbarConn);
            this.Controls.Add(this.dtvContactos);
            this.Name = "frmContactos";
            this.Text = "Contactos";
            ((System.ComponentModel.ISupportInitialize)(this.dtvContactos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvContactos;
        private System.Windows.Forms.Button btnProbarConn;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnConsultaInactivos;
    }
}

