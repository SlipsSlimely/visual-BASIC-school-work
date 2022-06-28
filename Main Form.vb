' Project name:         Calculator Project
' Project purpose:      Display the sum of the numbers entered
' Created/revised by:   <Paul Bahdouchi> on <10/30/2017>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Dim accumulator As Double
    Dim numbers As Double


    ' this makes the exit button close the application
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub numTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numTextBox.KeyPress
        ' allow the text box to accept only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    ' this makes the add button add things
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        ' this pulls the text in numtextbox to the numbers variable
        Double.TryParse(numTextBox.Text, numbers)

        ' this adds the number variable to the accumulator
        accumulator = accumulator + numbers

        ' this displays the numbers in the appropriate boxes
        numbersTextBox.Text = numbersTextBox.Text &
        numbers.ToString & ControlChars.NewLine


        ' this displays the accumulator in the sumLabel text box
        sumLabel.Text = accumulator.ToString

    End Sub

    ' this makes the start over button reset the app
    Private Sub startOverButton_Click(sender As Object, e As EventArgs) Handles startOverButton.Click

        numbersTextBox.Text = String.Empty
        sumLabel.Text = String.Empty
        accumulator = 0
        numbers = 0

    End Sub

End Class
