using MyFormHelper.helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormHelper.forms
{
    public partial class main_form : Form
    {
        private ErrorProvider err1 = new ErrorProvider() { BlinkStyle = ErrorBlinkStyle.NeverBlink };
        private ErrorProvider err2 = new ErrorProvider() { BlinkStyle = ErrorBlinkStyle.NeverBlink };
        private ErrorProvider err3 = new ErrorProvider() { BlinkStyle = ErrorBlinkStyle.NeverBlink };

        private List<TextBox> txtList1 = new List<TextBox>();
        private List<ComboBox> cmbList = new List<ComboBox>();

        public main_form()
        {
            InitializeComponent();

            // assigning values
            this.txtList1.AddRange(new List<TextBox>() { this.txtFirst_name, this.txtLast_name, this.txtContact_no });
            this.cmbList.AddRange(new List<ComboBox>() { this.cmbAccess_type, this.cmbStatus });

            // binding keypress events
            form_helper.SetTxtboxOnKeyPress(this.txtList1, false);

            // binding button click events
            this.btnValidateTextbox.Click += delegate { this.OnValidateTextbox(); };
            this.btnValidateCombobox.Click += delegate { this.OnValidateCombobox(); };
            this.btnValidatePassword.Click += delegate { this.OnValidatePassword(); };
        }

        private void OnValidateTextbox()
        {
            if (form_helper.ValidateRequiredTextbox(this.err1, this.txtList1))
            {
                // valid
            }
        }

        private void OnValidateCombobox()
        {
            if (form_helper.ValidateRequiredCombobox(this.err2, this.cmbList))
            {
                // valid
            }
        }

        private void OnValidatePassword()
        {
            if (!regex_helper.ValidatePassword(this.txtPassword.Text.Trim()))
            {
                // not vali
                form_helper.SetErrorProvider(this.txtPassword, this.err3);
            }
        }
    }
}
