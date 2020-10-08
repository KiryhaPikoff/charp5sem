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

            var value1 = new TestClass { id = 1, name = "SomeName", price = 11.34M };
            var value2 = new TestClass { id = 2, name = "SomeName1", price = 21.34M };
            var value3 = new TestClass { id = 3, name = "SomeName2", price = 31.34M };
            var value4 = new TestClass { id = 4, name = "SomeName3", price = 41.34M };
            var list = new List<TestClass>();
            list.Add(value1);
            list.Add(value2);
            list.Add(value3);
            list.Add(value4);
            var pattern = "price id name";
            controlFieldsListBox.setFieldsPattern(pattern);
            controlFieldsListBox.setData(list.ToArray());
            controlFieldsListBox.setValue(0, "id");
            controlFieldsListBox.setValue(1, "id");
            controlFieldsListBox.setValue(2, "id");
            controlFieldsListBox.setValue(3, "id");
            controlFieldsListBox.setValue(0, "name");
            controlFieldsListBox.setValue(1, "name");
            controlFieldsListBox.setValue(2, "price");
            controlFieldsListBox.setValue(3, "price");

            //    xmlBackupComponent.saveData<TestClass>("E:/work/1/2", list.ToArray());
            excelReporterComponent.CreateExcelReport<TestClass>("E:/work/1/2", "otch", false, list.ToArray());
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
