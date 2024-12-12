using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FrankoVA.Sprint6.Task6.V7.Lib
{
    public class DataService : ISprint6Task6V7
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                string[] fragments;
                while ((line = reader.ReadLine()) != null)
                {
                    fragments = line.Split(' ');
                    res += fragments.Length > 2 ? fragments[2] + " " : "";
                }
            }
            res = res.Trim();
            return res;
        }
    }
}
