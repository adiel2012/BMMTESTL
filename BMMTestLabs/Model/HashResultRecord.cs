using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMMTestLabs.Model
{
    public class HashResultRecord
    {
        public string Location { get; set; }

        public string FileFolderName { get; set; }

        public string SignatureType { get; set; }

        public string Signature { get; set; }

        public HashResultRecord(string location, string fileFolderName, string signatureType, string signature)
        {
            Location = location;
            FileFolderName = fileFolderName;
            Signature = signature;
            SignatureType = signatureType;
        }
    }
}
