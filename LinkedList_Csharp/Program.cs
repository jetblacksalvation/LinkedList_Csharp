namespace LinkedList_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            NodeList<int> list = new NodeList<int>(new List<int>() { 10, 20, 30, 40 });
            
            Console.WriteLine("next is = {0}", list.root.next.val);
            foreach(int item in list)
            {
                Console.WriteLine("value is = {0}", item);
            }
        }
    }
}