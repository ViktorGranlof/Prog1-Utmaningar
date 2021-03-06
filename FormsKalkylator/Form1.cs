﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormKalkylator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
        float tal1;
        int calc;
        
        public void calculate()
        {
            float summa = 0; //Ger float variabeln summa ett värde av 0, viktigt att det är float för att kunna använda decimaler...
            float tal2;     //Skapar en variabel tal2
            float.TryParse(txtBox.Text, out tal2); //Försöker att konvertera det som står i txtBox till float och sätta in det värdet i tal2
            txtBox.Text = ""; //Sätter txtBox texten till ingenting eftersom det är tomt i ""
            if (calc == 1) //Utför uträkningen beroende på vilken siffra från 1 till 4 som användaren skrivit in.
            {
                summa = tal1 / tal2; //Division
            }
            else if (calc == 2)
            {
                summa = tal1 - tal2; //Subtraktion
            }
            else if (calc == 3)
            {
                summa = tal1 + tal2; //Addition
            }
            else if (calc == 4)
            {
                summa = tal1 * tal2; //Multiplikation
            }
            tal1 = summa; 
            txtBox.Text = summa.ToString();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            calculate(); //Anropar calculate metoden
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calc = 1;
            float.TryParse(txtBox.Text, out tal1);
            txtBox.Text = "";
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)   // Ger alla sifferknappar ett värde som skrivs ut 
        {
            txtBox.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBox.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBox.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBox.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBox.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBox.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBox.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBox.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBox.Text += "0";
        }

        // Rensar rutan 
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            float.TryParse(txtBox.Text, out tal1);
            txtBox.Text = "";
            calc = 2;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float.TryParse(txtBox.Text, out tal1);
            txtBox.Text = "";
            calc = 3;
            
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            txtBox.Text += ",";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float.TryParse(txtBox.Text, out tal1);
            txtBox.Text = "";
            calc = 4;
        }
    }
}
