using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StateManager : MonoBehaviour {

    public List<Attack> attacks;
    public List<State> states;
    public State startState;
    private Attack currentAttack;

    private float durationAttack;
    private float elapsedDurationAttack;


    // Use this for initialization
    void Start()
    {
        Attack[] attacksArray;
        attacksArray = transform.GetComponents<Attack>();
        foreach (Attack a in attacksArray)
        {
            attacks.Add(a);
        }
        

        int attackSelection = Random.Range(0, attacks.Count);
        currentAttack = attacks[attackSelection];
    }

    // Update is called once per frame
    void Update()
    {
        int attackSelection = Random.Range(0, attacks.Count);
        //Debug.Log(attackSelection);
        //Debug.Log(states.Count);
        if (startState.CheckTransition())
        {
            startState = startState.nextState;
        }
                
        if(currentAttack.Execute())
        {
            
            currentAttack = attacks[attackSelection];
        }                     
    }
}
