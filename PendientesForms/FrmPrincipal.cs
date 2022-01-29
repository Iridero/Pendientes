using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pendientes.Negocios;

namespace Pendientes.InterfazWindows
{
    public partial class FrmPrincipal : Form
    {
        ListaDePendientes pendientes;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            pendientes = new ListaDePendientes();
            ActualizarListBox();
        }
        private void ActualizarListBox()
        {
            lstPendientes.DataSource = null;
            lstPendientes.DataSource = pendientes.Lista;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                pendientes.Agregar(txtTarea.Text);
                ActualizarListBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
