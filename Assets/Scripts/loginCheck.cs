using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class loginCheck : MonoBehaviour
{
    [SerializeField] 
    public TMP_InputField username;

    [SerializeField] 
    public TMP_InputField password;

    [SerializeField]
    public TMP_Text notification;


    public void checkLogin()
    {
        // Simple login check
        if (username.text == "steve" && password.text == "password123")
        {
            notification.text = "Login Successful!";
            SceneManager.LoadScene("BasicScene 1");
        }
        else
        {
            notification.text = "Invalid username or password.";
        }
    }

    void Start()
    {
        notification.text = ""; // Clear notification on start
    }
}
