Console.WriteLine("Welcome to the Bank");

BankAccount account = 
new BankAccount("new account name");

// BankAccount account = 
new BankAccount (11000);
try {
// account.balance = 100;
account.makeDeposit(-1);

} catch(Exception ex) {
    Console.WriteLine(ex.Message);
}

Console.Write($"Your balance is: {account.getBalance()} ");
Console.WriteLine($"Account Number: {account.accountNumber}");  