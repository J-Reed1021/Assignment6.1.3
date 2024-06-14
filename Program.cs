namespace Assignment6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 0, 6, 9, 0, 3 };
            MoveZeroesToEnd(array);
        }
        public static void MoveZeroesToEnd(int[] array)
        {
            int count = 0;
            // Move all non-zero elements to the beginning of the array
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    array[count++] = array[i];
                }
            }
            
            while (count < array.Length) 
            {
                array[count++] = 0;
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
    }
}
