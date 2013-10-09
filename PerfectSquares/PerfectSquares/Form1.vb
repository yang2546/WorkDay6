Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click
        lstResult.Items.Clear()
        Dim counter, X As Integer

        counter = 1
        Do While (counter < 11)

            X = counter * counter
            lstResult.Items.Add(CStr(X))
            counter = counter + 1

        Loop

    End Sub
End Class
