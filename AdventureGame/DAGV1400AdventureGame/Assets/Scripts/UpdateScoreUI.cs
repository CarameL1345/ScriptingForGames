using UnityEngine;
using TMPro;
using System.Globalization;

[RequireComponent(typeof(TextMeshProUGUI))]
public class UpdateScoreUI : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    public SimpleIntData dataObj;

    private void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        UpdateWithIntData(dataObj.value); // Initial update
        dataObj.OnValueChanged += UpdateWithIntData; // Subscribe to the event
    }

    // Update method now accepts an int parameter
    public void UpdateWithIntData(int newValue)
    {
        textObj.text = newValue.ToString(CultureInfo.InvariantCulture);
        Debug.Log("UI Update");
    }
}
