namespace SistemaGestionUI
{
    partial class FormUsuario
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
            txtEmail = new TextBox();
            txtContrasena = new TextBox();
            txtNombreUsuario = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(187, 336);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 23);
            txtEmail.TabIndex = 31;
            // 
            // txtContrasena
            // 
            txtContrasena.Cursor = Cursors.IBeam;
            txtContrasena.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena.Location = new Point(187, 285);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(237, 23);
            txtContrasena.TabIndex = 30;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Cursor = Cursors.IBeam;
            txtNombreUsuario.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreUsuario.Location = new Point(187, 234);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(237, 23);
            txtNombreUsuario.TabIndex = 29;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(187, 183);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(237, 23);
            txtApellido.TabIndex = 28;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(187, 132);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(237, 23);
            txtNombre.TabIndex = 27;
            // 
            // txtID
            // 
            txtID.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(187, 81);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(237, 23);
            txtID.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(25, 335);
            label7.Name = "label7";
            label7.Size = new Size(58, 22);
            label7.TabIndex = 25;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(25, 284);
            label6.Name = "label6";
            label6.Size = new Size(105, 22);
            label6.TabIndex = 24;
            label6.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 233);
            label5.Name = "label5";
            label5.Size = new Size(146, 22);
            label5.TabIndex = 23;
            label5.Text = "Nombre Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 182);
            label4.Name = "label4";
            label4.Size = new Size(79, 22);
            label4.TabIndex = 22;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 131);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 21;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 80);
            label2.Name = "label2";
            label2.Size = new Size(28, 22);
            label2.TabIndex = 20;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 33);
            label1.TabIndex = 19;
            label1.Text = "USUARIO";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(25, 397);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 43);
            btnVolver.TabIndex = 18;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(187, 397);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 43);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(327, 397);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 43);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 450);
            Controls.Add(txtEmail);
            Controls.Add(txtContrasena);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Name = "FormUsuario";
            Text = "FormUsuario";
            Load += FormUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtContrasena;
        private TextBox txtNombreUsuario;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnGuardar;
    }
}