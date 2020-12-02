using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinForm.Lab5_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Green;
            this.Load += Form2_Load;
            this.Size = new Size(700, 700);
            Button button1 = new Button
            {
                Location = new Point
                {
                    X = this.Width,
                    Y = this.Height
                }
            };
            button1.Text = "Green Peace";
            button1.Click += button1_Click;
            button1.Size = new Size(this.Height/2, this.Width/2);

            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            Point[] pts1 = { new Point(button1.Width / 2, 0),
                             new Point(button1.Width, button1.Height / 2),
                             new Point(button1.Width / 2, button1.Height),
                             new Point(0, button1.Height / 2), };
            button1.Location = new Point(this.Width / 2 - button1.Width / 2, this.Height / 2 - button1.Height / 2);
            myPath.AddPolygon(pts1);
            button1.Region = new Region(myPath);
           
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 18, FontStyle.Bold);
      
            this.Controls.Add(button1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            Point[] pts1 = { new Point(this.Width/2, 0), new Point(this.Width, this.Height / 2), new Point(this.Width / 2, this.Height), new Point(0, this.Height/2), };

            myPath.AddPolygon(pts1);
         
            this.Region = new Region(myPath);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
