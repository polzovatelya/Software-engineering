namespace PI_LABA_5_WinForms
{
    public partial class Form1 : Form

    {
        public Form2 InputForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm = new Form2();
            InputForm.Show();
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 InputForm2 = new Form4(InputForm);
            InputForm2.Show();
        }
    }
}
