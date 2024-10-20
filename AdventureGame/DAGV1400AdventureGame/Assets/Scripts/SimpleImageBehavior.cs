using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SimpleImageBehavior : MonoBehaviour
{
    private Image imageObj;
    public SimpleFloatData dataObj;

    private void Start()
    {
        imageObj = GetComponent<Image>();
        Debug.Log(dataObj.value);
    }

    public void UpdateWithFloatData()
    {
        imageObj.fillAmount = dataObj.value;
    }
}
