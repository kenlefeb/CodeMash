using System;
using System.Text;

public static class Extensions
{
    public static string ToString(this string[] array, string delimiter = ",")
    {
        var builder = new StringBuilder();
        foreach (var thisItem in array)
        {
            if (builder.Length > 0)
                builder.Append(delimiter);
            builder.Append(thisItem);
        }
        return builder.ToString();
    }
}
