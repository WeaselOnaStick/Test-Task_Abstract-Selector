using System.Collections.Generic;
using UnityEngine;

public abstract class ItemSelector<T> : MonoBehaviour
{
    [SerializeField]
    protected List<T> items = new List<T>();

    [SerializeField]
    int cur_idx = 0;

    [SerializeField]
    public bool loopSteps = true;

    T current_item;

    public T Current_item { get => current_item; private set => current_item = value; }

    public void StepTraverseSelection(bool prev = false)
    {
        int step = prev ? -1 : 1;
        cur_idx += step;
        if (loopSteps)
        {
            if (cur_idx < 0) cur_idx = items.Count - 1;
            if (cur_idx >= items.Count) cur_idx = 0;
        }
        else
        {
            if (cur_idx < 0) cur_idx = 0;
            if (cur_idx >= items.Count) cur_idx = items.Count - 1;
        }

        Current_item = items[cur_idx];
        DisplayCurrentItem();
    }

    public void GoToSelection(int index)
    {
        if (index < 0 || index >= items.Count) return;
        cur_idx = index;
        Current_item = items[cur_idx];
        DisplayCurrentItem();
    }

    public abstract void DisplayCurrentItem();

    public abstract void InitializeList();

    private void Start()
    {
        InitializeList();
        GoToSelection(0);
    }
}
