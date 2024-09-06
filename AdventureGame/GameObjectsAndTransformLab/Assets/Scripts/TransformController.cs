using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        // Move the target GameObject
        var x = Mathf.PingPong(Time.time, 10);
        var p = new Vector3(x, 0, 0);
        transform.position = p;

        // Rotate the target GameObject
        transform.Rotate(new Vector3(0, 0, 1000) * Time.deltaTime);
    }
}
