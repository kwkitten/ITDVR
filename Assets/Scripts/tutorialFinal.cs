using UnityEngine;
using TMPro;

public class tutorialFinal : MonoBehaviour
{
    [SerializeField]
    public GameObject tutorialEndArea;

    [SerializeField]
    public TMP_Text notification;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the third trigger area");
            tutorialEndArea.SetActive(true);
            notification.text = "Great! Now press the button to finish the tutorial.";
        }
    }
}
