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

        public ResultForm(string[] questions, string[] answers, string[] userAns, int truth, int count)
        {
            InitializeComponent();
            this.questions = questions;
            this.answers = answers;
            this.userAns = userAns;
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
                
                dataGridView.Rows.Add(new object[] { questions[i], answers[i], userAns[i] });
                
            }
            for (int i = 0; i < dataGridView.Rows.Count-1; i++)
            {
                string corrAns = dataGridView.Rows[i].Cells[2].Value.ToString().Trim().ToLower();
                string yourAns = dataGridView.Rows[i].Cells[1].Value.ToString().Trim().ToLower();
                if (corrAns.Equals(yourAns))
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
