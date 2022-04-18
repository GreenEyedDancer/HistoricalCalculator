using System.Drawing;

namespace Calculator
{
    partial class Calculator
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Screen = new System.Windows.Forms.TextBox();
            this.ButtonPlusMinus = new System.Windows.Forms.Button();
            this.ButtonComma = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.ButtonDivision = new System.Windows.Forms.Button();
            this.ButtonSquareRoot = new System.Windows.Forms.Button();
            this.ButtonMultiplication = new System.Windows.Forms.Button();
            this.ButtonPercent = new System.Windows.Forms.Button();
            this.ButtonSubtraction = new System.Windows.Forms.Button();
            this.ButtonInverse = new System.Windows.Forms.Button();
            this.ButtonAddition = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonBackspace = new System.Windows.Forms.Button();
            this.ButtonClearEveything = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Location = new System.Drawing.Point(12, 12);
            this.Screen.Name = "Screen";
            this.Screen.ReadOnly = true;
            this.Screen.Size = new System.Drawing.Size(368, 20);
            this.Screen.TabIndex = 1;
            // 
            // ButtonPlusMinus
            // 
            this.ButtonPlusMinus.ForeColor = System.Drawing.Color.Blue;
            this.ButtonPlusMinus.Location = new System.Drawing.Point(136, 253);
            this.ButtonPlusMinus.Name = "ButtonPlusMinus";
            this.ButtonPlusMinus.Size = new System.Drawing.Size(56, 54);
            this.ButtonPlusMinus.TabIndex = 2;
            this.ButtonPlusMinus.Text = "+/-";
            this.ButtonPlusMinus.UseVisualStyleBackColor = true;
            this.ButtonPlusMinus.Click += new System.EventHandler(this.NumberPlusMinus_Click);
            // 
            // ButtonComma
            // 
            this.ButtonComma.ForeColor = System.Drawing.Color.Blue;
            this.ButtonComma.Location = new System.Drawing.Point(198, 253);
            this.ButtonComma.Name = "ButtonComma";
            this.ButtonComma.Size = new System.Drawing.Size(56, 54);
            this.ButtonComma.TabIndex = 3;
            this.ButtonComma.Text = ",";
            this.ButtonComma.UseVisualStyleBackColor = true;
            this.ButtonComma.Click += new System.EventHandler(this.ButtonComma_Click);
            // 
            // Button0
            // 
            this.Button0.ForeColor = System.Drawing.Color.Blue;
            this.Button0.Location = new System.Drawing.Point(74, 253);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(56, 54);
            this.Button0.TabIndex = 0;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // Button1
            // 
            this.Button1.ForeColor = System.Drawing.Color.Blue;
            this.Button1.Location = new System.Drawing.Point(74, 193);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(56, 54);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.ForeColor = System.Drawing.Color.Blue;
            this.Button2.Location = new System.Drawing.Point(136, 193);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(56, 54);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.ForeColor = System.Drawing.Color.Blue;
            this.Button3.Location = new System.Drawing.Point(198, 193);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(56, 54);
            this.Button3.TabIndex = 6;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.ForeColor = System.Drawing.Color.Blue;
            this.Button4.Location = new System.Drawing.Point(74, 133);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(56, 54);
            this.Button4.TabIndex = 7;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.ForeColor = System.Drawing.Color.Blue;
            this.Button5.Location = new System.Drawing.Point(136, 133);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(56, 54);
            this.Button5.TabIndex = 8;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.ForeColor = System.Drawing.Color.Blue;
            this.Button6.Location = new System.Drawing.Point(198, 133);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(56, 54);
            this.Button6.TabIndex = 9;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button7
            // 
            this.Button7.ForeColor = System.Drawing.Color.Blue;
            this.Button7.Location = new System.Drawing.Point(74, 73);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(56, 54);
            this.Button7.TabIndex = 10;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button8
            // 
            this.Button8.ForeColor = System.Drawing.Color.Blue;
            this.Button8.Location = new System.Drawing.Point(136, 73);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(56, 54);
            this.Button8.TabIndex = 11;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button9
            // 
            this.Button9.ForeColor = System.Drawing.Color.Blue;
            this.Button9.Location = new System.Drawing.Point(198, 73);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(56, 54);
            this.Button9.TabIndex = 12;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // ButtonDivision
            // 
            this.ButtonDivision.ForeColor = System.Drawing.Color.Red;
            this.ButtonDivision.Location = new System.Drawing.Point(260, 73);
            this.ButtonDivision.Name = "ButtonDivision";
            this.ButtonDivision.Size = new System.Drawing.Size(56, 54);
            this.ButtonDivision.TabIndex = 13;
            this.ButtonDivision.Text = "/";
            this.ButtonDivision.UseVisualStyleBackColor = true;
            this.ButtonDivision.Click += new System.EventHandler(this.ButtonDivision_Click);
            // 
            // ButtonSquareRoot
            // 
            this.ButtonSquareRoot.ForeColor = System.Drawing.Color.Blue;
            this.ButtonSquareRoot.Location = new System.Drawing.Point(322, 73);
            this.ButtonSquareRoot.Name = "ButtonSquareRoot";
            this.ButtonSquareRoot.Size = new System.Drawing.Size(56, 54);
            this.ButtonSquareRoot.TabIndex = 14;
            this.ButtonSquareRoot.Text = "sqrt";
            this.ButtonSquareRoot.UseVisualStyleBackColor = false;
            this.ButtonSquareRoot.Click += new System.EventHandler(this.ButtonSquareRoot_Click);
            // 
            // ButtonMultiplication
            // 
            this.ButtonMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ButtonMultiplication.ForeColor = System.Drawing.Color.Red;
            this.ButtonMultiplication.Location = new System.Drawing.Point(260, 133);
            this.ButtonMultiplication.Name = "ButtonMultiplication";
            this.ButtonMultiplication.Size = new System.Drawing.Size(56, 54);
            this.ButtonMultiplication.TabIndex = 15;
            this.ButtonMultiplication.Text = "*";
            this.ButtonMultiplication.UseVisualStyleBackColor = true;
            this.ButtonMultiplication.Click += new System.EventHandler(this.ButtonMultiplication_Click);
            // 
            // ButtonPercent
            // 
            this.ButtonPercent.ForeColor = System.Drawing.Color.Blue;
            this.ButtonPercent.Location = new System.Drawing.Point(322, 133);
            this.ButtonPercent.Name = "ButtonPercent";
            this.ButtonPercent.Size = new System.Drawing.Size(56, 54);
            this.ButtonPercent.TabIndex = 16;
            this.ButtonPercent.Text = "%";
            this.ButtonPercent.UseVisualStyleBackColor = true;
            this.ButtonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // ButtonSubtraction
            // 
            this.ButtonSubtraction.ForeColor = System.Drawing.Color.Red;
            this.ButtonSubtraction.Location = new System.Drawing.Point(260, 193);
            this.ButtonSubtraction.Name = "ButtonSubtraction";
            this.ButtonSubtraction.Size = new System.Drawing.Size(56, 54);
            this.ButtonSubtraction.TabIndex = 17;
            this.ButtonSubtraction.Text = "--";
            this.ButtonSubtraction.UseVisualStyleBackColor = true;
            this.ButtonSubtraction.Click += new System.EventHandler(this.ButtonSubtraction_Click);
            // 
            // ButtonInverse
            // 
            this.ButtonInverse.ForeColor = System.Drawing.Color.Blue;
            this.ButtonInverse.Location = new System.Drawing.Point(324, 193);
            this.ButtonInverse.Name = "ButtonInverse";
            this.ButtonInverse.Size = new System.Drawing.Size(56, 54);
            this.ButtonInverse.TabIndex = 18;
            this.ButtonInverse.Text = "1/x";
            this.ButtonInverse.UseVisualStyleBackColor = true;
            this.ButtonInverse.Click += new System.EventHandler(this.ButtonInverse_Click);
            // 
            // ButtonAddition
            // 
            this.ButtonAddition.ForeColor = System.Drawing.Color.Red;
            this.ButtonAddition.Location = new System.Drawing.Point(260, 253);
            this.ButtonAddition.Name = "ButtonAddition";
            this.ButtonAddition.Size = new System.Drawing.Size(56, 54);
            this.ButtonAddition.TabIndex = 19;
            this.ButtonAddition.Text = "+";
            this.ButtonAddition.UseVisualStyleBackColor = true;
            this.ButtonAddition.Click += new System.EventHandler(this.ButtonAddition_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.ForeColor = System.Drawing.Color.Red;
            this.ButtonEquals.Location = new System.Drawing.Point(322, 253);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(56, 54);
            this.ButtonEquals.TabIndex = 20;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // ButtonBackspace
            // 
            this.ButtonBackspace.ForeColor = System.Drawing.Color.Red;
            this.ButtonBackspace.Location = new System.Drawing.Point(81, 38);
            this.ButtonBackspace.Name = "ButtonBackspace";
            this.ButtonBackspace.Size = new System.Drawing.Size(95, 29);
            this.ButtonBackspace.TabIndex = 21;
            this.ButtonBackspace.Text = "Backspace";
            this.ButtonBackspace.UseVisualStyleBackColor = true;
            this.ButtonBackspace.Click += new System.EventHandler(this.ButtonBackspace_Click);
            // 
            // ButtonClearEveything
            // 
            this.ButtonClearEveything.ForeColor = System.Drawing.Color.Red;
            this.ButtonClearEveything.Location = new System.Drawing.Point(182, 38);
            this.ButtonClearEveything.Name = "ButtonClearEveything";
            this.ButtonClearEveything.Size = new System.Drawing.Size(95, 29);
            this.ButtonClearEveything.TabIndex = 22;
            this.ButtonClearEveything.Text = "CE";
            this.ButtonClearEveything.UseVisualStyleBackColor = true;
            this.ButtonClearEveything.Click += new System.EventHandler(this.ButtonClearEverything_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.ForeColor = System.Drawing.Color.Red;
            this.ButtonClear.Location = new System.Drawing.Point(283, 38);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(95, 29);
            this.ButtonClear.TabIndex = 23;
            this.ButtonClear.Text = "C";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 317);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonClearEveything);
            this.Controls.Add(this.ButtonBackspace);
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.ButtonAddition);
            this.Controls.Add(this.ButtonInverse);
            this.Controls.Add(this.ButtonSubtraction);
            this.Controls.Add(this.ButtonPercent);
            this.Controls.Add(this.ButtonMultiplication);
            this.Controls.Add(this.ButtonSquareRoot);
            this.Controls.Add(this.ButtonDivision);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ButtonComma);
            this.Controls.Add(this.ButtonPlusMinus);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.Button0);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.Button ButtonPlusMinus;
        private System.Windows.Forms.Button ButtonComma;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button ButtonDivision;
        private System.Windows.Forms.Button ButtonSquareRoot;
        private System.Windows.Forms.Button ButtonMultiplication;
        private System.Windows.Forms.Button ButtonPercent;
        private System.Windows.Forms.Button ButtonSubtraction;
        private System.Windows.Forms.Button ButtonInverse;
        private System.Windows.Forms.Button ButtonAddition;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonBackspace;
        private System.Windows.Forms.Button ButtonClearEveything;
        private System.Windows.Forms.Button ButtonClear;
    }
}

