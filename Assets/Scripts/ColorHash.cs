using UnityEngine;

public static class ColorHash
{
    public static int ComputeHashFromString(string message)
    {
        var hash = Hash128.Compute(message);
        var hashCode = hash.GetHashCode();
        return hashCode;
    }
}
