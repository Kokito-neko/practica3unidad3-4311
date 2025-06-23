namespace Ejercicio_1_FrmTablaMultiplicar
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
            btnGenerar = new Button();
            label1 = new Label();
            txtNumero = new TextBox();
            lstTabla = new ListBox();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.Yellow;
            btnGenerar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(411, 132);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(112, 35);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar tabla";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 69);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 1;
            label1.Text = "Ingresa un Número";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(252, 120);
            txtNumero.Multiline = true;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(68, 47);
            txtNumero.TabIndex = 2;
            // 
            // lstTabla
            // 
            lstTabla.BackColor = Color.LightCyan;
            lstTabla.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstTabla.FormattingEnabled = true;
            lstTabla.ItemHeight = 25;
            lstTabla.Location = new Point(249, 188);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(246, 254);
            lstTabla.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 637);
            Controls.Add(lstTabla);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(btnGenerar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private Label label1;
        private TextBox txtNumero;
        private ListBox lstTabla;
    }
}
