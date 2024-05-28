


'Daniel Delgado Acosta
'Project 5 and 6
'May 2020
'Tuesday Lab







Public Class Form1




    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        'Closes program

        End

    End Sub

    Private Sub TitleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleToolStripMenuItem.Click

        'Toggles title visibility

        TitleLabel.Visible = TitleToolStripMenuItem.Checked

    End Sub

    Private Sub CountryNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountryNameToolStripMenuItem.Click

        'Toggles country name visibilty

        CountryNameLabel.Visible = CountryNameToolStripMenuItem.Checked

    End Sub

    Private Sub ProgrammedByToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgrammedByToolStripMenuItem.Click

        'Toggles programmers name visibility

        ProgrammerNameLabel.Visible = ProgrammedByToolStripMenuItem.Checked

    End Sub


    Private Sub USAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USAToolStripMenuItem.Click

        'Displays USA flag and name

        If USAToolStripMenuItem.Checked = False Then
            USAToolStripMenuItem.Checked = True

            CountryFlagPictureBox.Image = My.Resources.USAflag
            CountryNameLabel.Text = "USA"

            MexicoToolStripMenuItem.Checked = False
            IcelandToolStripMenuItem.Checked = False
            IrelandToolStripMenuItem.Checked = False

            'Displays nothing

        Else

            USAToolStripMenuItem.Checked = False
            CountryFlagPictureBox.Image = Nothing
            CountryNameLabel.Text = ""

        End If
    End Sub



    Private Sub IrelandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrelandToolStripMenuItem.Click

        'Displays Ireland flag and name

        If IrelandToolStripMenuItem.Checked = False Then
            IrelandToolStripMenuItem.Checked = True

            CountryFlagPictureBox.Image = My.Resources.IrelandFlag
            CountryNameLabel.Text = "Ireland"

            USAToolStripMenuItem.Checked = False
            IcelandToolStripMenuItem.Checked = False
            MexicoToolStripMenuItem.Checked = False

            'Displays nothing

        Else

            IrelandToolStripMenuItem.Checked = False
            CountryFlagPictureBox.Image = Nothing
            CountryNameLabel.Text = ""

        End If
    End Sub


    Private Sub IcelandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IcelandToolStripMenuItem.Click

        'Displays Iceland flag and name

        If IcelandToolStripMenuItem.Checked = False Then
            IcelandToolStripMenuItem.Checked = True

            CountryFlagPictureBox.Image = My.Resources.IcelandFlag
            CountryNameLabel.Text = "Iceland"

            USAToolStripMenuItem.Checked = False
            MexicoToolStripMenuItem.Checked = False
            IrelandToolStripMenuItem.Checked = False

            'Displays nothing

        Else

            IcelandToolStripMenuItem.Checked = False
            CountryFlagPictureBox.Image = Nothing
            CountryNameLabel.Text = ""

        End If
    End Sub



    Private Sub MexicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MexicoToolStripMenuItem.Click

        'Displays Mexico flag and name

        If MexicoToolStripMenuItem.Checked = False Then
            MexicoToolStripMenuItem.Checked = True

            CountryFlagPictureBox.Image = My.Resources.MexicoFlag
            CountryNameLabel.Text = "Mexico"

            USAToolStripMenuItem.Checked = False
            IcelandToolStripMenuItem.Checked = False
            IrelandToolStripMenuItem.Checked = False

            'Displays nothing

        Else

            MexicoToolStripMenuItem.Checked = False
            CountryFlagPictureBox.Image = Nothing
            CountryNameLabel.Text = ""

        End If
    End Sub




    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click

        'Prints form

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        'Shows about form

        AboutBox1.ShowDialog()

    End Sub
End Class



