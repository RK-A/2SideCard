
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
            this.bSetting = new System.Windows.Forms.Button();
            this.bMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxQuestions
            // 
            this.richTextBoxQuestions.DetectUrls = false;
            this.richTextBoxQuestions.Location = new System.Drawing.Point(12, 4);
            this.richTextBoxQuestions.Name = "richTextBoxQuestions";
            this.richTextBoxQuestions.Size = new System.Drawing.Size(346, 434);
            this.richTextBoxQuestions.TabIndex = 0;
            this.richTextBoxQuestions.Text = "";
            // 
            // richTextBoxAnswers
            // 
            this.richTextBoxAnswers.Location = new System.Drawing.Point(471, 4);
            this.richTextBoxAnswers.Name = "richTextBoxAnswers";
            this.richTextBoxAnswers.Size = new System.Drawing.Size(317, 434);
            this.richTextBoxAnswers.TabIndex = 1;
            this.richTextBoxAnswers.Text = "";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(364, 88);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bSetting
            // 
            this.bSetting.Location = new System.Drawing.Point(365, 137);
            this.bSetting.Name = "bSetting";
            this.bSetting.Size = new System.Drawing.Size(75, 23);
            this.bSetting.TabIndex = 3;
            this.bSetting.Text = "Settings";
            this.bSetting.UseVisualStyleBackColor = true;
            // 
            // bMenu
            // 
            this.bMenu.Location = new System.Drawing.Point(365, 186);
            this.bMenu.Name = "bMenu";
            this.bMenu.Size = new System.Drawing.Size(75, 23);
            this.bMenu.TabIndex = 4;
            this.bMenu.Text = "Save";
            this.bMenu.UseVisualStyleBackColor = true;
            this.bMenu.Click += new System.EventHandler(this.bMenu_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bMenu);
            this.Controls.Add(this.bSetting);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.richTextBoxAnswers);
            this.Controls.Add(this.richTextBoxQuestions);
            this.Name = "SettingForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxQuestions;
        private System.Windows.Forms.RichTextBox richTextBoxAnswers;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bSetting;
        private System.Windows.Forms.Button bMenu;
    }
}

