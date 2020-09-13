using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ClassLibraryControlListWinForms
{
    public partial class ControlFieldsListBox: UserControl
    {
        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Поля выводимого класса в указанном в шаблоне порядке
        /// </summary>
        private List<string> orderedFields;

        public ControlFieldsListBox()
        {
            InitializeComponent();
            orderedFields = new List<string>();
        }

        /// <summary>
        /// Установка шаблона вывода полей класса
        /// </summary>
        [Category("Спецификация"), Description("Установка шаблона вывода полей класса")]
        public void setFieldsPattern(string pattern)
        {
            if (pattern.Length == 0) { return; }
            orderedFields = Regex.Split(pattern, @"\s*").ToList();
        }

        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                if (value > -2 && value < listBox.Items.Count)
                {
                    _selectedIndex = value;
                    listBox.SelectedIndex = _selectedIndex;
                }
            }
        }

        /// <summary>
        /// Значение выбранного элемента
        /// </summary>
        [Category("Спецификация"), Description("Значение выбранного элемента")]
        public string SelectedString
        {
            get { return listBox.SelectedItem.ToString(); }
        }
    }
}
