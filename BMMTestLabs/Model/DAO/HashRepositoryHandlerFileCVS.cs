using BMMTestLabs.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMMTestLabs.Model.DAO
{
    class HashRepositoryHandlerFileCVS : IHashRepositoryHandler
    {
        private string filename;
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
                    var values = line.Split(',');
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
