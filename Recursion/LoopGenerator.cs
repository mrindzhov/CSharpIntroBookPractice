namespace Recursion
{
    public class LoopGenerator
    {
        public static void GenerateLoops(int count)
        {
            for (int i = 0; i < count; i++)
            {
                GenerateLoops(i);
            }
        }
    }
}
