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
        private readonly bool[] truths;

        public ResultForm(string[] questions, string[] answers, string[] userAns, bool[] truths, int truth, int count)
        {
            InitializeComponent();
            this.questions = questions;
            this.answers = answers;
            this.userAns = userAns;
            this.truths = truths;
            labelTotal.Text = $"Total: {truth}\\{count}";
        }

        private void ResultForm_SizeChanged(object sender, EventArgs e)
        {
            dataGridView.Height = Height - 82;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < questions.Length; i++)
            {
                if (questions[i].Equals(string.Empty) || answers[i].Equals(string.Empty))
                {
                    continue;
                }
                
                dataGridView.Rows.Add(new object[] { questions[i], answers[i], userAns[i], truths[i] ? "True" : "False" } );
                
            }
            for (int i = 0; i < dataGridView.Rows.Count-1; i++)
            {
                if (dataGridView.Rows[i].Cells[3].Value.Equals("True"))
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }

            }
        }
    }
}
