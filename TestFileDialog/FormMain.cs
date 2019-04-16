using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileDialog {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
        }

        private void buttonSaveFile_Click(object sender, EventArgs e) {
            SaveFileDialog dialog = new SaveFileDialog {
                AddExtension = true,
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|XML files (*.xml)|*.xml|Multidotted (*.abc.def)|*.abc.def",
                OverwritePrompt = true
            };
            if (dialog.ShowDialog() == DialogResult.OK) {
                textBoxFileName.Text = dialog.FileName + " | " + dialog.FileNameForceExtension();
            }
        }
    }
}
