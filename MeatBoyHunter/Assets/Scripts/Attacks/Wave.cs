using UnityEngine;
using System.Collections;

public class Wave : Attack {

    public Transform waveCollider;
    public float duration = 1;
    public float elapsedDuration = 0;

    public float waitTime = 1;
    public float elapsedWait = 0;

    private Boss boss;

    void Awake()
    {
        waveCollider.gameObject.SetActive(false);
        boss = GetComponent<Boss>();
    }

    // Use this for initialization
    void Start()
    {

    }

        // Update is called once per frame
    void Update () {
	
	}

    public override bool Execute()
    {
        if (boss.inCharge == false)
        {
            Debug.Log("Wave");
            if (elapsedDuration < duration)
            {
                if (waveCollider.gameObject.activeSelf == false)
                {
                    waveCollider.gameObject.SetActive(true);
                    return false;
                }
                elapsedDuration += Time.deltaTime;
                return false;
            }
            else
            {
                if (waitTime > elapsedWait)
                {
                    if (waveCollider.gameObject.activeSelf == true)
                    {
                        waveCollider.gameObject.SetActive(false);
                        boss.LaunchedAttack++;
                    }
                    elapsedWait += Time.deltaTime;
                    return false;

                }
                else
                {
                    elapsedWait = 0;
                    elapsedDuration = 0;
                    return true;
                }
            }
        }
        else
        {
            return true;
        }
    }
}
