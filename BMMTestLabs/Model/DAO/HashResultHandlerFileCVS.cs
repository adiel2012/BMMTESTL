using BMMTestLabs.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMMTestLabs.Model.DAO
{
    class HashResultHandlerFileCVS : IHashResultHandler
    {
        private string filename;

        public HashResultRecord[] getAll()
        {
            List<HashResultRecord> listA = new List<HashResultRecord>();
            using (var fs = File.OpenRead(filename))
            using (var reader = new StreamReader(fs))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (values.Length != 4)
                        return null;
                    listA.Add(new HashResultRecord(values[0], values[1], values[2], values[3]));
                }
            }

            return listA.ToArray();
        }

        public HashResultHandlerFileCVS(string filename) {

            this.filename = filename;
        }
    }
}
