using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckInfo : MonoBehaviour
{
    [SerializeField] InputField username;
    [SerializeField] InputField passwordTxt;
    string Username;
    string Userpassword;

    public void CheckPassword()
    {
        SceneManager.LoadScene(1);   
    }
    void FillInfo()
    {
        Username = username.text;
        Userpassword = passwordTxt.text;
    }
}
