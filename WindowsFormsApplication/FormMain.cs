using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.values;

namespace WindowsFormsApplication
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            List<string> values = new List<string>();
            foreach (var elem in Enum.GetValues(typeof(TestEnum)))
            {
                values.Add(elem.ToString());
            }
            controlComboBoxSelected.values = values;
            controlTextFieldPhone.ErrorColor = Color.FromArgb(255, 204, 204);
        }

        private void controlComboBoxSelected_ComboBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(controlComboBoxSelected.SelectedText);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            controlComboBoxSelected.SelectedIndex = 0;
        }
    }
}
