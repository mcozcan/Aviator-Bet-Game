using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace aviator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static  double kasa = 100000.0;
        public static double bakiye = 1000.0;
        public static int bahismiktari = 0;
        public static int sayi = 0;
        public static int sayi2 = 0;
        public static int status = 0;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
         
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 100;
            double deger2 = progressBar1.Value;
            deger2 =  (deger2 / 100);
            deger2  = Math.Round(deger2, 2);
            label7.Text = "" + deger2;
            label6.Text = "" + bakiye;
            label5.Text = "" + kasa;

            
           
            progressBar1.Maximum = 1000;

            
            progressBar1.Increment(1);
           

            if (progressBar1.Value == sayi)
            {
                button3.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = false;
                button2.Visible = true;
                pictureBox1.Location = new Point(182, 114);
                progressBar1.Value = 100;
                if (status == 0)
                {


                    


                }
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var psi = new ProcessStartInfo
            {
                FileName = "https://linktr.ee/mcozcan",
                UseShellExecute = true,
            };
            
            Process.Start(psi);
            
            timer1.Interval = 20; //0.5 saniye
            timer2.Interval = 60; //0.5 saniye
            backgroundWorker1.RunWorkerAsync();
       
            label6.Text = "" + bakiye;
            label5.Text = "" + kasa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kasa < 0)
            {
                MessageBox.Show("Kasayı bitirdin oC yeter! ! ! ! ");
            }

            status = 0;
            button2.Visible = false;
            bahismiktari = Convert.ToInt32(textBox2.Text);
            if  (bakiye < 1)
            {
                MessageBox.Show("Paran bitmiş siktir git");
               
            } 

            else
            {
                if (bakiye < bahismiktari)
                {
                    MessageBox.Show("Paran Kadar oyna amınakodum badigarları çağırtma bana");
                    button2.Visible = true;
                }

                else
                {

                    kasa = kasa + bahismiktari;
                    bakiye = bakiye - bahismiktari;
                    pictureBox1.Location = new Point(182, 114);



                    
                    Random rastgele = new Random();

                    sayi2 = rastgele.Next(1, 10);
                 
                    if(sayi2 == 1 || sayi2 == 2 || sayi2 == 3)
                    {
                        sayi = rastgele.Next(100, 199);

                    }

                    if (sayi2 == 4 || sayi2 == 5 || sayi2 == 6)
                    {
                        sayi = rastgele.Next(100, 299);

                    }

                    if (sayi2 == 7)
                    {


                        sayi = rastgele.Next(100, 599);


                    }

                    if (sayi2 == 8)
                    {


                        sayi = rastgele.Next(100, 799);


                    }

                    if (sayi2 == 9)
                    {
                    
                        
                            sayi = rastgele.Next(100, 999);
                        

                    }
                    


                   

                 


                    timer1.Enabled = true;
                    timer2.Enabled = true;
                    button3.Visible = true;

                    
                }
            }



           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            double oran = progressBar1.Value;
            double oran2 = oran / 100;
            bakiye = bakiye + (bahismiktari * (oran2));
            kasa = kasa - bahismiktari*oran2;
            status = 1;
            label12.Text = "" + oran2;
            timer1.Interval = 10; //0.5 saniye
            timer2.Interval = 30; //0.5 saniye


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            ff.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 1, 114);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            kasa = 100000;
            bakiye = 1000;
            label6.Text = "" + bakiye;
            label5.Text = "" + kasa;
            timer1.Interval = 20; //0.5 saniye
            timer2.Interval = 60; //0.5 saniye
        }
    }
}
