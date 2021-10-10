using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_forms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            word1.Text = Properties.Settings.Default.word1.ToString();
            word2.Text = Properties.Settings.Default.word2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               string word1 = this.word1.Text;
               string word2 = this.word2.Text;
                Properties.Settings.Default.word1 = word1;
                Properties.Settings.Default.word2 = word2;
                Properties.Settings.Default.Save();
            if (Logic.Compare(word1, word2) == "")
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(Logic.Compare(word1, word2), "Результат", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            word1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            word2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Даны два слова. Для каждой буквы первого слова определить, входит ли она во второе слово. Повторяющиеся буквы первого слова не рассматривать. Например, если заданные слова процессор и информация, то для букв первого из них ответом должно быть: нет да да да нет нет.", "Задача");
        }

        private void word1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                word2.Focus();
            }
        }

        private void word2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
