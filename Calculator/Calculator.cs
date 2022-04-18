using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private MainMenu mainMenu;
        private const string MathSymbols = "+-*/";

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
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Calculator_KeyDown);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        //private void Screen_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void Button0_Click(object sender, EventArgs e)
        {
            HandleDigitButton('0');
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            HandleDigitButton('1');
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            HandleDigitButton('2');
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            HandleDigitButton('3');
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            HandleDigitButton('4');
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            HandleDigitButton('5');
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            HandleDigitButton('6');
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            HandleDigitButton('7');
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            HandleDigitButton('8');
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            HandleDigitButton('9');
        }

        private void NumberPlusMinus_Click(object sender, EventArgs e)
        {
            if (IsNotEmptyAndIsASingleNumber(Screen.Text))
            {
                if (MinusIsFirstCharcter(Screen.Text))
                {
                    Screen.Text = Screen.Text.Remove(0, 1);
                }
                else
                {
                    Screen.Text = '-' + Screen.Text;
                }
            }
        }

        private void ButtonComma_Click(object sender, EventArgs e)
        {
            HandleCommaButton();
        }

        private void ButtonAddition_Click(object sender, EventArgs e)
        {
            HandleAdditionButton();
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            HandleEqualsButton();
        }

        private void ButtonSubtraction_Click(object sender, EventArgs e)
        {
            HandleSubtractionButton();
        }

        private void ButtonInverse_Click(object sender, EventArgs e)
        {
            if (IsNotEmptyAndIsASingleNumber(Screen.Text))
            {
                Screen.Text = HandleDivision(1, float.Parse(Screen.Text));
            }
        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            HandleMultiplicationButton();
        }

        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            HandlePercentButton();
        }

        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            HandleDivisionButton();
        }

        private void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            if (IsNotEmptyAndIsASingleNumber(Screen.Text))
            {
                double result = double.Parse(Screen.Text);
                result = Math.Sqrt(result);
                Screen.Text = result.ToString();
            }
        }
        private void ButtonBackspace_Click(object sender, EventArgs e)
        {
            HandleBackspaceButton();
        }

        private void ButtonClearEverything_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Screen.Text = "";
        }

        private void HandleDigitButton(char digit)
        {
            Screen.Text += digit;
        }

        private void HandleCommaButton()
        {
            if (string.IsNullOrEmpty(Screen.Text) || MathSymbols.Contains(Screen.Text.Last()))
                Screen.Text += "0,";
            else if (NumberAlreadyHasComma(Screen.Text) == false)
                Screen.Text += ',';
        }

        private void HandleAdditionButton()
        {
            Screen.Text = AddOrReplaceSymbol(Screen.Text, '+');
        }

        private void HandleSubtractionButton()
        {
            Screen.Text = AddOrReplaceSymbol(Screen.Text, '-');

        }

        private void HandleMultiplicationButton()
        {
            Screen.Text = AddOrReplaceSymbol(Screen.Text, '*');
        }

        private void HandleDivisionButton()
        {
            Screen.Text = AddOrReplaceSymbol(Screen.Text, '/');
        }

        private void HandleEqualsButton()
        {
            if (string.IsNullOrEmpty(Screen.Text) || IsSingleNumber(Screen.Text))
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

        private void HandlePercentButton()
        {
            if (IsNotEmptyAndIsASingleNumber(Screen.Text) && Screen.Text.Contains('%') == false)
            {
                double result = double.Parse(Screen.Text);
                result *= 100;
                Screen.Text = result.ToString() + "%";
            }
        }

        private void HandleBackspaceButton()
        {
            if (string.IsNullOrEmpty(Screen.Text) == false)
                Screen.Text = DeleteLastCharacter(Screen.Text);
        }

        private string DeleteLastCharacter(string text)
        {
            return text.Remove(text.Length - 1, 1);
        }

        private bool NumberAlreadyHasComma(string text)
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
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }
            if (MathSymbols.Contains(text.Last()))
            {
                text = DeleteLastCharacter(text);
            }
            if (IsSingleNumber(text) == false)
            {
                return text;
            }

            return text + newSymbol;
        }

        private bool MinusIsFirstCharcter(string text)
        {
            return text.First() == '-';
        }

        private bool IsNotEmptyAndIsASingleNumber(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            return IsSingleNumber(text);
        }

        private bool IsSingleNumber(string text)
        {
            if (MinusIsFirstCharcter(text))
            {
                text = text.Remove(0, 1);
            }

            return text.Any(t => MathSymbols.Contains(t)) == false;
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
                    return HandleDivision(firstNumber, secondNumber);
                default:
                    return Screen.Text;
            }
        }

        private string HandleDivision(float firstNumber, float secondNumber)
        {
            if (secondNumber == 0)
            {
                return Screen.Text;
            }
            else
            {
                return (firstNumber / secondNumber).ToString();
            }
        }

        void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "D0":
                case "NumPad0":
                    HandleDigitButton('0');
                    break;
                case "D1":
                case "NumPad1":
                    HandleDigitButton('1');
                    break;
                case "D2":
                case "NumPad2":
                    HandleDigitButton('2');
                    break;
                case "D3":
                case "NumPad3":
                    HandleDigitButton('3');
                    break;
                case "D4":
                case "NumPad4":
                    HandleDigitButton('4');
                    break;
                case "D5":
                case "NumPad5":
                    HandleDigitButton('5');
                    break;
                case "D6":
                case "NumPad6":
                    HandleDigitButton('6');
                    break;
                case "D7":
                case "NumPad7":
                    HandleDigitButton('7');
                    break;
                case "D8":
                case "NumPad8":
                    HandleDigitButton('8');
                    break;
                case "D9":
                case "NumPad9":
                    HandleDigitButton('9');
                    break;
                case "Oemcomma":
                case "OemPeriod":
                case "Decimal":
                    HandleCommaButton();
                    break;
                case "Oemplus":
                case "Add":
                    HandleAdditionButton();
                    break;
                case "OemMinus":
                case "Subtract":
                    HandleSubtractionButton();
                    break;
                case "Multiply":
                    HandleMultiplicationButton();
                    break;
                case "OemQuestion":
                case "Divide":
                    HandleDivisionButton();
                    break;
                case "Return":
                    HandleEqualsButton();
                    break;
                case "Back":
                    HandleBackspaceButton();
                    break;
            }
        }
    }
}
