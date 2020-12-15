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
        private System.Windows.Forms.Button KeyExponet;
        private System.Windows.Forms.Button KeySqrt;
        private System.Windows.Forms.Button KeyInv;
        private System.Windows.Forms.Button KeySquar;
        private System.Windows.Forms.Button KeyFact;
        private System.Windows.Forms.Button KeySqrtKub;
        private System.Windows.Forms.Button KeyBGFact;

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
        private ToolStripMenuItem cToolStripMenuItem;
        private BackgroundWorker backgroundWorker1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button KeyOne;
        private Button KeyTwo;
        private Button KeyThree;
        private Button KeyFour;
        private Button KeyFive;
        private Button KeySix;
        private Button KeySeven;
        private Button KeyEight;
        private Button KeyNine;
        private Button KeyZero;
        private Button KeyPlus;
        private Button KeyMinus;
        private Button KeyMultiply;
        private Button KeyDivide;
        private Button KeySign;
        private Button KeyPoint;
        private Button KeyEqual;
        private Button KeyDate;
        private Button KeyClear;
        private Button KeyExit;
        private TextBox OutputDisplay;
        private TextBox VersionInfo;
        private TextBox OutputDisplay2;
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
            this.KeyExponet = new System.Windows.Forms.Button();
            this.KeySqrt = new System.Windows.Forms.Button();
            this.KeyInv = new System.Windows.Forms.Button();
            this.KeySquar = new System.Windows.Forms.Button();
            this.KeyFact = new System.Windows.Forms.Button();
            this.KeyBGFact = new System.Windows.Forms.Button();
            this.KeySqrtKub = new System.Windows.Forms.Button();
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
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.KeyOne = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyDate = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.KeyExit = new System.Windows.Forms.Button();
            this.OutputDisplay = new System.Windows.Forms.TextBox();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.OutputDisplay2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // KeyFact
            // 
            this.KeyFact.Location = new System.Drawing.Point(0, 0);
            this.KeyFact.Name = "KeyFact";
            this.KeyFact.Size = new System.Drawing.Size(75, 23);
            this.KeyFact.TabIndex = 0;
            // 
            // KeyBGFact
            // 
            this.KeyBGFact.Location = new System.Drawing.Point(0, 0);
            this.KeyBGFact.Name = "KeyBGFact";
            this.KeyBGFact.Size = new System.Drawing.Size(75, 23);
            this.KeyBGFact.TabIndex = 0;
            // 
            // KeySqrtKub
            // 
            this.KeySqrtKub.Location = new System.Drawing.Point(0, 0);
            this.KeySqrtKub.Name = "KeySqrtKub";
            this.KeySqrtKub.Size = new System.Drawing.Size(75, 23);
            this.KeySqrtKub.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commonToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(278, 28);
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
            this.commonToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
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
            this.divisionToolStripMenuItem,
            this.cToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // sumToolStripMenuItem
            // 
            this.sumToolStripMenuItem.Name = "sumToolStripMenuItem";
            this.sumToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.sumToolStripMenuItem.Text = "Sum";
            // 
            // differenceToolStripMenuItem
            // 
            this.differenceToolStripMenuItem.Name = "differenceToolStripMenuItem";
            this.differenceToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.differenceToolStripMenuItem.Text = "Difference";
            // 
            // compositionToolStripMenuItem
            // 
            this.compositionToolStripMenuItem.Name = "compositionToolStripMenuItem";
            this.compositionToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.compositionToolStripMenuItem.Text = "Composition";
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.divisionToolStripMenuItem.Text = "Division";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.cToolStripMenuItem.Text = "Calculation of roots";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.KeyEqual, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.KeyPlus, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.KeyExit, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.KeyDate, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.KeySix, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.KeyClear, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.KeyMinus, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.KeyThree, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.KeyMultiply, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.KeyTwo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.KeyDivide, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.KeyOne, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.VersionInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.KeyFive, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.OutputDisplay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OutputDisplay2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.KeySign, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.KeyZero, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.KeyFour, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.KeySeven, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.KeyPoint, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.KeyEight, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.KeyNine, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 317);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // KeyOne
            // 
            this.KeyOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyOne.ForeColor = System.Drawing.Color.Blue;
            this.KeyOne.Location = new System.Drawing.Point(6, 216);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(44, 44);
            this.KeyOne.TabIndex = 26;
            this.KeyOne.TabStop = false;
            this.KeyOne.Text = "1";
            // 
            // KeyTwo
            // 
            this.KeyTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyTwo.ForeColor = System.Drawing.Color.Blue;
            this.KeyTwo.Location = new System.Drawing.Point(56, 216);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(44, 44);
            this.KeyTwo.TabIndex = 27;
            this.KeyTwo.TabStop = false;
            this.KeyTwo.Text = "2";
            // 
            // KeyThree
            // 
            this.KeyThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyThree.ForeColor = System.Drawing.Color.Blue;
            this.KeyThree.Location = new System.Drawing.Point(106, 216);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(44, 44);
            this.KeyThree.TabIndex = 28;
            this.KeyThree.TabStop = false;
            this.KeyThree.Text = "3";
            // 
            // KeyFour
            // 
            this.KeyFour.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFour.ForeColor = System.Drawing.Color.Blue;
            this.KeyFour.Location = new System.Drawing.Point(6, 166);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(44, 44);
            this.KeyFour.TabIndex = 29;
            this.KeyFour.TabStop = false;
            this.KeyFour.Text = "4";
            // 
            // KeyFive
            // 
            this.KeyFive.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyFive.ForeColor = System.Drawing.Color.Blue;
            this.KeyFive.Location = new System.Drawing.Point(56, 166);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(44, 44);
            this.KeyFive.TabIndex = 30;
            this.KeyFive.TabStop = false;
            this.KeyFive.Text = "5";
            // 
            // KeySix
            // 
            this.KeySix.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySix.ForeColor = System.Drawing.Color.Blue;
            this.KeySix.Location = new System.Drawing.Point(106, 166);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(44, 44);
            this.KeySix.TabIndex = 31;
            this.KeySix.TabStop = false;
            this.KeySix.Text = "6";
            // 
            // KeySeven
            // 
            this.KeySeven.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeySeven.ForeColor = System.Drawing.Color.Blue;
            this.KeySeven.Location = new System.Drawing.Point(6, 116);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(44, 44);
            this.KeySeven.TabIndex = 32;
            this.KeySeven.TabStop = false;
            this.KeySeven.Text = "7";
            // 
            // KeyEight
            // 
            this.KeyEight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEight.ForeColor = System.Drawing.Color.Blue;
            this.KeyEight.Location = new System.Drawing.Point(56, 116);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(44, 44);
            this.KeyEight.TabIndex = 33;
            this.KeyEight.TabStop = false;
            this.KeyEight.Text = "8";
            // 
            // KeyNine
            // 
            this.KeyNine.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyNine.ForeColor = System.Drawing.Color.Blue;
            this.KeyNine.Location = new System.Drawing.Point(106, 116);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(44, 44);
            this.KeyNine.TabIndex = 34;
            this.KeyNine.TabStop = false;
            this.KeyNine.Text = "9";
            // 
            // KeyZero
            // 
            this.KeyZero.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyZero.ForeColor = System.Drawing.Color.Blue;
            this.KeyZero.Location = new System.Drawing.Point(6, 266);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(44, 45);
            this.KeyZero.TabIndex = 35;
            this.KeyZero.TabStop = false;
            this.KeyZero.Text = "0";
            // 
            // KeyPlus
            // 
            this.KeyPlus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPlus.ForeColor = System.Drawing.Color.Red;
            this.KeyPlus.Location = new System.Drawing.Point(156, 266);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(44, 45);
            this.KeyPlus.TabIndex = 36;
            this.KeyPlus.TabStop = false;
            this.KeyPlus.Text = "+";
            this.toolTip1.SetToolTip(this.KeyPlus, "Sum operation");
            // 
            // KeyMinus
            // 
            this.KeyMinus.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMinus.ForeColor = System.Drawing.Color.Red;
            this.KeyMinus.Location = new System.Drawing.Point(156, 216);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(44, 44);
            this.KeyMinus.TabIndex = 37;
            this.KeyMinus.TabStop = false;
            this.KeyMinus.Text = "-";
            this.toolTip1.SetToolTip(this.KeyMinus, "Difference operation");
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyMultiply.ForeColor = System.Drawing.Color.Red;
            this.KeyMultiply.Location = new System.Drawing.Point(156, 166);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(44, 44);
            this.KeyMultiply.TabIndex = 38;
            this.KeyMultiply.TabStop = false;
            this.KeyMultiply.Text = "*";
            this.toolTip1.SetToolTip(this.KeyMultiply, "Multiplication operation");
            // 
            // KeyDivide
            // 
            this.KeyDivide.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDivide.ForeColor = System.Drawing.Color.Red;
            this.KeyDivide.Location = new System.Drawing.Point(156, 116);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(44, 44);
            this.KeyDivide.TabIndex = 39;
            this.KeyDivide.TabStop = false;
            this.KeyDivide.Text = "/";
            this.toolTip1.SetToolTip(this.KeyDivide, "Division operation");
            // 
            // KeySign
            // 
            this.KeySign.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.KeySign.ForeColor = System.Drawing.Color.Blue;
            this.KeySign.Location = new System.Drawing.Point(106, 266);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(44, 45);
            this.KeySign.TabIndex = 40;
            this.KeySign.TabStop = false;
            this.KeySign.Text = "+/-";
            this.toolTip1.SetToolTip(this.KeySign, "Change sign");
            // 
            // KeyPoint
            // 
            this.KeyPoint.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyPoint.ForeColor = System.Drawing.Color.Blue;
            this.KeyPoint.Location = new System.Drawing.Point(56, 266);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(44, 45);
            this.KeyPoint.TabIndex = 41;
            this.KeyPoint.TabStop = false;
            this.KeyPoint.Text = ".";
            this.toolTip1.SetToolTip(this.KeyPoint, "Dot");
            // 
            // KeyEqual
            // 
            this.KeyEqual.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyEqual.ForeColor = System.Drawing.Color.Red;
            this.KeyEqual.Location = new System.Drawing.Point(206, 266);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(66, 45);
            this.KeyEqual.TabIndex = 42;
            this.KeyEqual.TabStop = false;
            this.KeyEqual.Text = "=";
            this.toolTip1.SetToolTip(this.KeyEqual, "Calculate expression");
            // 
            // KeyDate
            // 
            this.KeyDate.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyDate.ForeColor = System.Drawing.Color.Blue;
            this.KeyDate.Location = new System.Drawing.Point(206, 166);
            this.KeyDate.Name = "KeyDate";
            this.KeyDate.Size = new System.Drawing.Size(66, 44);
            this.KeyDate.TabIndex = 43;
            this.KeyDate.TabStop = false;
            this.KeyDate.Text = "Date";
            this.toolTip1.SetToolTip(this.KeyDate, "Show current date");
            // 
            // KeyClear
            // 
            this.KeyClear.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyClear.ForeColor = System.Drawing.Color.Red;
            this.KeyClear.Location = new System.Drawing.Point(206, 116);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(66, 44);
            this.KeyClear.TabIndex = 44;
            this.KeyClear.TabStop = false;
            this.KeyClear.Text = "C";
            this.toolTip1.SetToolTip(this.KeyClear, "Clear");
            // 
            // KeyExit
            // 
            this.KeyExit.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.KeyExit.ForeColor = System.Drawing.Color.Red;
            this.KeyExit.Location = new System.Drawing.Point(206, 216);
            this.KeyExit.Name = "KeyExit";
            this.KeyExit.Size = new System.Drawing.Size(66, 44);
            this.KeyExit.TabIndex = 45;
            this.KeyExit.TabStop = false;
            this.KeyExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.KeyExit, "Exit application");
            // 
            // OutputDisplay
            // 
            this.OutputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.SetColumnSpan(this.OutputDisplay, 5);
            this.OutputDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay.Location = new System.Drawing.Point(6, 36);
            this.OutputDisplay.Name = "OutputDisplay";
            this.OutputDisplay.ReadOnly = true;
            this.OutputDisplay.Size = new System.Drawing.Size(266, 30);
            this.OutputDisplay.TabIndex = 25;
            this.OutputDisplay.TabStop = false;
            this.OutputDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // VersionInfo
            // 
            this.VersionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.VersionInfo, 5);
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.VersionInfo.Font = new System.Drawing.Font("Verdana", 8F);
            this.VersionInfo.Location = new System.Drawing.Point(6, 6);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.ReadOnly = true;
            this.VersionInfo.Size = new System.Drawing.Size(266, 24);
            this.VersionInfo.TabIndex = 24;
            this.VersionInfo.TabStop = false;
            this.VersionInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OutputDisplay2
            // 
            this.OutputDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.SetColumnSpan(this.OutputDisplay2, 5);
            this.OutputDisplay2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.OutputDisplay2.Location = new System.Drawing.Point(6, 76);
            this.OutputDisplay2.Name = "OutputDisplay2";
            this.OutputDisplay2.ReadOnly = true;
            this.OutputDisplay2.Size = new System.Drawing.Size(266, 30);
            this.OutputDisplay2.TabIndex = 26;
            this.OutputDisplay2.TabStop = false;
            this.OutputDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalcUI
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(278, 345);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CalcUI";
            this.Text = "Simple Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
            try
            {
                CalcEngine.CalcUnOperation(CalcEngine.Operator.eSqrt);
                OutputDisplay.Text = CalcEngine.CalcEqual();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат!");
            }
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

        protected void KeySqrtKub_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcUnOperation(CalcEngine.Operator.eSqrtKub);
            OutputDisplay.Text = CalcEngine.CalcEqual();
        }

        protected void KeyFact_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcUnOperation(CalcEngine.Operator.eFact);
            OutputDisplay.Text = CalcEngine.CalcEqual();
        }

        protected void KeyBGFact_Click(object sender, System.EventArgs e)
        {
            if (!(OutputDisplay.Text == ""))
            {
                try
                {

                    backgroundWorker1.RunWorkerAsync();
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный формат!");
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            CalcEngine.CalcUnOperation(CalcEngine.Operator.eFact);
            System.Threading.Thread.Sleep(1000);

            //  res.TopMost = true;
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

                standartToolStripMenuItem.Checked = false;
                engineeringToolStripMenuItem.Checked = true;

                this.KeyExponet.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                this.KeyExponet.ForeColor = System.Drawing.Color.Blue;
                this.KeyExponet.Location = new System.Drawing.Point(12, 292);
                this.KeyExponet.Name = "KeyExponet";
                this.KeyExponet.Size = new System.Drawing.Size(this.KeyZero.Size.Width, this.KeyZero.Size.Height);
                this.KeyExponet.TabIndex = 21;
                this.KeyExponet.TabStop = false;
                this.KeyExponet.Text = "^";
                this.KeyExponet.Click += new System.EventHandler(this.KeyExponent_Click);
                this.toolTip1.SetToolTip(KeyExponet, "Exponentiation operation");


                this.KeySqrt.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                this.KeySqrt.ForeColor = System.Drawing.Color.Blue;
                this.KeySqrt.Location = new System.Drawing.Point(60, 292);
                this.KeySqrt.Name = "KeySqrt";
                this.KeySqrt.Size = new System.Drawing.Size(this.KeyZero.Size.Width, this.KeyZero.Size.Height);
                this.KeySqrt.TabIndex = 22;
                this.KeySqrt.TabStop = false;
                this.KeySqrt.Text = "Sqrt";
                this.KeySqrt.Click += new System.EventHandler(this.KeySqrt_Click);
                this.toolTip1.SetToolTip(KeySqrt, "Square root");


                this.KeyInv.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
                this.KeyInv.ForeColor = System.Drawing.Color.Blue;
                this.KeyInv.Location = new System.Drawing.Point(108, 292);
                this.KeyInv.Name = "KeyInv";
                this.KeyInv.Size = new System.Drawing.Size(this.KeyZero.Size.Width, this.KeyZero.Size.Height);
                this.KeyInv.TabIndex = 23;
                this.KeyInv.TabStop = false;
                this.KeyInv.Text = "Inv";
                this.KeyInv.Click += new System.EventHandler(this.KeyInv_Click);
                this.toolTip1.SetToolTip(KeyInv, "Inversion operation");

                this.KeySquar.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                this.KeySquar.ForeColor = System.Drawing.Color.Blue;
                this.KeySquar.Location = new System.Drawing.Point(156, 292);
                this.KeySquar.Name = "KeySquar";
                this.KeySquar.Size = new System.Drawing.Size(this.KeyZero.Size.Width, this.KeyZero.Size.Height);
                this.KeySquar.TabIndex = 24;
                this.KeySquar.TabStop = false;
                this.KeySquar.Text = "Squar";
                this.toolTip1.SetToolTip(KeySquar, "Squaring operation");
                this.KeySquar.Click += new System.EventHandler(this.KeySquar_Click);

                this.KeyFact.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                this.KeyFact.ForeColor = System.Drawing.Color.Blue;
                this.KeyFact.Location = new System.Drawing.Point(204, 292);
                this.KeyFact.Name = "KeyFact";
                this.KeyFact.Size = new System.Drawing.Size(this.KeyEqual.Size.Width, this.KeyEqual.Size.Height);
                this.KeyFact.TabIndex = 25;
                this.KeyFact.TabStop = false;
                this.KeyFact.Text = "!";
                this.toolTip1.SetToolTip(this.KeyFact, "Calculate factorial");
                this.KeyFact.Click += new System.EventHandler(this.KeyFact_Click);


                this.KeySqrtKub.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                this.KeySqrtKub.ForeColor = System.Drawing.Color.Blue;
                this.KeySqrtKub.Location = new System.Drawing.Point(12, 340);
                this.KeySqrtKub.Name = "KeySqrtKub";
                this.KeySqrtKub.Size = new System.Drawing.Size(this.KeyZero.Size.Width, this.KeyZero.Size.Height);
                this.KeySqrtKub.TabIndex = 26;
                this.KeySqrtKub.TabStop = false;
                this.KeySqrtKub.Text = "Sqrt3";
                this.KeySqrtKub.Click += new System.EventHandler(this.KeySqrtKub_Click);
                this.toolTip1.SetToolTip(KeySqrtKub, "Сubic root operation");

                this.KeyBGFact.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
                this.KeyBGFact.ForeColor = System.Drawing.Color.Blue;
                this.KeyBGFact.Location = new System.Drawing.Point(60, 340);
                this.KeyBGFact.Name = "KeyBGFact";
                this.KeyBGFact.Size = new System.Drawing.Size(this.KeyZero.Size.Width, this.KeyZero.Size.Height);
                this.KeyBGFact.TabIndex = 26;
                this.KeyBGFact.TabStop = false;
                this.KeyBGFact.Text = "! in background";
                this.KeyBGFact.Click += new System.EventHandler(this.KeyBGFact_Click);
                this.toolTip1.SetToolTip(KeySqrtKub, "Calculate factorial in backgoung process");



                for (int i = 0; i < 2; i++)
                {
                    this.Size = new System.Drawing.Size(this.Width, this.Height + 50);
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                }

                tableLayoutPanel1.Controls.Add(this.KeyExponet, -1, -1);
                tableLayoutPanel1.Controls.Add(this.KeySqrt, -1, -1);
                tableLayoutPanel1.Controls.Add(this.KeyInv, -1, -1);
                tableLayoutPanel1.Controls.Add(this.KeySquar, -1, -1);
                tableLayoutPanel1.Controls.Add(this.KeyFact, -1, -1);

                tableLayoutPanel1.Controls.Add(this.KeySqrtKub, -1, -1);

                tableLayoutPanel1.Controls.Add(this.KeyBGFact, -1, -1);
                tableLayoutPanel1.SetColumnSpan(this.KeyBGFact, 4);
                this.KeyBGFact.Size = new System.Drawing.Size(tableLayoutPanel1.Width / 5 * 4, this.KeyZero.Size.Height);
            }

        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (engineeringToolStripMenuItem.Checked)
            {
              

                engineeringToolStripMenuItem.Checked = false;
                standartToolStripMenuItem.Checked = true;



                tableLayoutPanel1.Controls.Add(this.KeyExponet, -1, -1);
                tableLayoutPanel1.Controls.Add(this.KeyExponet, -1, -1);
                tableLayoutPanel1.Controls.Add(this.KeySqrt, -1, -1);
                tableLayoutPanel1.Controls.Add(this.KeyInv, -1, -1);
                tableLayoutPanel1.Controls.Add(this.KeySquar, -1, -1);
                tableLayoutPanel1.Controls.Add(this.KeyFact, -1, -1);

                tableLayoutPanel1.Controls.Add(this.KeySqrtKub, -1, -1);

                tableLayoutPanel1.Controls.Add(this.KeyBGFact, -1, -1);
                tableLayoutPanel1.SetColumnSpan(this.KeyBGFact, 4);
                this.KeyBGFact.Size = new System.Drawing.Size(tableLayoutPanel1.Width / 5 * 4, this.KeyZero.Size.Height);

                for (int i = 0; i < 2; i++)
                {
                    tableLayoutPanel1.RowStyles.RemoveAt(tableLayoutPanel1.RowCount-1);
                    this.Size = new System.Drawing.Size(this.Width, this.Height - 50);
                }


            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcRoots calcRoots = new CalcRoots();
            calcRoots.Show();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string result = CalcEngine.CalcEqual();
            Result res = new Result();
            res.result = result;
            res.StartPosition = FormStartPosition.CenterScreen;
            res.TopMost = true;
            res.Show();

        }
    }
}
