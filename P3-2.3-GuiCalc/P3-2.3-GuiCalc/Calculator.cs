using System;
using Algebraic;
using Arithmetic;
using Trigonometric;
using System.Windows.Forms;

/**
 * @Author Chris Kalms
 * @Created 09/05/19
 * @Version 2.0
 **/

namespace P3_2._3_GuiCalc
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            /* Sets the focus to the textbox so the keyboard
             * can be used straight away.
             */
            tbResult.Focus();
        } 

        //Holds the value from equations
        private double valueHolder = 0;
        //Used for the printing of the total
        private double total = 0;
        //used to see if the value in the textbox is the total
        private bool isTotal = false;   
        /* These are set after the corresponding
         * buttons are clicked
         */          
        private bool plusButtonClicked = false;
        private bool minusButtonClicked = false;
        private bool divisionButtonClicked = false;
        private bool multiplyButtonClicked = false;

        //print 1 to tbResult
        private void BtnOne_Click(object sender, EventArgs e)
        {            
            if (isTotal)
            {
                tbResult.Text = "1";
                isTotal = false;
            }
            else
                tbResult.Text += "1";
        }

        //print 2 to tbResult
        private void BtnTwo_Click(object sender, EventArgs e)
        {
            if (isTotal)
            {
                tbResult.Text = "2";
                isTotal = false;
            }
            else
                tbResult.Text += "2";
        }

        //print 3 to tbResult
        private void BtnThree_Click(object sender, EventArgs e)
        {
            if (isTotal)
            {
                tbResult.Text = "3";
                isTotal = false;
            }
            else
                tbResult.Text += "3";
        }

        //print 4 to tbResult
        private void BtnFour_Click(object sender, EventArgs e)
        {
            if (isTotal)
            {
                tbResult.Text = "4";
                isTotal = false;
            }
            else
                tbResult.Text += "4";
        }

        //print 5 to tbResult
        private void BtnFive_Click(object sender, EventArgs e)
        {
            if (isTotal)
            {
                tbResult.Text = "5";
                isTotal = false;
            }
            else
                tbResult.Text += "5";
        }

        //print 6 to tbResult
        private void BtnSix_Click(object sender, EventArgs e)
        {
            if (isTotal)
            {
                tbResult.Text = "6";
                isTotal = false;
            }
            else
                tbResult.Text += "6";
        }

        //print 7 to tbResult
        private void BtnSeven_Click(object sender, EventArgs e)
        {
            if (isTotal)
            {
                tbResult.Text = "7";
                isTotal = false;
            }
            else
                tbResult.Text += "7";
        }

        //print 8 to tbResult
        private void BtnEight_Click(object sender, EventArgs e)
        {
            if (isTotal)
            {
                tbResult.Text = "8";
                isTotal = false;
            }
            else
                tbResult.Text += "8";
        }

        //print 9 to tbResult
        private void BtnNine_Click(object sender, EventArgs e)
        {
            if (isTotal)
            {
                tbResult.Text = "9";
                isTotal = false;
            }
            else
                tbResult.Text += "9";
        }

        //print 0 to tbResult
        private void BtnZero_Click(object sender, EventArgs e)
        {
            if (isTotal)
            {
                tbResult.Text = "0";
                isTotal = false;
            }
            else
                tbResult.Text += "0";
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            //if Input call the Third Party library and perform the multiplication function
            if (CheckForInput(tbResult.Text))
            {
                if(!(plusButtonClicked && multiplyButtonClicked && minusButtonClicked && divisionButtonClicked))
                    valueHolder = double.Parse(tbResult.Text);
                else
                    valueHolder = BasicMath.Multiplication(valueHolder, double.Parse(tbResult.Text));
                
                tbResult.Clear();
                plusButtonClicked = false;
                minusButtonClicked = false;
                divisionButtonClicked = false;
                multiplyButtonClicked = true;
            }
            //if invalid input print error to user
            else
                MessageBox.Show("Please enter valid input");            
            isTotal = false;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {            
            //if there's valid input call the Third Party library and perform the Division function            
            if (CheckForInput(tbResult.Text))
            {
                //if this is the first input set valueHolder to the input
                if (!(plusButtonClicked && multiplyButtonClicked && minusButtonClicked && divisionButtonClicked))
                    valueHolder = double.Parse(tbResult.Text);                
                else
                {
                    //If division returns true output result
                    if (BasicMath.Division(valueHolder, double.Parse(tbResult.Text), out double a))
                        valueHolder = a;                    
                    //If Division retuns false print error to user
                    else
                        MessageBox.Show("Error: Cannot divide by zero");                    
                }
                tbResult.Clear();
                plusButtonClicked = false;
                minusButtonClicked = false;
                divisionButtonClicked = true;
                multiplyButtonClicked = false;
            }
            //if invalid input print error to user
            else
                MessageBox.Show("Please enter valid input");
            
            isTotal = false;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            //check for input in text field 
            if (CheckForInput(tbResult.Text))
            {
                // If this is the first input, set valueHolder to input
                if (!(minusButtonClicked && plusButtonClicked && multiplyButtonClicked
                    && divisionButtonClicked))
                {
                    valueHolder = double.Parse(tbResult.Text);
                    tbResult.Clear();

                    plusButtonClicked = false;
                    minusButtonClicked = true;
                    divisionButtonClicked = false;
                    multiplyButtonClicked = false;
                }
                // If this isn't the first input subtract input from valueHolder
                else
                {
                    valueHolder = BasicMath.Subtraction(valueHolder, double.Parse(tbResult.Text));
                    tbResult.Clear();

                    plusButtonClicked = false;
                    minusButtonClicked = true;
                    divisionButtonClicked = false;
                    multiplyButtonClicked = false;
                }                
            }
            //if there is no input, input to text field "-" 
            else
            {
                if (!tbResult.Text.Contains("-"))
                    tbResult.Text = "-";
            }    
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            //if there is input in the textbox add input to valueHolder
            if (CheckForInput(tbResult.Text))
            {
                valueHolder = BasicMath.Addition(valueHolder, double.Parse(tbResult.Text));
                tbResult.Clear();

                plusButtonClicked = true;
                minusButtonClicked = false;
                divisionButtonClicked = false;
                multiplyButtonClicked = false;
            }
            else
            {
                MessageBox.Show("Please enter valid input");
            }
            
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            tbResult.Text += tbResult.Text.Contains(".") ? "" : ".";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //reset the calculator
            tbResult.Clear();
            valueHolder = 0;
            total = 0;
            isTotal = false;
            plusButtonClicked = minusButtonClicked = divisionButtonClicked = multiplyButtonClicked = false;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            /*depending on the last button to be clicked perform the correct operation 
             * and output the result to the user
             */            
            if (!(multiplyButtonClicked && minusButtonClicked &&
                plusButtonClicked && divisionButtonClicked) && CheckForInput(tbResult.Text))
                total = double.Parse(tbResult.Text);  
            if (!double.TryParse(tbResult.Text, out double lastInput))
                return;
            if (plusButtonClicked)
                total = BasicMath.Addition(valueHolder, lastInput);
            else if (minusButtonClicked)
                total = BasicMath.Subtraction(valueHolder, lastInput);
            else if (multiplyButtonClicked)
                total = BasicMath.Multiplication(valueHolder, lastInput);
            else if (divisionButtonClicked)
            {
                if (BasicMath.Division(valueHolder, lastInput, out double setTotal))
                    total = setTotal;
                else
                {
                    MessageBox.Show("Error: Cannot Divide By Zero");
                    return;
                }
            }
            //print result
            tbResult.Text = $"{total}";
            //reset calculator
            valueHolder = 0;
            total = 0;
            isTotal = true;
            plusButtonClicked = minusButtonClicked = divisionButtonClicked = multiplyButtonClicked = false;
        }

        private void BtnSqRt_Click(object sender, EventArgs e)
        {
            //if there's input call the Third library and perform the square root function
            if (CheckForInput(tbResult.Text))
            {
                //if square root returns true, output result
                if(Algebra.SquareRoot(double.Parse(tbResult.Text),out double output))
                {
                    tbResult.Text = output.ToString();
                    isTotal = true;
                }
                //if false is returned print error to user
                else
                    MessageBox.Show("Invalid Input");                
            }
            //if there's no input or input is invalid print error to user
            else
                MessageBox.Show("Please enter valid input");

        }

        private void BtnCubeRoot_Click(object sender, EventArgs e)
        {
            //if there's input call the Third library and perform the cube root function
            if (CheckForInput(tbResult.Text))
            {
                tbResult.Text = Algebra.CubeRoot(double.Parse(tbResult.Text)).ToString();
                isTotal = true;
            }
            //if there's no input or input is invalid print error to user
            else
                MessageBox.Show("Please enter valid input");

        }

        private void BtnSin_Click(object sender, EventArgs e)
        {
            //if there's input call the Third library and perform the sin function
            if (CheckForInput(tbResult.Text))
            {
                tbResult.Text = Trigonometry.DegreesSin(double.Parse(tbResult.Text)).ToString();
                isTotal = true;
            }
            //if there's no input or input is invalid print error to user
            else
                MessageBox.Show("Please enter valid input");            
        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            //if there's input call the Third library and perform the cos function
            if (CheckForInput(tbResult.Text))
            {
                tbResult.Text = Trigonometry.DegreesCos(double.Parse(tbResult.Text)).ToString();
                isTotal = true;
            }
            //if there's no input or input is invalid print error to user
            else
                MessageBox.Show("Please enter valid input");
            
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            //if there's input call the Third library and perform the tan function
            if (CheckForInput(tbResult.Text))
            {
                //if tan returns true output returned value
                if (Trigonometry.DegreesTan(double.Parse(tbResult.Text), out double tan))
                {
                    tbResult.Text = tan.ToString();
                    isTotal = true;
                }
                //if tan returns false print error to user
                else
                    MessageBox.Show("Invalid input");                
            }
            //if there's no input or input is invalid print error to user
            else
                MessageBox.Show("Please enter valid input");
        }

        private void BtnInverse_Click(object sender, EventArgs e)
        {
            //if there's input call the Third library and perform the inverse function
            if (CheckForInput(tbResult.Text))
            {
                //if inverse returns true output returned value
                if(Algebra.Inverse(double.Parse(tbResult.Text), out double output))
                {
                    tbResult.Text = output.ToString();
                    isTotal = true;
                }
                //if inverse returns false print error to user
                else                
                    MessageBox.Show("Error: Cannot Divide By Zero");                                
            }
            //if there's no input or input is invalid print error to user
            else
                MessageBox.Show("Please enter valid input");
        }

        /// <summary>
        /// Checks the value in text field to see if it exists and that
        /// it is a number.
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns>True if value exists and is a number
        ///    , False if value doesn't exist or value isn't a number</returns>
        private bool CheckForInput(string inputValue)
        {
            bool valid = true;
            //trim the input value incase of empty string
            if (inputValue.Trim() == "")
                valid = false;
            //checks to see if input is a number.
            if (!double.TryParse(inputValue, out double dummy))
                valid = false;
            return valid;
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            //if there is data in the text field remove the last character
            if (!string.IsNullOrEmpty(tbResult.Text))
                tbResult.Text = tbResult.Text.Substring(0, tbResult.Text.Length - 1);
        }

        
        private void TbResult_KeyDown(object sender, KeyEventArgs e)
        {
            //Removes ability to press control while in the text box
            if (e.Control == true)
                MessageBox.Show("Copy/Paste options are disabled.");
        }

        private void TbResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow keyboard to enter numbers
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;                       
            
            //control the buttons on the form with the keyboard equivalent
            if (e.KeyChar == 8) //backspace           
                BtnBackSpace_Click(sender, e);                          
            if (e.KeyChar == 61 || e.KeyChar == 13) // = || Enter           
                BtnEquals_Click(sender, e);                          
            if (e.KeyChar == 45) // -
                BtnMinus_Click(sender, e);
            if ((e.KeyChar == 43)) // +
                BtnPlus_Click(sender, e);
            if (e.KeyChar == 42) // *
                BtnMultiply_Click(sender, e);
            if (e.KeyChar == 47) // /
                BtnDivide_Click(sender, e);            
            if (e.KeyChar == 99 || e.KeyChar == 67)
                BtnClear_Click(sender, e);
            if (e.KeyChar == 46) // .                
                BtnDot_Click(sender, e);

            //set the caret at the end of the text box
            tbResult.SelectionStart = tbResult.Text.Length;
            
        }        
    }
}
