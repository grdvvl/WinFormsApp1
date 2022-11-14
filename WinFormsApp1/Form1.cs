namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brush brush = Brushes.Green;
            Graphics gr = this.CreateGraphics();
            gr.FillEllipse(brush, 20, 50, 100, 50);
            gr.Dispose();
           
            Brush brush = Brushes.White;
            Graphics gr = this.CreateGraphics();
            gr.FillPie(brush, 0, 0, 100, 100, -90, 90);
            gr.Dispose();


        
        }
    }
}
