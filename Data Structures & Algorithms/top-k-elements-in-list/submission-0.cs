public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> count = new();
        foreach(int num in nums)
        {
            if(count.ContainsKey(num)) count[num] ++;
            else count[num] = 1;
        }

        PriorityQueue<int, int> heap = new();
        foreach(var entry in count)
        {
            heap.Enqueue(entry.Key, entry.Value);
            if(heap.Count > k){
                heap.Dequeue();
            }
        }

        var result = new int[k];
        for(int i=0; i<k; i++){
            result[i] = heap.Dequeue();
        }

        return result;
    }
}
