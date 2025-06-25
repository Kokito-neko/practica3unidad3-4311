namespace Ejercicio_7_FrmPrimosEnRango
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
            btnMostrar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtInicio = new TextBox();
            txtFin = new TextBox();
            lstPrimos = new ListBox();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.Aquamarine;
            btnMostrar.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(302, 272);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(117, 44);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar primos";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 97);
            label1.Name = "label1";
            label1.Size = new Size(181, 33);
            label1.TabIndex = 1;
            label1.Text = "Número inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 191);
            label2.Name = "label2";
            label2.Size = new Size(162, 33);
            label2.TabIndex = 2;
            label2.Text = "Número final";
            // 
            // txtInicio
            // 
            txtInicio.BackColor = Color.Honeydew;
            txtInicio.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInicio.Location = new Point(303, 94);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(96, 40);
            txtInicio.TabIndex = 3;
            // 
            // txtFin
            // 
            txtFin.BackColor = Color.Honeydew;
            txtFin.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFin.Location = new Point(302, 188);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(97, 40);
            txtFin.TabIndex = 4;
            // 
            // lstPrimos
            // 
            lstPrimos.BackColor = SystemColors.Info;
            lstPrimos.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstPrimos.FormattingEnabled = true;
            lstPrimos.ItemHeight = 33;
            lstPrimos.Location = new Point(454, 94);
            lstPrimos.Name = "lstPrimos";
            lstPrimos.Size = new Size(180, 235);
            lstPrimos.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPrimos);
            Controls.Add(txtFin);
            Controls.Add(txtInicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Label label1;
        private Label label2;
        private TextBox txtInicio;
        private TextBox txtFin;
        private ListBox lstPrimos;
    }
}
