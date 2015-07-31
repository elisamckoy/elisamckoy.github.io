/********************************* This File is not compiled or tested ********************************/
namespace CalculateMedian
{
    public float Median(List<int> list)
    {
        list.Sort();
        if (list.Count % 2 == 0)
        {
            var sum = list[(list.Count / 2) - 1] + list[list.Count / 2];
            return sum / (float)2.0;
        }
        var temp = list[list.Count / 2];
        return temp;
    }
}