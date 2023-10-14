namespace CursoWindowsForms
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Titulo_Click(object sender, EventArgs e)
        {
            lbl_Titulo.BackColor = Color.Yellow;
        }

        private void Btn_modificaLabel_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = txt_ConteudoLabel.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_ConteudoLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}