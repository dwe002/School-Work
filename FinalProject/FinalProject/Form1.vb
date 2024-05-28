
'Daniel Delgado Acosta
'Final Project
'June 2020
'Tuesday Lab




Public Class Form1

    'Sets the constants

    Const TaxRateDecimal As Decimal = 0.08
    Const ShippingRateDecimal As Decimal = 0.25

    Const LessThan10Decimal As Decimal = 1
    Const InBetweenDecimal As Decimal = 3
    Const MoreThan100Decimal As Decimal = 5

    'Dimensions modular variables

    Dim BoxWeightDecimal As Decimal
    Dim SubTotalDecimal As Decimal

    Dim ShippingandHandlingDecimal As Decimal
    Dim TaxDecimal As Decimal
    Dim TotalDueDecimal As Decimal







    Private Sub AddItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemButton.Click

        'Dimensions variables

        Dim WeightOfOneDecimal As Decimal
        Dim PriceOfOneDecimal As Decimal
        Dim QuantityInteger As Integer

        Dim WeightOfManyDecimal As Decimal
        Dim PriceOfManyDecimal As Decimal

        'Tries to calculate Subtotal and Box weight

        Try
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)


            Try
                WeightOfOneDecimal = Decimal.Parse(WeightTextBox.Text)



                Try
                    PriceOfOneDecimal = Decimal.Parse(PriceTextBox.Text)

                    'Calculations

                    WeightOfManyDecimal = QuantityInteger * WeightOfOneDecimal
                    BoxWeightDecimal = BoxWeightDecimal + WeightOfManyDecimal

                    PriceOfManyDecimal = QuantityInteger * PriceOfOneDecimal
                    SubTotalDecimal = SubTotalDecimal + PriceOfManyDecimal

                    'Shows subtotal

                    SubTotalLabel.Text = SubTotalDecimal.ToString("C")

                    'Disables Shipping Info

                    ShippingInfoGroupBox.Enabled = False


                    'Adjusts the buttons and menu strip

                    AddItemButton.Enabled = False
                    AddItemToolStripMenuItem.Enabled = False

                    NewOrderButton.Enabled = False
                    NewOrderToolStripMenuItem.Enabled = False

                    NextItemButton.Enabled = True
                    NextItemToolStripMenuItem.Enabled = True

                    FinishOrderButton.Enabled = True
                    FinishOrderToolStripMenuItem.Enabled = True



                Catch PriceOfOne As Exception

                    'Shows error messsage

                    MessageBox.Show("Price should be a numerical value.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    With PriceTextBox
                        .Focus()
                        .SelectAll()

                    End With


                End Try



            Catch WeightOfOne As Exception

                'Shows error messsage

                MessageBox.Show("Weight should be a numerical value.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                With WeightTextBox
                    .Focus()
                    .SelectAll()

                End With


            End Try



        Catch Quantity As Exception

            'Shows error messsage

            MessageBox.Show("Quantity should be a numerical value.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            With QuantityTextBox
                .Focus()
                .SelectAll()

            End With


        End Try

    End Sub

    Private Sub NextItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextItemButton.Click

        'Puts focus on Description text box and resets product data

        With DescriptionTextBox
            .Text = ""
            .Focus()

        End With

        QuantityTextBox.Text = ""
        WeightTextBox.Text = ""
        PriceTextBox.Text = ""

        'Adjusts Buttons and menu strip

        AddItemButton.Enabled = True
        AddItemToolStripMenuItem.Enabled = True

        NewOrderButton.Enabled = False
        NewOrderToolStripMenuItem.Enabled = False

        NextItemButton.Enabled = False
        NextItemToolStripMenuItem.Enabled = False

        FinishOrderButton.Enabled = False
        FinishOrderToolStripMenuItem.Enabled = False


    End Sub

    Private Sub FinishOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishOrderButton.Click

        'Dimensions Variables

        Dim HandlingDecimal As Decimal
        Dim ShippingDecimal As Decimal



        'Displays assurance window

        Dim YesNoResult As DialogResult

        YesNoResult = MessageBox.Show("Do you really want to Finish Order?", "Finish Order Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If YesNoResult = Windows.Forms.DialogResult.Yes Then

            'Calculates Handling

            If BoxWeightDecimal < 10 Then

                HandlingDecimal = LessThan10Decimal


            ElseIf BoxWeightDecimal > 100 Then

                HandlingDecimal = MoreThan100Decimal

            Else

                HandlingDecimal = InBetweenDecimal

            End If


            'Calculates Tax

            If StateTextBox.Text.ToUpper = "CA" Then

                TaxDecimal = SubTotalDecimal * TaxRateDecimal

            End If

            'Calculates Shipping and handling and Total Due 

            ShippingDecimal = BoxWeightDecimal * ShippingRateDecimal
            ShippingandHandlingDecimal = ShippingDecimal + HandlingDecimal

            TotalDueDecimal = ShippingandHandlingDecimal + TaxDecimal + SubTotalDecimal

            'Displays Results

            TaxLabel.Text = TaxDecimal.ToString("N")
            ShippingandHandlingLabel.Text = ShippingandHandlingDecimal.ToString("N")
            TotalDueLabel.Text = TotalDueDecimal.ToString("C")

            'Adjusts Buttons and Menu strip

            AddItemButton.Enabled = False
            AddItemToolStripMenuItem.Enabled = False

            NewOrderButton.Enabled = True
            NewOrderToolStripMenuItem.Enabled = True

            NextItemButton.Enabled = False
            NextItemToolStripMenuItem.Enabled = False

            FinishOrderButton.Enabled = True
            FinishOrderToolStripMenuItem.Enabled = True


        End If


    End Sub

    Private Sub NewOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrderButton.Click

        'Calls Next Button code

        Call NextItemButton_Click(sender, e)

        ShippingInfoGroupBox.Enabled = True

        'Puts focus on name text box and resets the entire form

        With NameTextBox
            .Text = ""
            .Focus()

        End With

        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""

        SubTotalLabel.Text = ""
        TaxLabel.Text = ""
        ShippingandHandlingLabel.Text = ""
        TotalDueLabel.Text = ""

        'Resets modular variables

        BoxWeightDecimal = 0
        SubTotalDecimal = 0
        ShippingandHandlingDecimal = 0
        TaxDecimal = 0
        TotalDueDecimal = 0

    End Sub

    Private Sub AddItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemToolStripMenuItem.Click

        'Calls AddItemButton code

        Call AddItemButton_Click(sender, e)


    End Sub

    Private Sub NextItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextItemToolStripMenuItem.Click

        'Calls NextButton code

        Call NextItemButton_Click(sender, e)

    End Sub

    Private Sub FinishOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishOrderToolStripMenuItem.Click

        'Calls FinishOrderButtton code

        Call FinishOrderButton_Click(sender, e)

    End Sub

    Private Sub NewOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOrderToolStripMenuItem.Click

        'Calls NewOrderButton code

        Call NewOrderButton_Click(sender, e)

    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        'Exits the program

        End

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        'Shows About box

        AboutBox1.Show()


    End Sub



    Private Sub PrintFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintFormToolStripMenuItem.Click

        'Prints form

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()


    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click

        'Shows color dialog box and changes the calculated labels, buttons, and programmer name color

        With ColorDialog1

            .ShowDialog()

            Me.ForeColor = .Color
            FileToolStripMenuItem.ForeColor = .Color
            EditToolStripMenuItem.ForeColor = .Color
            HelpToolStripMenuItem.ForeColor = .Color
            ShippingInfoGroupBox.ForeColor = .Color
            ProductDataGroupBox.ForeColor = .Color

        End With


    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click

        'Shows font dialog box and changes the font of the entire form

        With FontDialog1

            .ShowDialog()


            Me.Font = .Font

            FileToolStripMenuItem.Font = .Font
            EditToolStripMenuItem.Font = .Font
            HelpToolStripMenuItem.Font = .Font

        End With


    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'Handles Book Info Print preview

        Dim HeaderFont As New Font("Arial", 43, FontStyle.Bold)
        Dim RegularFont As New Font("Arial", 12)

        Dim LineHeightSingle As Single = RegularFont.GetHeight + 2

        Dim HorizontalPrintLoctaionSingle As Single = e.MarginBounds.Left
        Dim EndingHorizontalPrintLocationSingle As Single = 750

        Dim WhatLineImOnSingle As Single = e.MarginBounds.Top

        Dim PrintString As String
        Dim FormattedOutputString As String

        Dim FontSizeF As New SizeF
        Dim ColumnStartSingle As Single

        'Shows page title

        PrintString = "Total Cost Summary"

        e.Graphics.DrawString(PrintString, HeaderFont,
                              Brushes.Black, 115, WhatLineImOnSingle)


        WhatLineImOnSingle = WhatLineImOnSingle + LineHeightSingle * 5


        'Next line

        PrintString = "Sub Total"

        e.Graphics.DrawString(PrintString, RegularFont,
                              Brushes.Black, HorizontalPrintLoctaionSingle, WhatLineImOnSingle)


        FormattedOutputString = SubTotalDecimal.ToString("C")

        FontSizeF = e.Graphics.MeasureString(FormattedOutputString, RegularFont)
        ColumnStartSingle = EndingHorizontalPrintLocationSingle - FontSizeF.Width

        e.Graphics.DrawString(FormattedOutputString, RegularFont,
                              Brushes.Black, ColumnStartSingle, WhatLineImOnSingle)


        WhatLineImOnSingle = WhatLineImOnSingle + LineHeightSingle

        'Next line

        PrintString = "Tax Amount"

        e.Graphics.DrawString(PrintString, RegularFont,
                              Brushes.Black, HorizontalPrintLoctaionSingle, WhatLineImOnSingle)


        FormattedOutputString = TaxDecimal.ToString("N")

        FontSizeF = e.Graphics.MeasureString(FormattedOutputString, RegularFont)
        ColumnStartSingle = EndingHorizontalPrintLocationSingle - FontSizeF.Width

        e.Graphics.DrawString(FormattedOutputString, RegularFont,
                              Brushes.Black, ColumnStartSingle, WhatLineImOnSingle)



        WhatLineImOnSingle = WhatLineImOnSingle + LineHeightSingle

        'Next line

        PrintString = "Shipping and Handling"

        e.Graphics.DrawString(PrintString, RegularFont,
                              Brushes.Black, HorizontalPrintLoctaionSingle, WhatLineImOnSingle)

        FormattedOutputString = ShippingandHandlingDecimal.ToString("N")

        FontSizeF = e.Graphics.MeasureString(FormattedOutputString, RegularFont)
        ColumnStartSingle = EndingHorizontalPrintLocationSingle - FontSizeF.Width

        e.Graphics.DrawString(FormattedOutputString, RegularFont,
                              Brushes.Black, ColumnStartSingle, WhatLineImOnSingle)


        WhatLineImOnSingle = WhatLineImOnSingle + LineHeightSingle * 2

        'Next line

        PrintString = "Total Amount Due"

        e.Graphics.DrawString(PrintString, RegularFont,
                              Brushes.Black, HorizontalPrintLoctaionSingle, WhatLineImOnSingle)

        FormattedOutputString = TotalDueDecimal.ToString("C")

        FontSizeF = e.Graphics.MeasureString(FormattedOutputString, RegularFont)
        ColumnStartSingle = EndingHorizontalPrintLocationSingle - FontSizeF.Width

        e.Graphics.DrawString(FormattedOutputString, RegularFont,
                              Brushes.Black, ColumnStartSingle, WhatLineImOnSingle)



        WhatLineImOnSingle = WhatLineImOnSingle + LineHeightSingle * 8

        'Next line

        PrintString = "Programmed By: Daniel Delgado Acosta"

        e.Graphics.DrawString(PrintString, RegularFont, 
                              Brushes.Black, HorizontalPrintLoctaionSingle, WhatLineImOnSingle)



    End Sub

    Private Sub PrintSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSummaryToolStripMenuItem.Click

        'Shows total cost summary preview

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub
End Class
