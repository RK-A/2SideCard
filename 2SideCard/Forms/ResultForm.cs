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
    public partial class ResultForm : Form
    {
        private readonly string[] questions;
        private readonly string[] answers;
        private readonly string[] userAns;

        public ResultForm(string[] questions, string[] answers, string[] userAns)
        {
            InitializeComponent();
            this.questions = questions;
            this.answers = answers;
            this.userAns = userAns;
        }

        private void ResultForm_SizeChanged(object sender, EventArgs e)
        {
            dataGridView.Height = Height - 82;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < questions.Length; i++)
            {
                dataGridView.Rows.Add(new object[] { questions[i], answers[i], userAns[i]});
            }
        }
    }
}
