using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yıgın ekle = new Yıgın(15);
            int i;

            for (i = 1; i < 16; i++)
            { ekle.Push(i); }

            Kuyruk kekle = new Kuyruk(15);

            for (i = 1; i < 16; i++)
            { kekle.Insert(i); }

            MessageBox.Show(kekle.Peek().ToString());
            kekle.Remove();
            MessageBox.Show(kekle.Peek().ToString());


           
            for (i = 0; i < 30; i++)
            {
                Random rastgele = new Random();
                int sayi = rastgele.Next(1);
                if (sayi == 0) {
                    int tmp;
                    kekle.Remove();

                   
                    


                }// To do Git ve Üst kattan User Taşı
                

                else { }//To do Git Ve alt kattan kullanıcı seç



            }
            
        }
    }
}
