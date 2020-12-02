using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinForms.Lab5_1
{
    public partial class Form1 : Form
    {
        Point point;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Red;
            MyButton button1 = new MyButton
            {
                Location = new Point
                {
                    X = this.Width / 3,
                    Y = this.Height / 3
                }
            };

            button1.Text = "Close";
            button1.Click += button1_Click;

            this.Controls.Add(button1);
            this.Load += Form1_Load;
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                point = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
            if ((e.Button & MouseButtons.Left) != 0)
            {

                Point deltaPos = new Point(e.X - point.X, e.Y - point.Y);
                this.Location = new Point(this.Location.X + deltaPos.X, this.Location.Y + deltaPos.Y);
            }
        }
    }
    class MyButton : Button
    {
        
        Point DownPoint;
      
        bool IsDragMode;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            DownPoint = e.Location;
            IsDragMode = true;
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            IsDragMode = false;
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            
            if (IsDragMode && mevent.Button == MouseButtons.Right)
            {
                Point p = mevent.Location;
                Point dp = new Point(p.X - DownPoint.X, p.Y - DownPoint.Y);
                Location = new Point(Location.X + dp.X, Location.Y + dp.Y);
            }
            base.OnMouseMove(mevent);
        }
    }
}
