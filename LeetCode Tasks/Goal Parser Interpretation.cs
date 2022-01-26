using System.Text;

namespace LeetCode_Tasks
{
    //https://leetcode.com/problems/goal-parser-interpretation/
    public static class GoalParserInterpretation
    {
        public static string Interpret(string command)
        {
            var result = new StringBuilder();
            for (var i = 0; i < command.Length; i++)
            {
                switch (command[i])
                {
                    case 'G':
                        result.Append('G');
                        break;
                    case '(' when i + 1 < command.Length && command[i + 1] == ')':
                        result.Append('o');
                        i += 1;
                        break;
                    default:
                        result.Append("al");
                        i += 3;
                        break;
                }
            }

            return result.ToString();
        }
    }
}