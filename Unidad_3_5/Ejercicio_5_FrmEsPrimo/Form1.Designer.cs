namespace Ejercicio_5_FrmEsPrimo
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
            mtbNumero = new MaskedTextBox();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 97);
            label1.Name = "label1";
            label1.Size = new Size(219, 33);
            label1.TabIndex = 0;
            label1.Text = "Ingresa un número";
            // 
            // mtbNumero
            // 
            mtbNumero.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbNumero.Location = new Point(337, 161);
            mtbNumero.Mask = "00000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(43, 40);
            mtbNumero.TabIndex = 2;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.Lime;
            btnVerificar.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificar.Location = new Point(235, 229);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(261, 47);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "Verificar si es primo";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerificar);
            Controls.Add(mtbNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox mtbNumero;
        private Button btnVerificar;
    }
}
