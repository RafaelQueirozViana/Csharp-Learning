public static class AccountService {
    public static List<Account> AccountsList { get; private set; } = [];

    public static void AddAccount(Account account) {
        AccountsList.Add(account);
    }

    public static double GetTotalBalance() {
        double balanceSum = 0;
        foreach (Account currentAccount in AccountsList) {
            balanceSum += currentAccount.Balance;
        }

        return balanceSum;
    }

    public static void RemoveFromAllAccounts(double amount) {
        foreach (Account currentAccount in AccountsList) {
            currentAccount.RemoveValue(amount);





        }
    }
}