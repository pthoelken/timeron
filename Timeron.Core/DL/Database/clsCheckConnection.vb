Imports Timeron

Public Class clsCheckConnection

    Private mobjRegistryReader As New clsHKLMRegistryReader

    Public Function SimplePingConnectionCheck()

        Dim strHostToCheck As String = "8.8.8.8"

        Try

            If My.Computer.Network.Ping(strHostToCheck) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
