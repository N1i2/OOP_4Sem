using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace laba4.worker
{
    static class FileWork
    {
        private static string path = "..\\..\\..\\..\\Product.json";
        public static void Serialize(List<Product> prod)
        {
            using (FileStream file = new FileStream(path, FileMode.Create))
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

                JsonSerializer.Serialize(file, prod, options);
            }
        }
        public static List<Product> Deserialize()
        {
            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                if (file.Length == 0)
                    return new List<Product>();

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

                return JsonSerializer.Deserialize<List<Product>>(file, options) ?? new List<Product>();
            }
        }
    }
}
