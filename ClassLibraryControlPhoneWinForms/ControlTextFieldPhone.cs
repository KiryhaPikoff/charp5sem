using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ClassLibraryControlPhoneWinForms
{
    public partial class ControlTextFieldPhone: UserControl
    {
        private string tip = "+7xxxxxxxxxx";
        private string userInput = "";

        public string UserInput {
            get { return checkInput() ? userInput : ""; }
        }

        public Color ErrorColor {
            get; set;
        }

        public ControlTextFieldPhone()
        {
            InitializeComponent();
            showTip();
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            showUserInput();
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (userAlreadyPrintSomething())
            {
                showUserInput();
            }
            else
            {
                showTip();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            userInput = textBox.Text != tip ? textBox.Text : "";
            var isInputCorrect = checkInput();
            if (isInputCorrect)
            {
                textBox.BackColor = Color.White;
            }
            else {
                textBox.BackColor = ErrorColor;
            }  
        }

        private bool checkInput()
        {
            return Regex.IsMatch(textBox.Text, @"^\+7\d{10}$");
        }

        private void showUserInput()
        {
            textBox.Text = userInput;
            textBox.ForeColor = Color.Black;
        }

        private void showTip()
        {
            textBox.Text = tip;
            textBox.ForeColor = Color.Gray;
        }

        private bool userAlreadyPrintSomething() 
        {
            return userInput.Length > 0;
        }
    }
}
