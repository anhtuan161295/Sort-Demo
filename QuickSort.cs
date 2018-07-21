namespace Sort
{
    public class QuickSort
    {
        public int loopCount = 0; // Số lần chạy vòng lặp
        public int inversionCount = 0; // Số lần đổi chỗ 2 số
        public int[] doSort(int[] data)
        {
            sort(data, 0, data.Length - 1);
            return data;
        }

        // Quick sort using the last index as pivot
        int partition(int[] data, int low, int high)
        {
            int pivot = data[high];
            int i = low - 1; // i = -1
            for (int j = low; j < high; j++)
            {
                // Nếu phần tử hiện tại < pivot thì đổi chỗ
                if (data[j] <= pivot)
                {
                    // Nếu có số < pivot thì đổi chỗ số đó ra vị trí đầu tiên index 0 rồi tăng dần
                    i++;
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    inversionCount++;
                }
                loopCount++;
            }
            // Đến đây thì những số nhỏ hơn pivot đã nằm bên trái pivot
            // i+1 là số lớn hơn, nên ta đổi chỗ, lúc này pivot nằm giữa 2 phàn số nhỏ và lớn hơn
            int temp2 = data[i + 1];
            data[i + 1] = data[high];
            data[high] = temp2;
            inversionCount++;

            return i + 1;
        }
        void sort(int[] data, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(data, low, high);
                sort(data, low, pi - 1);
                sort(data, pi + 1, high);
            }
        }
    }
}