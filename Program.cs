namespace רשימה_מקושרת_חד_כוונית
{
    internal class Program
    {
       public static int Sum(List<int> L)
        {
            Node<int> head1 = L.head;
            int sum = 0;
            while(head1 != null)
            {
                sum+=head1.Value;
                head1 = head1.next;
            }
            return sum;
        }
        static void Main(string[] args)
        {
      
        }
    }
}