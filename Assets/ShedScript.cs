using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShedScript : Subject
{
    public float CurrentnumOfChickens
    {
        get { return numOfChickens; }
    }
    [SerializeField] private int numOfChickens = 0;

    private UIManager uiManager;

    void Awake()
    {
        uiManager = gameObject.AddComponent<UIManager>();
    }

    void OnEnable()
    {
        if (uiManager)
            Attach(uiManager);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Chicken")
        {
            collision.gameObject.SetActive(false);
            numOfChickens += 1;
            NotifyObservers();
        }
    }
}

