using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMMTestLabs.Model.Abstractions;

namespace BMMTestLabs.Controller
{
    class HashRepositoryController
    {
         IHashRepositoryHandler repo;
        View.MainFrameMDIParent parentform;

        public HashRepositoryController(IHashRepositoryHandler repo, View.MainFrameMDIParent parentform)
        {
            this.repo = repo;
            this.parentform = parentform;
        }

        public void Display(string filename)
        {

            parentform.fill_HashRepository(repo.getAll());
            parentform.lbl_repository.Text = filename;
        }
    }
}
