using UnityEngine;

public class ShowPoster : MonoBehaviour
{
    public GameObject posterCanvas;   // <-- drag PosterCanvas here in Inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("EndTrigger hit by: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player reached end – showing poster");

            if (posterCanvas != null)
            {
                posterCanvas.SetActive(true);   // show canvas + image
                Time.timeScale = 0f;            // pause game
            }
            else
            {
                Debug.LogError("PosterCanvas is not assigned on ShowPoster!");
            }
        }
    }
}
