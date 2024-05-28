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
        Me.ShippingInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductDataGroupBox = New System.Windows.Forms.GroupBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinishOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemButton = New System.Windows.Forms.Button()
        Me.FinishOrderButton = New System.Windows.Forms.Button()
        Me.NextItemButton = New System.Windows.Forms.Button()
        Me.NewOrderButton = New System.Windows.Forms.Button()
        Me.ProgrammerNameLabel = New System.Windows.Forms.Label()
        Me.STLabel = New System.Windows.Forms.Label()
        Me.TLabel = New System.Windows.Forms.Label()
        Me.SHLabel = New System.Windows.Forms.Label()
        Me.TDLabel = New System.Windows.Forms.Label()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.TaxLabel = New System.Windows.Forms.Label()
        Me.ShippingandHandlingLabel = New System.Windows.Forms.Label()
        Me.TotalDueLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ShippingInfoGroupBox.SuspendLayout()
        Me.ProductDataGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShippingInfoGroupBox
        '
        Me.ShippingInfoGroupBox.Controls.Add(Me.ZipCodeTextBox)
        Me.ShippingInfoGroupBox.Controls.Add(Me.StateTextBox)
        Me.ShippingInfoGroupBox.Controls.Add(Me.CityTextBox)
        Me.ShippingInfoGroupBox.Controls.Add(Me.AddressTextBox)
        Me.ShippingInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.ShippingInfoGroupBox.Controls.Add(Me.Label5)
        Me.ShippingInfoGroupBox.Controls.Add(Me.Label4)
        Me.ShippingInfoGroupBox.Controls.Add(Me.Label3)
        Me.ShippingInfoGroupBox.Controls.Add(Me.Label2)
        Me.ShippingInfoGroupBox.Controls.Add(Me.Label1)
        Me.ShippingInfoGroupBox.Location = New System.Drawing.Point(32, 56)
        Me.ShippingInfoGroupBox.Name = "ShippingInfoGroupBox"
        Me.ShippingInfoGroupBox.Size = New System.Drawing.Size(258, 396)
        Me.ShippingInfoGroupBox.TabIndex = 0
        Me.ShippingInfoGroupBox.TabStop = False
        Me.ShippingInfoGroupBox.Text = "Shipping Info"
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(115, 314)
        Me.ZipCodeTextBox.MaxLength = 5
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(89, 26)
        Me.ZipCodeTextBox.TabIndex = 9
        Me.ZipCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.ZipCodeTextBox, "Type the Zip Code")
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(115, 255)
        Me.StateTextBox.MaxLength = 2
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(35, 26)
        Me.StateTextBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.StateTextBox, "Type the State Abreviation")
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(115, 188)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(129, 26)
        Me.CityTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.CityTextBox, "Type the city")
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(115, 125)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(129, 26)
        Me.AddressTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.AddressTextBox, "Type the Address")
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(115, 63)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(129, 26)
        Me.NameTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "Type the Name")
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&Zip Code"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&State"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&City"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Add&ress"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Na&me"
        '
        'ProductDataGroupBox
        '
        Me.ProductDataGroupBox.Controls.Add(Me.PriceTextBox)
        Me.ProductDataGroupBox.Controls.Add(Me.WeightTextBox)
        Me.ProductDataGroupBox.Controls.Add(Me.QuantityTextBox)
        Me.ProductDataGroupBox.Controls.Add(Me.DescriptionTextBox)
        Me.ProductDataGroupBox.Controls.Add(Me.Label9)
        Me.ProductDataGroupBox.Controls.Add(Me.Label8)
        Me.ProductDataGroupBox.Controls.Add(Me.Label7)
        Me.ProductDataGroupBox.Controls.Add(Me.Label6)
        Me.ProductDataGroupBox.Location = New System.Drawing.Point(330, 56)
        Me.ProductDataGroupBox.Name = "ProductDataGroupBox"
        Me.ProductDataGroupBox.Size = New System.Drawing.Size(325, 344)
        Me.ProductDataGroupBox.TabIndex = 1
        Me.ProductDataGroupBox.TabStop = False
        Me.ProductDataGroupBox.Text = "Product Data"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(151, 268)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(141, 26)
        Me.PriceTextBox.TabIndex = 7
        Me.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.PriceTextBox, "Type the price of the Item")
        '
        'WeightTextBox
        '
        Me.WeightTextBox.Location = New System.Drawing.Point(151, 194)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(141, 26)
        Me.WeightTextBox.TabIndex = 5
        Me.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.WeightTextBox, "Type the weight of the Item")
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(151, 121)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(141, 26)
        Me.QuantityTextBox.TabIndex = 3
        Me.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.QuantityTextBox, "Type the Quantity of the Item")
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(151, 55)
        Me.DescriptionTextBox.MaxLength = 100
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(141, 26)
        Me.DescriptionTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.DescriptionTextBox, "Type the Description of Item")
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(18, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 35)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "&Price"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(18, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 35)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "&Weight"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(18, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 35)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "&Quantity"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(18, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 35)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "&Description"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(691, 29)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintSummaryToolStripMenuItem, Me.PrintFormToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "&File"
        Me.FileToolStripMenuItem.ToolTipText = "Click for File Options"
        '
        'PrintSummaryToolStripMenuItem
        '
        Me.PrintSummaryToolStripMenuItem.Name = "PrintSummaryToolStripMenuItem"
        Me.PrintSummaryToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.PrintSummaryToolStripMenuItem.Text = "Print &Summary"
        Me.PrintSummaryToolStripMenuItem.ToolTipText = "Click to Print the Order Summary"
        '
        'PrintFormToolStripMenuItem
        '
        Me.PrintFormToolStripMenuItem.Name = "PrintFormToolStripMenuItem"
        Me.PrintFormToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.PrintFormToolStripMenuItem.Text = "&Print Form"
        Me.PrintFormToolStripMenuItem.ToolTipText = "Click to Print Form"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        Me.ExitToolStripMenuItem.ToolTipText = "Click to Exit Program"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem, Me.NextItemToolStripMenuItem, Me.FinishOrderToolStripMenuItem, Me.NewOrderToolStripMenuItem, Me.ToolStripMenuItem2, Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(48, 25)
        Me.EditToolStripMenuItem.Text = "&Edit"
        Me.EditToolStripMenuItem.ToolTipText = "Click for Edit Options"
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.AddItemToolStripMenuItem.Text = "&Add Item"
        Me.AddItemToolStripMenuItem.ToolTipText = "Click to Add Item"
        '
        'NextItemToolStripMenuItem
        '
        Me.NextItemToolStripMenuItem.Enabled = False
        Me.NextItemToolStripMenuItem.Name = "NextItemToolStripMenuItem"
        Me.NextItemToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.NextItemToolStripMenuItem.Text = "&Next Item"
        Me.NextItemToolStripMenuItem.ToolTipText = "Click to Move On to the Next Item"
        '
        'FinishOrderToolStripMenuItem
        '
        Me.FinishOrderToolStripMenuItem.Enabled = False
        Me.FinishOrderToolStripMenuItem.Name = "FinishOrderToolStripMenuItem"
        Me.FinishOrderToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.FinishOrderToolStripMenuItem.Text = "&Finish Order"
        Me.FinishOrderToolStripMenuItem.ToolTipText = "Click to Finish Order"
        '
        'NewOrderToolStripMenuItem
        '
        Me.NewOrderToolStripMenuItem.Enabled = False
        Me.NewOrderToolStripMenuItem.Name = "NewOrderToolStripMenuItem"
        Me.NewOrderToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.NewOrderToolStripMenuItem.Text = "Ne&w Order"
        Me.NewOrderToolStripMenuItem.ToolTipText = "Click for a New Order"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(192, 26)
        Me.ToolStripMenuItem2.Text = "________________"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.FontToolStripMenuItem.Text = "F&ont"
        Me.FontToolStripMenuItem.ToolTipText = "Click to Change Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.ColorToolStripMenuItem.Text = "&Color"
        Me.ColorToolStripMenuItem.ToolTipText = "Click to Change Color"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.HelpToolStripMenuItem.Text = "&Help"
        Me.HelpToolStripMenuItem.ToolTipText = "Click for Help Options"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "Clcik for More Info"
        '
        'AddItemButton
        '
        Me.AddItemButton.Location = New System.Drawing.Point(23, 506)
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(115, 57)
        Me.AddItemButton.TabIndex = 2
        Me.AddItemButton.Text = "&Add Item"
        Me.ToolTip1.SetToolTip(Me.AddItemButton, "Click to Add Item")
        Me.AddItemButton.UseVisualStyleBackColor = True
        '
        'FinishOrderButton
        '
        Me.FinishOrderButton.Enabled = False
        Me.FinishOrderButton.Location = New System.Drawing.Point(23, 592)
        Me.FinishOrderButton.Name = "FinishOrderButton"
        Me.FinishOrderButton.Size = New System.Drawing.Size(115, 57)
        Me.FinishOrderButton.TabIndex = 4
        Me.FinishOrderButton.Text = "Finish &Order"
        Me.ToolTip1.SetToolTip(Me.FinishOrderButton, "Click to Finish Order")
        Me.FinishOrderButton.UseVisualStyleBackColor = True
        '
        'NextItemButton
        '
        Me.NextItemButton.Enabled = False
        Me.NextItemButton.Location = New System.Drawing.Point(175, 506)
        Me.NextItemButton.Name = "NextItemButton"
        Me.NextItemButton.Size = New System.Drawing.Size(115, 57)
        Me.NextItemButton.TabIndex = 3
        Me.NextItemButton.Text = "Next &Item"
        Me.ToolTip1.SetToolTip(Me.NextItemButton, "Click to Move On to the Next Item")
        Me.NextItemButton.UseVisualStyleBackColor = True
        '
        'NewOrderButton
        '
        Me.NewOrderButton.Enabled = False
        Me.NewOrderButton.Location = New System.Drawing.Point(175, 592)
        Me.NewOrderButton.Name = "NewOrderButton"
        Me.NewOrderButton.Size = New System.Drawing.Size(115, 57)
        Me.NewOrderButton.TabIndex = 5
        Me.NewOrderButton.Text = "&New Order"
        Me.ToolTip1.SetToolTip(Me.NewOrderButton, "Click for a New Order")
        Me.NewOrderButton.UseVisualStyleBackColor = True
        '
        'ProgrammerNameLabel
        '
        Me.ProgrammerNameLabel.Location = New System.Drawing.Point(12, 691)
        Me.ProgrammerNameLabel.Name = "ProgrammerNameLabel"
        Me.ProgrammerNameLabel.Size = New System.Drawing.Size(307, 23)
        Me.ProgrammerNameLabel.TabIndex = 14
        Me.ProgrammerNameLabel.Text = "Programmed by: Daniel Delgado Acosta"
        '
        'STLabel
        '
        Me.STLabel.Location = New System.Drawing.Point(334, 480)
        Me.STLabel.Name = "STLabel"
        Me.STLabel.Size = New System.Drawing.Size(90, 26)
        Me.STLabel.TabIndex = 6
        Me.STLabel.Text = "SubTotal"
        '
        'TLabel
        '
        Me.TLabel.Location = New System.Drawing.Point(334, 524)
        Me.TLabel.Name = "TLabel"
        Me.TLabel.Size = New System.Drawing.Size(90, 26)
        Me.TLabel.TabIndex = 8
        Me.TLabel.Text = "Tax"
        '
        'SHLabel
        '
        Me.SHLabel.Location = New System.Drawing.Point(334, 566)
        Me.SHLabel.Name = "SHLabel"
        Me.SHLabel.Size = New System.Drawing.Size(175, 26)
        Me.SHLabel.TabIndex = 10
        Me.SHLabel.Text = "Shipping and Handling"
        '
        'TDLabel
        '
        Me.TDLabel.Location = New System.Drawing.Point(334, 608)
        Me.TDLabel.Name = "TDLabel"
        Me.TDLabel.Size = New System.Drawing.Size(90, 26)
        Me.TDLabel.TabIndex = 12
        Me.TDLabel.Text = "Total Due"
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SubTotalLabel.Location = New System.Drawing.Point(527, 480)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(128, 24)
        Me.SubTotalLabel.TabIndex = 7
        Me.SubTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TaxLabel
        '
        Me.TaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TaxLabel.Location = New System.Drawing.Point(527, 526)
        Me.TaxLabel.Name = "TaxLabel"
        Me.TaxLabel.Size = New System.Drawing.Size(128, 24)
        Me.TaxLabel.TabIndex = 9
        Me.TaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShippingandHandlingLabel
        '
        Me.ShippingandHandlingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShippingandHandlingLabel.Location = New System.Drawing.Point(527, 566)
        Me.ShippingandHandlingLabel.Name = "ShippingandHandlingLabel"
        Me.ShippingandHandlingLabel.Size = New System.Drawing.Size(128, 24)
        Me.ShippingandHandlingLabel.TabIndex = 11
        Me.ShippingandHandlingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalDueLabel
        '
        Me.TotalDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalDueLabel.Location = New System.Drawing.Point(527, 610)
        Me.TotalDueLabel.Name = "TotalDueLabel"
        Me.TotalDueLabel.Size = New System.Drawing.Size(128, 24)
        Me.TotalDueLabel.TabIndex = 13
        Me.TotalDueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 758)
        Me.Controls.Add(Me.TotalDueLabel)
        Me.Controls.Add(Me.ShippingandHandlingLabel)
        Me.Controls.Add(Me.TaxLabel)
        Me.Controls.Add(Me.SubTotalLabel)
        Me.Controls.Add(Me.TDLabel)
        Me.Controls.Add(Me.SHLabel)
        Me.Controls.Add(Me.TLabel)
        Me.Controls.Add(Me.STLabel)
        Me.Controls.Add(Me.ProgrammerNameLabel)
        Me.Controls.Add(Me.NewOrderButton)
        Me.Controls.Add(Me.NextItemButton)
        Me.Controls.Add(Me.FinishOrderButton)
        Me.Controls.Add(Me.AddItemButton)
        Me.Controls.Add(Me.ProductDataGroupBox)
        Me.Controls.Add(Me.ShippingInfoGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ShippingInfoGroupBox.ResumeLayout(False)
        Me.ShippingInfoGroupBox.PerformLayout()
        Me.ProductDataGroupBox.ResumeLayout(False)
        Me.ProductDataGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShippingInfoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ZipCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductDataGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddItemButton As System.Windows.Forms.Button
    Friend WithEvents FinishOrderButton As System.Windows.Forms.Button
    Friend WithEvents NextItemButton As System.Windows.Forms.Button
    Friend WithEvents NewOrderButton As System.Windows.Forms.Button
    Friend WithEvents ProgrammerNameLabel As System.Windows.Forms.Label
    Friend WithEvents STLabel As System.Windows.Forms.Label
    Friend WithEvents TLabel As System.Windows.Forms.Label
    Friend WithEvents SHLabel As System.Windows.Forms.Label
    Friend WithEvents TDLabel As System.Windows.Forms.Label
    Friend WithEvents SubTotalLabel As System.Windows.Forms.Label
    Friend WithEvents TaxLabel As System.Windows.Forms.Label
    Friend WithEvents ShippingandHandlingLabel As System.Windows.Forms.Label
    Friend WithEvents TotalDueLabel As System.Windows.Forms.Label
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinishOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

End Class
