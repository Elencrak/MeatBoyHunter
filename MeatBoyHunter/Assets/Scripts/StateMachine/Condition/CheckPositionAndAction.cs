using UnityEngine;
using System.Collections;

public class CheckPositionAndAction : Condition {

    public Boss boss;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override bool ExecuteCondition()
    { 
        if(boss.LaunchedAttack >= boss.nbAttackBeforeChange)
        {
            //boss.LaunchedAttack = 0;
            return true;
        }
        return false;
    }
}
