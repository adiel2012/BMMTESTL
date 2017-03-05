using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMMTestLabs.Model;
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
            HashRepositoryRecord[] res = repo.getAll();
            if (res == null)
            {
                System.Windows.Forms.MessageBox.Show("Wrong File Format");
                return;
            }
            parentform.fill_HashRepository(res);
            parentform.lbl_repository.Text = filename;
        }
    }
}
