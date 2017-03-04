﻿using BMMTestLabs.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMMTestLabs.Model;
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

        internal global::BMMTestLabs.Program.Match_result[] compare(HashRepositoryController ctrl_repo)
        {

             HashResultRecord[] data =  repo.getAll();
            global::BMMTestLabs.Program.Match_result[] res = new Program.Match_result[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                if (i%2==0)
                {
                    res[i] = Program.Match_result.MATCH;
                }
                else
                {
                    res[i] = Program.Match_result.NO_MATCH;
                }
                if(i == 3)
                    res[i] = Program.Match_result.NO_FILE;
            }
            return res;
        }
    }

}
