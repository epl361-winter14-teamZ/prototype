Public Class Form3
    Public Function Initialize()
        LogIn.Visible = False
        Form2.Visible = False
        Form4.Visible = False
        Form6.Visible = False
        Form7.Visible = False
        Return 1
    End Function

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        LogIn.Initialize()
        LogIn.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form4.Initialize()
        Form4.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form6.Initialize()
        Form6.Visible = True
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form7.Initialize()
        Form7.Visible = True
    End Sub
End Class