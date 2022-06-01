using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void OnChange<T>(T newValue);

[System.Serializable]
public class GenericObservable<T>
{
    [SerializeField]
    private T _value;

    public OnChange<T> OnChange;

    public T Value
    {
        get
        {
            return _value;
        }
        set
        {
            _value = value;
            if (OnChange != null)
            {
                OnChange.Invoke(_value);
            }
        }
    }

    public GenericObservable(T initialValue)
    {
        Value = initialValue;
    }
}
