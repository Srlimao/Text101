using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] State startingState;

    [SerializeField] Text titleText;
    [SerializeField] Text storyText;
    [SerializeField] Text optionsText;


    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        LoadStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
        LoadStory();

    }

    private void LoadStory()
    {
        titleText.text = state.GetStateTitle();
        storyText.text = state.GetStateStory();
        optionsText.text = state.GetStateOptions();
    }

    private void ManageState()
    {
        var nextState = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextState[0];
        }else 
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextState[1];
        }
        else
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextState[2];
        }
    }
}
