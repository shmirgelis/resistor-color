using System;

public static class ResistorColor
{
    static string[] colorCodes = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    public static int ColorCode(string color)
    {
        int i = 0;
        foreach (string item in colorCodes)
        {
            if (color == item)
            {
                break;
            }

            i++;
        }

        return i;
    }

    public static string[] Colors()
    {
        return colorCodes;
    }
}