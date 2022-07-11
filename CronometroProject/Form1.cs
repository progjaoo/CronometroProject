using System.Diagnostics;
namespace CronometroProject
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void BtnPausar_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();    
        }

        private void BtnResetar_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
        }

        private void TimerUnic_Tick(object sender, EventArgs e)
        {
            this.LblCronom.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", stopwatch.Elapsed);
        }
    }
}