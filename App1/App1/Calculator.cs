using System;
using System.Collections.Generic;
using System.Text;

namespace App1 {
    class Calculator {
        public static double Calculate(double value1, double value2, string Operator) {
            double result = 0;

            switch (Operator) {
                case "÷":
                    result = value1 / value2;
                    break;
                case "×":
                    result = value1 * value2;
                    break;
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
            }

            return result;
        }
    }
}
