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
            this.vacationWordButton = new System.Windows.Forms.Button();
            this.positionWordButton = new System.Windows.Forms.Button();
            this.componentWordJoinColumnsHeader = new WindowsFormsComponentLibrary.Report.ComponentWordJoinColumnsHeader();
            this.createJuniorBtn = new System.Windows.Forms.Button();
            this.createMiddleBtn = new System.Windows.Forms.Button();
            this.createSeniorBtn = new System.Windows.Forms.Button();
            this.xmlBackupComponent = new ClassLibraryXmlBackupControl.XmlBackupComponent();
            this.employeeCreateComponent = new ClassLibraryCreationalPatterns.EmployeeCreateComponent();
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
            this.backupSaveButton.Location = new System.Drawing.Point(685, 289);
            this.backupSaveButton.Name = "backupSaveButton";
            this.backupSaveButton.Size = new System.Drawing.Size(103, 33);
            this.backupSaveButton.TabIndex = 3;
            this.backupSaveButton.Text = "Создать бэкап";
            this.backupSaveButton.UseVisualStyleBackColor = true;
            this.backupSaveButton.Click += new System.EventHandler(this.backupSaveButton_Click);
            // 
            // vacationWordButton
            // 
            this.vacationWordButton.Location = new System.Drawing.Point(685, 329);
            this.vacationWordButton.Name = "vacationWordButton";
            this.vacationWordButton.Size = new System.Drawing.Size(103, 56);
            this.vacationWordButton.TabIndex = 4;
            this.vacationWordButton.Text = "Диаграмма по отпускам";
            this.vacationWordButton.UseVisualStyleBackColor = true;
            // 
            // positionWordButton
            // 
            this.positionWordButton.Location = new System.Drawing.Point(685, 391);
            this.positionWordButton.Name = "positionWordButton";
            this.positionWordButton.Size = new System.Drawing.Size(103, 56);
            this.positionWordButton.TabIndex = 5;
            this.positionWordButton.Text = "Отчет по должностям";
            this.positionWordButton.UseVisualStyleBackColor = true;
            this.positionWordButton.Click += new System.EventHandler(this.positionWordButton_Click);
            // 
            // createJuniorBtn
            // 
            this.createJuniorBtn.Location = new System.Drawing.Point(685, 51);
            this.createJuniorBtn.Name = "createJuniorBtn";
            this.createJuniorBtn.Size = new System.Drawing.Size(103, 32);
            this.createJuniorBtn.TabIndex = 6;
            this.createJuniorBtn.Text = "Создать Джуна";
            this.createJuniorBtn.UseVisualStyleBackColor = true;
            this.createJuniorBtn.Click += new System.EventHandler(this.createJuniorBtn_Click);
            // 
            // createMiddleBtn
            // 
            this.createMiddleBtn.Location = new System.Drawing.Point(684, 89);
            this.createMiddleBtn.Name = "createMiddleBtn";
            this.createMiddleBtn.Size = new System.Drawing.Size(103, 32);
            this.createMiddleBtn.TabIndex = 7;
            this.createMiddleBtn.Text = "Создать Мидла";
            this.createMiddleBtn.UseVisualStyleBackColor = true;
            this.createMiddleBtn.Click += new System.EventHandler(this.createMiddleBtn_Click);
            // 
            // createSeniorBtn
            // 
            this.createSeniorBtn.Location = new System.Drawing.Point(684, 127);
            this.createSeniorBtn.Name = "createSeniorBtn";
            this.createSeniorBtn.Size = new System.Drawing.Size(103, 32);
            this.createSeniorBtn.TabIndex = 8;
            this.createSeniorBtn.Text = "Создать Сеньёра";
            this.createSeniorBtn.UseVisualStyleBackColor = true;
            this.createSeniorBtn.Click += new System.EventHandler(this.createSeniorBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createSeniorBtn);
            this.Controls.Add(this.createMiddleBtn);
            this.Controls.Add(this.createJuniorBtn);
            this.Controls.Add(this.positionWordButton);
            this.Controls.Add(this.vacationWordButton);
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
        private System.Windows.Forms.Button vacationWordButton;
        private System.Windows.Forms.Button positionWordButton;
        private WindowsFormsComponentLibrary.Report.ComponentWordJoinColumnsHeader componentWordJoinColumnsHeader;
        private System.Windows.Forms.Button createJuniorBtn;
        private System.Windows.Forms.Button createMiddleBtn;
        private System.Windows.Forms.Button createSeniorBtn;
        private ClassLibraryCreationalPatterns.EmployeeCreateComponent employeeCreateComponent;
    }
}

