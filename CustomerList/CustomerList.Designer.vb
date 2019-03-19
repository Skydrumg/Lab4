<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.cmbTitles = New System.Windows.Forms.ComboBox()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lbLastName = New System.Windows.Forms.Label()
        Me.chkVIP = New System.Windows.Forms.CheckBox()
        Me.lvwCustomers = New System.Windows.Forms.ListView()
        Me.colVIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFirstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLastName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CustomerToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbResult = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(62, 452)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 9
        Me.btnEnter.Text = "&Enter"
        Me.CustomerToolTip.SetToolTip(Me.btnEnter, "Click to add a customer.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(143, 452)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "&Reset"
        Me.CustomerToolTip.SetToolTip(Me.btnReset, "Click to reset the screen.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(224, 452)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.CustomerToolTip.SetToolTip(Me.btnExit, "Click to exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbFirstName
        '
        Me.tbFirstName.Location = New System.Drawing.Point(84, 34)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(121, 20)
        Me.tbFirstName.TabIndex = 3
        Me.CustomerToolTip.SetToolTip(Me.tbFirstName, "Type the customer's first name here.")
        '
        'tbLastName
        '
        Me.tbLastName.Location = New System.Drawing.Point(84, 87)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(121, 20)
        Me.tbLastName.TabIndex = 5
        Me.CustomerToolTip.SetToolTip(Me.tbLastName, "Type the customer's last name here.")
        '
        'cmbTitles
        '
        Me.cmbTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTitles.FormattingEnabled = True
        Me.cmbTitles.Items.AddRange(New Object() {"Elon Musk", "Fiat", "Jeep", "Chevy", "Dodge", "VW", "Traxxas"})
        Me.cmbTitles.Location = New System.Drawing.Point(84, 7)
        Me.cmbTitles.Name = "cmbTitles"
        Me.cmbTitles.Size = New System.Drawing.Size(121, 21)
        Me.cmbTitles.TabIndex = 1
        Me.CustomerToolTip.SetToolTip(Me.cmbTitles, "Select the customer's title.")
        '
        'lbTitle
        '
        Me.lbTitle.Location = New System.Drawing.Point(12, 7)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(66, 13)
        Me.lbTitle.TabIndex = 0
        Me.lbTitle.Text = "&Make:"
        Me.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(12, 34)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(66, 13)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "&Model:"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFirstName.UseWaitCursor = True
        '
        'lbLastName
        '
        Me.lbLastName.Location = New System.Drawing.Point(12, 90)
        Me.lbLastName.Name = "lbLastName"
        Me.lbLastName.Size = New System.Drawing.Size(66, 13)
        Me.lbLastName.TabIndex = 4
        Me.lbLastName.Text = "&Price:"
        Me.lbLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkVIP
        '
        Me.chkVIP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVIP.Location = New System.Drawing.Point(38, 110)
        Me.chkVIP.Name = "chkVIP"
        Me.chkVIP.Size = New System.Drawing.Size(59, 24)
        Me.chkVIP.TabIndex = 6
        Me.chkVIP.Text = "&Used:"
        Me.chkVIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CustomerToolTip.SetToolTip(Me.chkVIP, "Check to make the customer a VIP.")
        Me.chkVIP.UseVisualStyleBackColor = True
        '
        'lvwCustomers
        '
        Me.lvwCustomers.CheckBoxes = True
        Me.lvwCustomers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colVIP, Me.colID, Me.colTitle, Me.colFirstName, Me.colLastName, Me.colYear})
        Me.lvwCustomers.FullRowSelect = True
        Me.lvwCustomers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCustomers.Location = New System.Drawing.Point(3, 140)
        Me.lvwCustomers.MultiSelect = False
        Me.lvwCustomers.Name = "lvwCustomers"
        Me.lvwCustomers.Size = New System.Drawing.Size(365, 237)
        Me.lvwCustomers.TabIndex = 7
        Me.CustomerToolTip.SetToolTip(Me.lvwCustomers, "Select a customer to modify.")
        Me.lvwCustomers.UseCompatibleStateImageBehavior = False
        Me.lvwCustomers.View = System.Windows.Forms.View.Details
        '
        'colVIP
        '
        Me.colVIP.Text = "Used"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colTitle
        '
        Me.colTitle.Text = "Make"
        '
        'colFirstName
        '
        Me.colFirstName.Text = "Model"
        '
        'colLastName
        '
        Me.colLastName.Text = "Price"
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(3, 389)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(365, 51)
        Me.lbResult.TabIndex = 8
        Me.CustomerToolTip.SetToolTip(Me.lbResult, "Success or Error message will appear here.")
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "&Year"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cmbYear.Location = New System.Drawing.Point(84, 60)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbYear.TabIndex = 13
        Me.CustomerToolTip.SetToolTip(Me.cmbYear, "Select the customer's title.")
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'frmCustomerList
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(369, 487)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lvwCustomers)
        Me.Controls.Add(Me.chkVIP)
        Me.Controls.Add(Me.lbLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.cmbTitles)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents cmbTitles As ComboBox
    Friend WithEvents lbTitle As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lbLastName As Label
    Friend WithEvents chkVIP As CheckBox
    Friend WithEvents lvwCustomers As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colFirstName As ColumnHeader
    Friend WithEvents colLastName As ColumnHeader
    Friend WithEvents colVIP As ColumnHeader
    Friend WithEvents colTitle As ColumnHeader
    Friend WithEvents CustomerToolTip As ToolTip
    Friend WithEvents lbResult As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents colYear As ColumnHeader
End Class
