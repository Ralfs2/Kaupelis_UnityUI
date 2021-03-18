using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour
{
  
    public GameObject fcepure1;
    public GameObject fcepure2;
    public GameObject fapgerbs1;
    public GameObject fapgerbs2;
    public GameObject fkurpes1;
    public GameObject fkurpes2;
    public GameObject fbrilles;

    public GameObject mbikses;
    public GameObject mkurpes1;
    public GameObject mkurpes2;
    public GameObject mapgerbs1;
    public GameObject mapgerbs2;
    public GameObject mcepure1;
    public GameObject mcepure2;

    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slaideris;
 

    public void faksesuaruAttelosana(bool vertiba)
    {
        fcepure1.SetActive(vertiba);
        fcepure2.SetActive(vertiba);
        fbrilles.SetActive(vertiba);
        mcepure1.SetActive(vertiba);
        mcepure2.SetActive(vertiba);
    
    }

    public void fapgerbsAttelosana(bool vertiba)
    {
        fapgerbs1.SetActive(vertiba);
        fapgerbs2.SetActive(vertiba);
        mapgerbs1.SetActive(vertiba);
        mapgerbs2.SetActive(vertiba);
        mbikses.SetActive(vertiba);
    }

    public void fkurpesAttelosana(bool vertiba)
    {
        fkurpes1.SetActive(vertiba);
        fkurpes2.SetActive(vertiba);
        mkurpes1.SetActive(vertiba);
        mkurpes2.SetActive(vertiba);
    }

 

    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];

        }
        else if (skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];

        }
       
    }

    public void mainitLielumu()
    {
        float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector3(1F * pasreizejaVertiba, 1F * pasreizejaVertiba, 1);
    }

   
 

}

