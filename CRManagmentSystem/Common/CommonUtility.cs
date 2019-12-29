using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRManagmentSystem.Common
{
    public static class CommonUtility
    {
        /// <summary>
        /// Dynamic to object
        /// </summary>
        /// <typeparam name="T">TEntity</typeparam>
        /// <param name="obj">Object</param>
        /// <returns>TEntity</returns>
        public static T DynamicToObject<T>(object obj)
        {
            var result = JsonConvert.SerializeObject(obj);

            return JsonConvert.DeserializeObject<T>(result);
        }

        /// <summary>
        /// Check half or full charactor
        /// </summary>
        /// <param name="c">charactor</param>
        /// <returns>true or false</returns>
        public static bool IsWideEastAsianWidth_SJIS(char c)
        {
            var sjis = System.Text.Encoding.GetEncoding("shift_JIS");
            int byteCount = sjis.GetByteCount(c.ToString());
            return byteCount == 2;
        }

        /// <summary>
        /// Create instance from dll
        /// </summary>
        /// <param name="functionDll">Function dll</param>
        /// <param name="nameDll">Name dll</param>
        /// <param name="form">Form is using</param>
        /// <returns>dynamic instance</returns>
        public static dynamic CreateInstanceDll(string functionDll, string nameDll, Form form)
        {
            try
            {
                Type type = CommonConstant.Types.Single(t => t.FullName == functionDll);
                dynamic instance = Activator.CreateInstance(type);
                return instance;
            }
            catch (Exception ex)
            {
                form.Close();
                CRManagmentSystemException sysException = new CRManagmentSystemException(string.Format(MessageConstant.InheritanceDllNotFound, nameDll), ex);
                throw sysException;
            }
        }

        /// <summary>
        /// Check form is open
        /// </summary>
        /// <param name="formName">Formname</param>
        /// <returns>Bool</returns>
        public static bool CheckFormIsOpen(string formName)
        {
            Form form = Application.OpenForms[formName];
            if (form != null)
            {
                return true;
            }

            return false;
        }
        /// Refresh combobox
        /// </summary>
        /// <param name="cbo">ComboBox</param>
        public static void RefreshCombobox(ComboBox cbo)
        {
            cbo.SelectedItem = null;
            cbo.SelectedText = null;
        }

        /// <summary>
        /// Export datagridview to csv
        /// </summary>
        /// <param name="dataGridView">DataGridView</param>
        /// <param name="fileName">FileName</param>
        /// <returns></returns>
        public static bool ExportToCSV(DataGridView dataGridView, string fileName, string message = null)
        {
            try
            {
                var stringBuilder = new StringBuilder();

                // Add header
                var headers = dataGridView.Columns.Cast<DataGridViewColumn>();
                stringBuilder.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));
                if (dataGridView.DataSource == null)
                {
                    Dialog.Warning(MessageConstant.NoresultExport);
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        // Add rows
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        stringBuilder.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "CSV|*.csv|All file|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.FileName = fileName;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, stringBuilder.ToString(), Encoding.UTF8);

                        Dialog.Info(string.Format(message, saveFileDialog.FileName));
                        return true;
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Check More Than 1000 Record
        /// </summary>
        /// <param name="count">Number record</param>
        /// <returns>bool</returns>
        public static bool IsMoreThan1000Record(int count)
        {
            if (count > 1000)
            {
                Dialog.Warning(MessageConstant.MoreThan1000);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Binding data combobox
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="dataDictionary"></param>
        public static void BindingCombobox(ComboBox cbo, Dictionary<string, string> dataDictionary)
        {
            cbo.DataSource = new BindingSource(dataDictionary, null);
            cbo.DisplayMember = "Value";
            cbo.ValueMember = "Key";
        }
    }
}
