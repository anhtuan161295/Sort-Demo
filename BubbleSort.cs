namespace Sort
{
    public class BubbleSort
    {
        public int loopCount = 0; // Số lần chạy vòng lặp
        public int inversionCount = 0; // Số lần đổi chỗ 2 số
        public int[] doSort(int[] data)
        {
            // So sánh 2 số liên tiếp và đổi chỗ nếu có số lớn hơn
            // Số lớn nhất là số ngoài cùng bên phải, min >>> max
            // vòng lặp i chạy 1 lần là dc số lớn nhất
            // Số lần chạy sau phải trừ đi các số đã sắp xếp
            // Chạy từ 0 nên length-1 , chạy 1 lần là sắp xếp dc 1 số nên length-1-i 
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - 1 - i; j++)
                {
                    // Nếu số bên trái > số bên phải thì đổi chỗ
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                        inversionCount++;
                    }
                    loopCount++;
                }
                loopCount++;
            }
            return data;
        }
    }
}