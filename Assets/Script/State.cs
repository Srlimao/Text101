using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField] string storyTitle;
    [TextArea(14, 10)] [SerializeField] string storyText;
    [TextArea(6, 4)] [SerializeField] string storyOptions;
    [SerializeField] State[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public string GetStateTitle()
    {
        return storyTitle;
    }

    public string GetStateOptions()
    {
        return storyOptions;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
