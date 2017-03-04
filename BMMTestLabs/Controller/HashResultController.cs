using BMMTestLabs.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMMTestLabs.View;

namespace BMMTestLabs.Controller
{
    public class HashResultController
    {
        IHashResultHandler repo;
        View.MainFrameMDIParent parentform;

        public HashResultController(IHashResultHandler repo, View.MainFrameMDIParent parentform)
        {
            this.repo = repo;
            this.parentform = parentform;
        }

        public void Display(string filename)
        {

            parentform.fill_HashResults(repo.getAll());
            parentform.lbl_result.Text = filename;

        }
    }

}
