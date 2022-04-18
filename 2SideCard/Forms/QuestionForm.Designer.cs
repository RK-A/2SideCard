
namespace _2SideCard
{
    partial class QuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuest = new System.Windows.Forms.Label();
            this.tbAns = new System.Windows.Forms.TextBox();
            this.bNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuest
            // 
            this.labelQuest.AutoSize = true;
            this.labelQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuest.Location = new System.Drawing.Point(12, 9);
            this.labelQuest.Name = "labelQuest";
            this.labelQuest.Size = new System.Drawing.Size(123, 31);
            this.labelQuest.TabIndex = 0;
            this.labelQuest.Text = "Question";
            // 
            // tbAns
            // 
            this.tbAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAns.Location = new System.Drawing.Point(18, 259);
            this.tbAns.Name = "tbAns";
            this.tbAns.Size = new System.Drawing.Size(350, 35);
            this.tbAns.TabIndex = 1;
            // 
            // bNext
            // 
            this.bNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNext.Location = new System.Drawing.Point(397, 259);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(93, 35);
            this.bNext.TabIndex = 2;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 327);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.tbAns);
            this.Controls.Add(this.labelQuest);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuest;
        private System.Windows.Forms.TextBox tbAns;
        private System.Windows.Forms.Button bNext;
    }
}