using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AddinContract
{
    public interface IAddinContract
    {
        string AddinTitle { get; }
        void DoWork();
    }
}
