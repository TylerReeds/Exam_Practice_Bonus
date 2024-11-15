using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIManager : Observer
{
    private ShedScript shed;
    private float _currentNumOfChickens;

    // Update is called once per frame
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(150, 150, 200, 400));

        // Display score
        GUILayout.BeginHorizontal("box");
        GUILayout.Label("Current Number of Chickens: " + _currentNumOfChickens);
        GUILayout.EndHorizontal();

        GUILayout.EndArea();
    }
    public override void Notify(Subject subject)
    {
        if (!shed)
            shed = subject.GetComponent<ShedScript>();
        if (shed)
        {

            _currentNumOfChickens = shed.CurrentnumOfChickens;

        }
    }
}

