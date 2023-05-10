namespace CruaAppEmpresa
{
    partial class FormCompanyList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtFiltrar = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1341, 312);
            dataGridView1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(123, 399);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 36);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Añadir";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(273, 399);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(435, 399);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 36);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtFiltrar
            // 
            txtFiltrar.Location = new Point(897, 404);
            txtFiltrar.Name = "txtFiltrar";
            txtFiltrar.Size = new Size(149, 27);
            txtFiltrar.TabIndex = 4;
            txtFiltrar.KeyUp += txtFiltrar_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(756, 407);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 5;
            label1.Text = "Buscar Empresa";
            // 
            // FormCompanyList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 609);
            Controls.Add(label1);
            Controls.Add(txtFiltrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Name = "FormCompanyList";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtFiltrar;
        private Label label1;
    }
}