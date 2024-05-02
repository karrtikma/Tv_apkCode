using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GoBack : MonoBehaviour
{
    //public VideoPlayer videoPlayer; // Reference to the VideoPlayer
    public Canvas canvasToEnable; // Reference to the Canvas to enable
    public Canvas canvasToDisable; // Reference to the Canvas to disable
    public GameObject[] quads; // Array of Quads to disable

    void Start()
    {
        // Add listener to the button
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // Stop the video playback
        //videoPlayer.Stop();

        // Disable the VideoPlayer
        //videoPlayer.gameObject.SetActive(false);

        // Enable the Canvas to enable
        canvasToEnable.gameObject.SetActive(true);

        // Disable the Canvas to disable
        canvasToDisable.gameObject.SetActive(false);

        // Disable each Quad
        foreach (GameObject quad in quads)
        {
            quad.SetActive(false);
        }
    }
}

