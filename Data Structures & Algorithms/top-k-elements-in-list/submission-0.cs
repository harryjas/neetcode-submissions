public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> mp = new();
        foreach(int i in nums){
            mp[i] = mp.GetValueOrDefault(i, 0) + 1;
        }
        PriorityQueue<int,int> pq = new();
        foreach(var node in mp){
            if(pq.Count < k){
                pq.Enqueue(node.Key, node.Value);
            }else{
                if(pq.TryPeek(out int ele, out int priority)){
                    if(priority < node.Value){
                        pq.Dequeue();
                        pq.Enqueue(node.Key, node.Value);
                    }
                }
            }
        }
        List<int> ans = new();
        while(pq.Count>0){
            ans.Add(pq.Dequeue());
        }
        return ans.ToArray();
    }
}
