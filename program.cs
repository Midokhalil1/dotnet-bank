Console.WriteLine("Welcome to the Bank");

BankAccount account = 
new BankAccount(5000);

// account.balance = 100;

Console.Write($"Your balance is: {account.balance} ");
Console.WriteLine($"Account Number: {account.accountNumber}");  