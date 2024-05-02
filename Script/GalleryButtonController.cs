using UnityEngine;
using UnityEngine.UI;

public class GallaryButtonController : MonoBehaviour
{
    public Canvas canvas; // Reference to the Canvas to enable

    void Start()
    {
        // Add listener to the button
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // Enable the Canvas
        canvas.gameObject.SetActive(true);

        // Disable this button
        gameObject.SetActive(false);
    }
}
