using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class GameController : MonoBehaviour
{
    public GameObject controller;
    public GameObject nextButtonPrefab;
    public Button nextButton;
    private GameObject whenDone;
    [SerializeField]
    private GameObject canvas;

    public void Activate() 
    {
        whenDone = GameObject.Find("Counter");
    }

    // Start is called before the first frame update
    void Start()
    {
        Activate();
        controller = GameObject.FindGameObjectWithTag("GameController");
     
    }


    // Update is called once per frame
    void Update()
    {
        if(whenDone.GetComponent<Counter>().maxCount == whenDone.GetComponent<Counter>().doneCounter &&
            GameObject.FindGameObjectWithTag("NextStepButton") == null)
        {
            SpawnNextSceneBut();
        }
    }
    void SpawnNextSceneBut()
    {
        GameObject goNext = Instantiate(nextButtonPrefab, new Vector3(960, 540, 0), Quaternion.identity);
        goNext.transform.SetParent(canvas.transform);
        nextButton = goNext.GetComponent<Button>();
        nextButton.onClick.AddListener(ClickedUpon);
        //Instantiate Button to load next scene (Potato Boiler)
    }

    void ClickedUpon()
    {
        SceneManager.LoadScene("PotatoBoiler");
    }
}
