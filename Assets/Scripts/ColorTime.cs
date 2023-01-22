using UnityEngine;

public class ColorTime
{
    public Color GetColor(float realTime)
    {
        var cycleTime = realTime % 1f;

        return SineColor(cycleTime);
    }

    private Color SineColor(float t)
    {
        var t2Pi = t * 2 * Mathf.PI;
        var cos = Mathf.Cos(t2Pi) * 0.5f + 0.5f;

        var color0 = Color.black;
        var color1 = Color.gray;
        return Color.Lerp(color0, color1, cos);
    }
}
