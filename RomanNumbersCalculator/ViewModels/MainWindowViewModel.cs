using Avalonia.Data;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace RomanNumbersCalculator.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private bool fladZapretMainos = false;
        private int? arabNumber = null;

        Stack<int?> numbersStack = new Stack<int?>();
        Stack<string?> operationStack = new Stack<string?>();


        public string? equation;
        public string? Equation
        {
            get => equation; 
            set 
            { 
                equation = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Equation)));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void numberToArabAndSave(int? enterNamder)
        {
            if (arabNumber != null)
            {
                if (arabNumber < enterNamder)
                {
                    if (fladZapretMainos) return;
                    fladZapretMainos = true;
                    enterNamder -= arabNumber;
                }
                else
                {
                    enterNamder += arabNumber;
                    fladZapretMainos = false;
                }
            }
            arabNumber = enterNamder;
        }
        private void pushOperToStack(string? opF2)
        {
            numbersStack.Push(arabNumber);
            if (operationStack.Count != 0 && numbersStack.Count >= 2)
            {
                if (operationStack.Peek() == "*" || operationStack.Peek() == "/" || operationStack.Peek() == "+" || operationStack.Peek() == "-")
                {
                    int? a1 = numbersStack.Pop();
                    int? a2 = numbersStack.Pop();
                    int? rezF2;
                    switch (operationStack.Peek())
                    {
                        case "+":
                            rezF2 = a1 + a2;
                            numbersStack.Push(rezF2);
                            break;
                        case "-":
                            rezF2 = a2 - a1;
                            numbersStack.Push(rezF2);
                            break;
                        case "*":
                            rezF2 = a1 * a2;
                            numbersStack.Push(rezF2);
                            break;
                        case "/":
                            rezF2 = a2 / a1;
                            numbersStack.Push(rezF2);
                            break;
                        default:
                            break;
                    }
                }
            }
            operationStack.Push(opF2);
        }
        private string? ConvertIntToRoman(int? ab)
        {
            string? rez = null;
            if (ab == 0) return "nulla";
            while (ab > 0)
            {
                if (ab - 1000 >= 0)
                {
                    rez += "M";
                    ab -= 1000;
                }
                else if (ab - 500 >= 0)
                {
                    rez += "D";
                    ab -= 500;
                }
                else if (ab - 100 >= 0)
                {
                    rez += "C";
                    ab -= 100;
                }
                else if (ab - 50 >= 0)
                {
                    rez += "L";
                    ab -= 50;
                }
                else if (ab - 10 >= 0)
                {
                    rez += "X";
                    ab -= 10;
                }
                else if (ab - 5 >= 0)
                {
                    rez += "V";
                    ab -= 5;
                }
                else
                {
                    rez += "I";
                    ab -= 1;
                }
            }
            return rez;
        }
        public void ClickButton(string? argument)
        {
            switch (argument)
            {
                case "I":
                    Equation += argument;
                    numberToArabAndSave(1);
                    break;
                case "C":
                    Equation += argument;
                    numberToArabAndSave(100);
                    break;
                case "+":
                    Equation += argument;
                    pushOperToStack("+");
                    arabNumber = null;
                    break;
                case "V":
                    Equation += argument;
                    numberToArabAndSave(5);
                    break;
                case "D":
                    Equation += argument;
                    numberToArabAndSave(500);
                    break;
                case "-":
                    Equation += argument;
                    pushOperToStack("-");
                    arabNumber = null;
                    break;
                case "X":
                    Equation += argument;
                    numberToArabAndSave(10);
                    break;
                case "M":
                    Equation += argument;
                    numberToArabAndSave(1000);
                    break;
                case "*":
                    Equation += argument;
                    pushOperToStack("*");
                    arabNumber = null;
                    break;
                case "L":
                    Equation += argument;
                    numberToArabAndSave(50);
                    break;
                case "/":
                    Equation += argument;
                    pushOperToStack("/");
                    arabNumber = null;
                    break;
                case "CE":
                    Equation = null;
                    numbersStack.Clear();
                    operationStack.Clear();
                    arabNumber = null;
                    fladZapretMainos = false;
                    break;
                case "=":
                    pushOperToStack("/");
                    arabNumber = null;
                    numberToArabAndSave(50);
                    Equation = ConvertIntToRoman(numbersStack.Pop());
                    numbersStack.Clear();
                    operationStack.Clear();
                    arabNumber = null;
                    fladZapretMainos = false;
                    break;
                default:
                    return;
            }
        }
    }
}
