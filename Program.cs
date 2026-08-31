using Classes;

// class
BankAccount account1 =
    new BankAccount("ACC-001", "Murtaza", 1000);

account1.Deposit(500);

account1.Withdraw(200);

account1.DisplayAccountInfo();

// anonymous object
new BankAccount("ACC-001", "Murtaza", 1000).DisplayAccountInfo();

// staic method
BankAccount.displayBankName();