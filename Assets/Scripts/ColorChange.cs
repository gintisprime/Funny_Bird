using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Renderer characterRenderer;  // Reference to the character's renderer

    void Update()
    {
        // Check for button input to change color to a specific color based on hex code
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeColor("#8D00F1");  // Blue color
        }

        // Check for button input to change color to another specific color based on hex code
        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeColor("#FF0000");  // Red color
        }

        // Check for button input to change color to yet another specific color based on hex code
        if (Input.GetKeyDown(KeyCode.W))
        {
            ChangeColor("#FFFFFF");  // Green color
        }
    }

    void ChangeColor(string hexCode)
    {
        Color newColor;
        if (ColorUtility.TryParseHtmlString(hexCode, out newColor))
        {
            characterRenderer.material.color = newColor;
        }
        else
        {
            Debug.LogError("Invalid hex code: " + hexCode);
        }
    }
}
