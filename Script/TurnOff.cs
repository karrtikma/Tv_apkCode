using UnityEngine;
using UnityEngine.UI;

public class TurnOff : MonoBehaviour
{
    public Canvas[] canvasesToDisable; // Array of Canvases to disable
    public GameObject[] quadsToDisable; // Array of Quads to disable
    public GameObject gameObjectToDisable; // GameObject to disable
    public Button[] buttonsToDisable; // Array of Buttons to disable

    void Start()
    {
        // Add listener to the button
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // Disable each Canvas in the array
        foreach (Canvas canvas in canvasesToDisable)
        {
            canvas.gameObject.SetActive(false);
        }

        // Disable each Quad in the array
        foreach (GameObject quad in quadsToDisable)
        {
            quad.SetActive(false);
        }

        // Disable the GameObject
        if (gameObjectToDisable != null)
        {
            gameObjectToDisable.SetActive(false);
        }

        // Disable each Button in the array
        foreach (Button button in buttonsToDisable)
        {
            button.gameObject.SetActive(false);
        }
    }
}
