using UnityEngine;
using System.Collections;

public class DeadAction : Action {

    public Boss boss;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public override bool ExecuteAction()
    {                
        Debug.Log("dead");
        Destroy(boss.gameObject);
        return true;
    }
}
