namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtSoa.Text);
            b = int.Parse(txtSob.Text);
            ketQua = a - b;
            txtkq.Text = ketQua.ToString();
        }
            
        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtSoa.Text);
            b = int.Parse(txtSob.Text);
            ketQua = a + b;
            txtkq.Text = ketQua.ToString();

        }
    }
}