using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
namespace DirBuster.DirBuster
{
    class BruteForce
    {
        String[] List;
        public static NetWork NtWork = new NetWork();
        public int Percentuale_Singola(string[] Listdir,int Status){return (Status * 100) / Listdir.ToArray().Length;}
        public int Percentuale_Totale(int Count, int ListTarget) {return (Count * 100) / ListTarget;}
        public bool interrupt { get; set; }


        private string[] RandomizeStrings(string[] arr)
        {
            Random _random = new Random();
            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
            foreach (string s in arr) list.Add(new KeyValuePair<int, string>(_random.Next(), s));
            var sorted = from item in list
                         orderby item.Key
                         select item;
            string[] result = new string[arr.Length];
            int index = 0;
            foreach (KeyValuePair<int, string> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }
            return result;
        }

        private void SetList(ref String[] list, int Select)
        {
            if (Select == 0) list = Properties.Resources.xtreamcodes.Split('\n');
            if (Select == 1) list = Properties.Resources.All_Directory.Split('\n');
            if (Select == 2) list = Properties.Resources.AdminAndSetup.Split('\n');
            if (Select == 3) list = Properties.Resources.All_File.Split('\n');
        }

        public void Run(ref ListBox Result, ref TextBox TxTConsole,ref ProgressBar PgBar,String Url,int Select, bool CheckBoxResult)
        {
            string addr;
            int Count = 1;
            SetList(ref List, Select);
            foreach (String Directory in RandomizeStrings(List))
            {
                if (interrupt) break;
                PgBar.Value = Percentuale_Singola(List, Count);
                addr = Url + "/" + Directory.Replace("\r",string.Empty);
                TxTConsole.Text = addr;
                if (NtWork.Address_Check(addr,CheckBoxResult)) Result.Items.Add(addr);
                Count++;
            }
        }
    }
}
