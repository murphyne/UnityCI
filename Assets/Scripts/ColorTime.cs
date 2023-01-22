using UnityEngine;

public class ColorTime
{
    private readonly float _cycleDuration;

    public ColorTime(float cycleDuration = 1f)
    {
        _cycleDuration = cycleDuration;
    }

    public Color GetColor(float realTime)
    {
        var cycleTime = realTime / _cycleDuration % 1f;

        return Sinebow(cycleTime);
    }

    // http://basecase.org/env/on-rainbows
    private Color Sinebow(float t)
    {
        const float rOffset2Pi = 2 * Mathf.PI * 0 / 3;
        const float gOffset2Pi = 2 * Mathf.PI * 1 / 3;
        const float bOffset2Pi = 2 * Mathf.PI * 2 / 3;

        var t2Pi = t * 2 * Mathf.PI;

        var r = Mathf.Sin(t2Pi + rOffset2Pi) * 0.5f + 0.5f;
        var g = Mathf.Sin(t2Pi + gOffset2Pi) * 0.5f + 0.5f;
        var b = Mathf.Sin(t2Pi + bOffset2Pi) * 0.5f + 0.5f;

        var c = new Color(r, g, b);
        return c;
    }
}
