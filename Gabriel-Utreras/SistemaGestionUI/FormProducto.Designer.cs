namespace SistemaGestionUI
{
    partial class FormProducto
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
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            txtDescripcion = new TextBox();
            txtCosto = new TextBox();
            txtPrecioVenta = new TextBox();
            txtStock = new TextBox();
            txtIdUsuario = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(326, 395);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 43);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(186, 395);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 43);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(24, 395);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 43);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(145, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 33);
            label1.TabIndex = 3;
            label1.Text = "PRODUCTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 78);
            label2.Name = "label2";
            label2.Size = new Size(28, 22);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 129);
            label3.Name = "label3";
            label3.Size = new Size(108, 22);
            label3.TabIndex = 5;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 180);
            label4.Name = "label4";
            label4.Size = new Size(57, 22);
            label4.TabIndex = 6;
            label4.Text = "Costo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 231);
            label5.Name = "label5";
            label5.Size = new Size(116, 22);
            label5.TabIndex = 7;
            label5.Text = "Precio Venta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 282);
            label6.Name = "label6";
            label6.Size = new Size(56, 22);
            label6.TabIndex = 8;
            label6.Text = "Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(24, 333);
            label7.Name = "label7";
            label7.Size = new Size(96, 22);
            label7.TabIndex = 9;
            label7.Text = "ID Usuario";
            // 
            // txtID
            // 
            txtID.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(186, 79);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(237, 23);
            txtID.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Cursor = Cursors.IBeam;
            txtDescripcion.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(186, 130);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(237, 23);
            txtDescripcion.TabIndex = 11;
            // 
            // txtCosto
            // 
            txtCosto.Cursor = Cursors.IBeam;
            txtCosto.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtCosto.Location = new Point(186, 181);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(237, 23);
            txtCosto.TabIndex = 12;
            txtCosto.KeyPress += txtCosto_KeyPress;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Cursor = Cursors.IBeam;
            txtPrecioVenta.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioVenta.Location = new Point(186, 232);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(237, 23);
            txtPrecioVenta.TabIndex = 13;
            txtPrecioVenta.KeyPress += txtPrecioVenta_KeyPress;
            // 
            // txtStock
            // 
            txtStock.Cursor = Cursors.IBeam;
            txtStock.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(186, 283);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(237, 23);
            txtStock.TabIndex = 14;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Cursor = Cursors.IBeam;
            txtIdUsuario.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdUsuario.Location = new Point(186, 334);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(237, 23);
            txtIdUsuario.TabIndex = 15;
            txtIdUsuario.KeyPress += txtIdUsuario_KeyPress;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 450);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripcion);
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
            Name = "FormProducto";
            Text = "Producto";
            Load += FormProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnVolver;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtID;
        private TextBox txtDescripcion;
        private TextBox txtCosto;
        private TextBox txtPrecioVenta;
        private TextBox txtStock;
        private TextBox txtIdUsuario;
    }
}