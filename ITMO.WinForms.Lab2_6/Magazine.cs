using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITMO.WinForms.Lab2_6
{
    class Magazine : Item, IPubs
    {
        private String volume;    // том
        private int number;        // номер
        private String title;       // название
        private int year;      // дата выпуска
        private double cost;
        private static double price = 3;
        

        public bool IfSubs { get; set; } // подписка на журнал
        public int PeriodSub { get; set; } // подписка на журнал
        public Magazine(String volume, int number, String title, int year, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }


        public override void Return()    // операция "вернуть"
        {
            taken = true;
        }

        // реализация интерфейса



        public void Subs()
        {
            if (IfSubs)
            {
                this.cost = PeriodSub * price * 0.13;
            }
            else
            {
                this.Return();
            }
        }

        public static void SetPrice(double price)
        {
            Magazine.price = price;
        }
        public override string ToString()
        {
            if (IfSubs)
                return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
                "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка оформлена";
            else
                return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
            "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка не оформлена"; ;
        }
    }
}
