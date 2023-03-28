using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HelpDeskAi
{
    public partial class Form5 : Form
    {
        //Fields
        private int borderSize = 2;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
                               //Constructor
        public Form5()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(98, 102, 244);//Border color
        }
       
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {

        }


        private void Form5_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

    private void CollapseMenu()
    {
        if (this.panelMenu.Width > 200) //Collapse menu
        {
            panelMenu.Width = 75;

            panelMenu.Dock = DockStyle.Left;
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                menuButton.Text = "";
                menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                menuButton.Padding = new Padding(0);
            }
        }
        else
        { //Expand menu
            panelMenu.Width = 230;

            panelMenu.Dock = DockStyle.Left;
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                menuButton.Text = "  " + menuButton.Tag.ToString();
                menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                menuButton.Padding = new Padding(10, 0, 0, 0);
            }
        }
    }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }


       

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string nöbetciad = textBox2.Text;
            textBox9.Text = nöbetciad;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string nöbetcisoyad = textBox6.Text;
            textBox10.Text = nöbetcisoyad;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string nöbetcinum = textBox7.Text;
            textBox11.Text = nöbetcinum;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                textBox12.Text = "9/A";
            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                textBox12.Text = "9/B";
            }
            else if (this.comboBox1.SelectedIndex == 2)
            {
                textBox12.Text = "9/C";
            }
            else if (this.comboBox1.SelectedIndex == 3)
            {
                textBox12.Text = "9/D";
            }
            else if (this.comboBox1.SelectedIndex == 4)
            {
                textBox12.Text = "10/A";
            }
            else if (this.comboBox1.SelectedIndex == 5)
            {
                textBox12.Text = "10/B";
            }
            else if (this.comboBox1.SelectedIndex == 6)
            {
                textBox12.Text = "10/C";
            }
            else if (this.comboBox1.SelectedIndex == 7)
            {
                textBox12.Text = "10/D";
            }
            else if (this.comboBox1.SelectedIndex == 8)
            {
                textBox12.Text = "11/A";
            }
            else if (this.comboBox1.SelectedIndex == 9)
            {
                textBox12.Text = "11/B";
            }
            else if (this.comboBox1.SelectedIndex == 10)
            {
                textBox12.Text = "11/C";
            }
            else if (this.comboBox1.SelectedIndex == 11)
            {
                textBox12.Text = "11/D";
            }
            else if (this.comboBox1.SelectedIndex == 12)
            {
                textBox12.Text = "12/A";
            }
            else if (this.comboBox1.SelectedIndex == 13)
            {
                textBox12.Text = "12/B";
            }
            else if (this.comboBox1.SelectedIndex == 14)
            {
                textBox12.Text = "12/C";
            }
            else if (this.comboBox1.SelectedIndex == 15)
            {
                textBox12.Text = "12/D";
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox13.Text = "Veriler Kaydedildi";
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
