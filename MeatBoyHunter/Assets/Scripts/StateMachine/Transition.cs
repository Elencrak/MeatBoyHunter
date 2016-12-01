using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Transition : MonoBehaviour {

    public List<Condition> conditions;
    public List<Action> actions;

    // Use this for initialization
    protected void Start()
    {
        Condition[] arrayConditions;
        arrayConditions = GetComponents<Condition>();

        foreach (Condition c in arrayConditions)
        {
            conditions.Add(c);
        }

        Action[] arrayActions;
        arrayActions = GetComponents<Action>();

        foreach (Action c in arrayActions)
        {
            actions.Add(c);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool Execute()
    {
        bool condition = true;
        bool action = true;
        foreach (Condition c in conditions)
        {
            if (c.ExecuteCondition() == false)
            {
                condition = false;
            }
        }

        if (condition == false)
            return false;

        foreach (Action a in actions)
        {
            if (a.ExecuteAction() == false)
            {
                   action = false;
            }
        }

        Debug.Log(action);
        return action == true && condition == true;
    }
}
