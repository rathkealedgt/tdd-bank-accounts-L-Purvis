Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestConstructors()

        'Arrange
        'Dim AccHolder As String = "Mrs I. N. Cognito"
        'Dim AccNumber As String = "ABCD 890111 11167890"
        'Dim Balance As Double = 10343.82
        'Dim CountryOrigin As String = "Isle of Man"
        'Dim InterestRate As Double = 4.3
        ''Act
        'Dim Account1 As New BankAccounts.BankAcc(AccHolder, AccNumber, Balance, InterestRate, CountryOrigin)
        'Dim Account2 As New BankAccounts.BankAcc(AccHolder, AccNumber, Balance, InterestRate)
        'Dim Account3 As New BankAccounts.BankAcc(AccHolder, AccNumber, Balance)
        ''Assert
        'Assert.IsNotNull(Account1)
        'Assert.IsNotNull(Account2)
        'Assert.IsNotNull(Account3)

        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim Account1 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)
        Dim Account2 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, Balance, InterestRate)
        Dim Account3 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, Balance)
    End Sub

    <TestMethod()> Public Sub TestGetName()

        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim Account1 As New BankAccounts.bankaccount(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        Dim Name As String = Account1.getaccountholder

        Assert.AreEqual(Name, "Ms I. N. Cognito")
    End Sub

    <TestMethod()> Public Sub TestGetAccNum()

        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim Account1 As New BankAccounts.bankaccount(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        Dim AccNum As String = Account1.getaccountnumber

        Assert.AreEqual(AccountNumber, "ABCD 890111 11167890")
    End Sub
    <TestMethod()> Public Sub TestGetIntRate()

        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim Account1 As New BankAccounts.bankaccount(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        Dim IntRate As String = Account1.getinterestrate

        Assert.AreEqual(InterestRate, 4.3)
    End Sub

    <TestMethod()> Public Sub TestGetBal()

        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim Account1 As New BankAccounts.bankaccount(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        Dim Bal As String = Account1.getbalance

        Assert.AreEqual(Balance, 10343.82)
    End Sub
    <TestMethod()> Public Sub TestGetCountry()

        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"

        Dim Account1 As New BankAccounts.bankaccount(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)

        Dim Country As String = Account1.getcountry

        Assert.AreEqual(CountryOfOrigin, "Isle of Man")
    End Sub

    <TestMethod()> Public Sub TestSetInterestRate()

        Dim Account1 As BankAccounts.bankaccount = Me.NewAccount()

        Account1.setinterestrate(4.3)

        Assert.AreEqual(4.3, Account1.getinterestrate())
    End Sub

    <TestMethod()> Public Sub TestApplyInterestRate()

        Dim Account1 As BankAccounts.bankaccount = Me.NewAccount()

        Account1.applyinterest()

        Assert.AreEqual(Account1.getbalance(), 10380.89)
    End Sub

    <TestMethod()> Public Sub TestToString()

        Dim ExpectedVal As New StringBuilder()
        ExpectedVal.Append("Isle of Man" & vbCrLf)
        ExpectedVal.Append("ABCD 890111 11167890" & vbCrLf)
        ExpectedVal.Append("Ms I.N.Cognito" & vbCrLf)
        ExpectedVal.Append("Interest: 4.3%" & vbCrLf)
        ExpectedVal.Append("10343.82" & vbCrLf)

        Dim account1 As BankAccounts.bankaccount = NewAccount()

        Dim ActualString = account1.tostring()
        Console.WriteLine(ActualString)

        Assert.AreEqual(ExpectedVal.ToString(), ActualString)
    End Sub

    <TestMethod()> Public Sub TestDeposit()
        Dim Account1 As BankAccounts.bankaccount = Me.NewAccount
        Dim ExVal As Double = 10343.82 + 700

        Dim ActualVal As Double = Account1.deposit(700)

        Assert.AreEqual(ExVal, ActualVal)

    End Sub

    <TestMethod()> Public Sub TestWithdrawal()
        Dim Account1 As BankAccounts.bankaccount = Me.NewAccount
        Dim ExVal As Double = 10343.82 - 700

        Dim ActualVal As Double = Account1.withdrawal(700)

        Assert.AreEqual(ExVal, ActualVal)

    End Sub

    Private Function NewAccount() As BankAccounts.bankaccount
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"
        Return New BankAccounts.bankaccount(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)
    End Function

End Class