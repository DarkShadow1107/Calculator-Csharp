namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonFactorial = new System.Windows.Forms.Button();
            this.ButtonProcent = new System.Windows.Forms.Button();
            this.ButtonBackspace = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ButtonSquareRoot = new System.Windows.Forms.Button();
            this.ButtonPower = new System.Windows.Forms.Button();
            this.Button_Inverse = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.ButtonPlusMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.Black;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.White;
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(370, 46);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonC
            // 
            this.ButtonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonC.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonC.ForeColor = System.Drawing.Color.OrangeRed;
            this.ButtonC.Location = new System.Drawing.Point(12, 64);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(88, 68);
            this.ButtonC.TabIndex = 1;
            this.ButtonC.Text = "C";
            this.ButtonC.UseVisualStyleBackColor = false;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // ButtonFactorial
            // 
            this.ButtonFactorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonFactorial.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFactorial.ForeColor = System.Drawing.Color.Lime;
            this.ButtonFactorial.Location = new System.Drawing.Point(106, 64);
            this.ButtonFactorial.Name = "ButtonFactorial";
            this.ButtonFactorial.Size = new System.Drawing.Size(88, 68);
            this.ButtonFactorial.TabIndex = 2;
            this.ButtonFactorial.Text = "x!";
            this.ButtonFactorial.UseVisualStyleBackColor = false;
            this.ButtonFactorial.Click += new System.EventHandler(this.ButtonFactorial_Click);
            // 
            // ButtonProcent
            // 
            this.ButtonProcent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonProcent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonProcent.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonProcent.ForeColor = System.Drawing.Color.Lime;
            this.ButtonProcent.Location = new System.Drawing.Point(200, 64);
            this.ButtonProcent.Name = "ButtonProcent";
            this.ButtonProcent.Size = new System.Drawing.Size(88, 68);
            this.ButtonProcent.TabIndex = 3;
            this.ButtonProcent.Text = "%";
            this.ButtonProcent.UseVisualStyleBackColor = false;
            this.ButtonProcent.Click += new System.EventHandler(this.Operational_Functions);
            // 
            // ButtonBackspace
            // 
            this.ButtonBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonBackspace.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBackspace.ForeColor = System.Drawing.Color.Lime;
            this.ButtonBackspace.Location = new System.Drawing.Point(294, 64);
            this.ButtonBackspace.Name = "ButtonBackspace";
            this.ButtonBackspace.Size = new System.Drawing.Size(88, 68);
            this.ButtonBackspace.TabIndex = 4;
            this.ButtonBackspace.Text = "⌫";
            this.ButtonBackspace.UseVisualStyleBackColor = false;
            this.ButtonBackspace.Click += new System.EventHandler(this.ButtonBackspace_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Lime;
            this.button5.Location = new System.Drawing.Point(294, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 68);
            this.button5.TabIndex = 8;
            this.button5.Text = "÷";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Operational_Functions);
            // 
            // ButtonSquareRoot
            // 
            this.ButtonSquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSquareRoot.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSquareRoot.ForeColor = System.Drawing.Color.Lime;
            this.ButtonSquareRoot.Location = new System.Drawing.Point(200, 138);
            this.ButtonSquareRoot.Name = "ButtonSquareRoot";
            this.ButtonSquareRoot.Size = new System.Drawing.Size(88, 68);
            this.ButtonSquareRoot.TabIndex = 7;
            this.ButtonSquareRoot.Text = "√x";
            this.ButtonSquareRoot.UseVisualStyleBackColor = false;
            this.ButtonSquareRoot.Click += new System.EventHandler(this.ButtonSquareRoot_Click);
            // 
            // ButtonPower
            // 
            this.ButtonPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonPower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonPower.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPower.ForeColor = System.Drawing.Color.Lime;
            this.ButtonPower.Location = new System.Drawing.Point(106, 138);
            this.ButtonPower.Name = "ButtonPower";
            this.ButtonPower.Size = new System.Drawing.Size(88, 68);
            this.ButtonPower.TabIndex = 6;
            this.ButtonPower.Text = "x^y";
            this.ButtonPower.UseVisualStyleBackColor = false;
            this.ButtonPower.Click += new System.EventHandler(this.Operational_Functions);
            // 
            // Button_Inverse
            // 
            this.Button_Inverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Button_Inverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Inverse.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Inverse.ForeColor = System.Drawing.Color.Lime;
            this.Button_Inverse.Location = new System.Drawing.Point(12, 138);
            this.Button_Inverse.Name = "Button_Inverse";
            this.Button_Inverse.Size = new System.Drawing.Size(88, 68);
            this.Button_Inverse.TabIndex = 5;
            this.Button_Inverse.Text = "1/x";
            this.Button_Inverse.UseVisualStyleBackColor = false;
            this.Button_Inverse.Click += new System.EventHandler(this.Button_Inverse_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Lime;
            this.button9.Location = new System.Drawing.Point(294, 212);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 68);
            this.button9.TabIndex = 12;
            this.button9.Text = "×";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Operational_Functions);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(200, 212);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(88, 68);
            this.button10.TabIndex = 11;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.NumericValue);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(106, 212);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(88, 68);
            this.button11.TabIndex = 10;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.NumericValue);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(12, 212);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(88, 68);
            this.button12.TabIndex = 9;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.NumericValue);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Lime;
            this.button13.Location = new System.Drawing.Point(294, 286);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(88, 68);
            this.button13.TabIndex = 16;
            this.button13.Text = "━";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Operational_Functions);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(200, 286);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(88, 68);
            this.button14.TabIndex = 15;
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.NumericValue);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(106, 286);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(88, 68);
            this.button15.TabIndex = 14;
            this.button15.Text = "5";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.NumericValue);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(12, 286);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(88, 68);
            this.button16.TabIndex = 13;
            this.button16.Text = "4";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.NumericValue);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.Lime;
            this.button17.Location = new System.Drawing.Point(294, 360);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(88, 68);
            this.button17.TabIndex = 20;
            this.button17.Text = "+";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.Operational_Functions);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(200, 360);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(88, 68);
            this.button18.TabIndex = 19;
            this.button18.Text = "3";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.NumericValue);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(106, 360);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(88, 68);
            this.button19.TabIndex = 18;
            this.button19.Text = "2";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.NumericValue);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(12, 360);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(88, 68);
            this.button20.TabIndex = 17;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.NumericValue);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonEquals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonEquals.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEquals.ForeColor = System.Drawing.Color.White;
            this.ButtonEquals.Location = new System.Drawing.Point(294, 434);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(88, 68);
            this.ButtonEquals.TabIndex = 24;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = false;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(200, 434);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(88, 68);
            this.button22.TabIndex = 23;
            this.button22.Text = ".";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.NumericValue);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(106, 434);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(88, 68);
            this.button23.TabIndex = 22;
            this.button23.Text = "0";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.NumericValue);
            // 
            // ButtonPlusMinus
            // 
            this.ButtonPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ButtonPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonPlusMinus.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlusMinus.ForeColor = System.Drawing.Color.White;
            this.ButtonPlusMinus.Location = new System.Drawing.Point(12, 433);
            this.ButtonPlusMinus.Name = "ButtonPlusMinus";
            this.ButtonPlusMinus.Size = new System.Drawing.Size(88, 68);
            this.ButtonPlusMinus.TabIndex = 21;
            this.ButtonPlusMinus.Text = "+/-";
            this.ButtonPlusMinus.UseVisualStyleBackColor = false;
            this.ButtonPlusMinus.Click += new System.EventHandler(this.ButtonPlusMinus_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(394, 514);
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.ButtonPlusMinus);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ButtonSquareRoot);
            this.Controls.Add(this.ButtonPower);
            this.Controls.Add(this.Button_Inverse);
            this.Controls.Add(this.ButtonBackspace);
            this.Controls.Add(this.ButtonProcent);
            this.Controls.Add(this.ButtonFactorial);
            this.Controls.Add(this.ButtonC);
            this.Controls.Add(this.txtDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ButtonFactorial;
        private System.Windows.Forms.Button ButtonProcent;
        private System.Windows.Forms.Button ButtonBackspace;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ButtonSquareRoot;
        private System.Windows.Forms.Button ButtonPower;
        private System.Windows.Forms.Button Button_Inverse;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button ButtonPlusMinus;
    }
}

