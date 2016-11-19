using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDownTImer
{
    public partial class Form1 : Form
    {
        //Made By: Filipe Amaral


        public Form1()
        {
            InitializeComponent();

        }

        private void btn_start_Click(object sender, EventArgs e)
        {

            if (txt_min.Text == "" || txt_hour.Text == "")
            {
                MessageBox.Show("Empty box", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                int minInt;
                int hourInt;

                if (!int.TryParse(txt_min.Text, out hourInt) || !int.TryParse(txt_hour.Text, out minInt))
                {
                    MessageBox.Show("This is a number only field", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    String min = txt_min.Text;
                    String hour = txt_hour.Text;
                    bool finishWhile = true;
                    do
                    {

                        DateTime d1 = DateTime.Now;

                        if (d1.Minute.ToString() == min && d1.Hour.ToString() == hour)
                        {
                            finishWhile = false;
                            this.Show();
                            Process.Start("shutdown", "/s /t 5");
                        }
                        else
                        {
                            this.Hide();
                            Thread.Sleep(1000);
                        }

                    } while (finishWhile != false);
                }

            }
        }


    }
}
