using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            txt_b_2.Clear();
            string[] Ralp = new string[] { "А", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И", "Й", "К", "Л",
                                                   "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х",
                                                   "Ц", "Ч", "Ш", "Щ", "Ы", "Ь", "Э", "Ю", "Я" };

            string[] Ealp = new string[] { "A", "B", "W", "G", "D", "E", "V", "Z", "I",
                                                   "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U",
                                                   "F", "H", "C", "-", "-", "Q", "Y", "X", "-", "-", "-" };

            string[] sMor = new string[] { ".-", "-...", ".--", "--.", "-..", ".", "...-", "--..",
                                                   "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", ".-.",
                                                   "...", "-", "..-", "..-.", "....", "-.-.", "---.", "----", "--.-",
                                                   "-.--", "-..-", "..-..", "..--", ".-.-" };

            string[] n_arr = new string[]  { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                                                   ",", ".", ";", ":", "?", "№", "\"", "'", "()", "!", "-" };

            string[] nm_arr = new string[] { ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..",
                                                   "----.", "-----", ".-.-.-", "......", "-.-.-", "---...", "..--..",
                                                   "-..-.", ".-..-.", ".----.", "-.--.-", "--..--", "-....-" };

            var nm_dict = new Dictionary<string, string>();
            var rm_dict = new Dictionary<string, string>();
            var em_dict = new Dictionary<string, string>();

            for (int i = 0; i < Ralp.Length; ++i) rm_dict.Add(Ralp[i], sMor[i]);

            for (int i = 0; i < Ealp.Length; ++i) { if (Ealp[i] == "-") ; else em_dict.Add(Ealp[i], sMor[i]); }

            for (int i = 0; i < n_arr.Length; ++i) nm_dict.Add(n_arr[i], nm_arr[i]);

            string txt = txt_b_1.Text;
            char[] s = txt.ToCharArray();

            foreach(var i in s)
            {
                if      (i.ToString() == " ")                         txt_b_2.Text += " ";
                else if (i.ToString() == "(" || i.ToString() == ")")  txt_b_2.Text += "-.--.-";
                else if (rm_dict.ContainsKey(i.ToString().ToUpper())) txt_b_2.Text += rm_dict[i.ToString().ToUpper()];
                else if (em_dict.ContainsKey(i.ToString().ToUpper())) txt_b_2.Text += em_dict[i.ToString().ToUpper()];
                else if (nm_dict.ContainsKey(i.ToString().ToUpper())) txt_b_2.Text += nm_dict[i.ToString().ToUpper()];
            }
        }
    }
}
