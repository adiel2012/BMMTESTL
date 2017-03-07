using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMMTestLabs.Model.Abstractions;
using BMMTestLabs.Model.DAO;

namespace BMMTestLabs.DependencyInjection
{
    // a dependency injector to provide dependencies
    //  this is a Singleton class
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

        // provide the concretion of IHashRepositoryHandler. In this case from csv
        public IHashRepositoryHandler getIHashRepositoryHandler(string filename)
        {
            return new HashRepositoryHandlerFileCVS(filename);
        }

        // provide the concretion of IHashResultHandler. In this case from csv
        public IHashResultHandler getIHashResultHandler(string filename)
        {
            return new HashResultHandlerFileCVS(filename);
        }

    }
}
