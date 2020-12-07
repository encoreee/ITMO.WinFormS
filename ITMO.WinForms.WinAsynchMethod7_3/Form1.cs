﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinForms.WinAsynchMethod7_3
{
    public partial class Form1 : Form
    {
        String str;
        private delegate int AsyncSumm(int a, int b);
        delegate void PrintLabel(string str);
        private PrintLabel PrintDlegateFunc;

        public Form1()
        {
            InitializeComponent();
            PrintDlegateFunc = new PrintLabel(PrintFunc);
            
        }

        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(1000);
            int sum = a + b;
            str = sum.ToString();
            lblResult.Invoke(PrintDlegateFunc, new object[] { str });
            return sum;
        }

        private void btnRun_Click(object sender, System.EventArgs e)
        {
            int a, b;
            try
            {
                // Преобразование типов данных.
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                txbA.Text = txbB.Text = "";
                return;
            }
            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);
            summdelegate.BeginInvoke(a, b, cb, summdelegate);
            
        }

        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("Сумма введенных чисел равна {0}", summdelegate.EndInvoke(ar));
            MessageBox.Show(str, "Результат операции");
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работа кипит!!!");
        }

        void PrintFunc(string str)
        {
            lblResult.Text = str;
        }


        private async Task<int> Subb(int a, int b)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(1000);
                return a - b;
            }
            );
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                txbA.Text = txbB.Text = "";
                return;
            }
            int res = await Subb(a, b);
            lblResult.Text = res.ToString();
            MessageBox.Show(res.ToString(), "Результат операции");
        }

       
    }
}
