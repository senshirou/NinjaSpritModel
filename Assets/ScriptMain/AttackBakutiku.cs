using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBakutiku : AttackScript
{
	[SerializeField] GameObject BakutikuGroup;
	[SerializeField] GameObject BakutikuPoint;
	//Animation
	Animator HigashiAnim;

    private void Start()
    {
        HigashiAnim = GetComponent<Animator>();
    }

    public override void Attack()
    {
        HigashiAnim.SetBool("AttackBool", true);
        //Invoke(nameof(TrueCancell), 0.5f);
        Instantiate(BakutikuGroup, BakutikuPoint.transform.position, BakutikuPoint.transform.rotation);
    }
}
