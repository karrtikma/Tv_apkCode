using UnityEngine;
using UnityEngine.UI;

public class TVController : MonoBehaviour
{
    public GameObject imageToShow; // Reference to the image you want to show
    public Button secondButtonToShow; // Reference to the second button you want to show

    // Flag to track the current state
    private bool isShowing = false;

    // Start is called before the first frame update
    void Start()
    {
        // Disable the image and second button initially
        if (imageToShow != null)
            imageToShow.SetActive(false);

        if (secondButtonToShow != null)
            secondButtonToShow.gameObject.SetActive(false);
    }

    // Function to handle button click event
    public void OnButtonClick()
    {
        // Toggle the visibility based on the current state
        if (isShowing)
        {
            // Turn off the image and second button
            if (imageToShow != null)
                imageToShow.SetActive(false);

            if (secondButtonToShow != null)
                secondButtonToShow.gameObject.SetActive(false);

            // Update the state
            isShowing = false;
        }
        else
        {
            // Turn on the image and second button
            if (imageToShow != null)
                imageToShow.SetActive(true);

            if (secondButtonToShow != null)
                secondButtonToShow.gameObject.SetActive(true);

            // Update the state
            isShowing = true;
        }
    }
}


