using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double num1 = 0; double num2 = 0;
        char ope;
        bool rep = false;
        public Form1()
        {
            InitializeComponent();
            mostrar_estandar();
        }

        private void aggnum(object sender, EventArgs e)
        {
            // (Presionar ceros)

            var boton = ((Button)sender);
            if (textBox4.Text == "0")
                textBox4.Text = "";
            textBox4.Text += boton.Text;
        }

        private void oper(object sender, EventArgs e)
        {
            // (Operadores)

            var boton = ((Button)sender);
            num1 = Convert.ToDouble(textBox4.Text);
            ope = Convert.ToChar(boton.Tag);
            if(ope== '√')
            {
                num1 = Math.Sqrt(num1);
                textBox4.Text = num1.ToString();

                rep = true;

                repetir(sender, e);

            }
            else {

                rep = true;

                repetir(sender, e);
                textBox4.Text = "0";
            }

                }



        public void mostrar_estandar()
        {
            panel9.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            Size = new Size(350, 410);
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }
        private void estándarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar_estandar();
        }


        private void científicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            Size = new Size(678, 410);
        }

        private void programadorToolStripMenuItem_Click(object sender, EventArgs e)
        {  panel5.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            Size = new Size(678, 410);
            panel3.Visible = false;
            panel4.Visible = false;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = false;
        }

        private void repetir (object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (rep)
            {
                textBox1.Text = num1.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // (=)

            num2 = Convert.ToDouble(textBox4.Text);
            
            if (ope == '+')
            {
                textBox4.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(textBox4.Text);
            }
            else if (ope == '-')
            {
                textBox4.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(textBox4.Text);
            }
            else if (ope == '*')
            {
                textBox4.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(textBox4.Text);
            }
            else if (ope == '/')
            {
                textBox4.Text = (num1 / num2).ToString();
                num1 = Convert.ToDouble(textBox4.Text);
            }

            rep = true;

            repetir(sender, e);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // (C)

            num1 = 0;
            num2 = 0;
            ope = '\0';
            textBox4.Text = "0";
            textBox1.Text = "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            // (CE)

            textBox4.Text = "0";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // (,)

            if (!textBox4.Text.Contains(","))
            {
                textBox4.Text += ",";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // (+-)

            num1 = Convert.ToDouble(textBox4.Text);
            num1 *= -1;
            textBox4.Text = num1.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void conversiónDeUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            Size = new Size(678, 410);
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
