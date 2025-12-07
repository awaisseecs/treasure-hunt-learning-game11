using UnityEngine;

public class ScrollPopup : MonoBehaviour
{
    public Sprite popupSprite;          // assign K2, Attabad, etc.
    public PopupController popupCtrl;   // assign PopupCanvas

    private bool used = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (used) return;
        if (!other.CompareTag("Player")) return;

        used = true;
        popupCtrl.ShowPopup(popupSprite);
    }
}
