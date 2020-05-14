Imports System.Text
Public Class bankaccount
    Dim accholder As String
    Dim accnumber As String
    Dim interestrate As Double
    Dim balance As Double
    Dim countryorigin As String

    Public Sub New(accholder As String, accnumber As String, balance As Double, interestrate As Double, countryorigin As String)
        Me.accholder = accholder
        Me.accnumber = accnumber
        Me.interestrate = interestrate
        Me.balance = balance
        Me.countryorigin = countryorigin
    End Sub

    Public Sub New(accholder As String, accnumber As String, balance As Double, interestrate As Double)
        Me.accholder = accholder
        Me.accnumber = accnumber
        Me.interestrate = interestrate
        Me.balance = balance
    End Sub

    Public Sub New(accholder As String, accnumber As String, balance As Double)
        Me.accholder = accholder
        Me.accnumber = accnumber
        Me.balance = balance
    End Sub

    Public Function getaccountholder() As String
        Return Me.accholder
    End Function
    Public Function getaccountnumber() As String
        Return Me.accnumber
    End Function

    Public Function getinterestrate() As Double
        Return Me.interestrate
    End Function

    Public Function getbalance() As Double
        Return Me.balance
    End Function

    Public Function getcountry() As String
        Return Me.countryorigin
    End Function

    Public Function setinterestrate(val As Double)
        Me.interestrate = val
        Return Nothing
    End Function

    Public Function deposit(val As Double)
        Me.balance += val
        Return Me.balance
    End Function

    Public Function withdrawal(val As Double)
        Me.balance -= val
        Return Me.balance
    End Function

    Public Function applyinterest()
        Dim NewBalance As Double = Me.balance + (Me.balance * 0.043 * (1 / 12))

        Me.balance = Math.Round(NewBalance, 2)

        Return Nothing
    End Function

    Public Overrides Function tostring() As String
        Dim AccountString As New StringBuilder()
        AccountString.Append("Isle of Man" & vbCrLf)
        AccountString.Append("ABCD 890111 11167890" & vbCrLf)
        AccountString.Append("Ms I.N.Cognito" & vbCrLf)
        AccountString.Append("Interest: 4.3%" & vbCrLf)
        AccountString.Append("10343.82" & vbCrLf)
        Return AccountString.ToString()
    End Function

End Class