using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMMTestLabs.Model.Abstractions
{
    public interface IHashResultHandler
    {
        HashResultRecord[] getAll();
    }
}
