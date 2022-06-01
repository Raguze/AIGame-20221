using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void OnChangeInt(int newValue);

[System.Serializable]
public class IntObservable
{
    [SerializeField]
    private int _value;

    public OnChangeInt OnChange;

    public int Value {
        get {
            return _value;
        } 
        set 
        {
            _value = value;
            if(OnChange != null)
            {
                OnChange.Invoke(_value);
            }
        } 
    }

    public IntObservable(int initialValue)
    {
        Value = initialValue;
    }
    
}
