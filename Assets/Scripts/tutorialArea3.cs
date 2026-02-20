using UnityEngine;
using TMPro;

public class tutorialArea3 : MonoBehaviour
{
    [SerializeField]
    public GameObject nextPlatform;

    [SerializeField]
    public TMP_Text notification;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the third trigger area");
            nextPlatform.SetActive(true);
            notification.text = "Nice! The next platform has appeared. Teleport to it and continue the tutorial.";
        }
    }
}
