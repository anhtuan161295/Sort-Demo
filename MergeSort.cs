namespace Sort
{
    public class MergeSort
    {
        public int loopCount = 0; // Số lần chạy vòng lặp
        public int inversionCount = 0; // Số lần đổi chỗ 2 số
        public int[] doSort(int[] data)
        {
            mergeSort(data, 0, data.Length - 1);
            return data;
        }

        void merge(int[] data, int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            // Tạo 2 mảng trái, phải
            int[] L = new int[n1];
            int[] R = new int[n2];

            // Copy data vào 2 mảng
            for (i = 0; i < n1; i++)
            {
                L[i] = data[l + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = data[m + 1 + j];
            }

            // Merge array
            i = 0; j = 0;
            k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    data[k] = L[i];
                    i++;
                }
                else
                {
                    data[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy phần tử còn dư của L[] nếu có
            while (i < n1)
            {
                data[k] = L[i];
                i++;
                k++;
            }
            // Copy phần tử còn dư của R[] nếu có
            while (j < n2)
            {
                data[k] = R[j];
                j++;
                k++;
            }

        }
        void mergeSort(int[] data, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                mergeSort(data, l, m);
                mergeSort(data, m + 1, r);
                merge(data, l, m, r);
            }
        }
    }
}