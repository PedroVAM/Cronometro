using System.Diagnostics;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        private Stopwatch stopWatch;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }
    }
}