using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // x=20 -> X=10100
        // y=30 -> Y=11110

        // STEP 1: X=X^Y =01010   x şuan 01010 yani x=10
        // STEP 2: Y=X^Y =10100   y şuan 10100 yani y=20 bu adımda y x'in değerini almış oldu.
        // STEP 3: X=X^Y =11110   x şuan 11110 yani x=30 bu adımda x y'nin değerini aldı.
        


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);

                x = x ^ y;
                y = x ^ y;
                x = x ^ y;
                textBox3.Text = x.ToString();
                textBox4.Text = y.ToString();
            }
            
             catch (Exception)
            {

                MessageBox.Show("Lütfen doğru değerler girin..");
            }

        }

        
    }
}
