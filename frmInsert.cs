using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
   
    public partial class frmInsert : Form
    {
        Conexion con = new Conexion();
        public frmInsert()
        {
            InitializeComponent();
        }
        private void Insertar()
        {
            if (!string.IsNullOrEmpty(txtTarea.Text))
            {
                string tarea = txtTarea.Text;
                DateTime fecha = dpFecha.Value;
                
                con.insertTarea(tarea, fecha);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe completar los datos");
            }
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insertar();
        }
    }
}
