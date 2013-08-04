using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TkSchnellschreib
{
    public partial class Form1 : Form
    {

        Random r = new Random();


        string[] words = new string[] { "das", "ist", "ein", "Test", "Thomas", "Igel", "Boot", "um", "zu" };


        public Form1()
        {
            InitializeComponent();
        }

 

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = RandomWord();
            label3.Text = RandomWord();
            label5.Text = RandomWord();
            label6.Text = RandomWord();

        }


        public string RandomWord()
        {
            

            return words[r.Next(0, words.Length - 1)];

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Return)
            {

                label7.Text = label4.Text;
                label7.ForeColor = label4.ForeColor;

                label4.Text = label2.Text;
                label4.ForeColor = label2.ForeColor;

                label2.Text = label1.Text;
                if (textBox1.Text.Trim() == label1.Text)
                {
                    label2.ForeColor = Color.Green;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                }
                label1.Text = label3.Text;

                

                label3.Text = label5.Text;

                

                label5.Text = label6.Text;

                

                label6.Text = RandomWord();




                textBox1.Text = "";

                SetLocations();
            }
        }


        public void SetLocations()
        {
            label1.Location = new Point(panel3.Width / 2 - label1.Width / 2, 0);
            label1.Font = new Font(label1.Font.FontFamily, (int)(panel3.Height * 0.60));

            label3.Location = new Point(panel3.Width / 2 - label1.Width / 2 + label1.Width, 0);
            label3.Font = new Font(label1.Font.FontFamily, (int)(panel3.Height * 0.30));

            label5.Location = new Point(panel3.Width / 2 - label1.Width / 2 + label1.Width + label3.Width, 0);
            label5.Font = new Font(label1.Font.FontFamily, (int)(panel3.Height * 0.15));

            label6.Location = new Point(panel3.Width / 2 - label1.Width / 2 + label1.Width + label3.Width + label5.Width, 0);
            label6.Font = new Font(label1.Font.FontFamily, (int)(panel3.Height * 0.075));
            
            
            label2.Location = new Point(panel3.Width / 2 - label1.Width / 2 - label2.Width, 0);
            label2.Font = new Font(label1.Font.FontFamily, (int)(panel3.Height * 0.30));

            
            label4.Location = new Point(panel3.Width / 2 - label1.Width / 2 - label2.Width - label4.Width, 0);
            label4.Font = new Font(label1.Font.FontFamily, (int)(panel3.Height * 0.15));

            
            label7.Location = new Point(panel3.Width / 2 - label1.Width / 2 - label2.Width - label4.Width - label7.Width, 0);
            label7.Font = new Font(label1.Font.FontFamily, (int)(panel3.Height * 0.075));
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetLocations();
        }

        private void splitContainer1_SplitterMoving(object sender, SplitterCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel5.Width = (int)(panel4.Width * textBox1.Text.Length / label1.Text.Length);
            if (textBox1.Text.Trim().Length <= label1.Text.Length)
            {
                panel5.BackColor = Color.Green;
            }
            else
            {
                panel5.BackColor = Color.Red;
            }
        }





    }
}
