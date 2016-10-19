using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using AddinContract;
using System.Windows.Forms;


namespace AddinA
{
    [Export(typeof(IAddinContract))]
    public class AddinSampleA : IAddinContract
    {
        public string AddinTitle { get { return "Addin -A"; } }
        public void DoWork()
        {
            MessageBox.Show("Hello, This is the A!");
            return;
        }
    }
}
