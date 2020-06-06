using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace lab_6_sharp_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread t1 = new Thread(Run1);
            t1.Start();
            t1.Join(100);           
            Thread t2 = new Thread(Run2);
            t2.Start();
            t2.Join(100);
            Thread t3 = new Thread(Run2);
            t3.Start();
            t3.Join(100);
        }

        Random r = new Random();
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Run1();
            Run2();
            Run3();
        }
        public void Run1()
        {
          GreenBox.Left += r.Next(10,30);
          if (GreenBox.Left > 500)
              timer1.Stop();
        }
        public void Run2()
        {
            BlueBox.Left += r.Next(10, 30);
            if (BlueBox.Left > 500)
                timer1.Stop();
        }
        public void Run3()
        {
            GoldBox.Left += r.Next(10, 30);
            if (GoldBox.Left > 500)
                timer1.Stop();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void Dropping(object sender, EventArgs e)
        {
            GoldBox.Location = new Point(0, 50);
            BlueBox.Location = new Point(0, 50);
            GreenBox.Location = new Point(0, 50);
            timer1.Stop();
        }

    }
}
