namespace Lab2._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCheckPass = new Button();
            btnLetterGrade = new Button();
            btnAverage = new Button();
            lblResult = new Label();
            txtScore = new TextBox();
            SuspendLayout();
            // 
            // btnCheckPass
            // 
            btnCheckPass.Location = new Point(168, 255);
            btnCheckPass.Name = "btnCheckPass";
            btnCheckPass.Size = new Size(124, 34);
            btnCheckPass.TabIndex = 1;
            btnCheckPass.Text = "Pass or Fail";
            btnCheckPass.UseVisualStyleBackColor = true;
            btnCheckPass.Click += btnCheckPass_Click;
            // 
            // btnLetterGrade
            // 
            btnLetterGrade.Location = new Point(348, 255);
            btnLetterGrade.Name = "btnLetterGrade";
            btnLetterGrade.Size = new Size(129, 34);
            btnLetterGrade.TabIndex = 2;
            btnLetterGrade.Text = "Letter Grade";
            btnLetterGrade.UseVisualStyleBackColor = true;
            btnLetterGrade.Click += btnLetterGrade_Click;
            // 
            // btnAverage
            // 
            btnAverage.Location = new Point(544, 255);
            btnAverage.Name = "btnAverage";
            btnAverage.Size = new Size(145, 34);
            btnAverage.TabIndex = 3;
            btnAverage.Text = "Average to 100";
            btnAverage.UseVisualStyleBackColor = true;
            btnAverage.Click += btnAverage_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(374, 189);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 25);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(327, 98);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(150, 31);
            txtScore.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtScore);
            Controls.Add(lblResult);
            Controls.Add(btnAverage);
            Controls.Add(btnLetterGrade);
            Controls.Add(btnCheckPass);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btnLetterGrade;
        private Button btnAverage;
        private Button btnCheckPass;
        private Label lblResult;
        private TextBox txtScore;
    }
}
