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
    public partial class Todo : Form
    {
        Conexion con = new Conexion();
        public Todo()
        {
            InitializeComponent();
            fillDGV();
        }
        private void fillDGV()
        {
            dgvTareas.Rows.Clear();
            foreach(DataRow fila in con.Tareas().Rows)
            {
                dgvTareas.Rows.Add(fila[0], fila[1], 
                    fila[2].ToString().Substring(0,10),
                    Properties.Resources.Listo, Properties.Resources.Delete);
            }
        }
        private void marcarTarea(int idTarea)
        {
            con.marcarTarea(idTarea);
            fillDGV();
        }
        private void borrarTarea(int idTarea)
        {
            con.borrarTarea(idTarea);
            fillDGV();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmInsert insert = new frmInsert();
            insert.ShowDialog();
            fillDGV();
        }

        private void dgvTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idTarea = int.Parse(dgvTareas.CurrentRow.Cells[0].Value.ToString());
            if (e.ColumnIndex == 3)
            {
                var result=MessageBox.Show("¿Marcar tarea como realizada?", "Tarea completa", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    marcarTarea(idTarea);
                }

            } else if (e.ColumnIndex == 4)
            {
                var result = MessageBox.Show("¿Desea cancelar la tarea", "Eliminar tarea",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    borrarTarea(idTarea);
                }
            }
        }

        private void dgvTareas_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex==4)
            {
                dgvTareas.Cursor = Cursors.Hand;

            }
            else
            {
                dgvTareas.Cursor = Cursors.Default;
            }
        }
    }
}
