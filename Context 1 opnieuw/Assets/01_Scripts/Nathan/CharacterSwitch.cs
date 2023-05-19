using _01_Scripts.Bryan.DeveloperSkill;
using _01_Scripts.Bryan.Grid;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    [Header("refrences")] 
    public GameObject SkillCanvas;

    [Header("bools")] 
    public bool DevState;
    public bool ArtState;
    public bool DesState;
    public bool NormState;


    [Header("variable")] public GameObject Norm;
    public GameObject Dev;
    public GameObject Art;
    public GameObject Des;

    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        Dev.SetActive(false);
        Art.SetActive(false);
        Des.SetActive(false);

        SkillCanvas.SetActive(false);
        NormState = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            counter++;

            //dev state
            if (counter == 1)
            {
                NormState = false;
                DevState = true;
                Norm.SetActive(false);
                Dev.SetActive(true);
            }
            //Art State
            else if (counter == 2)
            {
                DevState = false;
                ArtState = true;
                Dev.SetActive(false);
                Art.SetActive(true);
            }
            //Des state
            else if (counter == 3)
            {
                SkillCanvas.SetActive(true);

                ArtState = false;
                DesState = true;
                Art.SetActive(false);
                Des.SetActive(true);
            }
            else if (counter >= 4)
            {
                SkillCanvas.SetActive(false);
                DesState = false;
                DevState = true;
                Des.SetActive(false);
                Dev.SetActive(true);
                counter = 1;
            }
        }
    }
}