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
        private bool flagOverturn;
        private int trueAnswers, countAnswers;

        public SettingForm()
        {
            flagOverturn = false;
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string[] answers = richTextBoxAnswers.Text.Trim().Split('\n');
            string[] quetions = richTextBoxQuestions.Text.Trim().Split('\n');
            if (answers.Length!=quetions.Length)
            {
                MessageBox.Show("Need the same numbers of questions and answers");
                return;
            }
            DBSupplier.DeleteAllDB();
            for (int i = 0; i < quetions.Length; i++)
            {
                DBSupplier.AddToDB(quetions[i].Trim(), answers[i].Trim());
            }
        }


        private void bStart_Click(object sender, EventArgs e)
        {
            string questions, answers;
            DBSupplier.ReadDB(out questions, out answers);
            string[] q = questions.Trim().Split('\n');
            string[] a = answers.Trim().Split('\n');
            bool[] truth = new bool[q.Length];
            List<string> userAnswer = new List<string>();
            Hide();
            var indexes = RandomIndexes(q.Length);
            foreach (var i in indexes)
            {

                if (q[i].Trim().Equals(string.Empty) || a[i].Trim().Equals(string.Empty))
                {
                    userAnswer.Add("---------");
                    continue;
                }
                using (var qForm = new QuestionForm(flagOverturn ? a[i]: q[i]))
                {
                    if (qForm.ShowDialog().Equals(DialogResult.OK))
                    {
                        userAnswer.Add(qForm.Answer);
                        if (qForm.Answer.Trim().ToLower().Equals(flagOverturn ? q[i] : a[i]))
                        {
                            trueAnswers++;
                            truth[i] = true;
                        }
                        countAnswers++;
                    }
                    else
                    {
                        Show();
                        return;
                    }
                    
                }
            }
            ResultForm resultForm = new ResultForm(indexes.Select(x => flagOverturn ? a[x]: q[x]).ToArray(),
                                                   indexes.Select(x => flagOverturn ? q[x] : a[x]).ToArray(),
                                                   userAnswer.ToArray(),
                                                   truth,
                                                   trueAnswers,
                                                   countAnswers);
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

        private void checkBoxOverturn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOverturn.Checked)
            {
                flagOverturn = true;
                return;
            }
            flagOverturn = false;
        }
    }
}
