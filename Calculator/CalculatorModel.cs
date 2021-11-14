using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorModel
    {
        public CalculatorModel()
        {
            
        }
        //не понял про "для каждой операции создать отдельный метод"?
        //вроде как все прекрасно реализуется внутри метода Calculate?
        //через условную конструкцию...
        //или задание существенно проще, чем мне показалось
        //или я его конкретно не понял))
        //но вроде считает и на ноль не делит
        public object Calculate(int operand1, int operand2, char operation)
        {
            if (operation == '+') return operand1 + operand2;
            else if (operation == '-') return operand1 - operand2;
            else if (operation == '*') return operand1 * operand2;
            else if (operation == '/' && operand2 != 0) return operand1 / operand2;
            else if (operation == '/' && operand2 == 0) return null;
            else return null;
        }

        
    }
}
