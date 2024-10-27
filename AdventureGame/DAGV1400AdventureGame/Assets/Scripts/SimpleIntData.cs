using UnityEngine;
using System;

public class SimpleIntData : MonoBehaviour
{
    private int _value;

    public int value
    {
        get => _value;
        set
        {
            if (_value != value)
            {
                _value = value;
                OnValueChanged?.Invoke(_value); // Trigger event when value changes
            }
        }
    }

    public event Action<int> OnValueChanged; // Event to notify listeners

    public void UpdateValue(int amount)
    {
        value += amount; // This will trigger the OnValueChanged event
    }

    public void SetValue(int amount)
    {
        value = amount; // This will also trigger the OnValueChanged event
    }
}
