namespace Sort
{
    public class InsertionSort
    {
        public int loopCount = 0; // Số lần chạy vòng lặp
        public int inversionCount = 0; // Số lần đổi chỗ 2 số
        public int[] doSort(int[] data)
        {   // Chỉ chạy từ 1 > số kế cuối
            // vì số kế cuối bị đẩy lên số cuối, số đầu tiên thì dùng cho biến j
            for (int i = 1; i < data.Length; i++)
            {
                int key = data[i]; // Lấy 1 số , rút 1 là bài từ bộ bài data
                int j = i - 1; // lá bài bên trái của key, số bên trái key
                while (j >= 0 && data[j] > key) // vòng lặp chạy từ j về 0
                {
                    data[j + 1] = data[j]; // Số lớn hơn key sẽ bị đẩy qua bên phải, hay index tăng lên 1
                    j--;                    // để có vị trí chèn key
                    loopCount++;
                    inversionCount++;
                }
                // Khi gặp số nhỏ hơn thì while sẽ dừng, j lúc này là index của số nhỏ hơn
                // lúc này data[j] < data[j+1] = data[j+2] 
                // vì mình đẩy index lên 1 để lấy vị trí chèn trong while
                data[j + 1] = key; // j+1 chính là vị trí giữa số nhỏ hơn và lớn hơn key
                // gắn key vào và ta có 1 số đã được sắp xếp
                loopCount++;
            }
            return data;
        }
    }
}