using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    [SerializeField] GameObject Fade_start;
    GameObject MainCanvas;
    // Start is called before the first frame update
    void Start()
    {
        MainCanvas = GameObject.Find("MainMenu_Canvas");
        if(MainCanvas == null)
        {
            MainCanvas = GameObject.Find("Shop_Canvas");

        }
        GameObject obj = (GameObject)Instantiate(Fade_start);
        obj.transform.SetParent(MainCanvas.transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
