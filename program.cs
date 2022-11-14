Console.WriteLine("Welcome to the Bank");

BankAccount account = 
new BankAccount("new account name");

// account.balance = 100;

Console.Write($"Your balance is: {account.balance} ");
Console.WriteLine($"Account Number: {account.accountNumber}");  