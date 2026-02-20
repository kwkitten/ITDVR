using UnityEngine;

public class cabinetBehaviour : MonoBehaviour
{
    [SerializeField]
    public GameObject cabinet;

    [SerializeField]
    public GameObject key;

    [SerializeField]
    public GameObject dollHead;

    public void OpenCabinet()
    {
        cabinet.transform.Rotate(0f, 90f, 0f);
        key.SetActive(false);
        dollHead.SetActive(true);
    }
}
