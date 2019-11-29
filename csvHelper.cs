using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;

namespace SpliteHelper
{
    class CsvHelper
    {
        //public static List<CsvForm> Import(string file)
        //{
        //    using (var reader = new StreamReader(file))
        //    using (var csv = new CsvReader(reader))
        //    {
        //        var records = csv.GetRecords<CsvForm>();
        //        return records.ToList();
        //    }
        //}

        public static List<dynamic> Import(string file)
        {
            using (var reader = new StreamReader(file))
            using (var csv = new CsvReader(reader))
            {
                var records = csv.GetRecords<dynamic>();
                return records.ToList();
            }
        }

        public static void Export(string file, List<TemperatureRecord> temperatureRecords)
        {
            using (var writer = new StreamWriter(file, false, Encoding.UTF8))
            using (var csvWriter = new CsvWriter(writer))
            {
                csvWriter.Configuration.Delimiter = ",";
                csvWriter.Configuration.HasHeaderRecord = true;
                csvWriter.Configuration.AutoMap<TemperatureRecord>();
                csvWriter.NextRecord();
                foreach (var item in temperatureRecords)
                {
                    csvWriter.WriteRecord(item);
                    csvWriter.NextRecord();
                }
                writer.Flush();
            }
        }
    }
}
