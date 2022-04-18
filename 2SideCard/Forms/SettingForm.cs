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
    public partial class SettingForm : Form
    {
        
        public SettingForm()
        {
            InitializeComponent();
        }

        private void bMenu_Click(object sender, EventArgs e)
        {
            DBSupplier.AddToDB("Ты черт", "нет");
            string[] answers = richTextBoxAnswers.Text.Split('\n');
            string[] quetions = richTextBoxQuestions.Text.Split('\n');
            if (answers.Length!=quetions.Length)
            {
                MessageBox.Show("Need the same numbers of questions and answers");
                return;
            }
            for (int i = 0; i < quetions.Length; i++)
            {
                DBSupplier.AddToDB(quetions[i], answers[i]);
            }
        }


        private void bStart_Click(object sender, EventArgs e)
        {
            string questions, answers;
            DBSupplier.ReadDB(out questions, out answers);
            string[] q = questions.Trim().Split('\n');
            string[] a = answers.Trim().Split('\n');
            List<string> userAnswer = new List<string>();
            Hide();
            foreach (var i in RandomIndexes(q.Length))
            {
                using (var qForm = new QuestionForm(q[i]))
                {
                    if (qForm.ShowDialog().Equals(DialogResult.OK))
                    {
                        userAnswer.Add(qForm.Answer);
                    }
                    
                }
            }
            ResultForm resultForm = new ResultForm(q, a, userAnswer.ToArray());
            resultForm.Show();
            Show();
        }


        private static int[] RandomIndexes(int length)
        {
            Random rnd = new Random();
            var arr = Enumerable.Range(0, length).ToArray();
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                int t = arr[j];
                arr[j] = arr[i];
                arr[i] = t;
            }
            return arr;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            string questions, answers;
            DBSupplier.ReadDB(out questions, out answers);
            richTextBoxQuestions.Text = questions.Trim();
            richTextBoxAnswers.Text = answers.Trim();
        }
    }
}
