using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Concatenation_and_String_Accumulators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //1. Given a number, print it out forwards and backwards, then add them together.Eg. 234 + 432 = 666.
        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            string value = Interaction.InputBox("Enter a number", "Reverse string adder", "");
            string reverseValue = "";

            for (int i = value.Length - 1; i >= 0; i--)
            {
                char reversedChar = Convert.ToChar(value.Substring(i, 1));
                reverseValue += reversedChar;
            }

            int sum = Convert.ToInt32(value) + Convert.ToInt32(reverseValue);
            string displayValues = value + " + " + reverseValue + " = " + sum;
            txtDisplay.Text = displayValues;

        }

        //2. Enter two six digit numbers.From each number, form a new number consisting of the 2nd, 4th, and 6th digits.Find the sum of these new formed numbers.
        //Example: 623841 -> 281, 711846 -> 186, Sum -> 467
        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            string value1 = "";
            while (value1.Length != 6)
            {
                value1 = Interaction.InputBox("Enter the first 6 digit number", "Reverse string adder", "");
                if (value1.Length == 6)
                    break;
                MessageBox.Show("Please enter a 6 digit number");
            }
            string splitValue1 = value1.Substring(1, 1);
            splitValue1 += value1.Substring(3, 1);
            splitValue1 += value1.Substring(5, 1);

            string value2 = "";
            while (value2.Length != 6)
            {
                MessageBox.Show("Please enter a 6 digit number");
                value2 = Interaction.InputBox("Enter the first 6 digit number", "Reverse string adder", "");
            }
            string splitValue2 = value2.Substring(1, 1);
            splitValue2 += value2.Substring(3, 1);
            splitValue2 += value2.Substring(5, 1);

            int sum = Convert.ToInt32(splitValue1) + Convert.ToInt32(splitValue2);
            string displayValues = splitValue1 + " + " + splitValue2 + " = " + sum;
            txtDisplay.Text = displayValues;
        }

        //3. Consider that a drivers registration number has the format 94807856590702. Write a program which checks the validity of this number.
        //If the number is valid, the digits when totalled must be divisible evenly by 7.
        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            string value = "";
            while (value.Length != 14)
            {
                value = Interaction.InputBox("Enter your ID number", "ID number Checker", "");
                if (value.Length == 14)
                    break;
                else
                    MessageBox.Show("Please check that the ID number is the correct length");
            }

            int valueSum = 0;
            for (int i = 0; i < value.Length; i++)
                valueSum += Convert.ToInt32(value[i]);

            valueSum %= 7;

            if (valueSum == 0)
            {
                MessageBox.Show("Valid ID Number");
                string displayValues = value + " % 7 = " + valueSum;
                txtDisplay.Text = displayValues;
            }
            else
                MessageBox.Show("Invalid ID Number");

        }

        //4. Find all 3 digit whole numbers that are divisible by the product of their digits.There are 20 such numbers.
        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";

            for (int number = 100; number <= 999 ; number++) // for the first 3 (100) digit number and the last 3 digit number (999)
            {
                int product = 1;
                string num = number.ToString();

                for (int digit = 0; digit < num.Length; digit++)
                    product *= Convert.ToInt32(num.Substring(digit, 1));
                
                if (product != 0)
                {
                    if (number % product == 0)
                    {
                        txtDisplay.Text += number + "\tis divisible by the product of its digits\t" + product + Environment.NewLine;  
                    }
                }
            }
        }

        //5. For numbers from 1000-2000 determine which are divisible by the sum of the squares of their digits.
        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";

            for (int number = 1000; number <= 2000; number++)
            {
                int sum = 0;
                string num = number.ToString();

                for (int digit = 0; digit < num.Length; digit++)
                {
                    double square = Math.Pow(Convert.ToDouble(num.Substring(digit, 1)) , 2);
                    sum += Convert.ToInt32(square);
                }

                if (sum > 0)
                {
                    if (number % sum == 0)
                    {
                        txtDisplay.Text += number + "\tis divisible by the sum of the squares of its digits\t" + sum + Environment.NewLine;
                    }
                }
            }
        }

        //6. Take a 3 digits numbers like 200, reverse it(002), and then multiply the two numbers.
        //The result 400 is a perfect square. Find all such 3 digit numbers between 100-300.
        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";

            for (int number = 100; number <= 300; number++)
            {
                string num = number.ToString();
                string reversedNum = "";

                for (int digit = num.Length - 1; digit >= 0; digit--)
                {
                    char reversedChar = Convert.ToChar(num.Substring(digit, 1));
                    reversedNum += reversedChar;
                }

                int product = number * Convert.ToInt32(reversedNum);
                double square = Convert.ToDouble(Math.Sqrt(product));

                if (square % 1 == 0)
                {
                    txtDisplay.Text += "Original Number: " + number + "\t\tReversed Number: " + reversedNum + Environment.NewLine + "Product of the Original Number and the Reversed Number: " + product + Environment.NewLine + "The square-root of the Product: " + square + Environment.NewLine;
                }

            }
        }
    }
}
