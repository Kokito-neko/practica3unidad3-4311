namespace Ejercicio_2_FrmTemporizador
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            Temporizador = new System.Windows.Forms.Timer(components);
            btnIniciar = new Button();
            nudMinutos = new NumericUpDown();
            nudSegundos = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudMinutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSegundos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 148);
            label1.Name = "label1";
            label1.Size = new Size(109, 33);
            label1.TabIndex = 0;
            label1.Text = "Minutos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 251);
            label2.Name = "label2";
            label2.Size = new Size(123, 33);
            label2.TabIndex = 1;
            label2.Text = "Segundos";
            // 
            // Temporizador
            // 
            Temporizador.Interval = 1000;
            Temporizador.Tick += temporizador_Tick;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.MediumSpringGreen;
            btnIniciar.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(205, 82);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 40);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar Temporizador";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // nudMinutos
            // 
            nudMinutos.Location = new Point(282, 148);
            nudMinutos.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudMinutos.Name = "nudMinutos";
            nudMinutos.Size = new Size(180, 31);
            nudMinutos.TabIndex = 3;
            // 
            // nudSegundos
            // 
            nudSegundos.Location = new Point(282, 251);
            nudSegundos.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudSegundos.Name = "nudSegundos";
            nudSegundos.Size = new Size(180, 31);
            nudSegundos.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 310);
            Controls.Add(nudSegundos);
            Controls.Add(nudMinutos);
            Controls.Add(btnIniciar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudMinutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSegundos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer Temporizador;
        private Button btnIniciar;
        private NumericUpDown nudMinutos;
        private NumericUpDown nudSegundos;
    }
}
