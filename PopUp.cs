using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PopUp : MonoBehaviour
{
    public GameObject PopUpPanel;
    //private PhysicsRaycaster Ray;
    public AudioSource playSound;

    private void Awake()
    {
        PopUpPanel.SetActive(false);
        //Ray = GetComponent<UnityEngine.EventSystems.PhysicsRaycaster>();
    }

    

    public void OnClick()
    {
        PopUpPanel.SetActive(!PopUpPanel.activeSelf);
        playSound.Play();
    }
}
