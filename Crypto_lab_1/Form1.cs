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
            List<string> Ralp = new List<string> { "А", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И", "Й", "К", "Л",
                                                   "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х",
                                                   "Ц", "Ч", "Ш", "Щ", "Ы", "Ь", "Э", "Ю", "Я" };

            List<string> Ealp = new List<string> { "A", "B", "W", "G", "D", "E", "V", "Z", "I",
                                                   "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U",
                                                   "F", "H", "C", "-", "-", "Q", "Y", "X", "-", "-", "-" };

            List<string> sMor = new List<string> { ".-", "-...", ".--", "--.", "-..", ".", "...-", "--..",
                                                   "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", ".-.",
                                                   "...", "-", "..-", "..-.", "....", "-.-.", "---.", "----", "--.-",
                                                   "-.--", "-..-", "..-..", "..--", ".-.-" };

            List<string> Nalp = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                                                   ",", ".", ";", ":", "?", "№", "\"", "'", "()", "!", "-" };

            string[] n_arr = new string[]  { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                                                   ",", ".", ";", ":", "?", "№", "\"", "'", "()", "!", "-" };

            string[] nm_arr = new string[] { ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..",
                                                   "----.", "-----", ".-.-.-", "......", "-.-.-", "---...", "..--..",
                                                   "-..-.", ".-..-.", ".----.", "-.--.-", "--..--", "-....-" };

            List<string> Nmor = new List<string> { ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..",
                                                   "----.", "-----", ".-.-.-", "......", "-.-.-", "---...", "..--..",
                                                   "-..-.", ".-..-.", ".----.", "-.--.-", "--..--", "-....-" };
            /*
            var dict          = new Dictionary<List<string>, string>();
            var Ndict         = new Dictionary<List<string>, List<string>>();
            Ndict.Add(Nalp, Nmor);*/

            var dict = new Dictionary<string, string>();
            //dict.Add(n_arr, nm_arr);*/

            for (int i = 0; i < n_arr.Length; ++i)
            {
                dict.Add(n_arr[i], nm_arr[i]);
                //for (int j = 0 j < nm_arr.Length; ++j)
                //{
                    
                //}
            }

            //textBox1.Text = Ndict.ForEach(delegate (List<string> n1) //(List<string> n2)
            foreach (KeyValuePair<string, string> kv in dict)
            {
                txt_b_1.Text += kv.Key + "      " + kv.Value + "\r\n";
            }


        }
    }
}
