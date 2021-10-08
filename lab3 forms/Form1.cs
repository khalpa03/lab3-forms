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
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string word1 = this.word1.Text;
                string word2 = this.word2.Text;
            
                MessageBox.Show(Logic.Compare(word1, word2), "Результат", MessageBoxButtons.OK);
            
        }
       
    }
}
