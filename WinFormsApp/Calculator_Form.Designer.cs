
namespace WinFormsApp
{
    partial class Calculator_Form
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnSubtr = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMplus = new System.Windows.Forms.Button();
            this.btnMminus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputBox.Location = new System.Drawing.Point(44, 57);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(330, 43);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn1.Location = new System.Drawing.Point(100, 191);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn3.Location = new System.Drawing.Point(212, 191);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn6.Location = new System.Drawing.Point(212, 247);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 3;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn9.Location = new System.Drawing.Point(212, 303);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn2.Location = new System.Drawing.Point(156, 191);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn5.Location = new System.Drawing.Point(156, 247);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn8.Location = new System.Drawing.Point(156, 303);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn7.Location = new System.Drawing.Point(100, 303);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn4.Location = new System.Drawing.Point(100, 247);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.ForeColor = System.Drawing.Color.Red;
            this.btnPlus.Location = new System.Drawing.Point(268, 191);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 50);
            this.btnPlus.TabIndex = 10;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.ForeColor = System.Drawing.Color.Red;
            this.btnEquals.Location = new System.Drawing.Point(324, 247);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(50, 162);
            this.btnEquals.TabIndex = 11;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnC.ForeColor = System.Drawing.Color.Red;
            this.btnC.Location = new System.Drawing.Point(212, 135);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 50);
            this.btnC.TabIndex = 12;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnSubtr
            // 
            this.btnSubtr.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubtr.ForeColor = System.Drawing.Color.Red;
            this.btnSubtr.Location = new System.Drawing.Point(268, 247);
            this.btnSubtr.Name = "btnSubtr";
            this.btnSubtr.Size = new System.Drawing.Size(50, 50);
            this.btnSubtr.TabIndex = 13;
            this.btnSubtr.Text = "-";
            this.btnSubtr.UseVisualStyleBackColor = true;
            this.btnSubtr.Click += new System.EventHandler(this.btnSubtr_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMult.ForeColor = System.Drawing.Color.Red;
            this.btnMult.Location = new System.Drawing.Point(268, 303);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(50, 50);
            this.btnMult.TabIndex = 14;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.ForeColor = System.Drawing.Color.Red;
            this.btnDiv.Location = new System.Drawing.Point(268, 359);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(50, 50);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn0.Location = new System.Drawing.Point(100, 359);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(106, 50);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPoint.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPoint.Location = new System.Drawing.Point(212, 359);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(50, 50);
            this.btnPoint.TabIndex = 17;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCE.ForeColor = System.Drawing.Color.Red;
            this.btnCE.Location = new System.Drawing.Point(156, 135);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(50, 50);
            this.btnCE.TabIndex = 18;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(100, 135);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRoot.ForeColor = System.Drawing.Color.Red;
            this.btnRoot.Location = new System.Drawing.Point(324, 191);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(50, 50);
            this.btnRoot.TabIndex = 21;
            this.btnRoot.Text = "√";
            this.btnRoot.UseVisualStyleBackColor = true;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlusMinus.ForeColor = System.Drawing.Color.Red;
            this.btnPlusMinus.Location = new System.Drawing.Point(268, 135);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(50, 50);
            this.btnPlusMinus.TabIndex = 22;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPercent.ForeColor = System.Drawing.Color.Red;
            this.btnPercent.Location = new System.Drawing.Point(324, 135);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(50, 50);
            this.btnPercent.TabIndex = 23;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnMC
            // 
            this.btnMC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMC.ForeColor = System.Drawing.Color.Red;
            this.btnMC.Location = new System.Drawing.Point(44, 135);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(50, 50);
            this.btnMC.TabIndex = 24;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMR.ForeColor = System.Drawing.Color.Red;
            this.btnMR.Location = new System.Drawing.Point(44, 191);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(50, 50);
            this.btnMR.TabIndex = 25;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMS
            // 
            this.btnMS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMS.ForeColor = System.Drawing.Color.Red;
            this.btnMS.Location = new System.Drawing.Point(44, 247);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(50, 50);
            this.btnMS.TabIndex = 26;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMplus
            // 
            this.btnMplus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMplus.ForeColor = System.Drawing.Color.Red;
            this.btnMplus.Location = new System.Drawing.Point(44, 303);
            this.btnMplus.Name = "btnMplus";
            this.btnMplus.Size = new System.Drawing.Size(50, 50);
            this.btnMplus.TabIndex = 27;
            this.btnMplus.Text = "M+";
            this.btnMplus.UseVisualStyleBackColor = true;
            this.btnMplus.Click += new System.EventHandler(this.btnMplus_Click);
            // 
            // btnMminus
            // 
            this.btnMminus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMminus.ForeColor = System.Drawing.Color.Red;
            this.btnMminus.Location = new System.Drawing.Point(44, 359);
            this.btnMminus.Name = "btnMminus";
            this.btnMminus.Size = new System.Drawing.Size(50, 50);
            this.btnMminus.TabIndex = 28;
            this.btnMminus.Text = "M-";
            this.btnMminus.UseVisualStyleBackColor = true;
            this.btnMminus.Click += new System.EventHandler(this.btnMminus_Click);
            // 
            // Calculator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 447);
            this.Controls.Add(this.btnMminus);
            this.Controls.Add(this.btnMplus);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSubtr);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.inputBox);
            this.Name = "Calculator_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnSubtr;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMplus;
        private System.Windows.Forms.Button btnMminus;
    }
}

