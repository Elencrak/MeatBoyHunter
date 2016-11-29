using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StateManager : MonoBehaviour {

    public List<Attack> attacks;
    public List<State> states;
    public State startState;

    // Use this for initialization
    void Start()
    {
        transform.GetComponents<Attack>();


    }

    // Update is called once per frame
    void Update()
    {
        
        if (startState.CheckTransition())
        {
            startState = startState.nextState;
        }                       
    }
}
