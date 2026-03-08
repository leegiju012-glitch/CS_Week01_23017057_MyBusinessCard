namespace CS_Week01_23017057_MyBusinessCard
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            // 0~255 사이의R, G, B 값을무작위로생성하여배경색에적용
            this.BackColor= Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }
    }
}
