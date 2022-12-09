using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrefabSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    public Button theButton;
    public GameObject counter;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = theButton.GetComponent<Button>();
        btn.onClick.AddListener(ClickedUpon);
        counter = GameObject.Find("Counter");
    }

    public void ClickedUpon()
    {
        if (counter.GetComponent<Counter>().maxCount == counter.GetComponent<Counter>().doneCounter)
        {
            Debug.Log("Max Food Done");
        }
        else if (GameObject.FindGameObjectWithTag("Food") == null)
        {
            Spawn();
        }
        else
        {
            Debug.Log("Food Slot Full");
        }
    }

    void Spawn()
    {
        GameObject newBud = Instantiate(prefab, new Vector3(0,0,0),Quaternion.identity);
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
