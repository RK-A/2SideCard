
namespace _2SideCard
{
    partial class SettingForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxQuestions = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAnswers = new System.Windows.Forms.RichTextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.checkBoxOverturn = new System.Windows.Forms.CheckBox();
            this.labelQuest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxQuestions
            // 
            this.richTextBoxQuestions.DetectUrls = false;
            this.richTextBoxQuestions.Location = new System.Drawing.Point(18, 37);
            this.richTextBoxQuestions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxQuestions.Name = "richTextBoxQuestions";
            this.richTextBoxQuestions.Size = new System.Drawing.Size(517, 635);
            this.richTextBoxQuestions.TabIndex = 0;
            this.richTextBoxQuestions.Text = "";
            // 
            // richTextBoxAnswers
            // 
            this.richTextBoxAnswers.Location = new System.Drawing.Point(706, 37);
            this.richTextBoxAnswers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxAnswers.Name = "richTextBoxAnswers";
            this.richTextBoxAnswers.Size = new System.Drawing.Size(474, 635);
            this.richTextBoxAnswers.TabIndex = 1;
            this.richTextBoxAnswers.Text = "";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(546, 135);
            this.bStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(112, 35);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(548, 286);
            this.bSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(112, 35);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // checkBoxOverturn
            // 
            this.checkBoxOverturn.AutoSize = true;
            this.checkBoxOverturn.Location = new System.Drawing.Point(552, 188);
            this.checkBoxOverturn.Name = "checkBoxOverturn";
            this.checkBoxOverturn.Size = new System.Drawing.Size(89, 24);
            this.checkBoxOverturn.TabIndex = 5;
            this.checkBoxOverturn.Text = "Overturn";
            this.checkBoxOverturn.UseVisualStyleBackColor = true;
            this.checkBoxOverturn.CheckedChanged += new System.EventHandler(this.checkBoxOverturn_CheckedChanged);
            // 
            // labelQuest
            // 
            this.labelQuest.AutoSize = true;
            this.labelQuest.Location = new System.Drawing.Point(14, 9);
            this.labelQuest.Name = "labelQuest";
            this.labelQuest.Size = new System.Drawing.Size(81, 20);
            this.labelQuest.TabIndex = 6;
            this.labelQuest.Text = "Questions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(702, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Answers";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQuest);
            this.Controls.Add(this.checkBoxOverturn);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.richTextBoxAnswers);
            this.Controls.Add(this.richTextBoxQuestions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxQuestions;
        private System.Windows.Forms.RichTextBox richTextBoxAnswers;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.CheckBox checkBoxOverturn;
        private System.Windows.Forms.Label labelQuest;
        private System.Windows.Forms.Label label1;
    }
}

