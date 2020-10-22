namespace EmployeeView
{
    partial class MainForm
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
            this.controlSelectedListBoxSingle1 = new WindowsFormsControlLibrary.Selected.ControlSelectedListBoxSingle();
            this.controlDataTreeTable = new WindowsFormsControlLibrary.Data.ControlDataTreeTable();
            this.createEmployeeButton = new System.Windows.Forms.Button();
            this.backupSaveButton = new System.Windows.Forms.Button();
            this.xmlBackupComponent = new ClassLibraryXmlBackupControl.XmlBackupComponent();
            this.SuspendLayout();
            // 
            // controlSelectedListBoxSingle1
            // 
            this.controlSelectedListBoxSingle1.Location = new System.Drawing.Point(59, 0);
            this.controlSelectedListBoxSingle1.Name = "controlSelectedListBoxSingle1";
            this.controlSelectedListBoxSingle1.SelectedIndex = -1;
            this.controlSelectedListBoxSingle1.SelectedItem = null;
            this.controlSelectedListBoxSingle1.Size = new System.Drawing.Size(8, 8);
            this.controlSelectedListBoxSingle1.TabIndex = 0;
            // 
            // controlDataTreeTable
            // 
            this.controlDataTreeTable.Location = new System.Drawing.Point(0, 0);
            this.controlDataTreeTable.Name = "controlDataTreeTable";
            this.controlDataTreeTable.Size = new System.Drawing.Size(678, 449);
            this.controlDataTreeTable.TabIndex = 1;
            // 
            // createEmployeeButton
            // 
            this.createEmployeeButton.Location = new System.Drawing.Point(685, 13);
            this.createEmployeeButton.Name = "createEmployeeButton";
            this.createEmployeeButton.Size = new System.Drawing.Size(103, 32);
            this.createEmployeeButton.TabIndex = 2;
            this.createEmployeeButton.Text = "Создать";
            this.createEmployeeButton.UseVisualStyleBackColor = true;
            this.createEmployeeButton.Click += new System.EventHandler(this.createEmployeeButton_Click);
            // 
            // backupSaveButton
            // 
            this.backupSaveButton.Location = new System.Drawing.Point(685, 52);
            this.backupSaveButton.Name = "backupSaveButton";
            this.backupSaveButton.Size = new System.Drawing.Size(103, 33);
            this.backupSaveButton.TabIndex = 3;
            this.backupSaveButton.Text = "Создать бэкап";
            this.backupSaveButton.UseVisualStyleBackColor = true;
            this.backupSaveButton.Click += new System.EventHandler(this.backupSaveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backupSaveButton);
            this.Controls.Add(this.createEmployeeButton);
            this.Controls.Add(this.controlDataTreeTable);
            this.Controls.Add(this.controlSelectedListBoxSingle1);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary.Selected.ControlSelectedListBoxSingle controlSelectedListBoxSingle1;
        private WindowsFormsControlLibrary.Data.ControlDataTreeTable controlDataTreeTable;
        private System.Windows.Forms.Button createEmployeeButton;
        private System.Windows.Forms.Button backupSaveButton;
        private ClassLibraryXmlBackupControl.XmlBackupComponent xmlBackupComponent;
    }
}

