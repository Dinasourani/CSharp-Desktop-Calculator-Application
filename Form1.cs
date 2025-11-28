using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        decimal n1, n2;
        char op;
        public Form1()
        {

            InitializeComponent();
            int x = 0;
            textBox1.Text = x.ToString();

        }

        private void btnplass_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(textBox1.Text);
            op = '+';
            textBox1.Text = "0";
        }

        private void btnz_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(textBox1.Text);
            op = '*';
            textBox1.Text = "0";
        }

        private void btnmines_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(textBox1.Text);
            op = '-';
            textBox1.Text = "0";
        }

        private void btnt_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(textBox1.Text);
            op = '/';
            textBox1.Text = "0";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case '+':
                    n2 = int.Parse(textBox1.Text);
                    textBox1.Text = (n1 + n2).ToString();
                    listBox1.Items.Add(n1.ToString() + "+" + n2.ToString() + "=" + (n1 + n2).ToString());
                    break;
                case '*':
                    n2 = int.Parse(textBox1.Text);
                    textBox1.Text = (n1 * n2).ToString();
                    listBox1.Items.Add(n1.ToString() + "*" + n2.ToString() + "=" + (n1 * n2).ToString());
                    break;
                case '-':
                    n2 = int.Parse(textBox1.Text);
                    textBox1.Text = (n1 - n2).ToString();
                    listBox1.Items.Add(n1.ToString() + "-" + n2.ToString() + "=" + (n1 - n2).ToString());
                    break;
                case '/':
                    n2 = int.Parse(textBox1.Text);
                    textBox1.Text = (n1 / n2).ToString();
                    listBox1.Items.Add(n1.ToString() + "/" + n2.ToString() + "=" + (n1 / n2).ToString());
                    break;
                default:
                    break;
            }
        }

        private void btnclearall_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            listBox1.Items.Clear();
            n1 = 0;
            n2 = 0;
            op = ' ';
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            if (value.Length > 0)
                textBox1.Text = value.Remove(value.Length - 1, 1);
        }

        private void number_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null)
                return;
            string num = btn.Text;
            if (textBox1.Text == "0")
                textBox1.Text = num;
            else
                textBox1.Text += num;
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button btn1 = (Button)c;

                    btn1.FlatStyle = FlatStyle.Flat;
                    btn1.FlatAppearance.BorderSize = 0;
                    btn1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    btn1.FlatAppearance.MouseOverBackColor = Color.Pink;
                    btn1.FlatAppearance.MouseDownBackColor = Color.Pink;
                    btn1.BackColor = Color.Transparent;
                }
            }

        }

        private void btnoprator(object sender, EventArgs e)
        {
            Button oprator = sender as Button;
            if (oprator == null)
                return;
            string opu = oprator.Text;
            n1 = decimal.Parse(textBox1.Text);
            op = char.Parse(opu);
            textBox1.Text = "0";
        }

        private void textBox1_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_mousd(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
                btn.BackColor = Color.Red;
        }

        private void btn1_MeU(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
                btn.BackColor = SystemColors.Control;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //font and sixe textbox
            textBox1.Size = new Size(200, 100);
            textBox1.Font = new Font("Segoe UI",20, FontStyle.Bold);

            //font listbox
            listBox1.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // text form
            this.Text = "Calculator";
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;

                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    btn.FlatAppearance.MouseOverBackColor = Color.Pink;
                    btn.FlatAppearance.MouseDownBackColor = Color.Pink;
                    btn.BackColor = Color.Transparent;
                }
             }
            
        }
    }
}
