using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Lab_3
{
    class Task2
    {
        static void Main(string[] args)
        {
            bool is_space(string key) 
            {
                for (int i = 0; i < key.Length; i++) 
                {
                    if (key[i] == ' ') 
                    {
                        return true;
                    }
                }
                return false;
            }

            string replace_spaces(string key) 
            {
                string answer = "";
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] != ' ')
                    {
                        answer += key[i];
                    }
                }
                return answer;
            }

            var List = new Dictionary<string, int>()
            {
                { "apples", 5 },
                { "milk ", 1 },
                { "orange  s", 10 },
                { " potat o", 7 }
            };

            var new_List = new Dictionary<string, int> { };
            foreach (var item in List) 
            {
                if (is_space(item.Key))
                {
                    new_List.Add(replace_spaces(item.Key), item.Value);
                }
                else 
                {
                    new_List.Add(item.Key, item.Value);
                }
            }
            List = new_List;
            string j = JsonConvert.SerializeObject(List);
            File.WriteAllText("new_List.json", j);
            Console.WriteLine("Ключi словника успiшно перезаписано!");
        }
    }
}
