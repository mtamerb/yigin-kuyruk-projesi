using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamer_bilici_yigin_kuyruk_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class process
        {
            public String gelP;
            public process nextP;
        }
        public process pFirst = null;
        public process pEnd = null;

        // 3 process sınıfımızı olusturalım 

        public class tailP1
        {
            public String gel;
            public tailP1 next;
        }

        public tailP1 firstP1 = null;
        public tailP1 endP1 = null;

        public class tailP2
        {
            public String gel;
            public tailP2 next;
        }
        public tailP2 firstP2 = null;
        public tailP2 endP2 = null;


        public class tailP3
        {
            public String gel;
            public tailP3 next;
        }
        public tailP3 firstP3 = null;
        public tailP3 endP3 = null;



        // stack sınıflarımızı olusturalım

        public class stack1
        {
            public String stack1Gel;
            public stack1 stack1Next;
        }
        public stack1 stack1First = null;
        public stack1 stack1End = null;

        public class stack2
        {
            public String stack2Gel;
            public stack2 stack2Next;
        }
        public stack2 stack2First = null;
        public stack2 stack2End = null;

        public class stack3
        {
            public String stack3Gel;
            public stack3 stack3Next;
        }
        public stack3 stack3First = null;
        public stack3 stack3End = null;



        public void stackAdd1(string value)
        {
            stack1 yeni = new stack1();
            yeni.stack1Gel = value;

            if (stack1First == null)
            {
                stack1First = yeni;
                stack1End = stack1First;
                stack1End.stack1Next = null;
            }

            else
            {
                yeni.stack1Next = stack1First;
                stack1First = yeni;
            }

        }

        public void stackAdd2(string value)
        {
            stack2 yeni = new stack2();
            yeni.stack2Gel = value;

            if (stack2First == null)
            {
                stack2First = yeni;
                stack2End = stack2First;
                stack2End.stack2Next = null;
            }

            else
            {
                yeni.stack2Next = stack2First;
                stack2First = yeni;
            }
        }

        public void stackAdd3(string value)
        {
            stack3 yeni = new stack3();
            yeni.stack3Gel = value;

            if (stack3First == null)
            {
                stack3First = yeni;
                stack3End = stack3First;
                stack3End.stack3Next = null;
            }

            else
            {
                yeni.stack3Next = stack3First;
                stack3First = yeni;
            }
        }


        public void showStack1()
        {
            p1.Items.Clear();
            stack1 gecici;
            gecici = stack1First;

            if (stack1First == null)
            {
                return;
            }

            else
            {
                gecici = stack1First;

                while (gecici.stack1Next != null)
                {
                    p1.Items.Add(gecici.stack1Gel);
                    gecici = gecici.stack1Next;

                }
                p1.Items.Add(gecici.stack1Gel);
            }
        }
        public void showStack2()
        {
            p2.Items.Clear();
            stack2 gecici;
            gecici = stack2First;

            if (stack2First == null)
            {
                return;
            }

            else
            {
                gecici = stack2First;

                while (gecici.stack2Next != null)
                {
                    p1.Items.Add(gecici.stack2Gel);
                    gecici = gecici.stack2Next;

                }
                p1.Items.Add(gecici.stack2Gel);
            }
        }
        public void showStack3()
        {
            p1.Items.Clear();
            stack3 gecici;
            gecici = stack3First;

            if (stack3First == null)
            {
                return;
            }

            else
            {
                gecici = stack3First;

                while (gecici.stack3Next != null)
                {
                    p1.Items.Add(gecici.stack3Gel);
                    gecici = gecici.stack3Next;

                }
                p1.Items.Add(gecici.stack3Gel);
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            timer2.Start();
           
        }

        private void btn_dur_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void tb_islemci_Scroll(object sender, EventArgs e)
        {
            if (tb_islemci.Value == 1)
            {
                timer2.Interval = 1500;
            }
            if (tb_islemci.Value == 2)
            {
                timer2.Interval = 1000;
            }
            if (tb_islemci.Value == 3)
            {
                timer2.Interval = 500;
            }

        }

        private void tb_1_Scroll(object sender, EventArgs e)
        {
            if (tb_1.Value == 0)
            {
                timer1.Stop();
            }
            if (tb_1.Value == 1)
            {
                timer1.Interval = 1500;
                timer1.Start();
            }
            if (tb_1.Value == 2)
            {
                timer1.Interval = 1000;
                timer1.Start();
            }
            if (tb_1.Value == 3)
            {
                timer1.Interval = 500;
                timer1.Start();
            }
            
        }

        private void tb_2_Scroll(object sender, EventArgs e)
        {
           

            if (tb_3.Value == 0)
            {
                timer4.Stop();
            }
            if (tb_3.Value == 1)
            {
                timer4.Interval = 1500;
                timer4.Start();
            }
            if (tb_3.Value == 2)
            {
                timer4.Interval = 1000;
                timer4.Start();
            } if (tb_3.Value == 3)
            {
                timer4.Interval = 500;
                timer4.Start();
            } 
        }

        private void tb_3_Scroll(object sender, EventArgs e)
        {
            if (tb_2.Value == 0)
            {
                timer3.Stop();
            }
            if (tb_2.Value == 1)
            {
                timer3.Interval = 1500;
                timer3.Start();
            }
            if (tb_2.Value == 2)
            {
                timer3.Interval = 1000;
                timer3.Start();
            } if (tb_2.Value == 3)
            {
                timer3.Interval = 500;
                timer3.Start();
            }
        }

        static Random random = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {

            int randomSayi = random.Next(8);

            tailP1 yeni = new tailP1();
            yeni.gel = "P1 -> " + randomSayi;

            if (firstP1 == null)
            {
                firstP1 = yeni;
                endP1 = firstP1;
                endP1.next = null;
            }
            else
            {
                endP1.next = yeni;
                yeni.next = null;
                endP1 = yeni;
            }

            showP1();

        }

        public void showP1()
        {
            listBox1.Items.Clear();
            tailP1 gecici;
            if (firstP1 == null)
            {
                return;
            }
            else
            {
                gecici = firstP1;
                while (gecici.next != null)
                {
                    listBox1.Items.Add(gecici.gel);
                    gecici = gecici.next;
                }
                listBox1.Items.Add(gecici.gel);
            }
        }
        public void showP2()
        {
            listBox2.Items.Clear();
            tailP2 gecici;
            if (firstP2 == null)
            {
                return;
            }
            else
            {
                gecici = firstP2;
                while (gecici.next != null)
                {
                    listBox2.Items.Add(gecici.gel);
                    gecici = gecici.next;
                }
                listBox2.Items.Add(gecici.gel);
            }
        }
        public void showP3()
        {
            listBox3.Items.Clear();
            tailP3 gecici;
            if (firstP3 == null)
            {
                return;
            }
            else
            {
                gecici = firstP3;
                while (gecici.next != null)
                {
                    listBox3.Items.Add(gecici.gel);
                    gecici = gecici.next;
                }
                listBox3.Items.Add(gecici.gel);
            }
        }

        public void showProcess()
        {
            textBox1.Text = null;
            process gecici;
            if (pFirst == null)
            {
                return;
            }
            else
            {
                gecici = pFirst;
                while (gecici.nextP != null)
                {
                    textBox1.Text += gecici.gelP + " -> ";
                    gecici = gecici.nextP;
                }

                textBox1.Text  += gecici.gelP + " -> ";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (firstP1 == null)
            {

            }
            else
            {
                process yeni = new process();
                yeni.gelP = firstP1.gel;
                if (pFirst == null)
                {
                    pFirst = yeni;
                    pEnd = pFirst;
                    pEnd.nextP = null;
                }
                else
                {
                    pEnd.nextP = yeni;
                    yeni.nextP = null;
                    pEnd = yeni;
                }
                stackAdd1(firstP1.gel);
                firstP1 = firstP1.next;
            }
            showProcess();
            showP1();


            if (firstP2 == null)
            {

            }
            else
            {
                process yeni = new process();
                yeni.gelP = firstP2.gel;
                if (pFirst == null)
                {
                    pFirst = yeni;
                    pEnd = pFirst;
                    pEnd.nextP = null;
                }
                else
                {
                    pEnd.nextP = yeni;
                    yeni.nextP = null;
                    pEnd = yeni;
                }
                stackAdd2(firstP2.gel);
                firstP2 = firstP2.next;
            }
            showProcess();
            showP2();

            if (firstP3 == null)
            {

            }
            else
            {
                process yeni = new process();
                yeni.gelP = firstP3.gel;
                if (pFirst == null)
                {
                    pFirst = yeni;
                    pEnd = pFirst;
                    pEnd.nextP = null;
                }
                else
                {
                    pEnd.nextP = yeni;
                    yeni.nextP = null;
                    pEnd = yeni;
                }
                stackAdd3(firstP3.gel);
                firstP3 = firstP3.next;
            }
            showProcess();
            showP3();
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                showStack1();
            }
            if (checkBox2.Checked == true)
            {
                showStack2();
            }
            if (checkBox3.Checked == true)
            {
                showStack3();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int randomSayi = random.Next(8);

            tailP2 yeni = new tailP2();
            yeni.gel = "P2 -> " + randomSayi;

            if (firstP2 == null)
            {
                firstP2 = yeni;
                endP2 = firstP2;
                endP2.next = null;
            }
            else
            {
                endP2.next = yeni;
                yeni.next = null;
                endP2 = yeni;
            }

            showP2();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int randomSayi = random.Next(8);

            tailP3 yeni = new tailP3();
            yeni.gel = "P3 -> " + randomSayi;

            if (firstP3 == null)
            {
                firstP3 = yeni;
                endP3 = firstP3;
                endP3.next = null;
            }
            else
            {
                endP3.next = yeni;
                yeni.next = null;
                endP3 = yeni;
            }

            showP3();
        }



    }
}


