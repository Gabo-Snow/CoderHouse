namespace SistemaGestionUI
{
    partial class FormVenta
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
            txtIdUsuario = new TextBox();
            txtComentarios = new TextBox();
            txtID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Cursor = Cursors.IBeam;
            txtIdUsuario.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdUsuario.Location = new Point(187, 184);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(237, 23);
            txtIdUsuario.TabIndex = 44;
            txtIdUsuario.KeyPress += txtIdUsuario_KeyPress;
            // 
            // txtComentarios
            // 
            txtComentarios.Cursor = Cursors.IBeam;
            txtComentarios.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtComentarios.Location = new Point(187, 133);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(237, 23);
            txtComentarios.TabIndex = 43;
            // 
            // txtID
            // 
            txtID.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(187, 82);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(237, 23);
            txtID.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 183);
            label4.Name = "label4";
            label4.Size = new Size(96, 22);
            label4.TabIndex = 38;
            label4.Text = "ID Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 132);
            label3.Name = "label3";
            label3.Size = new Size(117, 22);
            label3.TabIndex = 37;
            label3.Text = "Comentarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 81);
            label2.Name = "label2";
            label2.Size = new Size(28, 22);
            label2.TabIndex = 36;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 35;
            label1.Text = "VENTA";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(25, 245);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 43);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(187, 245);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 43);
            btnEliminar.TabIndex = 33;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(327, 245);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 43);
            btnGuardar.TabIndex = 32;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 313);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Name = "FormVenta";
            Text = "FormVenta";
            Load += FormVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIdUsuario;
        private TextBox txtComentarios;
        private TextBox txtID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnGuardar;
    }
}