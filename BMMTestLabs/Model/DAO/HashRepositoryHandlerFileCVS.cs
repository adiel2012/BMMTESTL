using BMMTestLabs.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMMTestLabs.Model.DAO
{
    // this class handle the repository csv file
    class HashRepositoryHandlerFileCVS : IHashRepositoryHandler
    {
        private string filename;
        // load all records from csv file
        public HashRepositoryRecord[] getAll()
        {
            List<HashRepositoryRecord> listA = new List<HashRepositoryRecord>();
            using (var fs = File.OpenRead(filename))
            using (var reader = new StreamReader(fs))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string[] values = line.Split(',');
                    if (values.Length != 11)
                        return null;
                    listA.Add(new HashRepositoryRecord(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10]));
                }
            }

            return listA.ToArray();
        }

        public HashRepositoryHandlerFileCVS(string filename)
        {
            this.filename = filename;
        }
    }
}
