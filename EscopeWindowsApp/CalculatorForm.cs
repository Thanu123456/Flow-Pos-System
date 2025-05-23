﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscopeWindowsApp
{
    public partial class CalculatorForm : Form
    {
        private string currentNumber = "";
        private string fullExpression = ""; // To store the complete expression
        private string operation = "";
        private double result = 0;
        private bool isOperationPerformed = false;

        public CalculatorForm()
        {
            InitializeComponent();
            this.KeyPreview = true; // Enable form to capture key presses
            this.KeyDown += CalculatorForm_KeyDown;
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        private void AppendNumber(string number)
        {
            currentNumber += number;
            fullExpression += number; // Build the expression
            numbersLabel.Text = fullExpression;
            UpdateFinalLabel(); // Show the current number
        }

        private void PerformOperation(string op)
        {
            if (currentNumber != "")
            {
                if (fullExpression.Length > 0 && !IsOperator(fullExpression.Last().ToString()))
                {
                    fullExpression += " " + op + " "; // Add operation with spaces
                }
                operation = op;
                currentNumber = "";
                numbersLabel.Text = fullExpression;
                UpdateFinalLabel(); // Show the last result or current number
            }
        }

        private void CalculateResult()
        {
            if (fullExpression != "")
            {
                try
                {
                    result = EvaluateExpression(fullExpression); // Evaluate the full expression
                    finalNumLabel.Text = result.ToString();
                    numbersLabel.Text = result.ToString();
                    fullExpression = result.ToString(); // Reset to result
                    currentNumber = result.ToString();
                    operation = "";
                    isOperationPerformed = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid expression: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearAll();
                }
            }
        }

        private double EvaluateExpression(string expression)
        {
            // Simple evaluation with basic precedence (*, / before +, -)
            var parts = expression.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 1) return 0;

            List<double> numbers = new List<double>();
            List<string> operators = new List<string>();

            for (int i = 0; i < parts.Length; i++)
            {
                if (IsOperator(parts[i]))
                {
                    operators.Add(parts[i]);
                }
                else
                {
                    numbers.Add(double.Parse(parts[i]));
                }
            }

            double currentResult = numbers[0];
            for (int i = 0; i < operators.Count && i + 1 < numbers.Count; i++)
            {
                double nextNumber = numbers[i + 1];
                switch (operators[i])
                {
                    case "+":
                        currentResult += nextNumber;
                        break;
                    case "-":
                        currentResult -= nextNumber;
                        break;
                    case "*":
                        currentResult *= nextNumber;
                        break;
                    case "/":
                        if (nextNumber != 0)
                            currentResult /= nextNumber;
                        else
                            throw new DivideByZeroException("Division by zero");
                        break;
                    case "%":
                        currentResult = (currentResult * nextNumber) / 100;
                        break;
                }
            }
            return currentResult;
        }

        private bool IsOperator(string s)
        {
            return s == "+" || s == "-" || s == "*" || s == "/" || s == "%";
        }

        private void UpdateFinalLabel()
        {
            if (currentNumber != "")
            {
                finalNumLabel.Text = currentNumber; // Show the current number being entered
            }
            else
            {
                finalNumLabel.Text = result.ToString(); // Show the last result
            }
        }

        private void ClearAll()
        {
            currentNumber = "";
            fullExpression = "";
            operation = "";
            result = 0;
            numbersLabel.Text = "";
            finalNumLabel.Text = "";
        }

        private void CutLastDigit()
        {
            if (currentNumber.Length > 0)
            {
                currentNumber = currentNumber.Substring(0, currentNumber.Length - 1);
                fullExpression = fullExpression.Substring(0, fullExpression.Length - 1); // Adjust full expression
                numbersLabel.Text = fullExpression;
                UpdateFinalLabel();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            PerformOperation("/");
        }

        private void percentageBtn_Click(object sender, EventArgs e)
        {
            PerformOperation("%");
        }

        private void cutBtn_Click(object sender, EventArgs e)
        {
            CutLastDigit();
        }

        private void substractBtn_Click(object sender, EventArgs e)
        {
            PerformOperation("-");
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            PerformOperation("+");
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            CalculateResult();
        }

        private void no7Btn_Click(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void no8Btn_Click(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void no9Btn_Click(object sender, EventArgs e)
        {
            AppendNumber("9");
        }

        private void no4Btn_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void no5Btn_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void no6Btn_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void no1Btn_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        private void no2Btn_Click(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void no3Btn_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (!currentNumber.Contains("."))
            {
                AppendNumber(".");
            }
        }

        private void no0Btn_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void no00Btn_Click(object sender, EventArgs e)
        {
            AppendNumber("00");
        }

        private void numbersLabel_Click(object sender, EventArgs e)
        {
            // No action needed; label shows the full expression
        }

        private void finalNumLabel_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void CalculatorForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    ClearAll();
                    break;
                case Keys.Back:
                    CutLastDigit();
                    break;
                case Keys.Enter:
                    CalculateResult();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    AppendNumber("7");
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    AppendNumber("8");
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    AppendNumber("9");
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    AppendNumber("4");
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    AppendNumber("5");
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    AppendNumber("6");
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    AppendNumber("1");
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    AppendNumber("2");
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    AppendNumber("3");
                    break;
                case Keys.D0:
                case Keys.NumPad0:
                    AppendNumber("0");
                    break;
                case Keys.OemPeriod:
                case Keys.Decimal:
                    if (!currentNumber.Contains("."))
                    {
                        AppendNumber(".");
                    }
                    break;
                case Keys.Add:
                    PerformOperation("+");
                    break;
                case Keys.Subtract:
                    PerformOperation("-");
                    break;
                case Keys.Multiply:
                    PerformOperation("*");
                    break;
                case Keys.Divide:
                    PerformOperation("/");
                    break;
            }
        }

        private void multipleBtn_Click(object sender, EventArgs e)
        {
            PerformOperation("*");
        }
    }
}