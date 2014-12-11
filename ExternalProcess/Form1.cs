using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ExternalProcess {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Click_1(object sender, EventArgs e) {
            Process.Start("explorer.exe", "/e,/select," + Environment.SpecialFolder.MyComputer);
        }
    }
}
