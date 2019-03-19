# form_helper
This application will do the bulk input boxes validation, combo boxes validation and password validation. A dot net application using windows form. This uses LINQ, lambda expression, and List&lt;T>

# form properties
private ErrorProvider err1 = new ErrorProvider() { BlinkStyle = ErrorBlinkStyle.NeverBlink };
private ErrorProvider err2 = new ErrorProvider() { BlinkStyle = ErrorBlinkStyle.NeverBlink };
private ErrorProvider err3 = new ErrorProvider() { BlinkStyle = ErrorBlinkStyle.NeverBlink };

private List<TextBox> txtList1 = new List<TextBox>();
private List<ComboBox> cmbList = new List<ComboBox>();

# assigning values
this.txtList1.AddRange(new List<TextBox>() { this.txtFirst_name, this.txtLast_name, this.txtContact_no });
this.cmbList.AddRange(new List<ComboBox>() { this.cmbAccess_type, this.cmbStatus });

# error provider helper
public static void SetErrorProvider(Control ctrl, ErrorProvider err) // control such as textbox and combobox
{
    err.SetError(ctrl, text_helper.UppercaseFirst(string.Format("{0} is required", ctrl.Name.ToString().Replace("txt", "").Replace("_", " "))));
}

# how to use
if (form_helper.ValidateRequiredTextbox(this.err1, this.txtList1)) // textboxes
{
    // valid
}

if (form_helper.ValidateRequiredCombobox(this.err2, this.cmbList)) // combo boxes
{
    // valid
}

if (!regex_helper.ValidatePassword(this.txtPassword.Text.Trim()))
{
    // not vali
    form_helper.SetErrorProvider(this.txtPassword, this.err3);
}
