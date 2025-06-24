namespace Ejercicio_6_FrmNumeroPerfecto
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
            btnVerificar = new Button();
            mtbPerfecto = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleTurquoise;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 114);
            label1.Name = "label1";
            label1.Size = new Size(225, 33);
            label1.TabIndex = 0;
            label1.Text = "Ingresa un número";
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.LawnGreen;
            btnVerificar.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificar.Location = new Point(200, 253);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(127, 46);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // mtbPerfecto
            // 
            mtbPerfecto.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbPerfecto.Location = new Point(242, 181);
            mtbPerfecto.Mask = "00000";
            mtbPerfecto.Name = "mtbPerfecto";
            mtbPerfecto.Size = new Size(44, 40);
            mtbPerfecto.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(518, 450);
            Controls.Add(mtbPerfecto);
            Controls.Add(btnVerificar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVerificar;
        private MaskedTextBox mtbPerfecto;
    }
}
