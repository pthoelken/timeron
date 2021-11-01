Imports Timeron.Core

Public Class frmMain

    Private mobjCheckHostAlive As New clsCheckConnection
    Private mobjConnectionHandler As New clsConnectionHandler

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strDateTime As String = DateTime.Now

        Try

            tsslDateTimeNow.Text = strDateTime

            If mobjCheckHostAlive.SimplePingConnectionCheck = True Then
                tsslConnectionStatus.Text = "Online"
                tsslConnectionStatus.ForeColor = Color.Green
            Else
                tsslConnectionStatus.Text = "Offline"
                tsslConnectionStatus.ForeColor = Color.Red
                ' tsslConnectionStatus.Font = Font.Bold
            End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mobjConnectionHandler.EstablishConnection()
    End Sub
End Class
