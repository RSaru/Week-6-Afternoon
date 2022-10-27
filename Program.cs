bankAccount barclaysAccount = new bankAccount();
barclaysAccount.pin("1234");
//barclaysAccount.setAccountNo("12345678");
//barclaysAccount.setSortCode("12-34-56");
//Console.WriteLine("Account Number = " + barclaysAccount.getAccountNumber());
//Console.WriteLine("Account Number = " + barclaysAccount.getSortCode());
//Console.WriteLine("Balance = " + barclaysAccount.getBalance());
//barclaysAccount.deposit(200);
//Console.WriteLine("Balance = " + barclaysAccount.getBalance());
//barclaysAccount.with(56);
//Console.WriteLine("Balance = " + barclaysAccount.getBalance());
String userPin;
Console.WriteLine("Please enter your pin code");
userPin = Console.ReadLine();

int i;
i = 0;
do

    if (userPin == "1234")
    {
        Console.WriteLine("Please pick an option from the list:");
        Console.WriteLine("1. View Balance");
        Console.WriteLine("2. Withdraw Money");
        Console.WriteLine("3. Deposit Money");
        Console.WriteLine("4. Change Pin Number");
        int choice;
        Console.WriteLine("5. Exit");
        choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Your balance is: " +barclaysAccount.getBalance());
            Console.WriteLine("----------------");
        }
        else if (choice == 2)
        {
            double withdrawCash;
            Console.WriteLine("How much money would you like to withdraw?");
            withdrawCash = Convert.ToDouble(Console.ReadLine());
            barclaysAccount.with(withdrawCash);
            Console.WriteLine("----------------");
        }
        else if (choice == 3)
        {
            double depositCash;
            Console.WriteLine("How much money would you like to deposit?");
            depositCash = Convert.ToDouble(Console.ReadLine());
            barclaysAccount.deposit(depositCash);
            Console.WriteLine("----------------");
        }
        else if (choice == 4)
        {
            String usersPin;
            Console.WriteLine("What would you want to change your pin code to?");
            usersPin = Console.ReadLine();
            Console.WriteLine("----------------");
            Console.WriteLine("Your pin is now: "+ usersPin);
            Console.WriteLine("----------------");
        }
        else if (choice == 5)
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("That Pin was not incorrect");
    }

while (i < 5);








Console.ReadKey();