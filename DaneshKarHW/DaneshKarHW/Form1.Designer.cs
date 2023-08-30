namespace DaneshKarHW
{
    partial class Form1
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
            this.btnIsAnagramByLinq = new System.Windows.Forms.Button();
            this.btnIsAnagramByList = new System.Windows.Forms.Button();
            this.btnAddDigits = new System.Windows.Forms.Button();
            this.btnIsUgly = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAddDigitsNumber = new System.Windows.Forms.Label();
            this.txtAddDigitsNumber = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblIsUglyNumber = new System.Windows.Forms.Label();
            this.txtIsUglyNumber = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMoveZeroesNumbers = new System.Windows.Forms.Label();
            this.txtMoveZeroesNumbers = new System.Windows.Forms.TextBox();
            this.btnMoveZeroes = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblS = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.lblPattern = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.btnWordPattern = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIsAnagramByLinq
            // 
            this.btnIsAnagramByLinq.Location = new System.Drawing.Point(249, 45);
            this.btnIsAnagramByLinq.Name = "btnIsAnagramByLinq";
            this.btnIsAnagramByLinq.Size = new System.Drawing.Size(177, 23);
            this.btnIsAnagramByLinq.TabIndex = 0;
            this.btnIsAnagramByLinq.Text = "Get Result By LINQ";
            this.btnIsAnagramByLinq.UseVisualStyleBackColor = true;
            this.btnIsAnagramByLinq.Click += new System.EventHandler(this.btnIsAnagramByLinq_Click);
            // 
            // btnIsAnagramByList
            // 
            this.btnIsAnagramByList.Location = new System.Drawing.Point(249, 74);
            this.btnIsAnagramByList.Name = "btnIsAnagramByList";
            this.btnIsAnagramByList.Size = new System.Drawing.Size(177, 23);
            this.btnIsAnagramByList.TabIndex = 1;
            this.btnIsAnagramByList.Text = "Get Result By LIST";
            this.btnIsAnagramByList.UseVisualStyleBackColor = true;
            this.btnIsAnagramByList.Click += new System.EventHandler(this.btnIsAnagramByList_Click);
            // 
            // btnAddDigits
            // 
            this.btnAddDigits.Location = new System.Drawing.Point(249, 21);
            this.btnAddDigits.Name = "btnAddDigits";
            this.btnAddDigits.Size = new System.Drawing.Size(177, 23);
            this.btnAddDigits.TabIndex = 2;
            this.btnAddDigits.Text = "Get Result";
            this.btnAddDigits.UseVisualStyleBackColor = true;
            this.btnAddDigits.Click += new System.EventHandler(this.btnAddDigits_Click);
            // 
            // btnIsUgly
            // 
            this.btnIsUgly.Location = new System.Drawing.Point(249, 18);
            this.btnIsUgly.Name = "btnIsUgly";
            this.btnIsUgly.Size = new System.Drawing.Size(177, 23);
            this.btnIsUgly.TabIndex = 3;
            this.btnIsUgly.Text = "Get Result";
            this.btnIsUgly.UseVisualStyleBackColor = true;
            this.btnIsUgly.Click += new System.EventHandler(this.btnIsUgly_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSecond);
            this.groupBox1.Controls.Add(this.lblFirst);
            this.groupBox1.Controls.Add(this.txtFirst);
            this.groupBox1.Controls.Add(this.txtSecond);
            this.groupBox1.Controls.Add(this.btnIsAnagramByLinq);
            this.groupBox1.Controls.Add(this.btnIsAnagramByList);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IsAnagram";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(4, 48);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(46, 15);
            this.lblSecond.TabIndex = 3;
            this.lblSecond.Text = "Second";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(20, 19);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(29, 15);
            this.lblFirst.TabIndex = 2;
            this.lblFirst.Text = "First";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(55, 16);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(177, 23);
            this.txtFirst.TabIndex = 0;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(55, 45);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(178, 23);
            this.txtSecond.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAddDigitsNumber);
            this.groupBox2.Controls.Add(this.txtAddDigitsNumber);
            this.groupBox2.Controls.Add(this.btnAddDigits);
            this.groupBox2.Location = new System.Drawing.Point(12, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 53);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AddDigits";
            // 
            // lblAddDigitsNumber
            // 
            this.lblAddDigitsNumber.AutoSize = true;
            this.lblAddDigitsNumber.Location = new System.Drawing.Point(3, 26);
            this.lblAddDigitsNumber.Name = "lblAddDigitsNumber";
            this.lblAddDigitsNumber.Size = new System.Drawing.Size(51, 15);
            this.lblAddDigitsNumber.TabIndex = 4;
            this.lblAddDigitsNumber.Text = "Number";
            // 
            // txtAddDigitsNumber
            // 
            this.txtAddDigitsNumber.Location = new System.Drawing.Point(56, 22);
            this.txtAddDigitsNumber.Name = "txtAddDigitsNumber";
            this.txtAddDigitsNumber.Size = new System.Drawing.Size(178, 23);
            this.txtAddDigitsNumber.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblIsUglyNumber);
            this.groupBox3.Controls.Add(this.txtIsUglyNumber);
            this.groupBox3.Controls.Add(this.btnIsUgly);
            this.groupBox3.Location = new System.Drawing.Point(12, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(441, 53);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IsUgly";
            // 
            // lblIsUglyNumber
            // 
            this.lblIsUglyNumber.AutoSize = true;
            this.lblIsUglyNumber.Location = new System.Drawing.Point(3, 22);
            this.lblIsUglyNumber.Name = "lblIsUglyNumber";
            this.lblIsUglyNumber.Size = new System.Drawing.Size(51, 15);
            this.lblIsUglyNumber.TabIndex = 4;
            this.lblIsUglyNumber.Text = "Number";
            // 
            // txtIsUglyNumber
            // 
            this.txtIsUglyNumber.Location = new System.Drawing.Point(56, 18);
            this.txtIsUglyNumber.Name = "txtIsUglyNumber";
            this.txtIsUglyNumber.Size = new System.Drawing.Size(178, 23);
            this.txtIsUglyNumber.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMoveZeroesNumbers);
            this.groupBox4.Controls.Add(this.txtMoveZeroesNumbers);
            this.groupBox4.Controls.Add(this.btnMoveZeroes);
            this.groupBox4.Location = new System.Drawing.Point(12, 231);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(441, 53);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MoveZeroes";
            // 
            // lblMoveZeroesNumbers
            // 
            this.lblMoveZeroesNumbers.AutoSize = true;
            this.lblMoveZeroesNumbers.Location = new System.Drawing.Point(-1, 26);
            this.lblMoveZeroesNumbers.Name = "lblMoveZeroesNumbers";
            this.lblMoveZeroesNumbers.Size = new System.Drawing.Size(56, 15);
            this.lblMoveZeroesNumbers.TabIndex = 4;
            this.lblMoveZeroesNumbers.Text = "Numbers";
            // 
            // txtMoveZeroesNumbers
            // 
            this.txtMoveZeroesNumbers.Location = new System.Drawing.Point(55, 22);
            this.txtMoveZeroesNumbers.Name = "txtMoveZeroesNumbers";
            this.txtMoveZeroesNumbers.Size = new System.Drawing.Size(178, 23);
            this.txtMoveZeroesNumbers.TabIndex = 3;
            // 
            // btnMoveZeroes
            // 
            this.btnMoveZeroes.Location = new System.Drawing.Point(249, 22);
            this.btnMoveZeroes.Name = "btnMoveZeroes";
            this.btnMoveZeroes.Size = new System.Drawing.Size(177, 23);
            this.btnMoveZeroes.TabIndex = 3;
            this.btnMoveZeroes.Text = "Get Result";
            this.btnMoveZeroes.UseVisualStyleBackColor = true;
            this.btnMoveZeroes.Click += new System.EventHandler(this.btnMoveZeroes_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblS);
            this.groupBox5.Controls.Add(this.txtS);
            this.groupBox5.Controls.Add(this.lblPattern);
            this.groupBox5.Controls.Add(this.txtPattern);
            this.groupBox5.Controls.Add(this.btnWordPattern);
            this.groupBox5.Location = new System.Drawing.Point(12, 286);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(441, 74);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "WordPattern";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(36, 47);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(13, 15);
            this.lblS.TabIndex = 6;
            this.lblS.Text = "S";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(56, 44);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(177, 23);
            this.txtS.TabIndex = 5;
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(4, 19);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(45, 15);
            this.lblPattern.TabIndex = 4;
            this.lblPattern.Text = "Pattern";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(56, 16);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(178, 23);
            this.txtPattern.TabIndex = 3;
            // 
            // btnWordPattern
            // 
            this.btnWordPattern.Location = new System.Drawing.Point(249, 43);
            this.btnWordPattern.Name = "btnWordPattern";
            this.btnWordPattern.Size = new System.Drawing.Size(177, 23);
            this.btnWordPattern.TabIndex = 3;
            this.btnWordPattern.Text = "Get Result";
            this.btnWordPattern.UseVisualStyleBackColor = true;
            this.btnWordPattern.Click += new System.EventHandler(this.btnWordPattern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 372);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnIsAnagramByLinq;
        private Button btnIsAnagramByList;
        private Button btnAddDigits;
        private Button btnIsUgly;
        private GroupBox groupBox1;
        private TextBox txtFirst;
        private Label lblFirst;
        private TextBox txtSecond;
        private Label lblSecond;
        private GroupBox groupBox2;
        private Label lblAddDigitsNumber;
        private TextBox txtAddDigitsNumber;
        private GroupBox groupBox3;
        private Label lblIsUglyNumber;
        private TextBox txtIsUglyNumber;
        private GroupBox groupBox4;
        private Label lblMoveZeroesNumbers;
        private TextBox txtMoveZeroesNumbers;
        private Button btnMoveZeroes;
        private GroupBox groupBox5;
        private Label lblPattern;
        private TextBox txtPattern;
        private Button btnWordPattern;
        private Label lblS;
        private TextBox txtS;
    }
}