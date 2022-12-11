using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6_pd
{
    public partial class Form1 : Form
    {
        private List<CheckBox> _checkBoxes;
        public Form1()
        {
            InitializeComponent();
            _checkBoxes = new List<CheckBox>();
            _checkBoxes.Add(chbFirst);
            _checkBoxes.Add(chbSecond);
            _checkBoxes.Add(chbThird);
            _checkBoxes.Add(chbFourth);
            _checkBoxes.Add(chbFifth);
        }

        private void Check(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox) // <==>  var checkBox = sender as CheckBox; without if() {}
            {
                int index = _checkBoxes.IndexOf(checkBox);

                for (int i = 0; i < 2; i++)
                {
                    if (index + 1 >= _checkBoxes.Count)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }

                    _checkBoxes[index].CheckedChanged -= Check;
                    _checkBoxes[index].Checked = !_checkBoxes[index].Checked;
                    _checkBoxes[index].CheckedChanged += Check;
                    for (int j = 0; j < _checkBoxes.Count; j++)
                    {
                        if (_checkBoxes[j].Checked)
                        {
                            _checkBoxes[j].Enabled = false;
                        }
                        else
                        {
                            _checkBoxes[j].Enabled = true;
                        }
                    }
                }

                int counter = 0;
                for (int i = 0; i < _checkBoxes.Count; i++)
                {
                    if (_checkBoxes[i].Checked)
                    {
                        counter++;
                    }
                }
                if (counter == 5)
                {
                    MessageBox.Show("Вы победили!", "Поздравляю", MessageBoxButtons.OK);
                }
            }
        }

        /*
        private void chbFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFirst.Checked)
            {
                chbFirst.Checked = true;
                chbFirst.Enabled = false;

                //if (!chbSecond.Checked)
                //{
                //    chbSecond.Checked = true;
                //    chbSecond.Enabled = false;
                //}
                //else
                //{
                //    chbSecond.Checked = false;
                //    chbSecond.Enabled = true;
                //}

                //if (!chbThird.Checked)
                //{
                //    chbThird.Checked = true;
                //    chbThird.Enabled = false;
                //}
                //else
                //{
                //    chbThird.Checked = false;
                //    chbThird.Enabled = true;
                //}
            }
        }
        */
    }
}
