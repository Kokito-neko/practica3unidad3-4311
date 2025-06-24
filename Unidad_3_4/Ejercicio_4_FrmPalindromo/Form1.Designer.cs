namespace Ejercicio_4_FrmPalindromo
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
            txtPalabra = new TextBox();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 104);
            label1.Name = "label1";
            label1.Size = new Size(229, 33);
            label1.TabIndex = 0;
            label1.Text = "Ingresa una palabra";
            // 
            // txtPalabra
            // 
            txtPalabra.BackColor = Color.LightCyan;
            txtPalabra.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPalabra.Location = new Point(280, 242);
            txtPalabra.Multiline = true;
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(207, 45);
            txtPalabra.TabIndex = 1;
            txtPalabra.TextAlign = HorizontalAlignment.Center;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.SpringGreen;
            btnVerificar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.Location = new Point(329, 174);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(112, 34);
            btnVerificar.TabIndex = 2;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerificar);
            Controls.Add(txtPalabra);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPalabra;
        private Button btnVerificar;
    }
}
