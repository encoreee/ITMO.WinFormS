using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;

namespace SimpleCalculator
{
    /// <summary>
    /// Summary description for CalcUI.
    /// </summary>
    public class CalcUI : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox VersionInfo;
        private System.Windows.Forms.Button KeyExit;
        private System.Windows.Forms.Button KeyDate;
        private System.Windows.Forms.TextBox OutputDisplay;
        private System.Windows.Forms.Button KeyClear;
        private System.Windows.Forms.Button KeyMinus;
        private System.Windows.Forms.Button KeyPlus;
        private System.Windows.Forms.Button KeyEqual;
        private System.Windows.Forms.Button KeyMultiply;
        private System.Windows.Forms.Button KeyDivide;
        private System.Windows.Forms.Button KeyPoint;
        private System.Windows.Forms.Button KeySign;
        private System.Windows.Forms.Button KeyZero;
        private System.Windows.Forms.Button KeyNine;
        private System.Windows.Forms.Button KeyEight;
        private System.Windows.Forms.Button KeySeven;
        private System.Windows.Forms.Button KeySix;
        private System.Windows.Forms.Button KeyFive;
        private System.Windows.Forms.Button KeyFour;
        private System.Windows.Forms.Button KeyThree;
        private System.Windows.Forms.Button KeyTwo;
        private System.Windows.Forms.Button KeyOne;
        private System.Windows.Forms.Button KeyExponet;
        private System.Windows.Forms.Button KeySqrt;
        private System.Windows.Forms.Button KeyInv;
        private System.Windows.Forms.Button KeySquar;

        // Output Display Constants.
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";
        private MenuStrip menuStrip1;
        private ToolStripMenuItem commonToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem sumToolStripMenuItem;
        private ToolStripMenuItem differenceToolStripMenuItem;
        private ToolStripMenuItem compositionToolStripMenuItem;
        private ToolStripMenuItem divisionToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem standartToolStripMenuItem;
        private ToolStripMenuItem engineeringToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolTip toolTip1;
        private IContainer components;

