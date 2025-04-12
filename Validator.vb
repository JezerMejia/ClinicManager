Imports System.Reflection.Metadata.Ecma335
Imports System.Text.RegularExpressions
Imports Windows.Win32.System

Public Module Validator
    Public Sub only_float(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim numbers As TextBox = sender
        If InStr("1234567890.", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
        If Asc(e.KeyChar) <> 8 And numbers.Text.Length >= 16 Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Public Sub only_integer(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim numbers As TextBox = sender
        If InStr("1234567890", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub


    Function limit_length(length As Int32, ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim text As TextBox = sender
        If Asc(e.KeyChar) <> 8 And text.Text.Length >= length Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
        Return Nothing
    End Function

    Function limit_length_with(length As Int32) As KeyPressEventHandler
        Return Function(sender As Object, e As KeyPressEventArgs) (limit_length(length, sender, e))
    End Function

    Function strings_are_empty(ParamArray Vals() As String)
        For Each value In Vals
            If String.IsNullOrWhiteSpace(value) Then
                Return True
            End If
        Next
        Return False
    End Function

    Function is_email(email As String)
        Dim reg As New Regex("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", RegexOptions.ECMAScript)
        Return reg.IsMatch(email)
    End Function
End Module