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

        public static void Serialize(List<Lesson> lesson)
        {
            using (FileStream file = new FileStream(adress1, FileMode.Create))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

                JsonSerializer.Serialize(file, lesson, options);
            }
        }
        public static List<Lesson> Diserialize()
        {
            using (FileStream file = new FileStream(adress1, FileMode.Open))
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