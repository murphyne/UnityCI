using UnityEngine;

public class DebugColorHash : MonoBehaviour
{
    private void Update()
    {
        var str = $"{Time.time}";
        var color = ColorHash.ComputeHashColor(str);
        var rgb = ColorUtility.ToHtmlStringRGB(color);
        Debug.Log($"<color=#{rgb}>#{rgb}</color>");
    }
}
