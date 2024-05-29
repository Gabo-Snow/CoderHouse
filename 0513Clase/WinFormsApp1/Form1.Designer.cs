namespace WinFormsApp1
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
            label1 = new Label();
            listaRazasPerro = new ListBox();
            label2 = new Label();
            ListaPaisXCiudad = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 14);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 0;
            label1.Text = "Holi soy un label entero choro";
            label1.Click += label1_Click;
            // 
            // listaRazasPerro
            // 
            listaRazasPerro.FormattingEnabled = true;
            listaRazasPerro.ItemHeight = 15;
            listaRazasPerro.Location = new Point(31, 181);
            listaRazasPerro.Name = "listaRazasPerro";
            listaRazasPerro.Size = new Size(120, 94);
            listaRazasPerro.TabIndex = 1;
            listaRazasPerro.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 138);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Super Lista";
            label2.Click += label2_Click;
            // 
            // ListaPaisXCiudad
            // 
            ListaPaisXCiudad.FormattingEnabled = true;
            ListaPaisXCiudad.ItemHeight = 15;
            ListaPaisXCiudad.Location = new Point(312, 181);
            ListaPaisXCiudad.Name = "ListaPaisXCiudad";
            ListaPaisXCiudad.Size = new Size(231, 94);
            ListaPaisXCiudad.TabIndex = 3;
            ListaPaisXCiudad.SelectedIndexChanged += ListaPaisXCiudad_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 138);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "Super Lista 2";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(ListaPaisXCiudad);
            Controls.Add(label2);
            Controls.Add(listaRazasPerro);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listaRazasPerro;
        private Label label2;
        private ListBox ListaPaisXCiudad;
        private Label label3;
    }
}
