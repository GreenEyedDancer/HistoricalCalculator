using System.Drawing;

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
            this.Button0 = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.TextBox();
            this.ButtonPlusMinus = new System.Windows.Forms.Button();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.ButtonSlash = new System.Windows.Forms.Button();
            this.ButtonSquareRoot = new System.Windows.Forms.Button();
            this.ButtonStar = new System.Windows.Forms.Button();
            this.ButtonPercent = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonInverse = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonBackspace = new System.Windows.Forms.Button();
            this.ButtonClearEveything = new System.Windows.Forms.Button();
            this.ButtonCear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Location = new System.Drawing.Point(12, 12);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(368, 20);
            this.Screen.TabIndex = 1;
            //this.Screen.TextChanged += new System.EventHandler(this.Screen_TextChanged);
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(74, 253);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(56, 54);
            this.Button0.TabIndex = 0;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Number0_Click);
            // 
            // Button1
            // 
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
            this.Button9.Location = new System.Drawing.Point(198, 73);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(56, 54);
            this.Button9.TabIndex = 12;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // ButtonPlusMinus
            // 
            this.ButtonPlusMinus.Location = new System.Drawing.Point(136, 253);
            this.ButtonPlusMinus.Name = "ButtonPlusMinus";
            this.ButtonPlusMinus.Size = new System.Drawing.Size(56, 54);
            this.ButtonPlusMinus.TabIndex = 2;
            this.ButtonPlusMinus.Text = "+/-";
            this.ButtonPlusMinus.UseVisualStyleBackColor = true;
            this.ButtonPlusMinus.Click += new System.EventHandler(this.NumberPlusMinus_Click);
            // 
            // ButtonDot
            // 
            this.ButtonDot.Location = new System.Drawing.Point(198, 253);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(56, 54);
            this.ButtonDot.TabIndex = 3;
            this.ButtonDot.Text = ",";
            this.ButtonDot.UseVisualStyleBackColor = true;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonDot_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Location = new System.Drawing.Point(260, 253);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(56, 54);
            this.ButtonPlus.TabIndex = 19;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Location = new System.Drawing.Point(322, 253);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(56, 54);
            this.ButtonEquals.TabIndex = 20;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Location = new System.Drawing.Point(260, 193);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(56, 54);
            this.ButtonMinus.TabIndex = 17;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonInverse
            // 
            this.ButtonInverse.Location = new System.Drawing.Point(324, 193);
            this.ButtonInverse.Name = "ButtonInverse";
            this.ButtonInverse.Size = new System.Drawing.Size(56, 54);
            this.ButtonInverse.TabIndex = 18;
            this.ButtonInverse.Text = "1/x";
            this.ButtonInverse.UseVisualStyleBackColor = true;
            this.ButtonInverse.Click += new System.EventHandler(this.ButtonInverse_Click);
            this.ButtonInverse.BackColor = Color.Red;
            // 
            // ButtonStar
            // 
            this.ButtonStar.Location = new System.Drawing.Point(260, 133);
            this.ButtonStar.Name = "ButtonStar";
            this.ButtonStar.Size = new System.Drawing.Size(56, 54);
            this.ButtonStar.TabIndex = 15;
            this.ButtonStar.Text = "*";
            this.ButtonStar.UseVisualStyleBackColor = true;
            this.ButtonStar.Click += new System.EventHandler(this.ButtonStar_Click);
            // 
            // ButtonPercent
            // 
            this.ButtonPercent.Location = new System.Drawing.Point(322, 133);
            this.ButtonPercent.Name = "ButtonPercent";
            this.ButtonPercent.Size = new System.Drawing.Size(56, 54);
            this.ButtonPercent.TabIndex = 16;
            this.ButtonPercent.Text = "%";
            this.ButtonPercent.UseVisualStyleBackColor = true;
            this.ButtonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            this.ButtonPercent.BackColor = Color.Red;
            // 
            // ButtonSlash
            // 
            this.ButtonSlash.Location = new System.Drawing.Point(260, 73);
            this.ButtonSlash.Name = "ButtonSlash";
            this.ButtonSlash.Size = new System.Drawing.Size(56, 54);
            this.ButtonSlash.TabIndex = 13;
            this.ButtonSlash.Text = "/";
            this.ButtonSlash.UseVisualStyleBackColor = true;
            this.ButtonSlash.Click += new System.EventHandler(this.ButtonSlash_Click);
            // 
            // ButtonSquareRoot
            // 
            this.ButtonSquareRoot.Location = new System.Drawing.Point(322, 73);
            this.ButtonSquareRoot.Name = "ButtonSquareRoot";
            this.ButtonSquareRoot.Size = new System.Drawing.Size(56, 54);
            this.ButtonSquareRoot.TabIndex = 14;
            this.ButtonSquareRoot.Text = "sqrt";
            this.ButtonSquareRoot.UseVisualStyleBackColor = true;
            this.ButtonSquareRoot.Click += new System.EventHandler(this.ButtonSquareRoot_Click);
            this.ButtonSquareRoot.BackColor = Color.Red;
            // 
            // ButtonBackspace
            // 
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
            this.ButtonClearEveything.Location = new System.Drawing.Point(182, 38);
            this.ButtonClearEveything.Name = "ButtonClearEveything";
            this.ButtonClearEveything.Size = new System.Drawing.Size(95, 29);
            this.ButtonClearEveything.TabIndex = 22;
            this.ButtonClearEveything.Text = "CE";
            this.ButtonClearEveything.UseVisualStyleBackColor = true;
            this.ButtonClearEveything.Click += new System.EventHandler(this.ButtonClearEverything_Click);
            // 
            // ButtonCear
            // 
            this.ButtonCear.Location = new System.Drawing.Point(283, 38);
            this.ButtonCear.Name = "ButtonCear";
            this.ButtonCear.Size = new System.Drawing.Size(95, 29);
            this.ButtonCear.TabIndex = 23;
            this.ButtonCear.Text = "C";
            this.ButtonCear.UseVisualStyleBackColor = true;
            this.ButtonCear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 317);
            this.Controls.Add(this.ButtonCear);
            this.Controls.Add(this.ButtonClearEveything);
            this.Controls.Add(this.ButtonBackspace);
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ButtonInverse);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonPercent);
            this.Controls.Add(this.ButtonStar);
            this.Controls.Add(this.ButtonSquareRoot);
            this.Controls.Add(this.ButtonSlash);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ButtonDot);
            this.Controls.Add(this.ButtonPlusMinus);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.Button0);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.Button ButtonPlusMinus;
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button ButtonSlash;
        private System.Windows.Forms.Button ButtonSquareRoot;
        private System.Windows.Forms.Button ButtonStar;
        private System.Windows.Forms.Button ButtonPercent;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonInverse;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonBackspace;
        private System.Windows.Forms.Button ButtonClearEveything;
        private System.Windows.Forms.Button ButtonCear;
    }
}

