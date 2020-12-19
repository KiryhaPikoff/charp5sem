using EmployeeBusinessLogic.repository.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrarySendToVacation
{
    public partial class SendVacationForm : Form
    {
        public DateTime Date { get; set; }
        public SendVacationForm()
        {
            InitializeComponent();
        }

        private void buttonSemd_Click(object sender, EventArgs e)
        {
            this.Date = dateTimePicker1.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
