Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Enabled = False
        Me.Visible = False
        Form1.Show()
    End Sub
End Class