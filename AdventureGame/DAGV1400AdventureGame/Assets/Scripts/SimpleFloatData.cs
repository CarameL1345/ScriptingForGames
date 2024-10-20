using UnityEngine;

[CreateAssetMenu(menuName = "Single Variable/SimpleFloatData")]
public class SimpleFloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float amount)
    {
        value += amount;
        value = Mathf.Clamp(value, 0, 1); // Clamp to 0 - 1 range for health
    }

    public void SetValue(float amount)
    {
        value = amount;
    }
}
