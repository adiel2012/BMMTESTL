using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMMTestLabs.Model.Abstractions;
using BMMTestLabs.Model.DAO;

namespace BMMTestLabs.DependencyInjection
{
    class Injector
    {
        private static Injector __instance = null;

        private Injector()
        {
        }

        public static Injector getIstance()
        {
            if(__instance==null)
                __instance = new Injector();
            return __instance;
        }


        public IHashRepositoryHandler getIHashRepositoryHandler(string filename)
        {
            return new HashRepositoryHandlerFileCVS(filename);
        }
        public IHashResultHandler getIHashResultHandler(string filename)
        {
            return new HashResultHandlerFileCVS(filename);
        }

    }
}
