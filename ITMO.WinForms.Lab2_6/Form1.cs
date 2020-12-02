using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinForms.Lab2_6
{

    public partial class Form1 : Form
    {

        List<Item> its = new List<Item>();
        uint invNumber = 1;


        public Form1()
        {
            InitializeComponent();
            checkBox2.Checked = false;
        }

        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string volume // Том
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }

        public string Title // Название
        {
            get
            {
                if (this.tabControl1.SelectedIndex == 0)
                {
                    return textBox3.Text;
                }
                else
                {
                    return textBox5.Text;
                }
            }
            set
            {
                if (this.tabControl1.SelectedIndex == 1)
                {
                    textBox3.Text = value; ;
                }
                else
                {
                    textBox5.Text = value; ;
                }
            }
        }

        public int number // Номер
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }


        public string PublishHouse // Издательство
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get
            {
                if (this.tabControl1.SelectedIndex == 0)
                {
                    return (int)numericUpDown2.Value;
                }
                else
                {
                    return (int)numericUpDown6.Value;
                }
            }
            set
            {
                if (this.tabControl1.SelectedIndex == 1)
                {
                    numericUpDown2.Value = value;
                }
                else
                {
                    numericUpDown6.Value = value;
                }
            }
        }
        public int InvNumber // Инвентарный номер
        {
            get
            {
                if (this.tabControl1.SelectedIndex == 0)
                {
                    return (int)numericUpDown3.Value;
                }
                else
                {
                    return (int)numericUpDown5.Value;
                }
            }
            set
            {
                if (this.tabControl1.SelectedIndex == 1)
                {
                    numericUpDown3.Value = value;
                }
                else
                {
                    numericUpDown5.Value = value;
                }
            }
        }
        public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }

        public bool taken // Вернуть
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public int PeriodUse // Срок пользования
        {
            get { return (int)numericUpDown4.Value; }

            set { numericUpDown4.Value = value; }
        }

        public int PeriodSub // Срок подписки
        {
            get { return (int)numericUpDown8.Value; }

            set { numericUpDown8.Value = value; }
        }

        public bool Ifsubs // Наличие
        {
            get { return checkBox6.Checked; }
            set { checkBox6.Checked = value; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
            {
                Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
                if (ReturnTime)
                {
                    b.ReturnSrok();
                }

                b.PriceBook(PeriodUse);
                its.Add(b);
                Author = Title = PublishHouse = "";
                Page = InvNumber = PeriodUse = 0;
                Year = 0;
                Existence = ReturnTime = false;
                InvNumber = (int)this.invNumber;
                this.invNumber++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
            {
                its.Sort();
            }

            StringBuilder sb = new StringBuilder();
            if (this.tabControl1.SelectedIndex == 0)
            {
                
                
                foreach (Item item in its)
                {

                    if (item is Book)
                    {
                        sb.Append("\n" + item.ToString());
                    }    
                 
                }
                richTextBox1.Text = sb.ToString();
            }

            if (this.tabControl1.SelectedIndex == 1)
            {


                foreach (Item item in its)
                {

                    if (item is Magazine)
                    {
                        sb.Append("\n" + item.ToString());
                    }

                }
                richTextBox1.Text = sb.ToString();
            }

        }





        private void button3_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 1)
            {
                Magazine m = new Magazine(volume, number, Title, Year, invNumber, taken);
                if (taken)
                {
                    m.Return();
                }
                if (Ifsubs) 
                {
                    m.PeriodSub = PeriodSub;
                    m.Subs();
                }
               
                its.Add(m);
                volume = Title = "";
                number = InvNumber  = 0;
                Year = PeriodSub = 0;
                taken = false;
                InvNumber = (int)this.invNumber;
                this.invNumber++;
            }
        }
   }
}