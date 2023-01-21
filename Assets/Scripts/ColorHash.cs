using UnityEngine;

public static class ColorHash
{
    public static Color ComputeHashColor(string message)
    {
        var rgba = ComputeHashFromString(message);
        var r = (rgba >> 24 & 0xFF) / 256f;
        var g = (rgba >> 16 & 0xFF) / 256f;
        var b = (rgba >>  8 & 0xFF) / 256f;
        var hashColor = new Color(r, g, b);
        return hashColor;
    }

    private static int ComputeHashFromString(string message)
    {
        var hash = Hash128.Compute(message);
        var hashCode = hash.GetHashCode();
        return hashCode;
    }
}
