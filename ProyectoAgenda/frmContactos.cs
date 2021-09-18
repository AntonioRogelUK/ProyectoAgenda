using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAgenda
{
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();
        }

        private void btnProbarConn_Click(object sender, EventArgs e)
        {
            try
            {
                Contacto contacto = new Contacto();
                if (contacto.ProbarConexion())
                {
                    MessageBox.Show("Conexión exitosa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Contacto contacto = new Contacto();
                dtvContactos.DataSource = contacto.ObtenerContactos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
