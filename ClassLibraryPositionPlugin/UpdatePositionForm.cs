using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeBusinessLogic.repository.models;

namespace ClassLibraryPositionPlugin
{
    public partial class UpdatePositionForm : Form
    {
        public Position Position { get; set; }

        public UpdatePositionForm()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Position));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Position = (Position) comboBox1.SelectedItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
