using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.FileName;
            }
           
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            
            
        }

        private void mediaplayer_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label13.Text = mediaplayer.Ctlcontrols.currentPositionString.ToString();
            
            if (label13.Text == textBox2.Text )
            {
                mediaplayer.Ctlcontrols.currentPosition += Convert.ToInt32(textBox3.Text);
            }
            
            }

        private void button3_Click(object sender, EventArgs e)
        {
           
            mediaplayer.URL = textBox1.Text;
            timer1.Enabled = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mediaplayer.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mediaplayer.Ctlcontrols.pause();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mediaplayer.Ctlcontrols.stop();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            mediaplayer.settings.volume -= 20; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            mediaplayer.settings.volume += 20;
        }
    }
    }

