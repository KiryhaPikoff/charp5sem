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
using System.Reflection;

namespace ClassLibraryControlListWinForms
{
    public partial class ControlFieldsListBox: UserControl
    {
        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Объекты для вывода
        /// </summary>
        private Object[] objects;

        private string pattern;

        public ControlFieldsListBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Установка шаблона вывода полей класса
        /// </summary>
        [Category("Спецификация"), Description("Установка шаблона вывода полей класса")]
        public void setFieldsPattern(string pattern)
        {
            if (pattern.Length == 0) { return; }
            this.pattern = pattern;
        }

        /// <summary>
        /// Установка значения по номеру строки и названию поля
        /// </summary>
        [Category("Спецификация"), Description("Установка значения по номеру строки и названию поля")]
        public void setValue(int row, string fieldName)
        {
            Type t = objects[0].GetType();
            var field = t.GetProperty(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            listBox.Items[row] = listBox.Items[row].ToString().Replace(fieldName, field.GetValue(objects[row]).ToString());
        }

        /// <summary>
        /// Установка значения по номеру строки и названию поля
        /// </summary>
        [Category("Спецификация"), Description("Установка списка объектов")]
        public void setData(Object[] objects)
        {
            this.objects = objects;
            for(int i = 0; i < objects.Length; i++)
            {
                listBox.Items.Add(pattern);
            }
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
