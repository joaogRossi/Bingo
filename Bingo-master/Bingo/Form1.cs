namespace Bingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal qtd = numQtd.Value;
            DialogResult r = MessageBox.Show($"Deseja iniciar o bingo com {qtd} cartelas?", "Bingo", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes) {
                FrmSorteador frm = new FrmSorteador(this, (int)qtd);
                frm.Show();
                this.Hide();
            }


        }
    }
}
