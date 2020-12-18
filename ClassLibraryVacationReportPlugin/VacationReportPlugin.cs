using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.Service;
using Microsoft.Office.Interop.Word;
using System;
using System.ComponentModel.Composition;
using System.IO;


namespace ClassLibraryVacationReportPlugin
{
    [Export(typeof(IEmployeePlugin))]
    public class VacationReportPlugin : IEmployeePlugin
    {
        public string Name => "VacationReport";

        public EmployeeBindingModel Handle(EmployeeBindingModel employee)
        {
            Stream myStream;
            System.Windows.Forms.SaveFileDialog saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();


            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    if (employee == null)
                    {
                        throw new Exception();
                    }

                    var word = new Application();
                    try
                    {
                        object missing = System.Reflection.Missing.Value;
                        var document = word.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                        var paragraph = document.Paragraphs.Add(missing);
                        var range = paragraph.Range;
                        range.Text = "Приказ на отпуск";

                        paragraph = document.Paragraphs.Add(missing);
                        range = paragraph.Range;
                        range.Text = "Сотрудник " + employee.Position + " " + employee.Surname + " " + employee.Name + " " + employee.Patronymic +
                            " отправляется в отпуск c " + employee.VacationStart.ToString() + ".";

                        var font = range.Font;
                        font.Size = 14;
                        font.Name = "Times New Roman";
                        font.Bold = 1;

                        object fileFormat = WdSaveFormat.wdFormatXMLDocument;
                        document.SaveAs(Path.GetFullPath(saveFileDialog1.FileName), ref fileFormat, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing);
                        document.Close(ref missing, ref missing, ref missing);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        word.Quit();
                    }
                    myStream.Close();
                }
            }

            
            return employee;
        }
    }
}
