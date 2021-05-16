
namespace Practica_5
{
    partial class Todo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uI_TitleBanner1 = new UIDC.UI_TitleBanner();
            this.dgvTareas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lista = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cancelar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNew = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // uI_TitleBanner1
            // 
            this.uI_TitleBanner1.Animate = UIDC.UI_TitleBanner.Anim.AnimateON;
            this.uI_TitleBanner1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.uI_TitleBanner1.ButtonMenuActive = UIDC.UI_TitleBanner.Active.ActiveOff;
            this.uI_TitleBanner1.ButtonsVisible = UIDC.UI_TitleBanner.ButtonVisible.Close_Minimize;
            this.uI_TitleBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uI_TitleBanner1.FlatAppearance.BorderSize = 0;
            this.uI_TitleBanner1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.uI_TitleBanner1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.uI_TitleBanner1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uI_TitleBanner1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.uI_TitleBanner1.ForeColor = System.Drawing.Color.White;
            this.uI_TitleBanner1.Location = new System.Drawing.Point(0, 0);
            this.uI_TitleBanner1.MoveActive = true;
            this.uI_TitleBanner1.Name = "uI_TitleBanner1";
            this.uI_TitleBanner1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uI_TitleBanner1.ParentControl = this;
            this.uI_TitleBanner1.Size = new System.Drawing.Size(564, 30);
            this.uI_TitleBanner1.TabIndex = 1;
            this.uI_TitleBanner1.Text = "TodoManager";
            this.uI_TitleBanner1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.uI_TitleBanner1.TypeWindows = UIDC.UI_TitleBanner.TypeTheme.Windows;
            this.uI_TitleBanner1.UseVisualStyleBackColor = false;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvTareas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTareas.ColumnHeadersHeight = 22;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTarea,
            this.Tarea,
            this.Fecha,
            this.Lista,
            this.Cancelar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTareas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTareas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTareas.EnableHeadersVisualStyles = false;
            this.dgvTareas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvTareas.Location = new System.Drawing.Point(0, 80);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTareas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(564, 370);
            this.dgvTareas.TabIndex = 2;
            this.dgvTareas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgvTareas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvTareas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTareas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTareas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTareas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTareas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTareas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvTareas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvTareas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTareas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTareas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTareas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTareas.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvTareas.ThemeStyle.ReadOnly = true;
            this.dgvTareas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvTareas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTareas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTareas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTareas.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTareas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvTareas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellContentClick);
            this.dgvTareas.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellMouseEnter);
            // 
            // idTarea
            // 
            this.idTarea.HeaderText = "idTarea";
            this.idTarea.Name = "idTarea";
            this.idTarea.ReadOnly = true;
            this.idTarea.Visible = false;
            // 
            // Tarea
            // 
            this.Tarea.HeaderText = "Tarea";
            this.Tarea.Name = "Tarea";
            this.Tarea.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Lista
            // 
            this.Lista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Lista.HeaderText = "";
            this.Lista.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Lista.Name = "Lista";
            this.Lista.ReadOnly = true;
            this.Lista.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista.ToolTipText = "Lista";
            this.Lista.Width = 23;
            // 
            // Cancelar
            // 
            this.Cancelar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cancelar.HeaderText = "";
            this.Cancelar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.ReadOnly = true;
            this.Cancelar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cancelar.ToolTipText = "Cancelar";
            this.Cancelar.Width = 23;
            // 
            // btnNew
            // 
            this.btnNew.CheckedState.Parent = this.btnNew;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.CustomImages.Parent = this.btnNew;
            this.btnNew.Font = new System.Drawing.Font("Amaranth", 20F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.HoverState.Parent = this.btnNew;
            this.btnNew.Location = new System.Drawing.Point(522, 44);
            this.btnNew.Name = "btnNew";
            this.btnNew.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNew.ShadowDecoration.Parent = this.btnNew;
            this.btnNew.Size = new System.Drawing.Size(30, 30);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "+";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.uI_TitleBanner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Todo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodoManager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UIDC.UI_TitleBanner uI_TitleBanner1;
        private Guna.UI2.WinForms.Guna2CircleButton btnNew;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewImageColumn Lista;
        private System.Windows.Forms.DataGridViewImageColumn Cancelar;
    }
}

