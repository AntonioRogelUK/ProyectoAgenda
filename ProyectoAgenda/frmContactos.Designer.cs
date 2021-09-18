
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContactoNuevo = new System.Windows.Forms.Button();
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
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(627, 47);
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(228, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(383, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // btnContactoNuevo
            // 
            this.btnContactoNuevo.Location = new System.Drawing.Point(627, 12);
            this.btnContactoNuevo.Name = "btnContactoNuevo";
            this.btnContactoNuevo.Size = new System.Drawing.Size(117, 23);
            this.btnContactoNuevo.TabIndex = 6;
            this.btnContactoNuevo.Text = "Agregar contacto";
            this.btnContactoNuevo.UseVisualStyleBackColor = true;
            // 
            // frmContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Controls.Add(this.btnContactoNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnConsultaInactivos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnProbarConn);
            this.Controls.Add(this.dtvContactos);
            this.Name = "frmContactos";
            this.Text = "Contactos";
            ((System.ComponentModel.ISupportInitialize)(this.dtvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvContactos;
        private System.Windows.Forms.Button btnProbarConn;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnConsultaInactivos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContactoNuevo;
    }
}

