using System.Linq;

namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/richest-customer-wealth/
    public static class RichestCustomerWealth
    {
        public static int MaximumWealth(int[][] accounts)
        {
            return accounts.Max(customerBankMoney => customerBankMoney.Sum());
        }
    }
}