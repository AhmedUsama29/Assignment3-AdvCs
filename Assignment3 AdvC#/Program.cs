namespace Assignment3_AdvC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : Given a Queue, implement a function to reverse the elements of a queue using a stack.

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("-----------Before------------");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            ReverseQueue(queue);

            Console.WriteLine("-----------After------------");

            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

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
    }
}
