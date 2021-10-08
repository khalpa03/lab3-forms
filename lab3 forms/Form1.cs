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
            string word1;
            string word2;
            try
            {
                word1 = this.word1.Text;
                word2 = this.word2.Text;
                Properties.Settings.Default.word1 = word1;
                Properties.Settings.Default.word2 = word2;
                Properties.Settings.Default.Save();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Logic.Compare(word1, word2) == "")
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(Logic.Compare(word1, word2), "Результат", MessageBoxButtons.OK);
            }
        }

    }
}
