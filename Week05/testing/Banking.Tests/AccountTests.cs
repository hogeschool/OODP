using System;


namespace Banking.Tests;

[TestClass]
public class AccountTests
{
    Account _account;

    [TestInitialize]
    public void Initialize()
    {
        _account = new Account();
    }

    [TestMethod]
    public void Deposit_UpdatesBalance()
    {
        _account.Deposit(100);
        Assert.AreEqual(100, _account.GetBalance());
    }

    [TestMethod]
    public void Withdraw_UpdatesBalance()
    {
        _account.Deposit(100);
        _account.Withdraw(50);
        Assert.AreEqual(50, _account.GetBalance());
    }

    [TestMethod]
    public void Withdraw_UpdatesBalance_WithNegativeAmount()
    {
        _account.Deposit(100);
        _account.Withdraw(-50);
        Assert.AreEqual(50, _account.GetBalance());
    }

    [TestMethod]
    public void Withdraw_UpdatesBalance_NegativeBalance()
    {
        _account.Deposit(100);
        
        
        Assert.ThrowsException<InvalidOperationException>(() => _account.Withdraw(150));
        
        
        Assert.AreEqual(100, _account.GetBalance());
    }

    [TestMethod]
    public void GetBalance_ReturnsZero()
    {
        Assert.AreEqual(0, _account.GetBalance());
    }

    // dit wil je voorkomen!
    [TestMethod]
    public void PrintWarningWhenNegativeBalance_ShouldNotPrintWarning_WhenBalanceIsPositive()
    {
        // Arrange
        var account = new Account();
        account.Deposit(100);

        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);

            // Act
            account.PrintWarningWhenNegativeBalance();

            // Assert
            var result = sw.ToString().Trim();
            Assert.AreEqual(string.Empty, result);
        }
    }

    [TestMethod]
    [DataRow(100, 200, 50)]
    [DataRow(500, 300, 100)]
    [DataRow(1000, 500, 250)]
    public void Transfer_ValidAmount_UpdatesBothAccounts(double initialSourceBalance, double initialTargetBalance, double transferAmount)
    {
        // Arrange
        var sourceAccount = new Account { Transactions = new () {new Transaction (initialSourceBalance, true)} };
        var targetAccount = new Account { Transactions = new () {new Transaction (initialTargetBalance, true)} };

        // Act
        sourceAccount.Transfer(transferAmount, targetAccount);

        // Assert
        Assert.AreEqual(initialSourceBalance - transferAmount, sourceAccount.GetBalance());
        Assert.AreEqual(initialTargetBalance + transferAmount, targetAccount.GetBalance());
    }
}