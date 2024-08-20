using System.Collections;
using System.Collections.Generic;

public class vector<T>
{
    private List<T> data;
    public vector() {
        data = new List<T>();
    }
    public void push_back(T item)
    {
        data.Add(item);
    }
    public void pop_back()
    {
        data.RemoveAt(data.Count - 1);
    }
    public T back()
    {
        T temp;
        temp = data[data.Count - 1];
        return temp;
    }
    public T front()
    {
        T temp;
        temp = data[0];
        return temp;
    }
    public int size()
    {
        return data.Count;
    }
    public bool empty()
    {
        if(data.Count == 0) return true;
        return false;
    }
    public void insert(int index, T item)
    {
        if(index >= data.Count) data.Add(item);
        else data.Insert(index, item);
    }
    public void erase(int index)
    {
        data.RemoveAt(index);
    }
    public T this[int index]
    {
        get
        {
            return data[index];
        }
        set
        {
            data[index] = value;
        }
    }
}
