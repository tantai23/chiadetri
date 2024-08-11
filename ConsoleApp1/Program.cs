class QuickSortExample
{
    // Phương thức thực hiện sắp xếp nhanh
    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            // Phân hoạch mảng
            int pi = Partition(array, low, high);

            // Sắp xếp các phần tử ở hai nửa
            QuickSort(array, low, pi - 1);
            QuickSort(array, pi + 1, high);
        }
    }

    // Phương thức phân hoạch mảng
    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high]; // Chọn phần tử cuối cùng làm pivot
        int i = (low - 1); // Chỉ số của phần tử nhỏ hơn

        for (int j = low; j < high; j++)
        {
            // Nếu phần tử hiện tại nhỏ hơn pivot
            if (array[j] <= pivot)
            {
                i++;
                // Hoán đổi array[i] và array[j]
                Swap(ref array[i], ref array[j]);
            }
        }

        // Hoán đổi array[i + 1] và array[high] (pivot)
        Swap(ref array[i + 1], ref array[high]);
        return i + 1;
    }

    // Phương thức hoán đổi hai phần tử
    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void Main()
    {
        int[] array = { 34, 7, 23, 32, 5, 62, 32, 34 };
        Console.WriteLine("Array before sorting:");
        Console.WriteLine(string.Join(", ", array));

        QuickSort(array, 0, array.Length - 1);

        Console.WriteLine("Array after sorting:");
        Console.WriteLine(string.Join(", ", array));
    }
}