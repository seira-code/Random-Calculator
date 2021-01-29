using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // пре лоад
        {
            Random rand = new Random();
            chislo1.Text = rand.Next(0, 1000).ToString();
            chislo2.Text = rand.Next(0, 1000).ToString();
            Reset.Location = new Point(700, 700);

            checker();
        }

        void checker()
        {
            if (plus.Text == "-")
            {
                int ypor1 = int.Parse(chislo1.Text);
                int ypor2 = int.Parse(chislo2.Text);

                if (ypor1 > ypor2)
                {
                    chislo1.Text = ypor1 + "";
                    chislo2.Text = ypor2 + "";
                }
                else
                {
                    chislo1.Text = ypor2 + "";
                    chislo2.Text = ypor1 + "";
                }
            }
        }

        public void etoravno_Click(object sender, EventArgs e) // кнопка равно
        {
            if (plus.Text == "+")
            {
                int sum;
                int chsl1 = int.Parse(chislo1.Text);
                int chsl2 = int.Parse(chislo2.Text);
                sum = chsl1 + chsl2;
                summa.Text = sum.ToString();
                Reset.Location = new Point(221, 170);
                MessageBox.Show("Вот ответ :)");
            };

            if (plus.Text == "-")
            {
                int sum;
                int chsl1 = int.Parse(chislo1.Text);
                int chsl2 = int.Parse(chislo2.Text);

                if (chsl1 > chsl2) { sum = chsl1 - chsl2; }
                else { sum = chsl2 - chsl1; }

                summa.Text = sum.ToString();
                Reset.Location = new Point(221, 170);
                MessageBox.Show("Вот ответ :)");
            };

            if (plus.Text == "*")
            {
                int sum;
                int chsl1 = int.Parse(chislo1.Text);
                int chsl2 = int.Parse(chislo2.Text);
                sum = chsl1 * chsl2;
                summa.Text = sum.ToString();
                Reset.Location = new Point(221, 170);
                MessageBox.Show("Вот ответ :)");
            };


        }

        private void Reset_Click(object sender, EventArgs e) // кнопка ресет
        {
            summa.Text = "";
            Reset.Location = new Point(700, 700);

            Random rand = new Random();
            chislo1.Text = rand.Next(0, 1000).ToString();
            chislo2.Text = rand.Next(0, 1000).ToString();

            checker();

        }

        private void plus1_Click(object sender, EventArgs e)
        {
            plus.Text = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            plus.Text = "-";
            checker();
        }

        private void ymnoj_Click(object sender, EventArgs e)
        {
            plus.Text = "*";
        }

        private void randomchik_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            chislo1.Text = rand.Next(0, 1000).ToString();
            chislo2.Text = rand.Next(0, 1000).ToString();

            checker();
        }

        
    }
}
