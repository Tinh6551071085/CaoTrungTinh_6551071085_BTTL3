namespace bI5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = textBox1.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                textBox1.ForeColor = Color.Red;
                lblLapTrinh.ForeColor = Color.Red;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                textBox1.ForeColor = Color.Blue;
                lblLapTrinh.ForeColor = Color.Blue;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                textBox1.ForeColor = Color.Green;
                lblLapTrinh.ForeColor = Color.Green;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                textBox1.ForeColor = Color.Black;
                lblLapTrinh.ForeColor = Color.Black;
            }
        }

        private void UpdateFont()
        {
            FontStyle style = FontStyle.Regular;

            if (checkBox5.Checked)
            {
                style |= FontStyle.Bold;
            }

            if (checkBox6.Checked)
            {
                style |= FontStyle.Italic;
            }

            if (checkBox7.Checked)
            {
                style |= FontStyle.Underline;
            }

            textBox1.Font = new Font(
                textBox1.Font.FontFamily,
                textBox1.Font.Size,
                style
            );

            lblLapTrinh.Font = new Font(
                lblLapTrinh.Font.FontFamily,
                lblLapTrinh.Font.Size,
                style
            );
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}