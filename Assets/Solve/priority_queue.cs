using System;
using System.Collections;
using System.Collections.Generic;

public class priority_queue<T>
{
    vector<Tuple<T,int>> data;
    public priority_queue()
    {
        data = new vector<Tuple<T, int>>();
    }
    private int getPriority(int priority)
    {
        for (int i = 0; i < data.size(); i++)
        {
            if (priority < data[i].Item2)
            {
                return i;
            }
        }
        return data.size();
    }
    public void push(T item, int _priority)
    {
        Tuple<T, int> temp = new Tuple<T, int>(item, _priority);
        data.insert(getPriority(_priority), temp);
    }
    public void pop()
    {
        data.erase(0);
    }
    public T top()
    {
        T temp = data[0].Item1;
        return temp;
    }
    public int size()
    {
        return data.size();
    }
    public bool empty()
    {
        return data.empty();
    }
    public T this[int index]
    {
        get
        {
            return data[index].Item1;
        }
    }
}
