namespace LeetCode_Tasks
{
    // https://leetcode.com/problems/defanging-an-ip-address/
    public static class DefangingAnIpAddress
    {
        static string DefangIPaddr(string address)
        {
            return string.Join("[.]", address.Split('.'));
        }
    }
}