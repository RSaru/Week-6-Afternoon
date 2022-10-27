class bankAccount
{
    double balance = 0;
    double overdraftLimit;

    double interestRate;
    String accountNo;

    String sortCode;

    public void deposit(double dep)
    {
        balance += dep;
    }
        public double getBalance()
    {
        return balance;
    }

        public void with(double withdraw)
    {
        balance -= withdraw;
    }
        public double with()
    {
        return balance;
    }

    //Method to set the account number
    public void setAccountNo(String acc)
    {
        this.accountNo = acc;
    }
    //MEthod to get the account number
    public String getAccountNumber()
    {
        return accountNo;
    }
    //Method to set the interest rate

        public void setSortCode(String sort)
    {
        this.sortCode = sort;
    }
    //MEthod to get the interest rate
    public String getSortCode()
    {
        return sortCode;
    }


}