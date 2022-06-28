Public Class Form1

    Dim ProcessingFee As Double
    Dim Premium As Double
    Dim BasicFee As Double
    Dim Total As Double
    Dim channels As String
    Dim connection As String


    'Public Shared Function ToDouble(channels As String) As Double
    'End Function

    Public Shared Function ToDouble(connection As String) As Double
    End Function

    Private Sub MainForm_Load(sender As Object, e As EventArgs
   ) Handles Me.Load

        ' puts stuff in the list box
        ConnectionListBox.Items.Add("3")
        ConnectionListBox.Items.Add("4")
        ConnectionListBox.Items.Add("5")
        ConnectionListBox.Items.Add("6")
        ConnectionListBox.Items.Add("7")
        ConnectionListBox.Items.Add("8")
        ConnectionListBox.Items.Add("9")
        ConnectionListBox.Items.Add("10")
        ConnectionListBox.Items.Add("11")
        ConnectionListBox.Items.Add("12")
        ConnectionListBox.Items.Add("13")
        ConnectionListBox.Items.Add("14")
        ConnectionListBox.Items.Add("15")
        ConnectionListBox.Items.Add("16")
        ConnectionListBox.Items.Add("17")
        ConnectionListBox.Items.Add("18")
        ConnectionListBox.Items.Add("19")
        ConnectionListBox.Items.Add("20")
        ConnectionListBox.SelectedIndex = 0

        PremiumListBox.Items.Add("0")
        PremiumListBox.Items.Add("1")
        PremiumListBox.Items.Add("2")
        PremiumListBox.Items.Add("3")
        PremiumListBox.Items.Add("4")
        PremiumListBox.Items.Add("5")
        PremiumListBox.Items.Add("6")
        PremiumListBox.Items.Add("7")
        PremiumListBox.Items.Add("8")
        PremiumListBox.Items.Add("9")
        PremiumListBox.Items.Add("10")
        PremiumListBox.Items.Add("11")
        PremiumListBox.Items.Add("12")
        PremiumListBox.Items.Add("13")
        PremiumListBox.Items.Add("14")
        PremiumListBox.Items.Add("15")
        PremiumListBox.Items.Add("16")
        PremiumListBox.Items.Add("17")
        PremiumListBox.Items.Add("18")
        PremiumListBox.Items.Add("19")
        PremiumListBox.Items.Add("20")
        PremiumListBox.SelectedIndex = 0

        connection = ConnectionListBox.Items().ToString

        channels = PremiumListBox.Items().ToString

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        ProcessingFee = 4.5
        Premium = 5
        BasicFee = 30
    End Sub

    Private Sub PremiumListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PremiumListBox.SelectedIndexChanged
        
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        ProcessingFee = 16.5
        Premium = 50
        BasicFee = 80
    End Sub

    ' closes the app
    Private Sub exitButton_Click(sender As Object, e As EventArgs
    ) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click

        If RadioButton2.Checked Then
            Total = ProcessingFee + (Premium * channels) + BasicFee
        Else
            Total = ProcessingFee + (Premium * channels) + BasicFee

        End If

        TotalDueLabel.Text = Total.ToString()

    End Sub


End Class
