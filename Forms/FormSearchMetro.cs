using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_metro_App.Forms
{
    public partial class FormSearchMetro : Form
    {
        public FormSearchMetro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> Dict1 = new Dictionary<string, int>(); //Purple line stations
            Dict1.Add("Baiyappanahalli", 1);
            Dict1.Add("Swami Vivekananda Road", 2);
            Dict1.Add("Indiranagar", 3);
            Dict1.Add("Halasuru", 4);
            Dict1.Add("Trinity", 5);
            Dict1.Add("MG Road", 6);
            Dict1.Add("Cubbon Park", 7);
            Dict1.Add("Vidhan Soudha", 8);
            Dict1.Add("Sir Viswesaraya Station - Central College", 9);
            Dict1.Add("Majestic Station", 10); //Main Station
            Dict1.Add("KSR Railway Station", 11);
            Dict1.Add("Magadi Road", 12);
            Dict1.Add("Hosahalli", 13);
            Dict1.Add("Vijayanagar", 14);
            Dict1.Add("Attiguppe", 15);
            Dict1.Add("Gitanjali Nagar", 16);
            Dict1.Add("Mysore Road", 17);
            Dict1.Add("Nayadanahalli", 18);
            Dict1.Add("Rajarajeshwari", 19);
            Dict1.Add("Jnanabharathi", 20);
            Dict1.Add("Pattanagere", 21);
            Dict1.Add("Kengeri Bus Terminal", 22);
            Dict1.Add("Kengeri", 23);

            Dictionary<string, int> Dict2 = new Dictionary<string, int>(); //Green line stations
            Dict2.Add("Nagasandra", 1);
            Dict2.Add("Dasarahalli", 2);
            Dict2.Add("Jalahalli", 3);
            Dict2.Add("Peenya Industry", 4);
            Dict2.Add("Peenya", 5);
            Dict2.Add("Goraguntepalya", 6);
            Dict2.Add("Yeshwantpur", 7);
            Dict2.Add("Sandal Soap Factory", 8);
            Dict2.Add("Mahalakhsmi", 9);
            Dict2.Add("Rajajinagar", 10);
            Dict2.Add("Mahakavi Kuvempu Road", 11);
            Dict2.Add("Srirampura", 12);
            Dict2.Add("Mantri Square - Sampige Road", 13);
            Dict2.Add("Majestic", 14); //Main Station
            Dict2.Add("Chikpete", 15);
            Dict2.Add("Krishna Rajendra Nagar", 16);
            Dict2.Add("National College", 17);
            Dict2.Add("Lalbagh", 18);
            Dict2.Add("South End Circle", 19);
            Dict2.Add("Jayanagar", 20);
            Dict2.Add("Rashtreeya Vidyalaya Road", 21);
            Dict2.Add("Banashankari", 22);
            Dict2.Add("Jaya Prakash Nagar", 23);
            Dict2.Add("Yelachenahalli", 24);
            Dict2.Add("Konanakunte Cross", 25);
            Dict2.Add("Doddakallasandra", 26);
            Dict2.Add("Vajrahalli", 27);
            Dict2.Add("Thalaghattapura", 28);
            Dict2.Add("Silk Institute", 29);

            string b = comboBox1.Text;
            string d = comboBox2.Text;


            if ((Dict1.ContainsKey(b) == false & Dict2.ContainsKey(b) == false) | (Dict1.ContainsKey(d) == false & Dict2.ContainsKey(d) == false) | b == d)
            {
                MessageBox.Show("Invalid Boarding/Destination Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            List<string> StopList = new List<string>();

            if (Dict1.ContainsKey(b) & Dict1.ContainsKey(d)) //both on purple line
            {
                int n = Dict1[b];
                int m = Dict1[d];

                if (n < m)
                {
                    for (int i = n; i < m; i++)
                    {
                        string h = Dict1.ElementAt(i).Key;
                        StopList.Add(h);
                    }
                }

                if (m < n)
                {
                    for (int i = n; i > m; i--)
                    {
                        string h = Dict1.ElementAt(i - 2).Key;
                        StopList.Add(h);
                    }
                }

                lblSwitch.Visible = false;

            }

            if (Dict2.ContainsKey(b) & Dict2.ContainsKey(d)) // both on green line
            {
                int n = Dict2[b];
                int m = Dict2[d];

                if (n < m)
                {
                    for (int i = n; i < m; i++)
                    {
                        string h = Dict2.ElementAt(i).Key;
                        StopList.Add(h);
                    }
                }

                if (m < n)
                {
                    for (int i = n; i > m; i--)
                    {
                        string h = Dict2.ElementAt(i - 2).Key;
                        StopList.Add(h);
                    }
                }

                lblSwitch.Visible = false;
            }

            if (Dict1.ContainsKey(b) & Dict2.ContainsKey(d)) //boarding from purple line and destination on green line
            {
                int n = Dict1[b];
                int m = 10;

                if (n < m)
                {
                    for (int i = n; i < m; i++)
                    {
                        string h = Dict1.ElementAt(i).Key;
                        StopList.Add(h);
                    }
                }

                if (m < n)
                {
                    for (int i = n; i > m; i--)
                    {
                        string h = Dict1.ElementAt(i - 2).Key;
                        StopList.Add(h);
                    }
                }

                int n2 = 14;
                int m2 = Dict2[d];

                if (n2 < m2)
                {
                    for (int i = n2; i < m2; i++)
                    {
                        string h2 = Dict2.ElementAt(i).Key;
                        StopList.Add(h2);
                    }
                }

                if (m2 < n2)
                {
                    for (int i = n2; i > m2; i--)
                    {
                        string h2 = Dict2.ElementAt(i - 2).Key;
                        StopList.Add(h2);
                    }
                }

                lblSwitch.Visible = true;
            }

            if (Dict2.ContainsKey(b) & Dict1.ContainsKey(d)) //boarding from green line and destination on purple line
            {
                int n = Dict2[b];
                int m = 14;

                if (n < m)
                {
                    for (int i = n; i < m; i++)
                    {
                        string h = Dict2.ElementAt(i).Key;
                        StopList.Add(h);
                    }
                }

                if (m < n)
                {
                    for (int i = n; i > m; i--)
                    {
                        string h = Dict2.ElementAt(i - 2).Key;
                        StopList.Add(h);
                    }
                }


                int n2 = 10;
                int m2 = Dict1[d];

                if (n2 < m2)
                {
                    for (int i = n2; i < m2; i++)
                    {
                        string h2 = Dict1.ElementAt(i).Key;
                        StopList.Add(h2);
                    }
                }

                if (m2 < n2)
                {
                    for (int i = n2; i > m2; i--)
                    {
                        string h2 = Dict1.ElementAt(i - 2).Key;
                        StopList.Add(h2);
                    }
                }
                lblSwitch.Visible = true;
            }

            int counTs = StopList.Count;
            string v = " Stops";
            textBox1.Text = counTs.ToString() + v.ToString();

            listBox1.Items.Clear();
            foreach (var qy in StopList)
            {
                listBox1.Items.Add(qy);
            }

            int price = 0;
            if (counTs == 1)
            {
                price = 9;
            }
            if (counTs == 2)
            {
                price = 14;
            }
            if (counTs == 3)
            {
                price = 18;
            }
            if (counTs > 3)
            {
                price = 18 + 2 * (counTs - 3);
            }
            if (d == "Majestic - Kempegowda Station" | d == "Majestic")
            {
                price += 1;
            }

            string z = " Rs";
            textBox2.Text = price.ToString() + z.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
