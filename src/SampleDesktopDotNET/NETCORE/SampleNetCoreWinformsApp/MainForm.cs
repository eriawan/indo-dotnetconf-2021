using System;
using System.Windows.Forms;

namespace SampleNetCoreWinformsApp
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