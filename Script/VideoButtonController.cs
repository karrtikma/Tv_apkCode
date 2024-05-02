using UnityEngine;
using UnityEngine.UI;

public class VideoButtonController : MonoBehaviour
{
    public GameObject quad; // Reference to the Quad to enable
    public Canvas canvasToEnable; // Reference to the Canvas to enable
    public Canvas canvasToDisable; // Reference to the Canvas to disable

    void Start()
    {
        // Add listener to the button
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // Enable the Quad
        quad.SetActive(true);

        // Enable the Canvas to enable
        canvasToEnable.gameObject.SetActive(true);

        // Disable the Canvas to disable
        canvasToDisable.gameObject.SetActive(false);
    }
}