        public CalcUI()
        {
            //
            // Required for Windows Form Designer support
            //
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.TopMost = true;

            //
            // Get version information from the Calculator Module.
            //

            VersionInfo.Text = CalcEngine.GetVersion();
            OutputDisplay.Text = "0";

            // to delete
            //Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            //this.Location = new System.Drawing.Point(resolution.Width / 2 - this.Width / 2, resolution.Height - 2 - this.Height / 2);
            //his.Refresh();
            //Console.WriteLine("Width: {0}, Height: {1}", resolution.Width, resolution.Height);
            // to delete
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.KeyExponet = new System.Windows.Forms.Button();
            this.KeySqrt = new System.Windows.Forms.Button();
            this.KeyInv = new System.Windows.Forms.Button();
            this.KeySquar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineeringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyDate
            // 
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Blue;
            this.KeyDate.Location = new System.Drawing.Point(245, 171);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(67, 46);
            this.KeyDate.TabIndex = 19;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.toolTip1.SetToolTip(this.KeyDate, "Show current date");
            this.KeyDate.Click += new System.EventHandler(this.KeyDate_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.Blue;
            this.KeyOne.Location = new System.Drawing.Point(14, 226);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(48, 46);
            this.KeyOne.TabIndex = 2;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // VersionInfo
            // 
            this.VersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.VersionInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.VersionInfo.Location = new System.Drawing.Point(14, 42);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.ReadOnly = true;
            this.VersionInfo.Size = new System.Drawing.Size(298, 24);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.TabStop = false;
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeySix
            // 
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.Blue;
            this.KeySix.Location = new System.Drawing.Point(130, 171);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(48, 46);
            this.KeySix.TabIndex = 7;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            this.KeySix.Click += new System.EventHandler(this.KeySix_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.Blue;
            this.KeyFive.Location = new System.Drawing.Point(72, 171);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(48, 46);
            this.KeyFive.TabIndex = 6;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            this.KeyFive.Click += new System.EventHandler(this.KeyFive_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(245, 282);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(67, 46);
            this.KeyEqual.TabIndex = 18;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.toolTip1.SetToolTip(this.KeyEqual, "Calculate expression");
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.Blue;
            this.KeyTwo.Location = new System.Drawing.Point(72, 226);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(48, 46);
            this.KeyTwo.TabIndex = 3;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            this.KeyTwo.Click += new System.EventHandler(this.KeyTwo_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.Blue;
            this.KeyZero.Location = new System.Drawing.Point(14, 282);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(48, 46);
            this.KeyZero.TabIndex = 11;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            this.KeyZero.Click += new System.EventHandler(this.KeyZero_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.Blue;
            this.KeyThree.Location = new System.Drawing.Point(130, 226);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(48, 46);
            this.KeyThree.TabIndex = 4;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            this.KeyThree.Click += new System.EventHandler(this.KeyThree_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(187, 282);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(48, 46);
            this.KeyPlus.TabIndex = 12;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.toolTip1.SetToolTip(this.KeyPlus, "Sum operation");
            this.KeyPlus.Click += new System.EventHandler(this.KeyPlus_Click);
            // 
            // KeyExit
            // 
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(245, 226);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(67, 46);
            this.KeyExit.TabIndex = 21;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.KeyExit, "Exit application");
            this.KeyExit.Click += new System.EventHandler(this.KeyExit_Click);
            // 
            // KeySign
            // 
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.Blue;
            this.KeySign.Location = new System.Drawing.Point(130, 282);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(48, 46);
            this.KeySign.TabIndex = 16;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.toolTip1.SetToolTip(this.KeySign, "Change sign");
            this.KeySign.Click += new System.EventHandler(this.KeySign_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.Blue;
            this.KeySeven.Location = new System.Drawing.Point(14, 115);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(48, 47);
            this.KeySeven.TabIndex = 8;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            this.KeySeven.Click += new System.EventHandler(this.KeySeven_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.Blue;
            this.KeyPoint.Location = new System.Drawing.Point(72, 282);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(48, 46);
            this.KeyPoint.TabIndex = 17;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.toolTip1.SetToolTip(this.KeyPoint, "Dot");
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.Blue;
            this.KeyNine.Location = new System.Drawing.Point(130, 115);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(48, 47);
            this.KeyNine.TabIndex = 10;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            this.KeyNine.Click += new System.EventHandler(this.KeyNine_Click);
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(14, 78);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(298, 30);
            this.OutputDisplay.TabIndex = 1;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // KeyMinus
            // 
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(187, 226);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(48, 46);
            this.KeyMinus.TabIndex = 13;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.toolTip1.SetToolTip(this.KeyMinus, "Difference operation");
            this.KeyMinus.Click += new System.EventHandler(this.KeyMinus_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.Blue;
            this.KeyEight.Location = new System.Drawing.Point(72, 115);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(48, 47);
            this.KeyEight.TabIndex = 9;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            this.KeyEight.Click += new System.EventHandler(this.KeyEight_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(187, 171);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(48, 46);
            this.KeyMultiply.TabIndex = 14;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.toolTip1.SetToolTip(this.KeyMultiply, "Multiplication operation");
            this.KeyMultiply.Click += new System.EventHandler(this.KeyMultiply_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.Blue;
            this.KeyFour.Location = new System.Drawing.Point(14, 171);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(48, 46);
            this.KeyFour.TabIndex = 5;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            this.KeyFour.Click += new System.EventHandler(this.KeyFour_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(245, 115);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(67, 47);
            this.KeyClear.TabIndex = 20;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.toolTip1.SetToolTip(this.KeyClear, "Clear");
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(187, 115);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(48, 47);
            this.KeyDivide.TabIndex = 15;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.toolTip1.SetToolTip(this.KeyDivide, "Division operation");
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // KeyExponet
            // 
            this.KeyExponet.Location = new System.Drawing.Point(0, 0);
            this.KeyExponet.Name = "KeyExponet";
            this.KeyExponet.Size = new System.Drawing.Size(75, 23);
            this.KeyExponet.TabIndex = 0;
            // 
            // KeySqrt
            // 
            this.KeySqrt.Location = new System.Drawing.Point(0, 0);
            this.KeySqrt.Name = "KeySqrt";
            this.KeySqrt.Size = new System.Drawing.Size(75, 23);
            this.KeySqrt.TabIndex = 0;
            // 
            // KeyInv
            // 
            this.KeyInv.Location = new System.Drawing.Point(0, 0);
            this.KeyInv.Name = "KeyInv";
            this.KeyInv.Size = new System.Drawing.Size(75, 23);
            this.KeyInv.TabIndex = 0;
            // 
            // KeySquar
            // 
            this.KeySquar.Location = new System.Drawing.Point(0, 0);
            this.KeySquar.Name = "KeySquar";
            this.KeySquar.Size = new System.Drawing.Size(75, 23);
            this.KeySquar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commonToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(327, 30);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commonToolStripMenuItem
            // 
            this.commonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripSeparator2,
            this.standartToolStripMenuItem,
            this.engineeringToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.commonToolStripMenuItem.Name = "commonToolStripMenuItem";
            this.commonToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.commonToolStripMenuItem.Text = "Common";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Checked = true;
            this.standartToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.standartToolStripMenuItem.Text = "Standart";
            this.standartToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
            // 
            // engineeringToolStripMenuItem
            // 
            this.engineeringToolStripMenuItem.Name = "engineeringToolStripMenuItem";
            this.engineeringToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.engineeringToolStripMenuItem.Text = "Engineering";
            this.engineeringToolStripMenuItem.Click += new System.EventHandler(this.engineeringToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumToolStripMenuItem,
            this.differenceToolStripMenuItem,
            this.compositionToolStripMenuItem,
            this.divisionToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // sumToolStripMenuItem
            // 
            this.sumToolStripMenuItem.Name = "sumToolStripMenuItem";
            this.sumToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.sumToolStripMenuItem.Text = "Sum";
            // 
            // differenceToolStripMenuItem
            // 
            this.differenceToolStripMenuItem.Name = "differenceToolStripMenuItem";
            this.differenceToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.differenceToolStripMenuItem.Text = "Difference";
            // 
            // compositionToolStripMenuItem
            // 
            this.compositionToolStripMenuItem.Name = "compositionToolStripMenuItem";
            this.compositionToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.compositionToolStripMenuItem.Text = "Composition";
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.divisionToolStripMenuItem.Text = "Division";
            // 
            // CalcUI
            // 
            this.AcceptButton = this.KeyZero;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(327, 343);
            this.Controls.Add(this.KeyOne);
            this.Controls.Add(this.KeyTwo);
            this.Controls.Add(this.KeyThree);
            this.Controls.Add(this.KeyFour);
            this.Controls.Add(this.KeyFive);
            this.Controls.Add(this.KeySix);
            this.Controls.Add(this.KeySeven);
            this.Controls.Add(this.KeyEight);
            this.Controls.Add(this.KeyNine);
            this.Controls.Add(this.KeyZero);
            this.Controls.Add(this.KeyPlus);
            this.Controls.Add(this.KeyMinus);
            this.Controls.Add(this.KeyMultiply);
            this.Controls.Add(this.KeyDivide);
            this.Controls.Add(this.KeySign);
            this.Controls.Add(this.KeyPoint);
            this.Controls.Add(this.KeyEqual);
            this.Controls.Add(this.KeyDate);
            this.Controls.Add(this.KeyClear);
            this.Controls.Add(this.KeyExit);
            this.Controls.Add(this.OutputDisplay);
            this.Controls.Add(this.VersionInfo);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CalcUI";
            this.Text = "Simple Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        protected void KeyPlus_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
        }

        protected void KeyMinus_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
        }

        protected void KeyMultiply_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
        }

        protected void KeyDivide_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
        }
        //
        // Engenireeng cals key click methods.
        //

        protected void KeyExponent_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcOperation(CalcEngine.Operator.eExponentiation);
        }

        protected void KeySqrt_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcUnOperation(CalcEngine.Operator.eSqrt);
            OutputDisplay.Text = CalcEngine.CalcEqual();
        }

        protected void KeyInv_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcUnOperation(CalcEngine.Operator.eInv);
            OutputDisplay.Text = CalcEngine.CalcEqual();
        }

        protected void KeySquar_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcUnOperation(CalcEngine.Operator.eSquar);
            OutputDisplay.Text = CalcEngine.CalcEqual();
        }


        //
        // Other non-numeric key click methods.
        //

        protected void KeySign_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSign();
        }

        protected void KeyPoint_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcDecimal();
        }

        protected void KeyDate_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.GetDate();
            CalcEngine.CalcReset();
        }

        protected void KeyClear_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcReset();
            OutputDisplay.Text = "0";
        }

        //
        // Perform the calculation.
        //

        protected void KeyEqual_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.CalcReset();
        }

