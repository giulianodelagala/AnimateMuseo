using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public class Init : MonoBehaviour
{

    //Escenarios
    //static public Image escenario_select;
    public GameObject SmallEscenario;
    public Transform ContentEscenario;

    //public GameObject PreviewEscenario;
    //public Transform PanelEscenario;
    public Sprite[] escenarios;



    private void Awake()
    {
        //panelEscenario =  GameObject.FindGameObjectWithTag("PanelEscenario");

        //escenario_select = gameObject.AddComponent<Image>();
      
    }


    void Start()
    {
        PopulateEscenario();
        //GameObject playerCard = Instantiate(PreviewEscenario, PanelEscenario);
        //panelEscenario.SetActive(true);

    }

 

    void PopulateEscenario()
    {
        escenarios = Resources.LoadAll<Sprite>("sprites/PotadaMuseos/");
        for (int i = 0; i < escenarios.Length; i++)
        {
            GameObject clone = (GameObject)Instantiate(SmallEscenario, ContentEscenario);
            clone.GetComponentInChildren<Image>().sprite = escenarios[i];
        }
    }


    private void OnDisable()
    {
        
    }
}
