using UnityEngine;

public class DebugColorHash : MonoBehaviour
{
    private void Update()
    {
        var color = ColorHash.ComputeHashColor(Time.time);
        var rgb = ColorUtility.ToHtmlStringRGB(color);
        Debug.Log($"<color=#{rgb}>#{rgb}</color>");
    }
}
