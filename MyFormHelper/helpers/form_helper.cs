using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormHelper.helpers
{
    public class form_helper
    {
        #region Props
        public const int EM_SETCUEBANNER = 0x1501;
        #endregion

        #region Set error provider
        public static void SetErrorProvider(Control ctrl, ErrorProvider err)
        {
            err.SetError(ctrl, text_helper.UppercaseFirst(string.Format("{0} is required",
                        ctrl.Name.ToString().Replace("txt", "").Replace("_", " "))));
        }
        #endregion

        #region Set textbox placeholder
        public static void SetTextboxPlaceHolder(List<TextBox> txtList, string preString)
        {
            txtList.ForEach((x) =>
            {
                text_helper.SendMessage(
                    x.Handle,
                    EM_SETCUEBANNER,
                    1,
                    text_helper.UppercaseFirst(string.Format("{0} {1}", 
                        preString.Trim(), x.Name.ToString().Replace("txt", "").Replace("_", " "))) // sample output -> Enter username
                );
            });
        }
        #endregion

        #region Validate textboxes
        public static bool ValidateRequiredTextbox(ErrorProvider err, List<TextBox> txtList)
        {
            err.Clear(); var woNull = 0;
            txtList.ForEach((x) => 
            {
                var value = x.Text.Trim();
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    woNull++;
                    SetErrorProvider(x, err);
                }
            });
            return (woNull == 0);
        }
        #endregion

        #region Validate required comboboxes
        public static bool ValidateRequiredCombobox(ErrorProvider err, List<ComboBox> cmbList)
        {
            err.Clear(); var woNull = 0;

            cmbList.ForEach((x) => 
            {
                if (Convert.ToInt32(x.SelectedValue) == 0)
                {
                    woNull++;
                    SetErrorProvider(x, err);
                }
            });

            return (woNull == 0);
        }
        #endregion

        #region Clear textbox
        public static void TextboxClear(List<TextBox> txtList)
        {
            if (txtList.Count > 0)
            {
                txtList.ForEach((x) => 
                {
                    if (!string.IsNullOrEmpty(x.Text))
                    {
                        x.Clear();
                    }
                });
            }
        }
        #endregion

        #region Disabler method
        public static void EnableGroupBox(List<GroupBox> list, bool status)
        {
            list.ForEach((x) => { x.Enabled = status; });
        }

        public static void EnableTextbox(List<TextBox> list, bool status)
        {
            list.ForEach((x) => { x.Enabled = status; });
        }
        #endregion

        #region Set textbox keypress event
        public static void SetTxtboxOnKeyPress(List<TextBox> txtList, bool hasShortcut)
        {
            txtList.ForEach((x) =>
            {
                var tag = x.Tag.ToString();
                switch (tag)
                {
                    case "numeric":
                        x.KeyPress += NumericKeypress;
                        break;

                    case "alpha":
                        x.KeyPress += AlphaKeypress;
                        break;

                    case "alphanumeric":
                        x.KeyPress += AlphaNumericSpacesKeypress;
                        break;

                    case "wild":
                        x.KeyPress += WildKeypress;
                        break;

                    default:
                        x.KeyPress += AlphaNumericSpacesKeypress;
                        break;
                }

                x.ShortcutsEnabled = hasShortcut;
            });
        }

        private static void NumericKeypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private static void AlphaKeypress(object sender, KeyPressEventArgs e)
        {
            var str = e.KeyChar.ToString();
            if (!char.IsControl(e.KeyChar) && !regex_helper.Validate(str, @"^([a-zA-Z]*[\s]*)+$"))
            {
                e.Handled = true;
            }
        }

        private static void AlphaNumericSpacesKeypress(object sender, KeyPressEventArgs e)
        {
            var str = e.KeyChar.ToString();
            if (!regex_helper.Validate(str, @"^([a-zA-Z0-9]*[\s]*)+$") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private static void WildKeypress(object sender, KeyPressEventArgs e)
        {
            var str = e.KeyChar.ToString();
            if (!regex_helper.Validate(str, @"^([a-zA-Z0-9]*[\s]*[\.\,]*)+$") && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Textbox trimmer
        public static void TextboxTrimmer(List<TextBox> list, int p)
        {
            list.ForEach((x) => 
            {
                x.MaxLength = p;
                if (x.Text.Length > p)
                {
                    x.Text = x.Text.Substring(0, p);
                }
            });
        }
        #endregion

        #region DataGridView_Styles
        private static void DataGridViewStyler(DataGridView dtgv, string colName, int colWidth)
        {
            if (dtgv.Columns.Contains(colName))
            {
                dtgv.Columns[colName].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dtgv.Columns[colName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgv.Columns[colName].Width = colWidth;
            }

            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void HideDataGridCol(DataGridView dtgv, List<string> colNameList)
        {
            if (colNameList.Count() > 0)
            {
                colNameList.ForEach((colName) =>
                {
                    dtgv.Columns[colName].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dtgv.Columns[colName].Visible = false;
                });
            }
        }

        #endregion
    }
}
