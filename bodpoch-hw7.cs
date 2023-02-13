namespace HW7
{
    internal class Program
    {
        string path = @"C:\Users\B\source\repos\HW7\";
        static void Main(string[] args)
        {
            try
            {
            Dictionary<string, string> phoneDict = new Dictionary<string, string>();
            Program pr = new Program();
            
            pr.T1(phoneDict);
            pr.T2(phoneDict);
            pr.T3(phoneDict);
            }
            catch (Exception mainex)
            {
                Console.WriteLine(mainex.ToString());
            }
        }

        internal void T1(Dictionary<string, string> phoneDict)
        {
            using (StreamReader sr = new StreamReader(path + "phones.txt"))
            {
                string oneline;
                while ((oneline = sr.ReadLine()) != null)
                {
                    string[] separStrings = oneline.Split(',');
                    phoneDict.Add(separStrings[0], separStrings[1].ToUpper());
                }
            }

            using (StreamWriter sw = new StreamWriter(path + "pnums.txt", false, System.Text.Encoding.Default))
            {
                foreach (KeyValuePair<string, string> kvp in phoneDict)
                {
                    sw.WriteLine(kvp.Key);
                }
            }
        }

        internal void T2(Dictionary<string, string> phoneDict)
        {
            string name_toseach = Console.ReadLine().ToString().ToUpper();

            if (phoneDict.ContainsValue(name_toseach))
                foreach (string keyVar in phoneDict.Keys)
                {
                    if (phoneDict[keyVar] == name_toseach)
                    {
                         Console.WriteLine(keyVar);
                    }
                }
        }

        internal void T3(Dictionary<string, string> phoneDict)
        {
            using (StreamWriter sw = new StreamWriter(path + "Newformat.txt", false, System.Text.Encoding.Default))
            {
                foreach (KeyValuePair<string, string> kvp in phoneDict)
                {
                    if (kvp.Key.ToString().StartsWith('0') && kvp.Key.ToString().Length == 10)
                    {
                        sw.WriteLine("+38" + kvp.Key);
                    }
                }
            }
        }
    }
}