namespace stackcalculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.calculatorDisplay = new System.Windows.Forms.TextBox();
            this.listDisplay = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.timesButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.popButton = new System.Windows.Forms.Button();
            this.pushButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.BackColor = System.Drawing.SystemColors.WindowText;
            this.calculatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorDisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.calculatorDisplay.Location = new System.Drawing.Point(42, 60);
            this.calculatorDisplay.Multiline = true;
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.Size = new System.Drawing.Size(537, 88);
            this.calculatorDisplay.TabIndex = 0;
            this.calculatorDisplay.Text = "0";
            this.calculatorDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listDisplay
            // 
            this.listDisplay.BackColor = System.Drawing.SystemColors.WindowText;
            this.listDisplay.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.listDisplay.Location = new System.Drawing.Point(598, 60);
            this.listDisplay.Multiline = true;
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(328, 744);
            this.listDisplay.TabIndex = 1;
            this.listDisplay.Text = " empty ";
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(51, 569);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(114, 97);
            this.num1.TabIndex = 2;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(185, 569);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(114, 97);
            this.num2.TabIndex = 3;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(319, 569);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(114, 97);
            this.num3.TabIndex = 4;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(51, 447);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(114, 97);
            this.num4.TabIndex = 5;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(185, 447);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(114, 97);
            this.num5.TabIndex = 6;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(319, 447);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(114, 97);
            this.num6.TabIndex = 7;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(51, 322);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(114, 97);
            this.num7.TabIndex = 8;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(185, 322);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(114, 97);
            this.num8.TabIndex = 9;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(319, 322);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(114, 97);
            this.num9.TabIndex = 10;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(51, 690);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(114, 97);
            this.num0.TabIndex = 11;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(185, 690);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(248, 97);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plusButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.ForeColor = System.Drawing.Color.White;
            this.plusButton.Location = new System.Drawing.Point(455, 322);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(111, 97);
            this.plusButton.TabIndex = 13;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.op);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.minusButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.Color.White;
            this.minusButton.Location = new System.Drawing.Point(455, 447);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(111, 97);
            this.minusButton.TabIndex = 14;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.op);
            // 
            // timesButton
            // 
            this.timesButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.timesButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.timesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesButton.ForeColor = System.Drawing.Color.White;
            this.timesButton.Location = new System.Drawing.Point(455, 569);
            this.timesButton.Name = "timesButton";
            this.timesButton.Size = new System.Drawing.Size(111, 97);
            this.timesButton.TabIndex = 15;
            this.timesButton.Text = "x";
            this.timesButton.UseVisualStyleBackColor = false;
            this.timesButton.Click += new System.EventHandler(this.op);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.divideButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.ForeColor = System.Drawing.Color.White;
            this.divideButton.Location = new System.Drawing.Point(455, 690);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(111, 97);
            this.divideButton.TabIndex = 16;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.op);
            // 
            // popButton
            // 
            this.popButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.popButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.popButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popButton.ForeColor = System.Drawing.Color.White;
            this.popButton.Location = new System.Drawing.Point(51, 181);
            this.popButton.Name = "popButton";
            this.popButton.Size = new System.Drawing.Size(248, 117);
            this.popButton.TabIndex = 17;
            this.popButton.Text = "Pop";
            this.popButton.UseVisualStyleBackColor = false;
            this.popButton.Click += new System.EventHandler(this.popButton_Click);
            // 
            // pushButton
            // 
            this.pushButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pushButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.pushButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pushButton.ForeColor = System.Drawing.Color.White;
            this.pushButton.Location = new System.Drawing.Point(319, 181);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(248, 117);
            this.pushButton.TabIndex = 18;
            this.pushButton.Text = "Push";
            this.pushButton.UseVisualStyleBackColor = false;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 837);
            this.Controls.Add(this.pushButton);
            this.Controls.Add(this.popButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.timesButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.listDisplay);
            this.Controls.Add(this.calculatorDisplay);
            this.Name = "Form1";
            this.Text = "-";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calculatorDisplay;
        private System.Windows.Forms.TextBox listDisplay;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button timesButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button popButton;
        private System.Windows.Forms.Button pushButton;
    }
}

