using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    /// <summary>
    /// Лабораторная работа #6, задание 1, вариант 1.
    /// 1. Написать программу, которая вводит текст, состоящий из нескольких
    /// предложений, и выводит каждое слово в обратном порядке.
    /// 2. Программа.Из данной строки сделать новую строку, заменив в ней все цифры
    /// на соответствующие слова: "один", "два", "три" и т.д.
    /// </summary>
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_oroginalText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string originalText = textBox_oroginalText.Text;
                string resultText = "";
                string[] words = originalText.Split(' ');
                string currWord = "";
                char symbol = '.';
                string temp = "";
                int index = 0;
                for (int i = 0; i < words.Length; i++)
                {

                    temp = "";
                    currWord = words[i];
                    for (int j = 0; j < currWord.Length; j++)
                    {
                        if (currWord[j] == ',' || currWord[j] == '.' || currWord[j] == '!' || currWord[j] == '?'
                            || currWord[j] == ';' || currWord[j] == ':')
                        {
                            symbol = currWord[j];
                            temp += symbol;
                            index++;
                        }
                    }
                    currWord = new string(currWord.Substring(0,currWord.Length-index).Reverse().ToArray());
                    currWord += temp;
                    resultText += currWord + ' ';
                    index = 0;
                    
                }
                textBox_resultText.Text = resultText;
            }
        }
        public string InvertLettersInWord(string originalText)
        {
            int wordCounter = 0;
            string currentWord = "";
            string resultText = "";
            for (int i = 0; i < originalText.Length; i++)
            {
                if (originalText[i] == ' ' || originalText[i] == ',' || originalText[i] == '.' ||
                        originalText[i] == '!' || originalText[i] == '?' || originalText[i] == ';' ||
                        i == originalText.Length -1)
                {
                    if (originalText[i] == ' ')
                    {
                        resultText += currentWord + originalText[i];
                        wordCounter++;
                    }
                    else if (originalText[i] == ',' || originalText[i] == '.' ||
                        originalText[i] == '!' || originalText[i] == '?' || originalText[i] == ';')
                    {
                        resultText += currentWord + originalText[i];
                    }
                    else if (i == originalText.Length -1)
                    {
                        currentWord = originalText[i] + currentWord;
                        resultText += currentWord;
                    }
                    currentWord = "";
                }
                else
                {
                    currentWord = originalText[i] + currentWord;
                }
            }
            return resultText;
        }

        private void textBox_numbers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string originalText = textBox_numbers.Text;
                string[] numbers = {"ноль","один","два","три","четыре","пять",
                "шесть","семь","восемь","девять"};
                for (int i = 0; i < numbers.Length; i ++)
                {
                    originalText = originalText.Replace(i.ToString(),numbers[i]);
                }
                textBox_numbersNames.Text = originalText;
            }
        }
        private string NumbersToNames(string numbers)
        {
            string resultNumb = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                switch (numbers[i])
                {
                    case '1':
                        resultNumb += "один";
                        break;
                    case '2':
                        resultNumb += "два";
                        break;
                    case '3':
                        resultNumb += "три";
                        break;
                    case '4':
                        resultNumb += "четыре";
                        break;
                    case '5':
                        resultNumb += "пять";
                        break;
                    case '6':
                        resultNumb += "шесть";
                        break;
                    case '7':
                        resultNumb += "семь";
                        break;
                    case '8':
                        resultNumb += "восемь";
                        break;
                    case '9':
                        resultNumb += "девять";
                        break;
                    case '0':
                        resultNumb += "ноль";
                        break;
                    default:
                        resultNumb += numbers[i];
                        break;
                }
            }
            return resultNumb;
        }
    }
}
