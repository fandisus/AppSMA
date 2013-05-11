Imports System.Text

Module AppHelpers
    Public Function GetMessage(ByVal ex As Exception) As String
        Dim msg As New StringBuilder
        msg.Append(ex.Message)
        If Not ex.InnerException Is Nothing Then
            msg.AppendLine(GetMessage(ex.InnerException))
        End If
        Return msg.ToString()
    End Function
End Module
