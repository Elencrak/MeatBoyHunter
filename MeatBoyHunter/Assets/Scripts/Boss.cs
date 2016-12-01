using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

    public int nbAttackBeforeChange;
    private int launchedAttack;
    public int LaunchedAttack
    {
        get { return launchedAttack; }
        set { launchedAttack = value; }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
