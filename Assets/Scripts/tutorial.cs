using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SocialPlatforms.Impl;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class tutorial : MonoBehaviour
{
    public static bool tutorialCompleted = false;

    [SerializeField]
    public TMP_Text notification;

    [SerializeField]
    public GameObject TriggerArea;

    [SerializeField]
    public GameObject tutorialArea2;

    [SerializeField]
    public GameObject tutorialArea3;

    [SerializeField]
    public GameObject player;

    [SerializeField]
    public GameObject TriggerArea2;

    [SerializeField]
    public GameObject tutorialEndArea;

    [SerializeField]
    public GameObject teleportPlatform1;

    [SerializeField]
    public GameObject teleportPlatform2;

    [SerializeField]
    public GameObject door;

    [SerializeField]
    int triggerCounter = 0;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player entered trigger area");
        if (triggerCounter == 0)
        {
            Debug.Log("Player entered the first trigger area");
            ShowInstruction1();
            triggerCounter = 1;
        }

        if (triggerCounter == 2)
        {
            Debug.Log("Player entered the third trigger area");
            ShowInstruction3();
            triggerCounter += 1;
        }

        if (triggerCounter == 5)
        {
            Debug.Log("Player entered the end area");
            notification.text = "Now press the button to finish the tutorial!";
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Player exited trigger area");
    }

    public void ShowInstruction1()
    {
        TriggerArea.SetActive(false);
        tutorialArea2.SetActive(true);
        // triggerCounter = 1;
        notification.text = "Great! Now try grabbing the object on the table. Aim with your controller and press the grab button. Then place the object on the right";
    }

    public void ShowInstruction2()
    { 
        // tutorialArea2.SetActive(false);
        tutorialArea3.SetActive(true);
        triggerCounter = 2;
        notification.text = "Excellent! You are almost done with the tutorial, just one more step! Open the door and the next area will be revealed.";   
    }

    public void ShowInstruction3()
    {
        TriggerArea2.SetActive(false);
        teleportPlatform1.SetActive(true);
        triggerCounter = 3;
        notification.text = "Awesome! Now try teleporting to that platform.";
    }

    public void CloseTutorial()
    {
        SceneManager.LoadScene("GameScene");
        tutorialCompleted = true;
    }
}
