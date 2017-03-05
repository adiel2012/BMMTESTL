using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMMTestLabs.Model;
using BMMTestLabs.Model.Abstractions;
using BMMTestLabs.View;

namespace BMMTestLabs.Controller
{
    class HashRepositoryController
    {
        public IHashRepositoryHandler Repo { get; private set; }
        public MainFrameMDIParent Parentform { get; private set; }

        public HashRepositoryController(IHashRepositoryHandler repo, View.MainFrameMDIParent parentform)
        {
            this.Repo = repo;
            this.Parentform = parentform;
        }

        public void Display(string filename)
        {
            HashRepositoryRecord[] res = Repo.getAll();
            if (res == null)
            {
                System.Windows.Forms.MessageBox.Show("Wrong File Format");
                return;
            }
            Parentform.fill_HashRepository(res);
            Parentform.lbl_repository.Text = filename;
        }
    }
}
