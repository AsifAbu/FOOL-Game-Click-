using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click
{
    public partial class Form1 : Form
    {
        List<Button> button = new List<Button>();
        int sc = 0;
        int check;
        int t = 1300;
        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.Blue)
            {
                sc = sc + 10;
            }
            else
            {
                sc = sc - 10;
            }

            score.Text = sc.ToString();

        }

        public void makeBlue()
        {

            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            button9.BackColor = Color.Red;
            button10.BackColor = Color.Red;

            check = ran.Next(1, 10);
            if (check == Convert.ToInt32(button1.Tag))
            {
                button1.BackColor = Color.Blue;
                timer1.Interval = t;

            }

            if (check == Convert.ToInt32(button2.Tag))
            {

                button2.BackColor = Color.Blue;
                timer1.Interval = t;

            }

            if (check == Convert.ToInt32(button3.Tag))
            {
                button3.BackColor = Color.Blue;
                timer1.Interval = t;

            }

            if (check == Convert.ToInt32(button4.Tag))
            {
                button4.BackColor = Color.Blue;
                timer1.Interval = t;

            }

            if (check == Convert.ToInt32(button5.Tag))
            {
                button5.BackColor = Color.Blue;
                timer1.Interval = t;

            }


            if (check == Convert.ToInt32(button6.Tag))
            {
                button6.BackColor = Color.Blue;
                timer1.Interval = t;

            }

            if (check == Convert.ToInt32(button7.Tag))
            {
                button7.BackColor = Color.Blue;
                timer1.Interval = t;

            }

            if (check == Convert.ToInt32(button8.Tag))
            {
                button8.BackColor = Color.Blue;
                timer1.Interval = t;

            }

            if (check == Convert.ToInt32(button9.Tag))
            {
                button9.BackColor = Color.Blue;
                timer1.Interval = t;

            }

            if (check == Convert.ToInt32(button10.Tag))
            {
                button10.BackColor = Color.Blue;
                timer1.Interval = t;

            }
}
       private void timer1_Tick(object sender, EventArgs e)
        {

            makeBlue();

        }
    }
}
