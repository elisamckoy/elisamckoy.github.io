/********************************* This File is not compiled or tested *******************************/
namespace ReversePolishNotationCalculater
{
    public class RPNCalculator
    {
        public int Evaluate(string expression)
        {
            string[] elements = expression.Split(' ');
            Stack<string> stack = new Stack<string>();

            foreach (string token in elements)
            {
                if (IsValue(token))
                {
                    stack.Push(token);
                }
                else
                {
                    string a = stack.Pop();
                    string b = stack.Pop();
                    int solution = EvaluateStringExpression(b + " " + token + " " + a);
                    stack.Push(solution.ToString());
                }

            }

            if (stack.Count == 1)
            {
                return Convert.ToInt32(stack.Pop());
            }
            return 0;
        }

        public bool IsValue(string token)
        {
            return Regex.IsMatch(token, @"^-?\d+$");
        }

        public int EvaluateStringExpression(string expression)
        {
            String[] elements = expression.Split(' ');
            int first = Convert.ToInt32(elements[0]);
            string op = elements[1];
            int second = Convert.ToInt32(elements[2]);
            if (op == "+")
            {
                return first + second;
            }
            else if (op == "-")
            {
                return first - second;
            }
            else
            {
                return first * second;
            }
        }
    }
}
