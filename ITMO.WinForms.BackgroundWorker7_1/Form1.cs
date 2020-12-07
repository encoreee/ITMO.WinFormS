using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinForms.BackgroundWorker7_1
{
    public partial class Form1 : Form
    {
        int i;
       
        int timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            i = int.Parse(e.Argument.ToString());
            for (; timer <= 100;)
            {

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    timer1.Stop();
                    return;
                }
                //  if ()
                //  {
                //     timer1.Stop();
                //       return;
                // }

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!(e.Cancelled))
                System.Windows.Forms.MessageBox.Show("Run Completed!");
            else
                System.Windows.Forms.MessageBox.Show("Run Cancelled");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == ""))
            {
                int i = int.Parse(textBox1.Text);
                backgroundWorker1.RunWorkerAsync(i);
                timer1.Enabled = true;
                timer1.Start();
                timer1.Interval = i * 10;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            timer1.Stop();
            progressBar1.Value = 0;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            if (timer <= 100)
            {
                backgroundWorker1.ReportProgress(timer);
            }
        }
    }
}
