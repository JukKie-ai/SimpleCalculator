using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1 {
    public partial class MainPage : ContentPage {
        
        int currentState = 1;
        string Operator;
        double firstNum, secondNum;
        public MainPage() {
            InitializeComponent();
            Clear(this, null);
        }

        void SelectNumber(object sender, EventArgs e) {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (result.Text == "0" || currentState < 0) {
                result.Text = " ";
                if(currentState < 0) {
                    currentState *= -1;
                }
            }

            result.Text += pressed;

            double number;
            if (double.TryParse(result.Text, out number)) {
                result.Text = number.ToString("N0");
                if (currentState == 1) {
                    firstNum = number;
                } else {
                    secondNum = number;
                }
            }
        }

        void SelectOperator(object sender, EventArgs e) {
            currentState = -2;
            Button button = (Button)sender;
            string pressed = button.Text;
            Operator = pressed;
        }

        void Clear(object sender, EventArgs e) {
            firstNum = 0;
            secondNum = 0;
            currentState = 1;
            result.Text = "0";
        }

        void Calculate(object sender, EventArgs e) {
            if (currentState == 2) {
                var finalResult = Calculator.Calculate(firstNum, secondNum, Operator);

                result.Text = finalResult.ToString();
                firstNum = finalResult;
                currentState = -1;
            }
        }
    }
}
