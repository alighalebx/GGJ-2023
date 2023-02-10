using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WeightedRandomList<T>
{
    [System.Serializable]
    public struct Pair
    {
        public T item;
        public T item2;

        public Pair(T item, T item2)
        {
            this.item = item;
            this.item2 = item2;
        }
    }

    public List<Pair> list = new List<Pair>();

    public int Count
    {
        get => list.Count;
    }

    public void Add(T item, T item2)
    {
        list.Add(new Pair(item, item2));
    }

    public Pair GetRandom()
    {
        //float totalWeight = 0;

        //foreach (Pair p in list)
        //{
        //    totalWeight += p.weight;
        //}

        float value = Random.value;

        //float sumWeight = 0;

        foreach (Pair p in list)
        {
            //sumWeight += p.weight;

                return p;
            
        }

        return default(Pair);
    }
}