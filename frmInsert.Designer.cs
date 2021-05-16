
namespace Practica_5
{
    partial class frmInsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTarea = new Guna.UI2.WinForms.Guna2TextBox();
            this.dpFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // txtTarea
            // 
            this.txtTarea.BorderColor = System.Drawing.Color.Black;
            this.txtTarea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTarea.DefaultText = "";
            this.txtTarea.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTarea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTarea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTarea.DisabledState.Parent = this.txtTarea;
            this.txtTarea.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTarea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTarea.FocusedState.Parent = this.txtTarea;
            this.txtTarea.Font = new System.Drawing.Font("Arial", 13F);
            this.txtTarea.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTarea.HoverState.Parent = this.txtTarea;
            this.txtTarea.Location = new System.Drawing.Point(13, 36);
            this.txtTarea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.PasswordChar = '\0';
            this.txtTarea.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTarea.PlaceholderText = "Nombre de la tarea";
            this.txtTarea.SelectedText = "";
            this.txtTarea.ShadowDecoration.Parent = this.txtTarea;
            this.txtTarea.Size = new System.Drawing.Size(326, 34);
            this.txtTarea.TabIndex = 0;
            // 
            // dpFecha
            // 
            this.dpFecha.BorderThickness = 1;
            this.dpFecha.CheckedState.Parent = this.dpFecha;
            this.dpFecha.FillColor = System.Drawing.Color.White;
            this.dpFecha.Font = new System.Drawing.Font("Arial", 12F);
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFecha.HoverState.Parent = this.dpFecha;
            this.dpFecha.Location = new System.Drawing.Point(16, 95);
            this.dpFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.ShadowDecoration.Parent = this.dpFecha;
            this.dpFecha.Size = new System.Drawing.Size(150, 36);
            this.dpFecha.TabIndex = 1;
            this.dpFecha.Value = new System.DateTime(2021, 5, 16, 16, 33, 58, 471);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la tarea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha a cumplirse";
            // 
            // btnInsert
            // 
            this.btnInsert.CheckedState.Parent = this.btnInsert;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.CustomImages.Parent = this.btnInsert;
            this.btnInsert.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsert.Font = new System.Drawing.Font("Amaranth", 20F);
            this.btnInsert.ForeColor = System.Drawing.Color.Green;
            this.btnInsert.HoverState.Parent = this.btnInsert;
            this.btnInsert.Location = new System.Drawing.Point(226, 86);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnInsert.ShadowDecoration.Parent = this.btnInsert;
            this.btnInsert.Size = new System.Drawing.Size(45, 45);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "✔";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Font = new System.Drawing.Font("Amaranth", 20F);
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(294, 86);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(45, 45);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(357, 140);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.txtTarea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTarea;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton btnInsert;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
    }
}