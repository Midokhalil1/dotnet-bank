public class BankAccount {


public string accountNumber  {get; set;}

private decimal balance {get; set;}

public decimal getBalance(){
    return balance;
}

public void makeDeposit (decimal newDeposit) {
      if (newDeposit < 0){
    //   balance = balance; 

    throw new Exception("deposit under zero dollars");

} else {
      balance = balance + newDeposit;
}
}

public BankAccount() {
    accountNumber = "unknown";
    balance = 100.01m;

}
public BankAccount(string newAccountName) {

    accountNumber = newAccountName;
    balance = 100.01m;
}

public BankAccount(decimal startingBalance) {

    accountNumber = "unknow";
    balance = 100.01m;

    if(startingBalance > 10000){
    balance = startingBalance + 2000;

    }else {
    balance = startingBalance + 100.01m;
    }
}




}