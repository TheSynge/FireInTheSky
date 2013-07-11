using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public Texture2D BurningPlanet;
    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), BurningPlanet);
        // Make a background box
        GUI.Box(new Rect(10, 10, 100, 90), "Fire in the Sky");

        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if (GUI.Button(new Rect(20, 40, 80, 20), "New Game"))
        {
            Application.LoadLevel("LunarSurfaceArea1");
        }

        // Make the second button.
        if (GUI.Button(new Rect(20, 70, 80, 20), "Quit Game"))
        {
            Application.Quit();
        }
    }
}


