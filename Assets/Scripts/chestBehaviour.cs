using UnityEngine;

public class chestBehaviour : MonoBehaviour
{

    [SerializeField]
    public GameObject key;

    [SerializeField]
    public GameObject chestLid;

    [SerializeField]
    public GameObject dollBody;
    private bool isOpen = false;

    public void OpenChest()
    {
        if (!isOpen)
        {
            chestLid.transform.Rotate(0f, 0f, -90f);
            isOpen = true;
            dollBody.SetActive(true);
        }
    }
}
