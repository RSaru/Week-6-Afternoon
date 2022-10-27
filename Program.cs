bankAccount barclaysAccount = new bankAccount();
barclaysAccount.setAccountNo("12345678");
barclaysAccount.setSortCode("12-34-56");
Console.WriteLine("Account Number = " + barclaysAccount.getAccountNumber());
Console.WriteLine("Account Number = " + barclaysAccount.getSortCode());
Console.WriteLine("Balance = " + barclaysAccount.getBalance());
barclaysAccount.deposit(200);
Console.WriteLine("Balance = " + barclaysAccount.getBalance());
barclaysAccount.with(56);
Console.WriteLine("Balance = " + barclaysAccount.getBalance());










Console.ReadKey();