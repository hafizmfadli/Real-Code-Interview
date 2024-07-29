// See https://aka.ms/new-console-template for more information


class Solution
{
  public static int TiketDotComInterviewV1(int[] arr, int target)
  {
    if (arr.Length == 0)
    {
      return -1;
    }

    int idx = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] == target)
      {
        idx = i;
        break;
      }

      if (arr[i] > target)
      {
        idx = i - 1;
        break;
      }

      idx = i;
    }

    return idx < 0 ? -1 : arr[idx];
  }


  public static int TiketDotComInterviewV2(int[] arr, int target)
  {
    if (arr.Length == 0)
    {
      return -1;
    }

    int idx = BinarySearch(arr, 0, arr.Length - 1, target);
    if (idx < 0)
    {
      return -1;
    }

    return arr[idx];
  }

  public static int BinarySearch(int[] arr, int start, int end, int target)
  {
    if (start > end)
    {
      return end;
    }

    int mid = (start + end) / 2;
    if (arr[mid] == target)
    {
      return mid;
    }

    return target > arr[mid] ? BinarySearch(arr, mid + 1, end, target) : BinarySearch(arr, start, mid - 1, target);
  }
}

class Program
{
  public static void Main(string[] args)
  {
    int[] arr = { 2, 4, 6, 8, 10 };
    Console.WriteLine(Solution.TiketDotComInterviewV2(arr, 1));
    Console.WriteLine(Solution.TiketDotComInterviewV2(arr, 6));
    Console.WriteLine(Solution.TiketDotComInterviewV2(arr, 11));


  }
}
