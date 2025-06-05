namespace Bingo
{
    partial class FrmSorteador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btProximo = new Button();
            btCancelar = new Button();
            btHistorico = new Button();
            lblNumero = new Label();
            SuspendLayout();
            // 
            // btProximo
            // 
            btProximo.Font = new Font("Segoe UI", 12F);
            btProximo.Location = new Point(203, 359);
            btProximo.Name = "btProximo";
            btProximo.Size = new Size(107, 48);
            btProximo.TabIndex = 0;
            btProximo.Text = "&Próximo número";
            btProximo.TextImageRelation = TextImageRelation.ImageAboveText;
            btProximo.UseVisualStyleBackColor = true;
            btProximo.Click += btProximo_Click;
            // 
            // btCancelar
            // 
            btCancelar.Font = new Font("Segoe UI", 12F);
            btCancelar.Location = new Point(505, 359);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(107, 48);
            btCancelar.TabIndex = 1;
            btCancelar.Text = "&Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btHistorico
            // 
            btHistorico.Font = new Font("Segoe UI", 12F);
            btHistorico.Location = new Point(548, 24);
            btHistorico.Name = "btHistorico";
            btHistorico.Size = new Size(174, 48);
            btHistorico.TabIndex = 2;
            btHistorico.Text = "&Histórico sorteado";
            btHistorico.UseVisualStyleBackColor = true;
            btHistorico.Click += btHistorico_Click;
            // 
            // lblNumero
            // 
            lblNumero.Font = new Font("Segoe UI", 12F);
            lblNumero.Location = new Point(-4, 118);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(807, 194);
            lblNumero.TabIndex = 3;
            // 
            // FrmSorteador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNumero);
            Controls.Add(btHistorico);
            Controls.Add(btCancelar);
            Controls.Add(btProximo);
            Name = "FrmSorteador";
            Text = "Sorteador";
            FormClosing += FrmSorteador_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btProximo;
        private Button btCancelar;
        private Button btHistorico;
        private Label lblNumero;
    }
}