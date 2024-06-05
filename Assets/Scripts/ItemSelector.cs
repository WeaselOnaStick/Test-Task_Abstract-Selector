using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemSelector<T> : MonoBehaviour
{
    [SerializeField]
    List<T> items = new List<T>();

    [SerializeField]
    int cur_idx = 0;

    T current_item;

    public T Current_item { get => current_item; private set => current_item = value; }

    public void TraverseSelection(bool prev = false)
    {
        int step = prev ? -1 : 1;
        cur_idx += step;
        if (cur_idx < 0) cur_idx = 0;
        if (cur_idx >= items.Count) cur_idx = items.Count - 1;

        Current_item = items[cur_idx];
    }

    public abstract void DisplayCurrentItem();
}
