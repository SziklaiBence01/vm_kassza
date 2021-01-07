using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SZB_vizsgamunka1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //string connetionString;
            //SqlConnection cnn;

            //connetionString = @"Server=localhost; 
            //                  Database = termekek;
            //                  User ID=root;
            //                  Password=";
                              
            //cnn = new SqlConnection(connetionString);
            //cnn.Open();

            //SqlCommand command;
            //SqlDataReader dataReader;
            //String sql, Output = "";

            //sql = "Select nev,ar from termekek";

            //command = new SqlCommand(sql,cnn);

            //dataReader = command.ExecuteReader();

            //while (dataReader.Read())
            //{
            //    Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            //}
            //MessageBox.Show(Output);
            //cnn.Close();
            //command.Dispose();
            //cnn.Close();


            if (tabControl1.SelectedTab == kezdes)
            {
                tabControl1.SelectedTab = kategoriak;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == kategoriak)
            {
                tabControl1.SelectedTab = termekek;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == kategoriak)
            {
                tabControl1.SelectedTab = termekek;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == kategoriak)
            {
                tabControl1.SelectedTab = termekek;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == kategoriak)
            {
                tabControl1.SelectedTab = termekek;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == kategoriak)
            {
                tabControl1.SelectedTab = termekek;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == kategoriak)
            {
                tabControl1.SelectedTab = termekek;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == kategoriak)
            {
                tabControl1.SelectedTab = termekek;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == kategoriak)
            {
                tabControl1.SelectedTab = termekek;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == kategoriak)
            {
                tabControl1.SelectedTab = termekek;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == kategoriak)
            {
                tabControl1.SelectedTab = termekek;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == kategoriak)
            {
                tabControl1.SelectedTab = termekek;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == kategoriak)
            {
                tabControl1.SelectedTab = termekek;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == termekek)
            {
                tabControl1.SelectedTab = kategoriak;
            }
        }

        private void nev1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(nev1);           
        }

        private void nev2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(nev2);
        }

        private void nev3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(nev3);
        }

        private void nev4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(nev4);
        }

        private void nev5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(nev5);
        }

        private void nev6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(nev6);
        }

        private void nev7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(nev7);
        }

        private void nev8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(nev8);
        }

        private void nev9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(nev9);
        }

        private void nev10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(nev10);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(nev1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(nev2);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(nev3);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(nev4);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(nev5);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(nev6);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(nev7);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(nev8);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(nev9);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(nev10);
        }
    }
}
