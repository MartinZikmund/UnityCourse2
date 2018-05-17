using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        WriteOutMenu("Hello");
    }

    private static void WriteOutMenu(string greeting)
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
        Terminal.WriteLine("The user typed " + input);
    }
}

