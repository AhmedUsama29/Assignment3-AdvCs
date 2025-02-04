namespace Assignment3_AdvC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);

            //Console.WriteLine("-----------Before------------");
            //foreach (int item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //ReverseQueue(queue);

            //Console.WriteLine("-----------After------------");

            //foreach (int item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q2 : Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //string text1 = "(){}[]";
            //string text2 = "()}[]";
            //string text3 = "(}{}[]";
            //string text4 = "({}[()])";
            
            //bool result1 = IsBalanced(text1);
            //bool result2 = IsBalanced(text2);
            //bool result3 = IsBalanced(text3);
            //bool result4 = IsBalanced(text4);

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.WriteLine(result4);

            #endregion

        }

        #region Q1 : Given a Queue, implement a function to reverse the elements of a queue using a stack.
        public static void ReverseQueue<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

        }
        #endregion

        #region Q2 : Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
        public static bool IsBalanced(string text)
        {

            Stack<char> stack = new Stack<char>();

            foreach (char c in text)
            {
                
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }


        #endregion
    }
}
