namespace Homework7_SavchenkoOleks_LV744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\oleks\OneDrive\Рабочий стол";
            Dictionary<string, string> phoneDict = new Dictionary<string, string>();
            phoneDict = Task1(path, phoneDict);
            Task2(path, phoneDict);
            Task3(path);
        }
        static Dictionary<string, string> Task1(string path, Dictionary<string, string> phoneDict)
        {
            using (StreamReader sr = new StreamReader(path + @"\phones.txt"))
            {
                string onePair = "";
                while ((onePair = sr.ReadLine()) != null)
                {
                    string[] separStrings = onePair.Split(',');
                    phoneDict.Add(separStrings[1].Trim(), separStrings[0].Trim());
                }
            }

            using (StreamWriter sw = new StreamWriter(path + @"\numbers.txt", false, System.Text.Encoding.Default))
            {
                foreach (var number in phoneDict.Keys)
                {
                    sw.WriteLine(number.Trim());
                }
            }
            return phoneDict;
        }
        static void Task2(string path, Dictionary<string, string> phoneDict)
        {
            try
            {
                Console.WriteLine("Please enter name of the person whose number you want to know(Starting letter have to be capital!): ");
                string name = Console.ReadLine();
                if (phoneDict.ContainsValue(name))
                {
                    foreach (KeyValuePair<string, string> kvp in phoneDict)
                    {
                        if (kvp.Value == name)
                        {
                            Console.WriteLine($"Name is {kvp.Value}. Number is {kvp.Key}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Task3(string path)
        {
            List<String> phones = new List<String>();
            using (StreamReader sr = new StreamReader(path + @"\phones.txt"))
            {
                string onePair = "";
                while ((onePair = sr.ReadLine()) != null)
                {
                    string[] separStrings = onePair.Split(',');
                    phones.Add(separStrings[1].Trim());
                }
            }
            using (StreamWriter sr = new StreamWriter(path + @"\new.txt"))
            {
                foreach(string phone in phones)
                {
                    if (phone[0] == '8')
                    {
                        sr.WriteLine("+3" + phone);
                    }
                    else sr.WriteLine(phone);
                }
            }
        }
    }
}