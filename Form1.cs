using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrir formulario:
            Form_Proveedores form = new Form_Proveedores();
            form.Show();
        }

        private void cREARNUEVAVENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
