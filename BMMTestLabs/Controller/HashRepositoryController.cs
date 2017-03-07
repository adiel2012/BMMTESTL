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
    // controls the hash repositories
    public class HashRepositoryController
    {
        // manipulate the source of the hash repository
        public IHashRepositoryHandler Repo { get; private set; }
        // reference to main form
        public MainFrameMDIParent Parentform { get; private set; }

        public HashRepositoryController(IHashRepositoryHandler repo, View.MainFrameMDIParent parentform)
        {
            this.Repo = repo;
            this.Parentform = parentform;
        }

        // display the content of file in the top left grid 
        public void Display(string source)
        {
            HashRepositoryRecord[] res = Repo.getAll();
            if (res == null)
            {
                System.Windows.Forms.MessageBox.Show("Wrong File Format");
                return;
            }
            Parentform.fill_HashRepository(res);
            Parentform.LblRepository.Text = source;
        }
    }
}
