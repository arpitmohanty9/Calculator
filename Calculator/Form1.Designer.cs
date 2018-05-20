namespace Calculator
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
            this.components = new System.ComponentModel.Container();
            this.display_output = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.hash = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.dec_point = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display_output
            // 
            this.display_output.Font = new System.Drawing.Font("Arial Narrow", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_output.Location = new System.Drawing.Point(21, 12);
            this.display_output.Name = "display_output";
            this.display_output.Size = new System.Drawing.Size(761, 59);
            this.display_output.TabIndex = 0;
            this.display_output.Text = "0";
            this.display_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display_output.TextChanged += new System.EventHandler(this.display_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(21, 127);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(128, 72);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(194, 127);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(128, 72);
            this.two.TabIndex = 3;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(362, 127);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(128, 72);
            this.three.TabIndex = 4;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(21, 205);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(128, 72);
            this.four.TabIndex = 5;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(194, 205);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(128, 72);
            this.five.TabIndex = 6;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(362, 205);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(128, 72);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(21, 283);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(128, 72);
            this.seven.TabIndex = 8;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(194, 283);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(128, 72);
            this.eight.TabIndex = 9;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(362, 283);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(128, 72);
            this.nine.TabIndex = 10;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(194, 366);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(128, 72);
            this.zero.TabIndex = 11;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_click);
            // 
            // hash
            // 
            this.hash.Location = new System.Drawing.Point(362, 366);
            this.hash.Name = "hash";
            this.hash.Size = new System.Drawing.Size(128, 72);
            this.hash.TabIndex = 13;
            this.hash.Text = "#";
            this.hash.UseVisualStyleBackColor = true;
            this.hash.Click += new System.EventHandler(this.hash_Click);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(520, 127);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(128, 72);
            this.addition.TabIndex = 14;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.operator_click);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(654, 127);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(128, 72);
            this.subtraction.TabIndex = 15;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.operator_click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(520, 205);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(128, 72);
            this.division.TabIndex = 16;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.operator_click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(654, 205);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(128, 72);
            this.multiplication.TabIndex = 17;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.operator_click);
            // 
            // dec_point
            // 
            this.dec_point.Location = new System.Drawing.Point(654, 283);
            this.dec_point.Name = "dec_point";
            this.dec_point.Size = new System.Drawing.Size(128, 72);
            this.dec_point.TabIndex = 19;
            this.dec_point.Text = ".";
            this.dec_point.UseVisualStyleBackColor = true;
            this.dec_point.Click += new System.EventHandler(this.operator_click);
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(520, 366);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(128, 72);
            this.History.TabIndex = 20;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Clear
            // 
            this.Clear.FlatAppearance.BorderSize = 2;
            this.Clear.Location = new System.Drawing.Point(654, 366);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(128, 72);
            this.Clear.TabIndex = 21;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.History);
            this.Controls.Add(this.dec_point);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.division);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.hash);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.display_output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display_output;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button hash;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button dec_point;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button Clear;
    }
}

