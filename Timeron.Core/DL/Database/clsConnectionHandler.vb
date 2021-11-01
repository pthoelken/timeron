Imports Microsoft.Data.Sqlite
Imports System.Windows.Forms

Public Class clsConnectionHandler

    Private mobjConnection As New SqliteConnection("Data Source = timeron.db")
    Private mstrDatabaseFile As String = Environment.CurrentDirectory + "\timeron.db"


    Private Function CreateDatbaseFile()

        Dim strDatebaseFile As String = mstrDatabaseFile
        Try

            If Not IO.File.Exists(strDatebaseFile) Then
                IO.File.Create(strDatebaseFile)
                MsgBox("Application seems to be starting the first time. Database will be created and application closed.")

            Else
                Return True
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function


    Public Sub EstablishConnection()

        Dim blnFileCreationCheck As Boolean = CreateDatbaseFile()

        Try

            If blnFileCreationCheck Then
                mobjConnection.Open()

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub CloseConnection()

        Try
            mobjConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub PurgeConnection()

    End Sub

End Class
