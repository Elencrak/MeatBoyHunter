using UnityEngine;
using System.Collections;

public class Lazer : Attack {

    public Transform LazerCollider;
    public float duration = 1;
    public float elapsedDuration = 0;

    public float waitTime = 1;
    public float elapsedWait = 0;

    private Boss boss;
    // Use this for initialization

    void Awake()
    {
        LazerCollider.gameObject.SetActive(false);
        boss = GetComponent<Boss>();
    }

    public override bool Execute()
    {
        if (boss.inCharge == false)
        {
            Debug.Log("Lazer");
            if (elapsedDuration < duration)
            {
                if (LazerCollider.gameObject.activeSelf == false)
                {
                    LazerCollider.gameObject.SetActive(true);
                    return false;
                }
                elapsedDuration += Time.deltaTime;
                return false;
            }
            else
            {
                if (waitTime > elapsedWait)
                {
                    if (LazerCollider.gameObject.activeSelf == true)
                    {
                        LazerCollider.gameObject.SetActive(false);
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
