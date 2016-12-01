using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Charge : Action {

    public Vector3 destinationPos;
    public Vector3 initialPosition;
    public float stunTime;
    public float chargeDuration;

    private bool isStarting = false;
    private bool isInCharge = false;

    public Boss boss;
    // Use this for initialization
    void Start () {
        initialPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override bool ExecuteAction()
    {
        if(isStarting == true && isInCharge == false)
        {
            Debug.Log("endCharge");
            boss.LaunchedAttack = 0;
            boss.inCharge = false;
            isStarting = false;
            return true;
        }

        if (isStarting == false && isInCharge == false)
        {
            Debug.Log("startCharge");
            boss.inCharge = true;
            isStarting = true;
            isInCharge = true;

            Sequence seq = DOTween.Sequence()
                .Append(transform.parent.DOMove(destinationPos, chargeDuration))
                .AppendInterval(stunTime)
                .Append(transform.parent.DOMove(initialPosition, chargeDuration * 2.0f))
                .AppendInterval(1.0f)
                .AppendCallback(() => isInCharge = false);

            seq.Play();
        }
        return false;
    }

}
