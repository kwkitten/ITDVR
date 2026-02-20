using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class gameLogic : MonoBehaviour
{
    [SerializeField]
    public TMP_Text Notification;

    [SerializeField]
    private bool BodyPart = false;
    [SerializeField]
    private bool LegsPart = false;
    [SerializeField]
    private bool HeadPart = false;

    [SerializeField]
    public GameObject finishedDoll;

    [SerializeField]
    public GameObject builtDoll;

    [SerializeField]
    public GameObject dollHead;

    [SerializeField]
    public GameObject dollLegs;

    [SerializeField]
    public GameObject dollBody;

    private tutorial tutorialScript; // Reference to the tutorial script to check if the tutorial is completed
    
        void Start()
        {
            if (tutorial.tutorialCompleted == true)
            {
                // Player has completed the tutorial, proceed with game logic
                Notification.text = "Welcome to the game! You have to collect the doll parts and place them on the pedistal to win!";
                dollBody.TryGetComponent<XRGrabInteractable>(out XRGrabInteractable grabInteractable);
                if (grabInteractable != null)
                {
                    grabInteractable.enabled = true; // Enable interaction with the doll body since tutorial is completed
                }
                dollLegs.TryGetComponent<XRGrabInteractable>(out XRGrabInteractable grabInteractableLegs);
                if (grabInteractableLegs != null)                {
                    grabInteractableLegs.enabled = true; // Enable interaction with the doll legs since tutorial is completed
                }
                dollHead.TryGetComponent<XRGrabInteractable>(out XRGrabInteractable grabInteractableHead);
                if (grabInteractableHead != null)
                {
                    grabInteractableHead.enabled = true; // Enable interaction with the doll head since tutorial is completed
                }
            }
            else
            {
                // Player has not completed the tutorial, maybe show a message or restrict access
                Notification.text = "Please complete the tutorial before playing the game.";
                dollBody.TryGetComponent<XRGrabInteractable>(out XRGrabInteractable grabInteractable);
                if (grabInteractable != null)
                {
                    grabInteractable.enabled = false; // Disable interaction with the doll body until the tutorial is completed
                }
                dollLegs.TryGetComponent<XRGrabInteractable>(out XRGrabInteractable grabInteractableLegs);
                if (grabInteractableLegs != null)                {
                    grabInteractableLegs.enabled = false; // Disable interaction with the doll legs until the tutorial is completed
                }
                dollHead.TryGetComponent<XRGrabInteractable>(out XRGrabInteractable grabInteractableHead);
                if (grabInteractableHead != null)
                {
                    grabInteractableHead.enabled = false; // Disable interaction with the doll head until the tutorial is completed
                }
            }       
        }   

        public void collectedBody()
        {
            Notification.text = "You collected the body!";
            BodyPart = true;
        }

        public void collectedLegs()
        {
            Notification.text = "You collected the legs!";
            LegsPart = true;
        }

        public void collectedHead()
        {
            Notification.text = "You collected the head!";
            HeadPart = true;
        }

        public void checkWinCondition()
        {
            if (BodyPart && LegsPart && HeadPart)
            {
                Notification.text = "Congratulations! You have collected all parts, now place the doll on the pedistal and win!";
                builtDoll.SetActive(false);
                dollHead.SetActive(false);
                dollLegs.SetActive(false);
                dollBody.SetActive(false);
                finishedDoll.SetActive(true);
            }
        }

        public void finishGame()
        {
            Notification.text = "";
        }
}
