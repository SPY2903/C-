using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KT30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();    
        }

        void Exit()
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)
            {
                Exit();
            }
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.L)
            {
                NEWW();
            }
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.X)
            {
                delete();
            }
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.N)
            {
                SUM();
            }
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.A)
            {
                MAX();
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Exit();
        }

        void Start()
        {
            Sumbutton.Enabled = false;
            Maxbutton.Enabled = false;
            Deletebutton.Enabled = false;
        }

        void NEWW()
        {
            Sumbutton.Enabled = true;
            Maxbutton.Enabled = true;
            Deletebutton.Enabled = true;
        }

        private void Newbutton_Click(object sender, EventArgs e)
        {
            NEWW();
        }

        void addToList()
        {
            bool ok = true;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập điểm", "Thông báo");
                ok = false;
            }
            else
            {
                char[] letters = textBox1.Text.ToCharArray();
                bool check = false;
                for (int i = 0; i < letters.Length; i++)
                {
                    if (!Char.IsDigit(letters[i]) && !Char.IsControl(letters[i]))
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    MessageBox.Show("Điểm không hợp lệ", "Thông báo");
                    ok = false;
                }
                else
                {
                    if (Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox1.Text) > 10)
                    {
                        MessageBox.Show("Điểm không hợp lệ", "Thông báo");
                        ok = false;
                    }
                }
                if (ok)
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            addToList();
            NEWW();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            delete();
        }

        void delete()
        {
            if (listBox1.Items.Count > 0)
            {
                if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn mục để xóa", "Thông báo");
                }
                else
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
            else
            {
                Start();
            }
        }

        void SUM()
        {
            int sum = 0;
            foreach (String s in listBox1.Items)
            {
                sum += Convert.ToInt32(s.ToString());
            }
            labelT.Text = "Tổng : " + sum.ToString();
        }

        void MAX()
        {
            int max = 0;
            foreach (String s in listBox1.Items)
            {
                if (Convert.ToInt32(s.ToString()) > max)
                {
                    max = Convert.ToInt32(s.ToString());
                }
            }
            labelMax.Text = "Max : " + max.ToString();
        }

        private void Sumbutton_Click(object sender, EventArgs e)
        {
            SUM();
        }

        private void Maxbutton_Click(object sender, EventArgs e)
        {
            MAX();
        }
    }
}
