namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void frmSimpleEvent_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, Welcome to C# 2010 programming!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSimpleEvent_Load(sender, e);
        }

        private void frmSimpleEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was clicked.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}