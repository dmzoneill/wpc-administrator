Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Try
            Form1.TreeView1.Nodes.Add(TextBox1.Text)
            Form1.Button4.Text = "Save Changes"
        Catch ex As Exception

        End Try

        Me.Hide()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Hide()
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
