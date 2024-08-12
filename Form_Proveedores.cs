using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaVentas
{
    public partial class Form_Proveedores : Form
    {
        metodos_negocio negocio = new metodos_negocio();
        public Form_Proveedores()
        {
            InitializeComponent();
        }
        private void Form_Proveedores_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        public void CargarGrid()
        {
            DataSet dataSet = new DataSet();
            
            DataSet ds = new DataSet();
            string query = "SELECT Nombre, Contacto, Direccion, Telefono, Email FROM dbo.Proveedores";
            if(negocio.ObtenerDatos(query, ref ds)){
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            string nombre = textBox_Nombre.Text;
            string contacto = textBox_Cotacto.Text;
            string direccion = textBox_Direccion.Text;
            string telefono = textBox_Telefono.Text;
            string email = textBox_Email.Text;

            //string query = "INSERT INTO [dbo].[Proveedores]([Nombre],[Contacto],[Direccion],[Telefono],[Email]) VALUES ('" + nombre + "','" + contacto + "', '" + direccion + "','" + telefono + "','" + email + "')";
            string query = "EXECUTE dbo.sp_GuardarProveedor 1, '" + nombre + "','" + contacto + "','" + direccion + "','" + telefono + "','" + email + "'";
            //negocio.EjecutarQuery(query);
            DataSet ds = new DataSet();
            if(negocio.ObtenerDatos(query, ref ds)==true)
            {
                CargarGrid();
                MessageBox.Show(ds.Tables[0].Rows[0]["mensaje"].ToString());
            }
            
            //MessageBox.Show("Proveedor guardado correctamente");
            

        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {

            
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
            int columnIndex = 0; 
            // Columna deseada

            object cellValue = dataGridView1.Rows[selectedRowIndex].Cells[columnIndex].Value;

            string Nombre = cellValue?.ToString();

            string query = "EXECUTE dbo.sp_EliminarProveedor '" + Nombre + "'";
            DataSet ds = new DataSet();
            if (negocio.ObtenerDatos(query, ref ds) == true)
            {
                CargarGrid();
                MessageBox.Show(ds.Tables[0].Rows[0]["mensaje"].ToString());
            }

            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Actualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBox_Nombre.Text;
            string contacto = textBox_Cotacto.Text;
            string direccion = textBox_Direccion.Text;
            string telefono = textBox_Telefono.Text;
            string email = textBox_Email.Text;

            string query = "EXECUTE dbo.sp_GuardarProveedor 2, '" + nombre + "','" + contacto + "','" + direccion + "','" + telefono + "','" + email + "'";
            DataSet ds = new DataSet();
            if (negocio.ObtenerDatos(query, ref ds) == true)
            {
                textBox_Nombre.Text = "";
                textBox_Cotacto.Text ="";
                textBox_Direccion.Text ="";
                textBox_Telefono.Text ="";
                textBox_Email.Text = "";
                CargarGrid();
                MessageBox.Show(ds.Tables[0].Rows[0]["mensaje"].ToString());
            }

        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            //cargar datos para editar:
            if (dataGridView1.SelectedRows[0].Index >= 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int columnIndex = 0; // Columna deseada
                object cellValue = dataGridView1.Rows[selectedRowIndex].Cells[columnIndex].Value;
                string Nombre = cellValue?.ToString();

                string query = "SELECT [ProveedorID],[Nombre] ,[Contacto] ,[Direccion] ,[Telefono] ,[Email] FROM [dbo].[Proveedores] where Nombre = '" + Nombre + "'";

                DataSet ds = new DataSet();
                if (negocio.ObtenerDatos(query, ref ds) == true)
                {
                    textBox_Nombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
                    textBox_Cotacto.Text = ds.Tables[0].Rows[0]["Contacto"].ToString();
                    textBox_Direccion.Text = ds.Tables[0].Rows[0]["Direccion"].ToString();
                    textBox_Telefono.Text = ds.Tables[0].Rows[0]["Telefono"].ToString();
                    textBox_Email.Text = ds.Tables[0].Rows[0]["Email"].ToString();

                }
            }
        }
    }
}
