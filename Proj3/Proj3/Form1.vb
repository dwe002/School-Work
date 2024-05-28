
'Daniel Delgado Acosta
'Project 3
'May 2020
'Tuesday Lab







Public Class Form1


    'Dimensions modular variables
    Dim MealDecimal As Decimal
    Dim ItemsEnteredInteger As Integer



    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click

        'Dimension local variables

        Dim FatDecimal As Decimal
        Dim CarbsDecimal As Decimal
        Dim ProteinDecimal As Decimal
        Dim ItemDecimal As Decimal


        'Assigns values

        Try
            FatDecimal = Decimal.Parse(FatTextBox.Text)




            Try
                CarbsDecimal = Decimal.Parse(CarbsTextBox.Text)




                Try
                    ProteinDecimal = Decimal.Parse(ProteinTextBox.Text)


                    'Calculates calories in item, adds to meal calorie count, and adds to total items entered 

                    ItemDecimal = FatDecimal * 9 + CarbsDecimal * 4 + ProteinDecimal * 4

                    'Calculates Totals

                    MealDecimal = ItemDecimal + MealDecimal
                    ItemsEnteredInteger = ItemsEnteredInteger + 1


                    'Displays total calories of Item, total of meal, and entry total 

                    ItemLabel.Text = ItemDecimal
                    MealLabel.Text = MealDecimal
                    ItemsEnteredLabel.Text = ItemsEnteredInteger


                    CalculateButton.Enabled = False


                Catch Protein As Exception

                    'Shows Error Message

                    MessageBox.Show("Protein should be a numerical value.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    With ProteinTextBox
                        .Focus()
                        .SelectAll()

                    End With

                End Try


            Catch Carbs As Exception

                'Shows error message

                MessageBox.Show("Carbohydrates should be a numerical value.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                With CarbsTextBox
                    .Focus()
                    .SelectAll()

                End With


            End Try


        Catch Fat As Exception

            'Shows error message

            MessageBox.Show("Fats should be a numerical value.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            With FatTextBox

                .Focus()
                .SelectAll()

            End With


        End Try



    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click

        'Closes program

        End

    End Sub

    Private Sub NextItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextItemButton.Click

        'Clears inputs and puts focus on fat textbox

        With FatTextBox
            .Text = ""
            .Focus()
        End With

        CarbsTextBox.Text = ""
        ProteinTextBox.Text = ""
        ItemLabel.Text = ""

        CalculateButton.Enabled = True


    End Sub

    Private Sub NewMealButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMealButton.Click

        'resets form to initial state

        Call NextItemButton_Click(sender, e)

        MealLabel.Text = ""
        ItemsEnteredLabel.Text = ""

        'resets values back to zero

        MealDecimal = 0
        ItemsEnteredInteger = 0


    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click

        'Prints form

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub



End Class
