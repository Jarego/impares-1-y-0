Public Class Form1
    Dim var1 As String
    Dim var2 = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text += " "
        q0()
    End Sub
    Sub q0()
        If TextBox1.Text(var2) = "1" Then
            var1 += "1"
            var2 += 1
            Label1.Text = var1
            MsgBox("1:1,D")
            q1()
        ElseIf TextBox1.Text(var2) = "0" Then
            var1 += "0"
            var2 += 1
            Label1.Text = var1
            MsgBox("0:0,D")
            q1()

        End If
    End Sub
    Sub q1()
        If TextBox1.Text(var2) = "1" Then
            var1 += "1"
            var2 += 1
            Label1.Text = var1
            MsgBox("1:1,D")
            q1()
        ElseIf TextBox1.Text(var2) = "0" Then
            var1 += "0"
            var2 += 1
            Label1.Text = var1
            MsgBox("0:0,D")
            q1()
        ElseIf TextBox1.Text(var2) = " " Then

            MsgBox("Cadena aceptada")

        End If
    End Sub
End Class