        //
        // Numeric key click methods.
        //

        protected void KeyNine_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(nineOut);
        }

        protected void KeyEight_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(eightOut);
        }

        protected void KeySeven_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sevenOut);
        }

        protected void KeySix_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sixOut);
        }

        protected void KeyFive_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fiveOut);
        }

        protected void KeyFour_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fourOut);
        }

        protected void KeyThree_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(threeOut);
        }

        protected void KeyTwo_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(twoOut);
        }

        protected void KeyOne_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(oneOut);
        }

        protected void KeyZero_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(zeroOut);
        }

        //
        // End the program.
        //

        protected void KeyExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new CalcUI());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcEngine.CalcReset();
            OutputDisplay.Text = "0";
        }

        private void engineeringToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (standartToolStripMenuItem.Checked)
            {
                this.Size = new System.Drawing.Size(315, 550);
                standartToolStripMenuItem.Checked = false;
                engineeringToolStripMenuItem.Checked = true;

                this.KeyExponet.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                this.KeyExponet.ForeColor = System.Drawing.Color.Blue;
                this.KeyExponet.Location = new System.Drawing.Point(14, 320);
                this.KeyExponet.Name = "KeyExponet";
                this.KeyExponet.Size = new System.Drawing.Size(43, 44);
                this.KeyExponet.TabIndex = 21;
                this.KeyExponet.TabStop = false;
                this.KeyExponet.Text = "^";
                this.KeyExponet.Click += new System.EventHandler(this.KeyExponent_Click);
                this.toolTip1.SetToolTip(KeyExponet, "Exponentiation operation");
                this.Controls.Add(this.KeyExponet);

                this.KeySqrt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                this.KeySqrt.ForeColor = System.Drawing.Color.Blue;
                this.KeySqrt.Location = new System.Drawing.Point(67, 320);
                this.KeySqrt.Name = "KeySqrt";
                this.KeySqrt.Size = new System.Drawing.Size(43, 44);
                this.KeySqrt.TabIndex = 22;
                this.KeySqrt.TabStop = false;
                this.KeySqrt.Text = "Sqrt";
                this.KeySqrt.Click += new System.EventHandler(this.KeySqrt_Click);
                this.toolTip1.SetToolTip(KeySqrt, "Square root");
                this.Controls.Add(this.KeySqrt);

                this.KeyInv.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
                this.KeyInv.ForeColor = System.Drawing.Color.Blue;
                this.KeyInv.Location = new System.Drawing.Point(120, 320);
                this.KeyInv.Name = "KeyInv";
                this.KeyInv.Size = new System.Drawing.Size(43, 44);
                this.KeyInv.TabIndex = 23;
                this.KeyInv.TabStop = false;
                this.KeyInv.Text = "Inv";
                this.KeyInv.Click += new System.EventHandler(this.KeyInv_Click);
                this.toolTip1.SetToolTip(KeyInv, "Inversion operation");
                this.Controls.Add(this.KeyInv);

                this.KeySquar.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                this.KeySquar.ForeColor = System.Drawing.Color.Blue;
                this.KeySquar.Location = new System.Drawing.Point(172, 320);
                this.KeySquar.Name = "KeySquar";
                this.KeySquar.Size = new System.Drawing.Size(43, 44);
                this.KeySquar.TabIndex = 24;
                this.KeySquar.TabStop = false;
                this.KeySquar.Text = "Squar";
                this.toolTip1.SetToolTip(KeySquar, "Squaring operation");
                this.KeySquar.Click += new System.EventHandler(this.KeySquar_Click);
                this.Controls.Add(this.KeySquar);

            }
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (engineeringToolStripMenuItem.Checked)
            {
                this.Size = new System.Drawing.Size(315, 365);
                engineeringToolStripMenuItem.Checked = false;
                standartToolStripMenuItem.Checked = true;
                this.Controls.Remove(this.KeyExponet);
                this.Controls.Remove(this.KeySqrt);
                this.Controls.Remove(this.KeyInv);
                this.Controls.Remove(this.KeySquar);
            }
        }
    }
}
