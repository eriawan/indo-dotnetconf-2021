using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleNetFxWinformsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDisplayRuntimeInfo_Click(object sender, EventArgs e)
        {
            var runtimeInfo = $"CLR Runtime: {Environment.Version.ToString()}, OS Version = {Environment.OSVersion.VersionString}";
            MessageBox.Show(runtimeInfo, "Runtime information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
