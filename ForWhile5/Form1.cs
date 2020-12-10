using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForWhile5
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

        private void btn1_Click(object sender, EventArgs e)
        {
            int N1, N2, i;
            N1 = Convert.ToInt32(txt1.Text);
            N2 = Convert.ToInt32(txt2.Text);
            i = N1;

            if (N1 == N2)
            {
                MessageBox.Show("Os números são iguais, o primeiro número deve ser menor que o segundo");
            }           
            while (N1 < N2)
            {
                lbl3.Text=("Os numeros impares entre " + i + " & " + N2 + " são: ");
                if (N1 % 2 != 0)
                {
                  lst1.Items.Add(N1);
                }
                N1++;                   
            }                
            while (N2<N1)
            {
              lbl3.Text = ("Os numeros pares entre " + i + " & " + N2 + " são: ");
              if (N2 % 2 == 0)
              {
                lst1.Items.Add(N2);
              }
              N2++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
            lbl3.Text="";
            txt1.Text = (" ");
            txt2.Text = (" ");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




    
        
    

