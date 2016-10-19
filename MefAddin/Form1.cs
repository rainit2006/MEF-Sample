using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using AddinContract;


namespace MefAddin
{
    public partial class Form1 : Form
    {
        [ImportMany]
        private List<IAddinContract> addins;

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateAddins()
        {
            try
            {
                var container = GetContainerFromDirectory();
                container.ComposeParts(this);
            }
            catch(CompositionException)
            {
                //through
            }
        }

        private CompositionContainer GetContainerFromDirectory()
        {
            var catalog = new DirectoryCatalog(".");
            return new CompositionContainer(catalog);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateAddins();
            foreach (var addin in addins)
            {
                addinsListBox.Items.Add(addin.AddinTitle);
            }

        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            if(addinsListBox.SelectedIndex < 0)
            {
                return;
            }
            addins[addinsListBox.SelectedIndex].DoWork();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
