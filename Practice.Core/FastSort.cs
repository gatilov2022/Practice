namespace Practice.Core;

public class FastSort
{
    private static void Swap(ref char left, ref char right)
    {
        var t = left;
        left = right;
        right = t;
    }

    //метод возвращающий индекс опорного элемента
    private static int Partition(char[] array, int minIndex, int maxIndex)
    {
        var pivot = minIndex - 1;
        for (var i = minIndex; i < maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivot++;
                Swap(ref array[pivot], ref array[i]);
            }
        }

        pivot++;
        Swap(ref array[pivot], ref array[maxIndex]);
        return pivot;
    }

    //быстрая сортировка
    private static char[] QuickSort(char[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }

        var pivotIndex = Partition(array, minIndex, maxIndex);
        QuickSort(array, minIndex, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, maxIndex);

        return array;
    }

    public static string QuickSort(char[] array)
    {
        return new string(QuickSort(array, 0, array.Length - 1));
    }
}