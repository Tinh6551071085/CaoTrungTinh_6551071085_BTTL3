namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;
        }

        private void btn_ten_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + " " + txtTen.Text;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
