namespace TareaUsuario
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
            components = new System.ComponentModel.Container();
            usuarioBindingSource = new BindingSource(components);
            dgvListaUsuario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuario).BeginInit();
            SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Usuario);
            // 
            // dgvListaUsuario
            // 
            dgvListaUsuario.AllowUserToOrderColumns = true;
            dgvListaUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaUsuario.Location = new Point(48, 48);
            dgvListaUsuario.Name = "dgvListaUsuario";
            dgvListaUsuario.RowTemplate.Height = 25;
            dgvListaUsuario.Size = new Size(691, 362);
            dgvListaUsuario.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListaUsuario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource usuarioBindingSource;
        private DataGridView dgvListaUsuario;
    }
}
