﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private MainMenu mainMenu;
        private const string MathSymbols = "+-*/";
        private const string Numbers = "0123456789";
        public Calculator()
        {
            InitializeComponent();
            mainMenu = new MainMenu();
            MenuItem File = mainMenu.MenuItems.Add("&Edit");
            File.MenuItems.Add(new MenuItem("&Who"));
            File.MenuItems.Add(new MenuItem("&Actually"));
            File.MenuItems.Add(new MenuItem("&Cares"));
            this.Menu = mainMenu;
            MenuItem About = mainMenu.MenuItems.Add("&View");
            About.MenuItems.Add(new MenuItem("&View"));
            this.Menu = mainMenu;
            MenuItem Help = mainMenu.MenuItems.Add("&Help");
            Help.MenuItems.Add(new MenuItem("&Me ObiWan Kenobi"));
            this.Menu = mainMenu;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        //private void Screen_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void Number0_Click(object sender, EventArgs e)
        {
            Screen.Text += "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Screen.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Screen.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Screen.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Screen.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Screen.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Screen.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Screen.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Screen.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Screen.Text += "9";
        }

        private void NumberPlusMinus_Click(object sender, EventArgs e)
        {
            if (!HasMathSymbolOnScreen(Screen.Text))
            {
                if (Screen.Text.First() == '-')
                    Screen.Text = Screen.Text.Remove(0, 1);
                else
                    Screen.Text = '-' + Screen.Text;
            }
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Screen.Text) || MathSymbols.Contains(Screen.Text.Last()))
                Screen.Text += "0,";
            else if (!NumberAlreadyHasDot(Screen.Text))
                Screen.Text += ",";
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            Screen.Text = AddOrReplaceSymbol(Screen.Text, '+');
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length < 3 || !HasMathSymbolOnScreen(Screen.Text))
                return;

            float firstNumber = 0, secondNumber = 0;
            char symbol = ' ';

            for (int i = 1; i < Screen.Text.Length; i++)
            {
                if (MathSymbols.Contains(Screen.Text[i]))
                {
                    firstNumber = float.Parse(Screen.Text.Substring(0, i));
                    symbol = Screen.Text[i];
                    secondNumber = float.Parse(Screen.Text.Substring(i + 1, Screen.Text.Length - i - 1));
                    break;
                }
            }

            Screen.Text = ReturnEqualityResult(symbol, firstNumber, secondNumber);
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            Screen.Text = AddOrReplaceSymbol(Screen.Text, '-');
        }

        private void ButtonInverse_Click(object sender, EventArgs e)
        {
            if (!HasMathSymbolOnScreen(Screen.Text))
            {
                double result = double.Parse(Screen.Text);
                result = 1 / result;
                Screen.Text = result.ToString();
            }
        }

        private void ButtonStar_Click(object sender, EventArgs e)
        {
            Screen.Text = AddOrReplaceSymbol(Screen.Text, '*');
        }

        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            if (!HasMathSymbolOnScreen(Screen.Text))
            {
                double result = double.Parse(Screen.Text);
                result *= 100;
                Screen.Text = result.ToString() + "%";
            }
        }

        private void ButtonSlash_Click(object sender, EventArgs e)
        {
            Screen.Text = AddOrReplaceSymbol(Screen.Text, '/');
        }

        private void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            if (!HasMathSymbolOnScreen(Screen.Text))
            {
                double result = double.Parse(Screen.Text);
                result = Math.Sqrt(result);
                Screen.Text = result.ToString();
            }
        }

        private void ButtonBackspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Screen.Text))
                Screen.Text = DeleteLastCharacter(Screen.Text);
        }

        private void ButtonClearEverything_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
        }

        private string DeleteLastCharacter(string text)
        {
            return text.Remove(text.Length - 1, 1);
        }

        private bool NumberAlreadyHasDot(string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (text[i] == ',')
                    return true;
                else if (MathSymbols.Contains(text[i]))
                    return false;
            }

            return false;
        }

        private string AddOrReplaceSymbol(string text, char newSymbol)
        {
            if (!string.IsNullOrEmpty(text) && MathSymbols.Contains(text.Last()))
                text = DeleteLastCharacter(text);
            else if (HasMathSymbolOnScreen(text) || string.IsNullOrEmpty(text))
                return text;

            return text + newSymbol;
        }

        private bool HasMathSymbolOnScreen(string text)
        {
            if (!string.IsNullOrEmpty(text) && MinusIsFirstCharcter(text))
                return HasMathSymbolOnScreen(text.Remove(0, 1));

            return text.Any(t => MathSymbols.Contains(t));
        }

        private bool MinusIsFirstCharcter(string text)
        {
            return text.First() == '-';
        }

        private string ReturnEqualityResult(char symbol, float firstNumber, float secondNumber)
        {
            switch (symbol)
            {
                case '+':
                    return (firstNumber + secondNumber).ToString();
                case '-':
                    return (firstNumber - secondNumber).ToString();
                case '*':
                    return (firstNumber * secondNumber).ToString();
                case '/':
                    return (firstNumber / secondNumber).ToString();
                default:
                    return Screen.Text;
            }
        }

        //not ready yet
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            var kc = new KeysConverter();
            var keyPressed = char.Parse(kc.ConvertToString(e.KeyCode));
            if (keyPressed > 47 && keyPressed < 58)
            {
                Screen.Text += keyPressed;
            }
        }
    }
}
