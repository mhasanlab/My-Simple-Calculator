namespace My_Simple_Calculator
{
    partial class Header
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header));
            this.label1 = new System.Windows.Forms.Label();
            this.lblValueOne = new System.Windows.Forms.Label();
            this.lblValueTwo = new System.Windows.Forms.Label();
            this.txtValueOne = new System.Windows.Forms.TextBox();
            this.txtValueTwo = new System.Windows.Forms.TextBox();
            this.btnSummation = new System.Windows.Forms.Button();
            this.btnSubsectio = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Hind Siliguri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Simple Calculator";
            // 
            // lblValueOne
            // 
            this.lblValueOne.AutoSize = true;
            this.lblValueOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValueOne.Font = new System.Drawing.Font("Hind Siliguri SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueOne.ForeColor = System.Drawing.Color.Navy;
            this.lblValueOne.Location = new System.Drawing.Point(41, 85);
            this.lblValueOne.Name = "lblValueOne";
            this.lblValueOne.Size = new System.Drawing.Size(109, 33);
            this.lblValueOne.TabIndex = 1;
            this.lblValueOne.Text = "Value One:";
            // 
            // lblValueTwo
            // 
            this.lblValueTwo.AutoSize = true;
            this.lblValueTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValueTwo.Font = new System.Drawing.Font("Hind Siliguri SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueTwo.ForeColor = System.Drawing.Color.Navy;
            this.lblValueTwo.Location = new System.Drawing.Point(41, 135);
            this.lblValueTwo.Name = "lblValueTwo";
            this.lblValueTwo.Size = new System.Drawing.Size(110, 33);
            this.lblValueTwo.TabIndex = 2;
            this.lblValueTwo.Text = "Value Two:";
            // 
            // txtValueOne
            // 
            this.txtValueOne.Font = new System.Drawing.Font("Hind Siliguri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValueOne.Location = new System.Drawing.Point(156, 85);
            this.txtValueOne.Name = "txtValueOne";
            this.txtValueOne.Size = new System.Drawing.Size(248, 33);
            this.txtValueOne.TabIndex = 3;
            // 
            // txtValueTwo
            // 
            this.txtValueTwo.Font = new System.Drawing.Font("Hind Siliguri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValueTwo.Location = new System.Drawing.Point(156, 135);
            this.txtValueTwo.Name = "txtValueTwo";
            this.txtValueTwo.Size = new System.Drawing.Size(248, 33);
            this.txtValueTwo.TabIndex = 4;
            // 
            // btnSummation
            // 
            this.btnSummation.BackColor = System.Drawing.Color.Navy;
            this.btnSummation.Font = new System.Drawing.Font("Hind Siliguri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummation.ForeColor = System.Drawing.Color.White;
            this.btnSummation.Location = new System.Drawing.Point(40, 186);
            this.btnSummation.Name = "btnSummation";
            this.btnSummation.Size = new System.Drawing.Size(52, 41);
            this.btnSummation.TabIndex = 5;
            this.btnSummation.Text = "+";
            this.btnSummation.UseVisualStyleBackColor = false;
            this.btnSummation.Click += new System.EventHandler(this.btnSummation_Click);
            // 
            // btnSubsectio
            // 
            this.btnSubsectio.BackColor = System.Drawing.Color.Navy;
            this.btnSubsectio.Font = new System.Drawing.Font("Hind Siliguri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubsectio.ForeColor = System.Drawing.Color.White;
            this.btnSubsectio.Location = new System.Drawing.Point(98, 186);
            this.btnSubsectio.Name = "btnSubsectio";
            this.btnSubsectio.Size = new System.Drawing.Size(52, 41);
            this.btnSubsectio.TabIndex = 6;
            this.btnSubsectio.Text = "-";
            this.btnSubsectio.UseVisualStyleBackColor = false;
            this.btnSubsectio.Click += new System.EventHandler(this.btnSubsectio_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.Color.Navy;
            this.btnMultiplication.Font = new System.Drawing.Font("Hind Siliguri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.ForeColor = System.Drawing.Color.White;
            this.btnMultiplication.Location = new System.Drawing.Point(156, 186);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(52, 41);
            this.btnMultiplication.TabIndex = 7;
            this.btnMultiplication.Text = "×";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.Navy;
            this.btnDivision.Font = new System.Drawing.Font("Hind Siliguri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.White;
            this.btnDivision.Location = new System.Drawing.Point(214, 186);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(52, 41);
            this.btnDivision.TabIndex = 8;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.BackColor = System.Drawing.Color.Navy;
            this.btnPercentage.Font = new System.Drawing.Font("Hind Siliguri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentage.ForeColor = System.Drawing.Color.White;
            this.btnPercentage.Location = new System.Drawing.Point(272, 186);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(52, 41);
            this.btnPercentage.TabIndex = 9;
            this.btnPercentage.Text = "% ";
            this.btnPercentage.UseVisualStyleBackColor = false;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Hind Siliguri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(330, 186);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 41);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Font = new System.Drawing.Font("Hind Siliguri SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Teal;
            this.lblAnswer.Location = new System.Drawing.Point(40, 249);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(85, 33);
            this.lblAnswer.TabIndex = 11;
            this.lblAnswer.Text = "Answer:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Hind Siliguri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(131, 249);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(273, 33);
            this.txtAnswer.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hind Siliguri Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(94, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Develop By: A.K.M Mainul Hasan";
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSubsectio);
            this.Controls.Add(this.btnSummation);
            this.Controls.Add(this.txtValueTwo);
            this.Controls.Add(this.txtValueOne);
            this.Controls.Add(this.lblValueTwo);
            this.Controls.Add(this.lblValueOne);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Header";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValueOne;
        private System.Windows.Forms.Label lblValueTwo;
        private System.Windows.Forms.TextBox txtValueOne;
        private System.Windows.Forms.TextBox txtValueTwo;
        private System.Windows.Forms.Button btnSummation;
        private System.Windows.Forms.Button btnSubsectio;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label3;
    }
}

