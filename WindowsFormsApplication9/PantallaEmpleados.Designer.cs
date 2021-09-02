namespace WindowsFormsApplication9
{
    partial class PantallaEmpleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaEmpleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NombreEmpleado = new System.Windows.Forms.TextBox();
            this.ApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.SueldoEmpleado = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Departamento = new System.Windows.Forms.ComboBox();
            this.Femenino = new System.Windows.Forms.RadioButton();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.definitivo = new WindowsFormsApplication9.Definitivo();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new WindowsFormsApplication9.DefinitivoTableAdapters.EmpleadosTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication9.DefinitivoTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TelefonoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.CedulaEmpleado = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.definitivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "NOMBRE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 43;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(906, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(906, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(906, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "APELLIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(906, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "TELÉFONO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(906, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "CÉDULA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(906, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "DEPARTAMENTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(906, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "SEXO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(906, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "SUELDO";
            // 
            // NombreEmpleado
            // 
            this.NombreEmpleado.Location = new System.Drawing.Point(976, 120);
            this.NombreEmpleado.Name = "NombreEmpleado";
            this.NombreEmpleado.Size = new System.Drawing.Size(195, 20);
            this.NombreEmpleado.TabIndex = 53;
            this.NombreEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreEmpleado_KeyPress);
            // 
            // ApellidoEmpleado
            // 
            this.ApellidoEmpleado.Location = new System.Drawing.Point(976, 153);
            this.ApellidoEmpleado.Name = "ApellidoEmpleado";
            this.ApellidoEmpleado.Size = new System.Drawing.Size(195, 20);
            this.ApellidoEmpleado.TabIndex = 54;
            this.ApellidoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidoEmpleado_KeyPress);
            // 
            // SueldoEmpleado
            // 
            this.SueldoEmpleado.Location = new System.Drawing.Point(963, 320);
            this.SueldoEmpleado.Name = "SueldoEmpleado";
            this.SueldoEmpleado.Size = new System.Drawing.Size(208, 20);
            this.SueldoEmpleado.TabIndex = 59;
            this.SueldoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SueldoEmpleado_KeyPress);
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1023;
            this.lineShape1.X2 = 975;
            this.lineShape1.Y1 = 109;
            this.lineShape1.Y2 = 109;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1249, 465);
            this.shapeContainer1.TabIndex = 62;
            this.shapeContainer1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(155, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 37);
            this.button3.TabIndex = 63;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 37);
            this.button2.TabIndex = 64;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(909, 346);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(262, 33);
            this.button5.TabIndex = 65;
            this.button5.Text = "GUARDAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox7.Location = new System.Drawing.Point(976, 93);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(49, 13);
            this.textBox7.TabIndex = 66;
            // 
            // Departamento
            // 
            this.Departamento.FormattingEnabled = true;
            this.Departamento.Location = new System.Drawing.Point(1009, 261);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(162, 21);
            this.Departamento.TabIndex = 68;
            this.Departamento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.Departamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Departamento_KeyDown);
            this.Departamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Departamento_KeyPress);
            // 
            // Femenino
            // 
            this.Femenino.AutoSize = true;
            this.Femenino.Location = new System.Drawing.Point(1019, 293);
            this.Femenino.Name = "Femenino";
            this.Femenino.Size = new System.Drawing.Size(31, 17);
            this.Femenino.TabIndex = 70;
            this.Femenino.Text = "F";
            this.Femenino.UseVisualStyleBackColor = true;
            this.Femenino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Checked = true;
            this.Masculino.Location = new System.Drawing.Point(963, 293);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(34, 17);
            this.Masculino.TabIndex = 71;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "M";
            this.Masculino.UseVisualStyleBackColor = true;
            this.Masculino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // definitivo
            // 
            this.definitivo.DataSetName = "Definitivo";
            this.definitivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.definitivo;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BK_ClientesEliminadosTableAdapter = null;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.Detalle_CompraTableAdapter = null;
            this.tableAdapterManager.Detalle_FacturaTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = this.empleadosTableAdapter;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication9.DefinitivoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(874, 239);
            this.dataGridView1.TabIndex = 72;
            // 
            // TelefonoEmpleado
            // 
            this.TelefonoEmpleado.Location = new System.Drawing.Point(976, 193);
            this.TelefonoEmpleado.Mask = "(999)-000-0000";
            this.TelefonoEmpleado.Name = "TelefonoEmpleado";
            this.TelefonoEmpleado.Size = new System.Drawing.Size(195, 20);
            this.TelefonoEmpleado.TabIndex = 73;
            // 
            // CedulaEmpleado
            // 
            this.CedulaEmpleado.Location = new System.Drawing.Point(976, 226);
            this.CedulaEmpleado.MaxLength = 13;
            this.CedulaEmpleado.Name = "CedulaEmpleado";
            this.CedulaEmpleado.Size = new System.Drawing.Size(195, 20);
            this.CedulaEmpleado.TabIndex = 74;
            this.CedulaEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CedulaEmpleado_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(985, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(711, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 37);
            this.button1.TabIndex = 76;
            this.button1.Text = "DESHABILITADOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(571, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 37);
            this.button4.TabIndex = 77;
            this.button4.Text = "DEPARTAMENTOS";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(450, 346);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 39);
            this.button6.TabIndex = 80;
            this.button6.Text = "ACTUALIZAR";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // PantallaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 465);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CedulaEmpleado);
            this.Controls.Add(this.TelefonoEmpleado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Masculino);
            this.Controls.Add(this.Femenino);
            this.Controls.Add(this.Departamento);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SueldoEmpleado);
            this.Controls.Add(this.ApellidoEmpleado);
            this.Controls.Add(this.NombreEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaEmpleados";
            this.Text = "PantallaClientes";
            this.Load += new System.EventHandler(this.PantallaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.definitivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NombreEmpleado;
        private System.Windows.Forms.TextBox ApellidoEmpleado;
        private System.Windows.Forms.TextBox SueldoEmpleado;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox Departamento;
        private System.Windows.Forms.RadioButton Femenino;
        private System.Windows.Forms.RadioButton Masculino;
        private Definitivo definitivo;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private DefinitivoTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private DefinitivoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox TelefonoEmpleado;
        private System.Windows.Forms.TextBox CedulaEmpleado;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
    }
}