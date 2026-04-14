public class Solution
{
    public int[] SortArray(int[] nums)
    {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private void MergeSort(int[] arr, int l, int r)
    {
        if (l >= r) return;

        int m = l + (r - l) / 2;

        MergeSort(arr, l, m);
        MergeSort(arr, m + 1, r);
        Merge(arr, l, m, r);
    }

    private void Merge(int[] arr, int L, int M, int R)
    {
        int leftSize = M - L + 1;
        int rightSize = R - M;

        int[] left = new int[leftSize];
        int[] right = new int[rightSize];

        // 🔥 Copy elements
        Array.Copy(arr, L, left, 0, leftSize);
        Array.Copy(arr, M + 1, right, 0, rightSize);

        int i = L, j = 0, k = 0;

        while (j < leftSize && k < rightSize)
        {
            if (left[j] <= right[k])
                arr[i++] = left[j++];
            else
                arr[i++] = right[k++];
        }

        while (j < leftSize)
            arr[i++] = left[j++];

        while (k < rightSize)
            arr[i++] = right[k++];
    }
}