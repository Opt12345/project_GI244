using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Settings
{
    public static string currentScene;

    public static Nation mySide;
    public static Nation EnemySide;

    public static void SelectSide(int side)
    {
        switch (side)
        {
            case 0:
                mySide = Nation.Britain;
                EnemySide = Nation.Pirates;
                break;
            case 1:
                mySide = Nation.Pirates;
                EnemySide = Nation.Britain;
                break;
        }
    }
}
