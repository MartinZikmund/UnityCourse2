using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    private int level;

    enum Screen
    {
        MainMenu,
        Password,
        Win
    };

    private Screen currentScreen = Screen.MainMenu;

    // Use this for initialization
    void Start()
    {        
        WriteOutMenu();
    }

    private static void WriteOutMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Choose difficulty");
        Terminal.WriteLine("1 Easy");
        Terminal.WriteLine("2 Medium");
        Terminal.WriteLine("3 Hard");
        Terminal.WriteLine("Enter your selection: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            WriteOutMenu();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Bond");
        }
    }

    void StartGame(int level)
    {
        Terminal.WriteLine("You have chosen level " + level);
    }
}

