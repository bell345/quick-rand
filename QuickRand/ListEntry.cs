using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickRand
{
    public partial class ListEntry : Form
    {
        public ListEntry() {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        public string ListString {
            get {
                return ListBox.Text;
            }
            set {
                ListBox.Text = value;
            }
        }
    }
}
