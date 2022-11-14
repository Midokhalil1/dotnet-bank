public class BankAccount {


public string accountNumber  {get; set;}

public decimal balance {get; set;}

public BankAccount() {
    accountNumber = "unknown";
    balance = 100.01m;

}

public BankAccount(decimal startingBalance) {

    accountNumber = "unknow";
    balance = 100.01m;

    if(startingBalance > 10000){
    balance = startingBalance + 2000;

    }else 
    balance = startingBalance + 100.01m;
}


}