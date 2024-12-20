using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Names2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += Form1_KeyPress;
            this.KeyDown += Form1_KeyDown;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
                lstNames.Items.Add(txtName.Text);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = true;
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.WriteLine($"Событие KeyPress сработало. KeyChar: {e.KeyChar}");

            if (char.IsDigit(e.KeyChar))
            {
                Debug.WriteLine($"Нажата цифра: {e.KeyChar}");
                if (e.KeyChar == '1' || e.KeyChar == '4' || e.KeyChar == '7')
                {
                    label1.Text = $"Вы нажали {e.KeyChar}";
                    e.Handled = true;
                    Debug.WriteLine($"Обработана клавиша: {e.KeyChar}");
                }
            }
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }
        private void button2_Click(object sender, EventArgs e) => 
            Cursor.Position = PointToScreen(button3.Location);
        private void button3_Click(object sender, EventArgs e) => 
            Cursor.Position = PointToScreen(button2.Location);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
