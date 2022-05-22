namespace Speller_Demo_Two
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
            this.btn_Play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblSaying = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMyWord = new System.Windows.Forms.TextBox();
            this.txtAddedWords = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMyWord = new System.Windows.Forms.Label();
            this.lblMyRules = new System.Windows.Forms.Label();
            this.btmXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(298, 69);
            this.btn_Play.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(77, 21);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(98, 81);
            this.lblWord.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(0, 15);
            this.lblWord.TabIndex = 2;
            // 
            // lblSaying
            // 
            this.lblSaying.Location = new System.Drawing.Point(36, 202);
            this.lblSaying.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSaying.Name = "lblSaying";
            this.lblSaying.Size = new System.Drawing.Size(457, 55);
            this.lblSaying.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Word:";
            // 
            // txtMyWord
            // 
            this.txtMyWord.Location = new System.Drawing.Point(110, 67);
            this.txtMyWord.Margin = new System.Windows.Forms.Padding(1);
            this.txtMyWord.Name = "txtMyWord";
            this.txtMyWord.Size = new System.Drawing.Size(142, 23);
            this.txtMyWord.TabIndex = 5;
            // 
            // txtAddedWords
            // 
            this.txtAddedWords.Location = new System.Drawing.Point(35, 108);
            this.txtAddedWords.Margin = new System.Windows.Forms.Padding(1);
            this.txtAddedWords.Multiline = true;
            this.txtAddedWords.Name = "txtAddedWords";
            this.txtAddedWords.Size = new System.Drawing.Size(461, 87);
            this.txtAddedWords.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rules";
            // 
            // lblMyWord
            // 
            this.lblMyWord.AutoSize = true;
            this.lblMyWord.Location = new System.Drawing.Point(102, 240);
            this.lblMyWord.Name = "lblMyWord";
            this.lblMyWord.Size = new System.Drawing.Size(56, 15);
            this.lblMyWord.TabIndex = 10;
            this.lblMyWord.Text = "Not filled";
            // 
            // lblMyRules
            // 
            this.lblMyRules.AutoSize = true;
            this.lblMyRules.Location = new System.Drawing.Point(102, 283);
            this.lblMyRules.Name = "lblMyRules";
            this.lblMyRules.Size = new System.Drawing.Size(58, 15);
            this.lblMyRules.TabIndex = 11;
            this.lblMyRules.Text = "Not Filled";
            // 
            // btmXML
            // 
            this.btmXML.Location = new System.Drawing.Point(405, 67);
            this.btmXML.Name = "btmXML";
            this.btmXML.Size = new System.Drawing.Size(75, 23);
            this.btmXML.TabIndex = 12;
            this.btmXML.Text = "MY XML";
            this.btmXML.UseVisualStyleBackColor = true;
            this.btmXML.Click += new System.EventHandler(this.btmXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 632);
            this.Controls.Add(this.btmXML);
            this.Controls.Add(this.lblMyRules);
            this.Controls.Add(this.lblMyWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddedWords);
            this.Controls.Add(this.txtMyWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaying);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Play);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Play;
        private Label label1;
        private Label lblWord;
        private Label lblSaying;
        private Label label2;
        private TextBox txtMyWord;
        private TextBox txtAddedWords;
        private Label label3;
        private Label label4;
        private Label lblMyWord;
        private Label lblMyRules;
        private Button btmXML;
    }
}