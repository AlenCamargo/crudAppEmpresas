namespace CrudAppEmpresa
{
    partial class frmEditor
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
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            txtDireccion = new TextBox();
            txtCiudad = new TextBox();
            txtDepartamento = new TextBox();
            txtPais = new TextBox();
            txtTelefono = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label9 = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(426, 110);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(668, 106);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(125, 27);
            txtDireccion.TabIndex = 2;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(879, 106);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(125, 27);
            txtCiudad.TabIndex = 3;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(266, 219);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(125, 27);
            txtDepartamento.TabIndex = 4;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(499, 219);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(125, 27);
            txtPais.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(717, 218);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 116);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 113);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 9;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(590, 113);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 10;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(817, 109);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 11;
            label4.Text = "Ciudad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 222);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 12;
            label5.Text = "Departamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(459, 222);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 13;
            label6.Text = "Pais";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(644, 221);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 14;
            label7.Text = "Telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(793, 229);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(333, 384);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 58);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(553, 384);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 58);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(443, 41);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 18;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(386, 41);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(92, 37);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Titulo ";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 510);
            Controls.Add(lblTitulo);
            Controls.Add(label9);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(txtPais);
            Controls.Add(txtDepartamento);
            Controls.Add(txtCiudad);
            Controls.Add(txtDireccion);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombre);
            Name = "frmEditor";
            Text = "FormCompanyEditor";
            Load += frmEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtNombre;
        private Button btnGuardar;
        private Button btnCancelar;
        public Label lblTitulo;
        public TextBox txtCodigo;
        public TextBox txtDireccion;
        public TextBox txtCiudad;
        public TextBox txtDepartamento;
        public TextBox txtPais;
        public TextBox txtTelefono;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public Label label7;
        public Label label8;
        public Label label9;
    }
}