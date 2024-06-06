namespace SistemaGestionUI
{
    partial class FormProductoVendido
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
            txtIdVenta = new TextBox();
            txtStock = new TextBox();
            txtIdProducto = new TextBox();
            txtID = new TextBox();
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
            // txtIdVenta
            // 
            txtIdVenta.Cursor = Cursors.IBeam;
            txtIdVenta.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdVenta.Location = new Point(187, 234);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(237, 23);
            txtIdVenta.TabIndex = 29;
            txtIdVenta.KeyPress += txtIdVenta_KeyPress;
            // 
            // txtStock
            // 
            txtStock.Cursor = Cursors.IBeam;
            txtStock.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(187, 183);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(237, 23);
            txtStock.TabIndex = 28;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Cursor = Cursors.IBeam;
            txtIdProducto.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdProducto.Location = new Point(187, 132);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(237, 23);
            txtIdProducto.TabIndex = 27;
            txtIdProducto.KeyPress += txtIdProducto_KeyPress;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(25, 233);
            label5.Name = "label5";
            label5.Size = new Size(81, 22);
            label5.TabIndex = 23;
            label5.Text = "ID Venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 182);
            label4.Name = "label4";
            label4.Size = new Size(56, 22);
            label4.TabIndex = 22;
            label4.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 131);
            label3.Name = "label3";
            label3.Size = new Size(109, 22);
            label3.TabIndex = 21;
            label3.Text = "ID Producto";
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
            label1.Location = new Point(84, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 33);
            label1.TabIndex = 19;
            label1.Text = "PRODUCTO VENDIDO";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Montserrat Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(25, 288);
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
            btnEliminar.Location = new Point(187, 288);
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
            btnGuardar.Location = new Point(327, 288);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 43);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 350);
            Controls.Add(txtIdVenta);
            Controls.Add(txtStock);
            Controls.Add(txtIdProducto);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Name = "FormProductoVendido";
            Text = "FormProductoVenta";
            Load += FormProductoVendido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIdVenta;
        private TextBox txtStock;
        private TextBox txtIdProducto;
        private TextBox txtID;
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