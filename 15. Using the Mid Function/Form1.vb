﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myPhrase As String
        myPhrase = InputBox("Enter your phrase")

        Label1.Text = myPhrase

        Label3.Text = Mid(myPhrase, 2, 6)



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
