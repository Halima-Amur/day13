namespace day13
{
    class program
    {
        static void Main()
        {
            int x = 12345;
            int y = (IntegerMiror.Miror(x));
            Console.WriteLine(y);

            List<int> lst = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> result = Enumerable.Where(lst, x => x % 2 == 0).ToList();
            foreach (var xx in result)
            {
                Console.WriteLine(xx);
            }
            Console.WriteLine(result.GetType());

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var lst1 = numbers.Where(i => i % 2 == 0).ToList();
            numbers.Remove(2);
            numbers.AddRange(new int[] { 10, 11, 12, 13, 14, 15 });
            foreach (var item in lst.ToList())
            {
                Console.Write($"{item} ,");
            }
            numbers.Remove(2);

        }

    }
}


