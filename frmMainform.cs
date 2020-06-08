using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyPythonGUICreator
{
    public partial class frmMainform : Form
    {
        private List<PythonGuiControl> _lstGuiControls;
        public frmMainform()
        {
            InitializeComponent();

            BindingSource bsGuiControls = new BindingSource();
            bsGuiControls.DataSource = this._lstGuiControls;
            this.dgvInformation.DataSource = bsGuiControls;
        }

        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            GUIFileCreator creator = new GUIFileCreator();
            creator.createFile(this._lstGuiControls);
        }

    }
}
