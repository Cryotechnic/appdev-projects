
namespace PresidentialTrivia
{
    partial class presidentialTriviaForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.showAnswerbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(17, 9);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(248, 75);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "What former U.S. president is known for going on an African safari?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerLabel
            // 
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(12, 84);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(253, 51);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showAnswerbutton
            // 
            this.showAnswerbutton.Location = new System.Drawing.Point(79, 151);
            this.showAnswerbutton.Name = "showAnswerbutton";
            this.showAnswerbutton.Size = new System.Drawing.Size(110, 23);
            this.showAnswerbutton.TabIndex = 2;
            this.showAnswerbutton.Text = "Show the Answer";
            this.showAnswerbutton.UseVisualStyleBackColor = true;
            this.showAnswerbutton.Click += new System.EventHandler(this.showAnswerbutton_Click);
            // 
            // presidentialTriviaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 197);
            this.Controls.Add(this.showAnswerbutton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionLabel);
            this.Name = "presidentialTriviaForm";
            this.Text = "Presidential Trivia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button showAnswerbutton;
    }
}

