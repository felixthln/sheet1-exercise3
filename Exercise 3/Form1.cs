using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3
{
    public partial class CalculatorForm : Form
    {
        private string firstCalculationValue = "";
        private string secondCalculationValue = "";
        private bool operationButtonClicked = false;
        private int operationNumber = 0;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnButton0_Click(object sender, EventArgs e)
        {
            if (operationNumber == 0 && secondCalculationValue != "")
            {
                // Delete all calculated numbers
                lblCalculationLabel.Text = null;
                firstCalculationValue = "";
                secondCalculationValue = "";
                operationButtonClicked = false;
            }
            AddOperationPart(0);
        }

        private void btnButton1_Click(object sender, EventArgs e)
        {
            AddOperationPart(1);
        }

        private void btnButton2_Click(object sender, EventArgs e)
        {
            AddOperationPart(2);
        }

        private void btnButton3_Click(object sender, EventArgs e)
        {
            AddOperationPart(3);
        }

        private void btnButton4_Click(object sender, EventArgs e)
        {
            AddOperationPart(4);
        }

        private void btnButton5_Click(object sender, EventArgs e)
        {
            AddOperationPart(5);
        }

        private void btnButton6_Click(object sender, EventArgs e)
        {
            AddOperationPart(6);
        }

        private void btnButton7_Click(object sender, EventArgs e)
        {
            AddOperationPart(7);
        }

        private void btnButton8_Click(object sender, EventArgs e)
        {
            AddOperationPart(8);
        }

        private void btnButton9_Click(object sender, EventArgs e)
        {
            AddOperationPart(9);
        }

        private void AddOperationPart(int value)
        {

            if (operationButtonClicked)
            {
                if (secondCalculationValue == "" && value != 0)
                {
                    if (value != 0)
                    {
                        secondCalculationValue = System.Convert.ToString(value);
                    }
                }
                else
                {
                    secondCalculationValue = secondCalculationValue + System.Convert.ToString(value);
                }

                lblCalculationLabel.Text = secondCalculationValue;
            }
            else
            {
                if (firstCalculationValue == "")
                {
                    if (value != 0)
                    {
                        firstCalculationValue = System.Convert.ToString(value);
                    }
                }
                else
                {
                    firstCalculationValue = firstCalculationValue + System.Convert.ToString(value);
                }

                lblCalculationLabel.Text = firstCalculationValue;
            }
        }

        private void btnPlusButton_Click(object sender, EventArgs e)
        {
            operationButtonClicked = true;
            operationNumber = 1;
        }

        private void btnMinusButton_Click(object sender, EventArgs e)
        {
            operationButtonClicked = true;
            operationNumber = 2;
        }

        private void btnMultiplyButton_Click(object sender, EventArgs e)
        {
            operationButtonClicked = true;
            operationNumber = 3;
        }

        private void btnDevideButton_Click(object sender, EventArgs e)
        {
            operationButtonClicked = true;
            operationNumber = 4;
        }

        private void btnEqualsButton_Click(object sender, EventArgs e)
        {
            int firstCalculation = System.Convert.ToInt32(firstCalculationValue);
            int secondCalculation = System.Convert.ToInt32(secondCalculationValue);

            float output;
            switch (operationNumber)
            {
                case 1: output = firstCalculation + secondCalculation;
                break;

                case 2: output = firstCalculation - secondCalculation;
                break;

                case 3: output = firstCalculation * secondCalculation;
                break;

                case 4: output = firstCalculation / secondCalculation;
                break;

                default: output = 0;
                break;
            }

            lblCalculationLabel.Text = System.Convert.ToString(output);
            operationNumber = 0;
        }
    }
}
