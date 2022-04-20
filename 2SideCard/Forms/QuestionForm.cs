using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SideCard
{
    public partial class QuestionForm : Form
    {
        public QuestionForm(string question)
        {
            InitializeComponent();
            labelQuest.Text = question;
        }

        public string Answer { get; private set; }

        private void bNext_Click(object sender, EventArgs e)
        {
            if (tbAns.Text.Equals(string.Empty))
            {
                MessageBox.Show("Fill out the field");
                return;
            }
            DialogResult = DialogResult.OK;
            Answer = tbAns.Text;
        }


        private void tbAns_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bNext.PerformClick();
            }
        }
    }
}
