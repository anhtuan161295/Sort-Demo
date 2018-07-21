namespace Sort
{
    public class SelectionSort
    {
        public int loopCount = 0; // Số lần chạy vòng lặp
        public int inversionCount = 0; // Số lần đổi chỗ 2 số
        public int[] doSort(int[] data)
        {
            int i, j, minIndex;
            // Xem số đầu tiên là số nhỏ nhất rồi kiểm tra xem có số nào nhỏ hơn thì đổi chỗ
            // Vì đã xem số thứ 1 là nhỏ nhất nên chỉ cần kiểm tra từ số thứ 2 > số kế cuối
            for (i = 0; i < data.Length; i++)
            {
                minIndex = i; // Index của số nhỏ nhất
                for (j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[minIndex])
                    {
                        minIndex = j; // Tìm được index mới của số nhỏ nhất
                    }
                    loopCount++;
                }
                // Đổi chỗ 2 số
                int temp = data[i];
                data[i] = data[minIndex];
                data[minIndex] = temp;
                inversionCount++;
                loopCount++;
            }
            return data;
        }
    }
}