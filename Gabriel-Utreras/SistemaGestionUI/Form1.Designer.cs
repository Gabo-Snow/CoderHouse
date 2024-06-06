namespace SistemaGestionUI
{
    partial class Form1
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
            dgvSistemaGestion = new DataGridView();
            btnAgregar = new Button();
            cmbSeleccionarListado = new ComboBox();
            label1 = new Label();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSistemaGestion).BeginInit();
            SuspendLayout();
            // 
            // dgvSistemaGestion
            // 
            dgvSistemaGestion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSistemaGestion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvSistemaGestion.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSistemaGestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSistemaGestion.Location = new Point(11, 144);
            dgvSistemaGestion.Name = "dgvSistemaGestion";
            dgvSistemaGestion.RowTemplate.Height = 25;
            dgvSistemaGestion.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSistemaGestion.Size = new Size(777, 294);
            dgvSistemaGestion.TabIndex = 0;
            dgvSistemaGestion.CellClick += dgvSistemaGestion_CellClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Montserrat Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Desktop;
            btnAgregar.Location = new Point(659, 77);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(129, 47);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbSeleccionarListado
            // 
            cmbSeleccionarListado.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSeleccionarListado.FormattingEnabled = true;
            cmbSeleccionarListado.Items.AddRange(new object[] { "Seleccione Un Listado", "Lista de Usuarios", "Lista de Productos", "Lista de Productos Vendidos", "Lista de Ventas" });
            cmbSeleccionarListado.Location = new Point(12, 94);
            cmbSeleccionarListado.Name = "cmbSeleccionarListado";
            cmbSeleccionarListado.Size = new Size(228, 26);
            cmbSeleccionarListado.TabIndex = 2;
            cmbSeleccionarListado.SelectedIndexChanged += cmbSeleccionarListado_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(224, 23);
            label1.Name = "label1";
            label1.Size = new Size(321, 44);
            label1.TabIndex = 3;
            label1.Text = "SISTEMA GESTIÓN";
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Montserrat Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = SystemColors.Desktop;
            btnActualizar.Location = new Point(498, 77);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(129, 47);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(label1);
            Controls.Add(cmbSeleccionarListado);
            Controls.Add(btnAgregar);
            Controls.Add(dgvSistemaGestion);
            Name = "Form1";
            Text = "Sistema Gestión";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSistemaGestion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSistemaGestion;
        private Button btnAgregar;
        private ComboBox cmbSeleccionarListado;
        private Label label1;
        private Button btnActualizar;
    }
}
