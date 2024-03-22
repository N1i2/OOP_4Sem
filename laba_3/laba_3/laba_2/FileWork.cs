using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace laba_2
{
    static class FileWork
    {
        static private string adress1 = "..\\..\\..\\..\\Inform.json";
        static private string adress2 = "..\\..\\..\\..\\InformSearch.json";

        public static void Serialize(List<Lesson> lesson, int i = 0)
        {
            string adress = adress1;
            
            if (i == 1)
            {
                adress = adress2;
            }

            using (FileStream file = new FileStream(adress, FileMode.Create))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

                JsonSerializer.Serialize(file, lesson, options);
            }
        }
        public static List<Lesson> Diserialize(int i = 0)
        {
            string adress = adress1;

            if(i == 1)
            {
                adress = adress2;
            }

            using (FileStream file = new FileStream(adress, FileMode.Open))
            {
                if (file.Length == 0)
                {
                    return new List<Lesson>();
                }

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

                return JsonSerializer.Deserialize<List<Lesson>>(file, options) ?? new List<Lesson>();
            }
        }
    }
}