using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    private float timeBtwSpawns;
    [SerializeField] float startTimeBtwSpawns;
    [SerializeField] GameObject[] Number, Spawner, NumberStatic;
    [SerializeField] Text voitto, rolls;
    [SerializeField] Button pelaa,linkki;
    [SerializeField] fireBaseJson fbj;
    private GameObject [] delete;
    private int countSpawns, VN, roll = 3;
    private bool start = false, lukuja = false, lukuja1 = false, lukuja2 = false;


    

    private void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
        linkki.gameObject.SetActive(false);
    }

    public void StartButton()
    {
        start = true;
        Voitto();
        lukuja = true;
        lukuja1 = true;
        lukuja2 = true;
        pelaa.interactable = false;
        roll -= 1;
        countSpawns = 0;
        voitto.gameObject.SetActive(false);
        delete = GameObject.FindGameObjectsWithTag("NumberStatic");
        foreach (GameObject item in delete)
        {
            Destroy(item);
        }
        switch (roll)
        {
            case 2:
                rolls.text = "Pyöräytyksiä: 2";
                break;
            case 1:
                rolls.text = "Pyöräytyksiä: 1";
                break;
            case 0:
                rolls.text = "Pyöräytyksiä: 0";
                break;
        }
    }

    private void Voitto()
    {
        int rand = Random.Range(0, 100);
        if(roll == 1)
        {
            if (rand <= 40)
            {
                VN = 0;
            }
            else if (rand >= 41 && rand <= 61)
            {
                VN = 1;
            }
            else if (rand >= 62 && rand <= 72)
            {
                VN = 2;
            }
            else if (rand >= 73 && rand <= 78)
            {
                VN = 3;
            }
            else if (rand >= 79 && rand <= 80)
            {
                VN = 4;
            }
            else
            {
                VN = 5;
            }
        }
        else
        {
            VN = 5;
        }
    }

    private void Update()
    {
        if (timeBtwSpawns <= 0 && start == true)
        {
            int rand = Random.Range(0, Number.Length);
            int rand1 = Random.Range(0, Number.Length);
            int rand2 = Random.Range(0, Number.Length);
            if (countSpawns < 30)
            {
                Instantiate(Number[rand], new Vector3(-5.5f, 4f, 0f), Quaternion.identity);
                Instantiate(Number[rand1], new Vector3(-0.4f, 4f, 0f), Quaternion.identity);
                Instantiate(Number[rand2], new Vector3(5f, 4f, 0f), Quaternion.identity);
                timeBtwSpawns = startTimeBtwSpawns;
                countSpawns++;
            }
            else if (countSpawns >= 30 && countSpawns < 35)
            {
                Spawner[0].SetActive(false);
                if(VN == 5 && lukuja == true)
                {
                    int r = Random.Range(0, NumberStatic.Length);
                    Instantiate(NumberStatic[r], new Vector3(-5.5f, 0.8f, 0f), Quaternion.identity);
                    lukuja = false;
                }
                else if (lukuja == true)
                {
                    Instantiate(NumberStatic[VN], new Vector3(-5.5f, 0.8f, 0f), Quaternion.identity);
                    lukuja = false;
                }
                Instantiate(Number[rand], new Vector3(-0.4f, 4f, 0f), Quaternion.identity);
                Instantiate(Number[rand1], new Vector3(5f, 4f, 0f), Quaternion.identity);
                timeBtwSpawns = startTimeBtwSpawns;
                countSpawns++;
            }
            else if (countSpawns >= 35 && countSpawns < 40)
            {
                Spawner[1].SetActive(false);
                if (VN == 5 && lukuja1 == true)
                {
                    int r = Random.Range(3, 4);
                    Instantiate(NumberStatic[r], new Vector3(-0.4f, 0.8f, 0f), Quaternion.identity);
                    lukuja1 = false;
                }
                else if(lukuja1 == true)
                {
                    Instantiate(NumberStatic[VN], new Vector3(-0.4f, 0.8f, 0f), Quaternion.identity);
                    lukuja1 = false;
                }
                Instantiate(Number[rand], new Vector3(5f, 4f, 0f), Quaternion.identity);
                timeBtwSpawns = startTimeBtwSpawns;
                countSpawns++;
            }
            else
            {
                if (VN == 5 && lukuja2 == true)
                {
                    int r = Random.Range(0, 2);
                    Instantiate(NumberStatic[r], new Vector3(5, 0.8f, 0f), Quaternion.identity);                  
                    lukuja2 = false;
                }
                else if (lukuja2 == true)
                {
                    Instantiate(NumberStatic[VN], new Vector3(5f, 0.8f, 0f), Quaternion.identity);
                    lukuja2 = false;
                }
                Spawner[2].SetActive(false);
                start = false;
                if(roll > 0)
                {
                    pelaa.interactable = true;
                }
                voitto.gameObject.SetActive(true);
                switch (VN)
                {
                    case 0:
                        voitto.text = "Onneksi olkoon! Voitit 2% alennuksen!\nLunasta voittosi painamalla tätä tekstiä!";
                        linkki.gameObject.SetActive(true);
                        fbj.getAlennus(2);
                        break;
                    case 1:
                        voitto.text = "Onneksi olkoon! Voitit 5% alennuksen!\nLunasta voittosi painamalla tätä tekstiä!";
                        linkki.gameObject.SetActive(true);
                        fbj.getAlennus(5);
                        break;
                    case 2:
                        voitto.text = "Onneksi olkoon! Voitit 8% alennuksen!\nLunasta voittosi painamalla tätä tekstiä!";
                        linkki.gameObject.SetActive(true);
                        fbj.getAlennus(8);
                        break;
                    case 3:
                        voitto.text = "Onneksi olkoon! Voitit 10% alennuksen!\nLunasta voittosi painamalla tätä tekstiä!";
                        linkki.gameObject.SetActive(true);
                        fbj.getAlennus(10);
                        break;
                    case 4:
                        voitto.text = "Onneksi olkoon! Voitit 15% alennuksen!\nLunasta voittosi painamalla tätä tekstiä!";
                        linkki.gameObject.SetActive(true);
                        fbj.getAlennus(15);
                        break;
                    case 5:
                        if(roll > 0) {
                            voitto.text = "Ei voittoa. Pelaa uudestaan!";
                        }
                        else
                        {
                            voitto.text = "Ei voittoa.\nPalaa takaisin etusivulle painamalla tätä tekstiä!";
                            linkki.gameObject.SetActive(true);
                        }
                        break;       
                }
            }
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }

}
