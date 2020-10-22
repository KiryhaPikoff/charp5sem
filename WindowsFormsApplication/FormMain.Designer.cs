namespace WindowsFormsApplication
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonChange = new System.Windows.Forms.Button();
			this.controlComboBoxSelected = new WindowsFormsControlLibraryWinForms.ControlComboBoxSelected();
			this.controlTextFieldPhone = new ClassLibraryControlPhoneWinForms.ControlTextFieldPhone();
			this.controlFieldsListBox = new ClassLibraryControlListWinForms.ControlFieldsListBox();
			this.xmlBackupComponent = new ClassLibraryXmlBackupControl.XmlBackupComponent();
			this.excelReporterComponent = new ClassLibraryExcelReporter.ExcelReporterComponent();
			this.pdfDiagramComponent = new ClassLibraryPdfDiagramControl.PdfDiagramComponent();
			this.SuspendLayout();
			// 
			// buttonChange
			// 
			this.buttonChange.Location = new System.Drawing.Point(41, 81);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(75, 23);
			this.buttonChange.TabIndex = 1;
			this.buttonChange.Text = "Сменить номер";
			this.buttonChange.UseVisualStyleBackColor = true;
			this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
			// 
			// controlComboBoxSelected
			// 
			this.controlComboBoxSelected.Location = new System.Drawing.Point(12, 12);
			this.controlComboBoxSelected.Name = "controlComboBoxSelected";
			this.controlComboBoxSelected.SelectedIndex = 0;
			this.controlComboBoxSelected.Size = new System.Drawing.Size(177, 63);
			this.controlComboBoxSelected.TabIndex = 0;
			// 
			// controlTextFieldPhone
			// 
			this.controlTextFieldPhone.ErrorColor = System.Drawing.Color.Empty;
			this.controlTextFieldPhone.Location = new System.Drawing.Point(278, 40);
			this.controlTextFieldPhone.Name = "controlTextFieldPhone";
			this.controlTextFieldPhone.Size = new System.Drawing.Size(204, 27);
			this.controlTextFieldPhone.TabIndex = 2;
			// 
			// controlFieldsListBox
			// 
			this.controlFieldsListBox.Location = new System.Drawing.Point(533, 159);
			this.controlFieldsListBox.Name = "controlFieldsListBox";
			this.controlFieldsListBox.SelectedIndex = 0;
			this.controlFieldsListBox.Size = new System.Drawing.Size(208, 200);
			this.controlFieldsListBox.TabIndex = 3;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.controlFieldsListBox);
			this.Controls.Add(this.controlTextFieldPhone);
			this.Controls.Add(this.buttonChange);
			this.Controls.Add(this.controlComboBoxSelected);
			this.Name = "FormMain";
			this.Text = "Формочка";
			this.ResumeLayout(false);

		}

		#endregion

		private WindowsFormsControlLibraryWinForms.ControlComboBoxSelected controlComboBoxSelected;
		private System.Windows.Forms.Button buttonChange;
		private ClassLibraryControlPhoneWinForms.ControlTextFieldPhone controlTextFieldPhone;
        private ClassLibraryControlListWinForms.ControlFieldsListBox controlFieldsListBox;
        private ClassLibraryXmlBackupControl.XmlBackupComponent xmlBackupComponent;
        private ClassLibraryExcelReporter.ExcelReporterComponent excelReporterComponent;
        private ClassLibraryPdfDiagramControl.PdfDiagramComponent pdfDiagramComponent;
    }
}

