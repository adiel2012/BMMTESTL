using BMMTestLabs.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMMTestLabs.Model;
using BMMTestLabs.View;

namespace BMMTestLabs.Controller
{
    // controls the hash results
    public class HashResultController
    {
        // manipulate the source of the hash result
        IHashResultHandler repo;
        // reference to main form
        View.MainFrameMDIParent parentform;

        public HashResultController(IHashResultHandler repo, View.MainFrameMDIParent parentform)
        {
            this.repo = repo;
            this.parentform = parentform;
        }

        // display the content of file in the top left grid 
        public void Display(string source)
        {
            HashResultRecord[] res = repo.getAll();
            if (res == null)
            {
                MessageBox.Show("Wrong File Format");
                return;
            }
            parentform.fill_HashResults(res);
            parentform.LblResult.Text = source;

        }

        // perform the comparisson between hash results and hash repository
        internal Match_result[] compare(HashRepositoryController ctrl_repo)
        {
             HashResultRecord[] dataresult =  repo.getAll();
             HashRepositoryRecord[] datarepo =  ctrl_repo.Repo.getAll();


             if (dataresult == null)
             {
                 MessageBox.Show("Wrong File Format");
                 return null;
             }

             Match_result[] res = new Match_result[dataresult.Length];


            for (int i = 0; i < dataresult.Length; i++)
            {
                HashResultRecord curr_result = dataresult[i];
                string cad = curr_result.FileFolderName.Trim(new char[]{' ','\"'});
                string signaturetype = curr_result.SignatureType.Trim(new char[] { ' ', '\"' });
                string signature = curr_result.Signature.Trim(new char[] { ' ', '\"' });
                for (int j = 0; j < datarepo.Length; j++)
                {
                    HashRepositoryRecord repo_curr = datarepo[j];
                    res[i] = Match_result.NO_FILE;
                    string cad2 = repo_curr.ImageName.Trim(new char[] { ' ', '\"' });
                    if (cad == cad2)
                    {
                        int g = 0;

                        if (valid_hash(signaturetype, signature, repo_curr))
                        {
                            res[i] = Match_result.MATCH;

                        }
                        else
                        {
                            res[i] = Match_result.NO_MATCH;
                        }
                        break;
                    }
                }


            }

            return res;
        }
        // utility function
        private bool valid_hash(string signaturetype, string signature, HashRepositoryRecord repo_curr)
        {

            switch (signaturetype)
            {
                case "SHA1":
                {
                    return repo_curr.Sig1.ToUpper() == signature;
                    
                }
                case "MD5":
                {
                    return repo_curr.Sig2.ToUpper() == signature;
                    ;
                }
                case "CRC16":
                {
                    return repo_curr.Sig3.ToUpper() == signature;
                    ;
                }
                case "CRC32":
                {
                    return repo_curr.Sig4.ToUpper() == signature;
                    ;
                }
                case "HMACSHA1":
                {
                    return repo_curr.Sig5.ToUpper() == signature;
                    ;
                }
                default :
                {
                    int g = 0;
                    break;
                }

            }
            


            return false;
        }
    }

}
