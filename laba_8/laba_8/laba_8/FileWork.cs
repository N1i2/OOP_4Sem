using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace laba_8
{
    class FileWork
    {
        private static string adres = "../../../../Config/AppConfig.json";

        public static void SaveConnectionString(List<string> connectionString)
        {
            using (var file = new FileStream(adres, FileMode.Create))
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                JsonSerializer.Serialize(file, connectionString, options);
            }
        }

        public static List<string> GetConnectionString()
        {
            using (var file = new FileStream(adres, FileMode.Open))
            {
                if (file.Length == 0)
                    return new List<string>();

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                return JsonSerializer.Deserialize<List<string>>(file) ?? new List<string>();
            }
        }
    }
}
