using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class State : MonoBehaviour {

    public List<Transition> transitions = new List<Transition>();
    public State nextState;

    // Use this for initialization
    protected void Start()
    {
        Transition[] arrayTransition;
        arrayTransition = GetComponentsInChildren<Transition>();

        foreach (Transition tr in arrayTransition)
        {
            transitions.Add(tr);
        }
    }

    public bool CheckTransition()
    {
        bool returnValue = true;
        foreach (Transition tr in transitions)
        {
            if (tr.Execute() == false)
                returnValue = false;
        }
        return returnValue;
    }

    //public virtual bool updateState() { return false; }
}
