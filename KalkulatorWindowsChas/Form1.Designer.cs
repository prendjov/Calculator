namespace KalkulatorWindowsChas
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnQuadratic = new System.Windows.Forms.Button();
            this.btnOnQuadrate = new System.Windows.Forms.Button();
            this.btn1DividedX = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(1, 5);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(406, 70);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPercent.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnPercent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPercent.Location = new System.Drawing.Point(1, 80);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(100, 75);
            this.btnPercent.TabIndex = 1;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCE.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnCE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCE.Location = new System.Drawing.Point(103, 80);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(100, 75);
            this.btnCE.TabIndex = 2;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnC.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnC.Location = new System.Drawing.Point(205, 80);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(100, 75);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(307, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "Clear One";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDivide.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnDivide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDivide.Location = new System.Drawing.Point(307, 157);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(100, 75);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnQuadratic
            // 
            this.btnQuadratic.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnQuadratic.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnQuadratic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuadratic.Location = new System.Drawing.Point(205, 157);
            this.btnQuadratic.Name = "btnQuadratic";
            this.btnQuadratic.Size = new System.Drawing.Size(100, 75);
            this.btnQuadratic.TabIndex = 7;
            this.btnQuadratic.Text = "√x";
            this.btnQuadratic.UseVisualStyleBackColor = false;
            this.btnQuadratic.Click += new System.EventHandler(this.btnQuadratic_Click);
            // 
            // btnOnQuadrate
            // 
            this.btnOnQuadrate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOnQuadrate.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnOnQuadrate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOnQuadrate.Location = new System.Drawing.Point(103, 157);
            this.btnOnQuadrate.Name = "btnOnQuadrate";
            this.btnOnQuadrate.Size = new System.Drawing.Size(100, 75);
            this.btnOnQuadrate.TabIndex = 6;
            this.btnOnQuadrate.Text = "x2";
            this.btnOnQuadrate.UseVisualStyleBackColor = false;
            this.btnOnQuadrate.Click += new System.EventHandler(this.btnbtnOnQuadrate_Click);
            // 
            // btn1DividedX
            // 
            this.btn1DividedX.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn1DividedX.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btn1DividedX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1DividedX.Location = new System.Drawing.Point(1, 157);
            this.btn1DividedX.Name = "btn1DividedX";
            this.btn1DividedX.Size = new System.Drawing.Size(100, 75);
            this.btn1DividedX.TabIndex = 5;
            this.btn1DividedX.Text = "1/x";
            this.btn1DividedX.UseVisualStyleBackColor = false;
            this.btn1DividedX.Click += new System.EventHandler(this.btn1DividedX_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMultiple.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnMultiple.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMultiple.Location = new System.Drawing.Point(307, 234);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(100, 75);
            this.btnMultiple.TabIndex = 12;
            this.btnMultiple.Text = "x";
            this.btnMultiple.UseVisualStyleBackColor = false;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNum9.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnNum9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNum9.Location = new System.Drawing.Point(205, 234);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(100, 75);
            this.btnNum9.TabIndex = 11;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNum8.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnNum8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNum8.Location = new System.Drawing.Point(103, 234);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(100, 75);
            this.btnNum8.TabIndex = 10;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNum7.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnNum7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNum7.Location = new System.Drawing.Point(1, 234);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(100, 75);
            this.btnNum7.TabIndex = 9;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEqual.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnEqual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEqual.Location = new System.Drawing.Point(307, 465);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(100, 75);
            this.btnEqual.TabIndex = 24;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDecimal.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnDecimal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDecimal.Location = new System.Drawing.Point(205, 465);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(100, 75);
            this.btnDecimal.TabIndex = 23;
            this.btnDecimal.Text = ",";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNum0.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnNum0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNum0.Location = new System.Drawing.Point(103, 465);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(100, 75);
            this.btnNum0.TabIndex = 22;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPlusMinus.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnPlusMinus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlusMinus.Location = new System.Drawing.Point(1, 465);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(100, 75);
            this.btnPlusMinus.TabIndex = 21;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMinus.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinus.Location = new System.Drawing.Point(307, 311);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(100, 75);
            this.btnMinus.TabIndex = 20;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNum3.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnNum3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNum3.Location = new System.Drawing.Point(205, 388);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(100, 75);
            this.btnNum3.TabIndex = 19;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNum2.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnNum2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNum2.Location = new System.Drawing.Point(103, 388);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(100, 75);
            this.btnNum2.TabIndex = 18;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNum1.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnNum1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNum1.Location = new System.Drawing.Point(1, 388);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(100, 75);
            this.btnNum1.TabIndex = 17;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPlus.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlus.Location = new System.Drawing.Point(307, 388);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(100, 75);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNum6.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnNum6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNum6.Location = new System.Drawing.Point(205, 311);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(100, 75);
            this.btnNum6.TabIndex = 15;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNum5.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnNum5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNum5.Location = new System.Drawing.Point(103, 311);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(100, 75);
            this.btnNum5.TabIndex = 14;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNum4.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnNum4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNum4.Location = new System.Drawing.Point(1, 311);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(100, 75);
            this.btnNum4.TabIndex = 13;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 542);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnQuadratic);
            this.Controls.Add(this.btnOnQuadrate);
            this.Controls.Add(this.btn1DividedX);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnQuadratic;
        private System.Windows.Forms.Button btnOnQuadrate;
        private System.Windows.Forms.Button btn1DividedX;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
    }
}

