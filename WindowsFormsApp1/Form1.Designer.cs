
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fecNac = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.departamento = new System.Windows.Forms.ComboBox();
            this.cargo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.foto = new System.Windows.Forms.PictureBox();
            this.agregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.Hcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hdni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hapellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hdireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Htelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HfecNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hdepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(109, 76);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(136, 20);
            this.nombre.TabIndex = 1;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(109, 107);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(298, 20);
            this.apellido.TabIndex = 1;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(109, 164);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 1;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(109, 138);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(298, 20);
            this.direccion.TabIndex = 1;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(109, 192);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(298, 20);
            this.email.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dirección:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(26, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefono:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(26, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha Nac:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fecNac
            // 
            this.fecNac.FormattingEnabled = true;
            this.fecNac.Location = new System.Drawing.Point(109, 218);
            this.fecNac.Name = "fecNac";
            this.fecNac.Size = new System.Drawing.Size(189, 21);
            this.fecNac.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(329, 220);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(293, 76);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(114, 20);
            this.dni.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dni:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Departamento";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cargo";
            // 
            // departamento
            // 
            this.departamento.FormattingEnabled = true;
            this.departamento.Location = new System.Drawing.Point(547, 44);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(189, 21);
            this.departamento.TabIndex = 2;
            this.departamento.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cargo
            // 
            this.cargo.FormattingEnabled = true;
            this.cargo.Location = new System.Drawing.Point(547, 75);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(189, 21);
            this.cargo.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(485, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Fotografía";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // foto
            // 
            this.foto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("foto.BackgroundImage")));
            this.foto.Location = new System.Drawing.Point(595, 110);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(141, 129);
            this.foto.TabIndex = 6;
            this.foto.TabStop = false;
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.agregar.FlatAppearance.BorderSize = 0;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.ForeColor = System.Drawing.Color.White;
            this.agregar.Location = new System.Drawing.Point(406, 264);
            this.agregar.Margin = new System.Windows.Forms.Padding(0);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 7;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(488, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(579, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(665, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // grid1
            // 
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hcodigo,
            this.Hdni,
            this.Hnombre,
            this.Hapellidos,
            this.Hdireccion,
            this.Htelefono,
            this.Hemail,
            this.HfecNac,
            this.Hdepartamento});
            this.grid1.Location = new System.Drawing.Point(29, 308);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(876, 182);
            this.grid1.TabIndex = 9;
            this.grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(26, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Código:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(106, 51);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(45, 13);
            this.codigo.TabIndex = 11;
            this.codigo.TabStop = true;
            this.codigo.Text = "U10023";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 213);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Datos Personales";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(458, 32);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(297, 217);
            this.flowLayoutPanel2.TabIndex = 12;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(473, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Información Personal";
            // 
            // Hcodigo
            // 
            this.Hcodigo.HeaderText = "Codigo";
            this.Hcodigo.Name = "Hcodigo";
            // 
            // Hdni
            // 
            this.Hdni.HeaderText = "Dni";
            this.Hdni.Name = "Hdni";
            // 
            // Hnombre
            // 
            this.Hnombre.HeaderText = "Nombre";
            this.Hnombre.Name = "Hnombre";
            // 
            // Hapellidos
            // 
            this.Hapellidos.HeaderText = "Apellidos";
            this.Hapellidos.Name = "Hapellidos";
            // 
            // Hdireccion
            // 
            this.Hdireccion.HeaderText = "Dirección";
            this.Hdireccion.Name = "Hdireccion";
            // 
            // Htelefono
            // 
            this.Htelefono.HeaderText = "Teléfono";
            this.Htelefono.Name = "Htelefono";
            // 
            // Hemail
            // 
            this.Hemail.HeaderText = "Email";
            this.Hemail.Name = "Hemail";
            // 
            // HfecNac
            // 
            this.HfecNac.HeaderText = "Fec/Nac";
            this.HfecNac.Name = "HfecNac";
            // 
            // Hdepartamento
            // 
            this.Hdepartamento.HeaderText = "Departamento";
            this.Hdepartamento.Name = "Hdepartamento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 502);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cargo);
            this.Controls.Add(this.departamento);
            this.Controls.Add(this.fecNac);
            this.Controls.Add(this.email);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Titulo 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fecNac;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox departamento;
        private System.Windows.Forms.ComboBox cargo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel codigo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hdni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hapellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hdireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Htelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn HfecNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hdepartamento;
    }
}

