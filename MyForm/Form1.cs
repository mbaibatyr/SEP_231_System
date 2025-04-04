namespace MyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(FillLB);
            t.Start();
        }

        void FillLB()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(1000);
                listBox1.Items.Add($"Строка - {i}");
            }
        }
    }
}