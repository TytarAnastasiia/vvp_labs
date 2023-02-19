using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_2
{
    /// <summary>
    /// Лабораторная работа #6, задание 2, вариант 1.
    /// 1. Дан текст. Вывести все слова, начинающиеся с гласных букв русского алфавита.
    /// 2. Выбрать IPv4 адреса во всех возможных, представлениях: десятичном,
    /// шестнадцатеричном и восьмеричном. С точками и без.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_originalText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string origText = textBox_originalText.Text;
                string pattern = @"\b[АЕЁИОУЫЭЮЯ]\w+";
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(origText);
                string result = "";
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        result += match.Value + " ";
                    }
                }
                textBox_resultText.Text = result;
            }
        }

        private void textBox_origAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string result = "";
                string ipV4_10Dot = @"^(((1\d\d|2([0-4]\d|5[0-5])|\d\d?)\.){3}(1\d\d|2([0-4]\d|5[0-5])|\d\d?))$";
                string ipV4_10 = @"^((1\d\d|2([0-4]\d|5[0-5])|\d\d?){4})$";
                string ipV4_8Dot = @"^(((0[0-3][0-7][0-7])\.){3}(0[0-3][0-7][0-7]))$";
                string ipV4_8 = @"^((0[0-3][0-7][0-7]){4})$";
                string ipV4_16Dot = @"^(((0[xX]([0-9a-fA-F]){2})\.){3}(0[xX]([0-9a-fA-F]){2}))$";
                string ipV4_16 = @"^(0[xX]([0-9a-fA-F]){8})$";
                string pattern = ipV4_10Dot + "|" + ipV4_10 + "|" + ipV4_8Dot + "|" + ipV4_8 + "|" + ipV4_16Dot + "|" + ipV4_16;
                string origText = textBox_origAddress.Text;
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(origText);
                if (matches.Count > 0)
                {
                    foreach(Match match in matches)
                    {
                        result += match.Value;
                    }
                }
                textBox_resultAddress.Text = result;
            }
        }
    }
}
