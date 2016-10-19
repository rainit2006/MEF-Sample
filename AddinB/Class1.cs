using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddinContract;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel.Composition;

namespace AddinB
{
    [Export(typeof(IAddinContract))]
    public class AddinSampleB : IAddinContract
    {
        public string AddinTitle { get { return "Addin -B"; } }
        public void DoWork()
        {
            MessageBox.Show("Hello, This is the B!");
            Process.Start("notepad", "readme.txt");
            return;
        }
    }
}
