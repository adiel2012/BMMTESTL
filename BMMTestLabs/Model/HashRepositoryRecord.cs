using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMMTestLabs.Model
{
    // represent each hash repository record
    public class HashRepositoryRecord
    {

        public HashRepositoryRecord() { }

        public string ImageName { get;  set; }

        public string Sigtype1 { get; set; }

        public string Sig1 { get; set; }

        public string Sigtype2 { get; set; }

        public string Sig2 { get; set; }

        public string Sigtype3 { get; set; }

        public string Sig3 { get; set; }

        public string Sigtype4 { get; set; }

        public string Sig4 { get; set; }

        public string Sigtype5 { get; set; }

        public string Sig5 { get; set; }
        
        public HashRepositoryRecord(string imageName, string sigtype1, string sig1, string sigtype2, string sig2, string sigtype3, string sig3, string sigtype4, string sig4, string sigtype5, string sig5)
        {
            ImageName = imageName;
            Sig1 = sig1;
            Sig2 = sig2;
            Sig3 = sig3;
            Sig4 = sig4;
            Sig5 = sig5;

            Sigtype1 = sigtype1;
            Sigtype2 = sigtype2;
            Sigtype3 = sigtype3;
            Sigtype4 = sigtype4;
            Sigtype5 = sigtype5;

        }
    }
}
