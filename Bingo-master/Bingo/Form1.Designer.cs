namespace Bingo
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
            btIniciar = new Button();
            numQtd = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
            SuspendLayout();
            // 
            // btIniciar
            // 
            btIniciar.Font = new Font("Segoe UI", 12F);
            btIniciar.Location = new Point(309, 153);
            btIniciar.Name = "btIniciar";
            btIniciar.Size = new Size(101, 33);
            btIniciar.TabIndex = 0;
            btIniciar.Text = "Iniciar";
            btIniciar.UseVisualStyleBackColor = true;
            btIniciar.Click += button1_Click;
            // 
            // numQtd
            // 
            numQtd.Font = new Font("Segoe UI", 12F);
            numQtd.Location = new Point(159, 153);
            numQtd.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(137, 29);
            numQtd.TabIndex = 1;
            numQtd.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(200, 124);
            label1.Name = "label1";
            label1.Size = new Size(215, 21);
            label1.TabIndex = 2;
            label1.Text = "Indique o número de cartelas:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 432);
            Controls.Add(label1);
            Controls.Add(numQtd);
            Controls.Add(btIniciar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btIniciar;
        private NumericUpDown numQtd;
        private Label label1;
    }
}
