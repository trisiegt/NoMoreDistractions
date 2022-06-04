Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("C:\Program Files (x86)\Tristan Carpenter\NoMoreDistractions\Scripts\DisableEmoticon.cmd")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        credits.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("C:\Program Files (x86)\Tristan Carpenter\NoMoreDistractions\Scripts\DisablePrivacyConsent.cmd")
    End Sub
End Class
