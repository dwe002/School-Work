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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FatLabel = New System.Windows.Forms.Label()
        Me.CarbsLabel = New System.Windows.Forms.Label()
        Me.ProteinLabel = New System.Windows.Forms.Label()
        Me.FatTextBox = New System.Windows.Forms.TextBox()
        Me.CarbsTextBox = New System.Windows.Forms.TextBox()
        Me.ProteinTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ItemLabel = New System.Windows.Forms.Label()
        Me.ItemsEnteredLabel = New System.Windows.Forms.Label()
        Me.MealLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.NextItemButton = New System.Windows.Forms.Button()
        Me.NewMealButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 558)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Daniel Delgado Acosta"
        '
        'FatLabel
        '
        Me.FatLabel.Location = New System.Drawing.Point(32, 82)
        Me.FatLabel.Name = "FatLabel"
        Me.FatLabel.Size = New System.Drawing.Size(75, 43)
        Me.FatLabel.TabIndex = 0
        Me.FatLabel.Text = "&Fat"
        '
        'CarbsLabel
        '
        Me.CarbsLabel.Location = New System.Drawing.Point(32, 158)
        Me.CarbsLabel.Name = "CarbsLabel"
        Me.CarbsLabel.Size = New System.Drawing.Size(75, 43)
        Me.CarbsLabel.TabIndex = 2
        Me.CarbsLabel.Text = "&Carbs"
        '
        'ProteinLabel
        '
        Me.ProteinLabel.Location = New System.Drawing.Point(32, 228)
        Me.ProteinLabel.Name = "ProteinLabel"
        Me.ProteinLabel.Size = New System.Drawing.Size(75, 43)
        Me.ProteinLabel.TabIndex = 4
        Me.ProteinLabel.Text = "P&rotein"
        '
        'FatTextBox
        '
        Me.FatTextBox.Location = New System.Drawing.Point(113, 82)
        Me.FatTextBox.Name = "FatTextBox"
        Me.FatTextBox.Size = New System.Drawing.Size(144, 26)
        Me.FatTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.FatTextBox, "Enter Grams of Fat")
        '
        'CarbsTextBox
        '
        Me.CarbsTextBox.Location = New System.Drawing.Point(113, 155)
        Me.CarbsTextBox.Name = "CarbsTextBox"
        Me.CarbsTextBox.Size = New System.Drawing.Size(144, 26)
        Me.CarbsTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CarbsTextBox, "Enter Grams of Carbohydrates")
        '
        'ProteinTextBox
        '
        Me.ProteinTextBox.Location = New System.Drawing.Point(113, 225)
        Me.ProteinTextBox.Name = "ProteinTextBox"
        Me.ProteinTextBox.Size = New System.Drawing.Size(144, 26)
        Me.ProteinTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.ProteinTextBox, "Enter Grams of Protein")
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 38)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Item"
        '
        'ItemLabel
        '
        Me.ItemLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemLabel.Location = New System.Drawing.Point(96, 54)
        Me.ItemLabel.Name = "ItemLabel"
        Me.ItemLabel.Size = New System.Drawing.Size(169, 34)
        Me.ItemLabel.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.ItemLabel, "Displays the Items' Total Calories")
        '
        'ItemsEnteredLabel
        '
        Me.ItemsEnteredLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemsEnteredLabel.Location = New System.Drawing.Point(471, 249)
        Me.ItemsEnteredLabel.Name = "ItemsEnteredLabel"
        Me.ItemsEnteredLabel.Size = New System.Drawing.Size(169, 34)
        Me.ItemsEnteredLabel.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.ItemsEnteredLabel, "Dsiplays Total Items Entered")
        '
        'MealLabel
        '
        Me.MealLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MealLabel.Location = New System.Drawing.Point(96, 125)
        Me.MealLabel.Name = "MealLabel"
        Me.MealLabel.Size = New System.Drawing.Size(169, 34)
        Me.MealLabel.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.MealLabel, "Dispalys Meals' Total Calories")
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(33, 370)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(164, 70)
        Me.CalculateButton.TabIndex = 5
        Me.CalculateButton.Text = "Ca&lculate"
        Me.ToolTip1.SetToolTip(Me.CalculateButton, "Click to Calculate Calories")
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'NextItemButton
        '
        Me.NextItemButton.Location = New System.Drawing.Point(258, 370)
        Me.NextItemButton.Name = "NextItemButton"
        Me.NextItemButton.Size = New System.Drawing.Size(164, 70)
        Me.NextItemButton.TabIndex = 6
        Me.NextItemButton.Text = "&Next Item"
        Me.ToolTip1.SetToolTip(Me.NextItemButton, "Click to Enter Next Item")
        Me.NextItemButton.UseVisualStyleBackColor = True
        '
        'NewMealButton
        '
        Me.NewMealButton.Location = New System.Drawing.Point(492, 370)
        Me.NewMealButton.Name = "NewMealButton"
        Me.NewMealButton.Size = New System.Drawing.Size(164, 70)
        Me.NewMealButton.TabIndex = 7
        Me.NewMealButton.Text = "New &Meal"
        Me.ToolTip1.SetToolTip(Me.NewMealButton, "Click to Enter a New Meal")
        Me.NewMealButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(258, 503)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(164, 70)
        Me.PrintButton.TabIndex = 8
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Click to Print")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(492, 503)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(164, 70)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Clcik to Close Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 38)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Meal"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(348, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 43)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Items Entered"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FatTextBox)
        Me.GroupBox1.Controls.Add(Me.CarbsTextBox)
        Me.GroupBox1.Controls.Add(Me.ProteinTextBox)
        Me.GroupBox1.Controls.Add(Me.FatLabel)
        Me.GroupBox1.Controls.Add(Me.CarbsLabel)
        Me.GroupBox1.Controls.Add(Me.ProteinLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 305)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grams of"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ItemLabel)
        Me.GroupBox2.Controls.Add(Me.MealLabel)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(375, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 201)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calories in"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 616)
        Me.Controls.Add(Me.ItemsEnteredLabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.NewMealButton)
        Me.Controls.Add(Me.NextItemButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FatLabel As System.Windows.Forms.Label
    Friend WithEvents CarbsLabel As System.Windows.Forms.Label
    Friend WithEvents ProteinLabel As System.Windows.Forms.Label
    Friend WithEvents FatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CarbsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProteinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents NewMealButton As System.Windows.Forms.Button
    Friend WithEvents NextItemButton As System.Windows.Forms.Button
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents MealLabel As System.Windows.Forms.Label
    Friend WithEvents ItemsEnteredLabel As System.Windows.Forms.Label
    Friend WithEvents ItemLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
