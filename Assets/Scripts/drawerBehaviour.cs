using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class drawerBehaviour : MonoBehaviour
{
    [SerializeField]
    public GameObject drawer;

    [SerializeField]
    public GameObject key;

    [SerializeField]
    public GameObject dollLegs;

    private bool isOpen = false;

    public void ToggleDrawer()
    {
        if (!isOpen)
        {
            // isOpen = true;
            drawer.TryGetComponent<XRGrabInteractable>(out XRGrabInteractable grabInteractable);
            key.SetActive(false);
            dollLegs.SetActive(true);
            if (grabInteractable != null)            
            {
                grabInteractable.enabled = true;
            }
        }
    }
}
