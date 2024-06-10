using System.Collections.Generic;

namespace Edabit
{
    internal class _05_28_Smallest_Transform
    {
        private static int[] DigitList(int num)
        {
            List<int> list = new List<int>();
            for (; num > 0; num /= 10) {
                list.Add(num % 10);
            }
            return list.ToArray();
        }
        public static int SmallestTransform(int num)
        {
            int[] digits = DigitList(num);
            int sum = 0, lowestSum = -1;
            for (int digitIndex = 0; digitIndex < digits.Length; digitIndex++) {
                sum = 0;
                for (int digitAddIndex = 0; digitAddIndex < digits.Length; digitAddIndex++) {
                    sum += Math.Abs(digits[digitIndex] - digits[digitAddIndex]);
                }
                if (lowestSum == -1 || sum < lowestSum) {
                    lowestSum = sum;
                }
            }
            return lowestSum;
        }
    }
}
