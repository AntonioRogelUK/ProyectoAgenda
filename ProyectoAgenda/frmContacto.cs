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
    public partial class frmContacto : Form
    {
        public frmContacto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Contacto contacto = new Contacto();
                contacto.Nombre = txtNombre.Text;
                contacto.FechaNacimiento = dtpFechaNacimiento.Value;
                contacto.Email = txtEmail.Text;
                contacto.TelefonoParticular = txtTelefonoParticular.Text;
                contacto.TelefonoCelular = txtTelefonoCelular.Text;

                contacto.AgregarContacto(contacto);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
