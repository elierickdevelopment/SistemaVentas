namespace SistemaVentas
{
    partial class Form_Proveedores
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
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Cotacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Actualizar = new System.Windows.Forms.Button();
            this.button_Editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(106, 36);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(171, 20);
            this.textBox_Nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contacto";
            // 
            // textBox_Cotacto
            // 
            this.textBox_Cotacto.Location = new System.Drawing.Point(106, 62);
            this.textBox_Cotacto.Name = "textBox_Cotacto";
            this.textBox_Cotacto.Size = new System.Drawing.Size(171, 20);
            this.textBox_Cotacto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(106, 88);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(171, 20);
            this.textBox_Direccion.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(106, 140);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(171, 20);
            this.textBox_Email.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefono";
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(106, 114);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(171, 20);
            this.textBox_Telefono.TabIndex = 6;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(324, 166);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(132, 41);
            this.button_Guardar.TabIndex = 10;
            this.button_Guardar.Text = "Guardar Nuevo";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(590, 169);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(462, 165);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(140, 42);
            this.button_Eliminar.TabIndex = 12;
            this.button_Eliminar.Text = "ELIMINAR";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // button_Actualizar
            // 
            this.button_Actualizar.Location = new System.Drawing.Point(186, 166);
            this.button_Actualizar.Name = "button_Actualizar";
            this.button_Actualizar.Size = new System.Drawing.Size(132, 41);
            this.button_Actualizar.TabIndex = 13;
            this.button_Actualizar.Text = "Actualizar";
            this.button_Actualizar.UseVisualStyleBackColor = true;
            this.button_Actualizar.Click += new System.EventHandler(this.button_Actualizar_Click);
            // 
            // button_Editar
            // 
            this.button_Editar.Location = new System.Drawing.Point(40, 166);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(140, 42);
            this.button_Editar.TabIndex = 14;
            this.button_Editar.Text = "EDITAR";
            this.button_Editar.UseVisualStyleBackColor = true;
            this.button_Editar.Click += new System.EventHandler(this.button_Editar_Click);
            // 
            // Form_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 404);
            this.Controls.Add(this.button_Editar);
            this.Controls.Add(this.button_Actualizar);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Telefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Direccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Cotacto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nombre);
            this.Name = "Form_Proveedores";
            this.Text = "Form_Proveedores";
            this.Load += new System.EventHandler(this.Form_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Cotacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Button button_Actualizar;
        private System.Windows.Forms.Button button_Editar;
    }
}