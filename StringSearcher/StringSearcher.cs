using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SearchInString
{
    public class StringSearcher
    {
        public delegate void myDelegate(string s);
        public event myDelegate MyEvent;
        
        private bool flag = false;

        public void Search(List<string> mylst, string mystr)
        {
            //  проверяем как работают разные вар-ты с regex
            
            foreach (string item in mylst)
            {
                Regex regex = new Regex($"{mystr}", RegexOptions.IgnoreCase);
                //Regex regex = new Regex(@$"{mystr}(/w*)", RegexOptions.RightToLeft);
                //Regex regex = new Regex($"{mystr}(/w*)");
                MatchCollection match = regex.Matches(item);
                if (match.Count > 0)
                {
                    flag = true;
                    foreach (Match matchitem in match)
                    {
                        //Console.WriteLine(matchitem.Value);
                        MyEvent?.Invoke(item);    
                    }
                }               
            }
            if (!flag) MyEvent?.Invoke("Совпадений не найдено");
        }
    }
}
