using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PopupController : MonoBehaviour
{
    public Image popupImage;      // assign your Popupimg1 here
    public float displayTime = 2f;
    private bool isShowing = false;

    public void ShowPopup(Sprite sprite)
    {
        if (!isShowing)
            StartCoroutine(ShowRoutine(sprite));
    }

    IEnumerator ShowRoutine(Sprite sprite)
    {
        isShowing = true;

        // Set the image
        popupImage.sprite = sprite;
        popupImage.gameObject.SetActive(true);

        // Pause the game
        Time.timeScale = 0f;

        // Wait in REAL TIME so pause doesn't affect timer
        yield return new WaitForSecondsRealtime(displayTime);

        popupImage.gameObject.SetActive(false);
        Time.timeScale = 1f;

        isShowing = false;
    }
}
