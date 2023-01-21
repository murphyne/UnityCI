using UnityEngine;

public class DebugColorHash : MonoBehaviour
{
    [SerializeField] private string message = "Hello World";

    private void Update()
    {
        var str = message + Time.time;
        var color = ColorHash.ComputeHashColor(str);
        var rgb = ColorUtility.ToHtmlStringRGB(color);
        Debug.Log($"<color=#{rgb}>{message}</color>");
    }
}
