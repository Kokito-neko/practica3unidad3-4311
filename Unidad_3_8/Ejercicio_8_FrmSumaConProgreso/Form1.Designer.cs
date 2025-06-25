namespace Ejercicio_8_FrmSumaConProgreso
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
            btnSumar = new Button();
            label1 = new Label();
            lblResultado = new Label();
            txtMaximo = new TextBox();
            prgSuma = new ProgressBar();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.BackColor = Color.DeepSkyBlue;
            btnSumar.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSumar.Location = new Point(243, 207);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(112, 46);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += btnSumar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 129);
            label1.Name = "label1";
            label1.Size = new Size(291, 33);
            label1.TabIndex = 1;
            label1.Text = "Número máximo a sumar";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(54, 278);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(127, 33);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado";
            // 
            // txtMaximo
            // 
            txtMaximo.BackColor = SystemColors.Info;
            txtMaximo.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaximo.Location = new Point(409, 129);
            txtMaximo.Name = "txtMaximo";
            txtMaximo.Size = new Size(87, 40);
            txtMaximo.TabIndex = 3;
            // 
            // prgSuma
            // 
            prgSuma.Location = new Point(418, 278);
            prgSuma.Name = "prgSuma";
            prgSuma.Size = new Size(217, 34);
            prgSuma.TabIndex = 4;
            prgSuma.Value = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(662, 450);
            Controls.Add(prgSuma);
            Controls.Add(txtMaximo);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(btnSumar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Label label1;
        private Label lblResultado;
        private TextBox txtMaximo;
        private ProgressBar prgSuma;
    }
}
