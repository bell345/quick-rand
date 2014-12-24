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
    public partial class Main : Form
    {
        public Main() {
            InitializeComponent();
            this.Init();
        }

        public void Init() {
            this.RangeFromSpinner.Maximum = int.MaxValue;
            this.RangeToSpinner.Maximum = int.MaxValue;
            this.RangeFromSpinner.Minimum = int.MinValue;
            this.RangeToSpinner.Minimum = int.MinValue;
        }

        private int Bound(int value, int min, int max) {
            return value < min ? min : value > max ? max : value;
        }

        private void OpNumberRadio_CheckedChanged(object sender, EventArgs e) {
            if (this.OpNumberRadio.Checked) {
                this.ListInputGB.Hide();
                this.NumInputGB.Show();
            }
        }

        private void OpListRadio_CheckedChanged(object sender, EventArgs e) {
            if (this.OpListRadio.Checked) {
                this.NumInputGB.Hide();
                this.ListInputGB.Show();
            }
        }

        private void RangeFromSpinner_ValueChanged(object sender, EventArgs e) {
            this.RangeToSpinner.Value = Bound((int)this.RangeToSpinner.Value, (int)this.RangeFromSpinner.Value, (int)this.RangeToSpinner.Value);
            this.RangeFromSpinner.Value = Bound((int)this.RangeFromSpinner.Value, (int)this.RangeFromSpinner.Value, (int)this.RangeToSpinner.Value);
        }

        private void RangeToSpinner_ValueChanged(object sender, EventArgs e) {
            this.RangeFromSpinner.Value = Bound((int)this.RangeFromSpinner.Value, (int)this.RangeFromSpinner.Value, (int)this.RangeToSpinner.Value);
            this.RangeToSpinner.Value = Bound((int)this.RangeToSpinner.Value, (int)this.RangeFromSpinner.Value, (int)this.RangeToSpinner.Value);
        }

        private void ManualButton_Click(object sender, EventArgs e) {
            using (ListEntry listEntry = new ListEntry()) {
                listEntry.ListString = String.Join("\r\n", this.ListInput.Items.Cast<string>().ToArray());
                if (listEntry.ShowDialog() == DialogResult.OK) {
                    this.ListInput.Items.Clear();
                    IEnumerator<string> listArrE = listEntry.ListString.Split('\n').ToList<string>().GetEnumerator();
                    while (listArrE.MoveNext()) {
                        this.ListInput.Items.Add(listArrE.Current);
                    }
                }
            }
        }

        private void AddNewItem() {
            this.ListInput.Items.Add(this.InputBox.Text);
            this.InputBox.Text = "";

        }

        private void AcceptButton_Click(object sender, EventArgs e) {
            AddNewItem();
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                AddNewItem();
            }
        }

        private int GetRandomNumber(int min, int max) {
            int range = Math.Abs(max - min);
            return min + new Random().Next(range);
        }

        private void RandomButton_Click(object sender, EventArgs e) {
            if (this.OpNumberRadio.Checked) {
                int value = GetRandomNumber((int)RangeFromSpinner.Value, (int)RangeToSpinner.Value+1);
                this.OutputBox.Text = value.ToString();
            } else {
                int len = this.ListInput.Items.Cast<string>().ToArray().Length;
                if (len > 0) {
                    int value = GetRandomNumber(0, len);
                    this.OutputBox.Text = (string)this.ListInput.Items[value];
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            if (ListInput.SelectedIndex != -1)
                ListInput.Items.RemoveAt(ListInput.SelectedIndex);
        }
    }
}
