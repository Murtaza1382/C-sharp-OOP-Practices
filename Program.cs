using Classes;
BankAccount account1 =
    new BankAccount("ACC-001", "Murtaza", 1000);

account1.Deposit(500);

account1.Withdraw(200);

account1.DisplayAccountInfo();