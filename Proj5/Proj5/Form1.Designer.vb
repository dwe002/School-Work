<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoutriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MexicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IrelandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IcelandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountryNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammedByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CountryFlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.CountryNameLabel = New System.Windows.Forms.Label()
        Me.ProgrammerNameLabel = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CountryFlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CoutriesToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(404, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.PrintToolStripMenuItem.Text = "&Print"
        Me.PrintToolStripMenuItem.ToolTipText = "Click to Print Form"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        Me.ExitToolStripMenuItem.ToolTipText = "Click to Exit"
        '
        'CoutriesToolStripMenuItem
        '
        Me.CoutriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USAToolStripMenuItem, Me.MexicoToolStripMenuItem, Me.IrelandToolStripMenuItem, Me.IcelandToolStripMenuItem})
        Me.CoutriesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoutriesToolStripMenuItem.Name = "CoutriesToolStripMenuItem"
        Me.CoutriesToolStripMenuItem.Size = New System.Drawing.Size(80, 25)
        Me.CoutriesToolStripMenuItem.Text = "&Coutries"
        '
        'USAToolStripMenuItem
        '
        Me.USAToolStripMenuItem.Name = "USAToolStripMenuItem"
        Me.USAToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.USAToolStripMenuItem.Text = "&USA"
        Me.USAToolStripMenuItem.ToolTipText = "Click to See USA Flag and Name"
        '
        'MexicoToolStripMenuItem
        '
        Me.MexicoToolStripMenuItem.Name = "MexicoToolStripMenuItem"
        Me.MexicoToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.MexicoToolStripMenuItem.Text = "&Mexico"
        Me.MexicoToolStripMenuItem.ToolTipText = "Click to See Mexico Flag and Name"
        '
        'IrelandToolStripMenuItem
        '
        Me.IrelandToolStripMenuItem.Name = "IrelandToolStripMenuItem"
        Me.IrelandToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.IrelandToolStripMenuItem.Text = "&Ireland"
        Me.IrelandToolStripMenuItem.ToolTipText = "Click to See Ireland Flag and Name"
        '
        'IcelandToolStripMenuItem
        '
        Me.IcelandToolStripMenuItem.Name = "IcelandToolStripMenuItem"
        Me.IcelandToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.IcelandToolStripMenuItem.Text = "Ic&eland"
        Me.IcelandToolStripMenuItem.ToolTipText = "Click to See Iceland Flag and Name"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.CheckOnClick = True
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitleToolStripMenuItem, Me.CountryNameToolStripMenuItem, Me.ProgrammedByToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(73, 25)
        Me.DisplayToolStripMenuItem.Text = "&Display"
        '
        'TitleToolStripMenuItem
        '
        Me.TitleToolStripMenuItem.Checked = True
        Me.TitleToolStripMenuItem.CheckOnClick = True
        Me.TitleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TitleToolStripMenuItem.Name = "TitleToolStripMenuItem"
        Me.TitleToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.TitleToolStripMenuItem.Text = "&Title"
        Me.TitleToolStripMenuItem.ToolTipText = "Click to Toggle Title Visibility"
        '
        'CountryNameToolStripMenuItem
        '
        Me.CountryNameToolStripMenuItem.Checked = True
        Me.CountryNameToolStripMenuItem.CheckOnClick = True
        Me.CountryNameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CountryNameToolStripMenuItem.Name = "CountryNameToolStripMenuItem"
        Me.CountryNameToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.CountryNameToolStripMenuItem.Text = "&Country Name"
        Me.CountryNameToolStripMenuItem.ToolTipText = "Click to Toggle Country Name Visibility"
        '
        'ProgrammedByToolStripMenuItem
        '
        Me.ProgrammedByToolStripMenuItem.Checked = True
        Me.ProgrammedByToolStripMenuItem.CheckOnClick = True
        Me.ProgrammedByToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ProgrammedByToolStripMenuItem.Name = "ProgrammedByToolStripMenuItem"
        Me.ProgrammedByToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.ProgrammedByToolStripMenuItem.Text = "&Programmed By"
        Me.ProgrammedByToolStripMenuItem.ToolTipText = "Click to Toggle Programmer Name Visibility"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "Click For More Information"
        '
        'TitleLabel
        '
        Me.TitleLabel.Location = New System.Drawing.Point(57, 43)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(283, 48)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "Flag Viewer"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CountryFlagPictureBox
        '
        Me.CountryFlagPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CountryFlagPictureBox.Location = New System.Drawing.Point(39, 94)
        Me.CountryFlagPictureBox.Name = "CountryFlagPictureBox"
        Me.CountryFlagPictureBox.Size = New System.Drawing.Size(323, 199)
        Me.CountryFlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CountryFlagPictureBox.TabIndex = 2
        Me.CountryFlagPictureBox.TabStop = False
        '
        'CountryNameLabel
        '
        Me.CountryNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CountryNameLabel.Location = New System.Drawing.Point(134, 296)
        Me.CountryNameLabel.Name = "CountryNameLabel"
        Me.CountryNameLabel.Size = New System.Drawing.Size(129, 40)
        Me.CountryNameLabel.TabIndex = 3
        Me.CountryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgrammerNameLabel
        '
        Me.ProgrammerNameLabel.Location = New System.Drawing.Point(12, 364)
        Me.ProgrammerNameLabel.Name = "ProgrammerNameLabel"
        Me.ProgrammerNameLabel.Size = New System.Drawing.Size(179, 28)
        Me.ProgrammerNameLabel.TabIndex = 4
        Me.ProgrammerNameLabel.Text = "Daniel Delgado Acosta"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 399)
        Me.Controls.Add(Me.ProgrammerNameLabel)
        Me.Controls.Add(Me.CountryNameLabel)
        Me.Controls.Add(Me.CountryFlagPictureBox)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "FlagViewerForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CountryFlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoutriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MexicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents CountryFlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CountryNameLabel As System.Windows.Forms.Label
    Friend WithEvents ProgrammerNameLabel As System.Windows.Forms.Label
    Friend WithEvents IrelandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IcelandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountryNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgrammedByToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
