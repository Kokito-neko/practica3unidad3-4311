namespace Ejercicio_3_FrmConversorLongitud
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
            label2 = new Label();
            label3 = new Label();
            lblResultado = new Label();
            txtValor = new TextBox();
            cmbOrigen = new ComboBox();
            cmbDestino = new ComboBox();
            btnConvertir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 82);
            label1.Name = "label1";
            label1.Size = new Size(172, 27);
            label1.TabIndex = 0;
            label1.Text = "Valor a convertir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(133, 162);
            label2.Name = "label2";
            label2.Size = new Size(176, 27);
            label2.TabIndex = 1;
            label2.Text = "Unidad de origen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(133, 243);
            label3.Name = "label3";
            label3.Size = new Size(185, 27);
            label3.TabIndex = 2;
            label3.Text = "Unidad de destino";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(222, 325);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(107, 26);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resutado";
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.PaleTurquoise;
            txtValor.Location = new Point(356, 78);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(150, 31);
            txtValor.TabIndex = 4;
            // 
            // cmbOrigen
            // 
            cmbOrigen.BackColor = Color.MistyRose;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(356, 156);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(150, 33);
            cmbOrigen.TabIndex = 5;
            // 
            // cmbDestino
            // 
            cmbDestino.BackColor = Color.MistyRose;
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(356, 237);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(150, 33);
            cmbDestino.TabIndex = 6;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.Lime;
            btnConvertir.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConvertir.Location = new Point(586, 162);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(112, 34);
            btnConvertir.TabIndex = 7;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConvertir);
            Controls.Add(cmbDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(txtValor);
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += FrmConversorLongitud_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResultado;
        private TextBox txtValor;
        private ComboBox cmbOrigen;
        private ComboBox cmbDestino;
        private Button btnConvertir;
    }
}
