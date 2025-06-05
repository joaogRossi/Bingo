namespace Bingo
{
    partial class FrmHistorico
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
            lbxHistorico = new ListBox();
            SuspendLayout();
            // 
            // lbxHistorico
            // 
            lbxHistorico.FormattingEnabled = true;
            lbxHistorico.ItemHeight = 15;
            lbxHistorico.Location = new Point(0, -1);
            lbxHistorico.Name = "lbxHistorico";
            lbxHistorico.Size = new Size(411, 454);
            lbxHistorico.TabIndex = 0;
            // 
            // FrmHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbxHistorico);
            Name = "FrmHistorico";
            Text = "Bingo - Historico";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbxHistorico;
    }
}