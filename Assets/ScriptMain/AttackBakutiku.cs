using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBakutiku : MonoBehaviour
{
	[SerializeField] GameObject BakutikuGroup;
	[SerializeField] GameObject BakutikuPoint;
	//Animation
	Animator HigashiAnim;

    private void Start()
    {
        HigashiAnim = GetComponent<Animator>();
    }

    public void Attack()
    {
        HigashiAnim.SetBool("AttackBool", true);
        Invoke(nameof(TrueCancell), 0.5f);
        Instantiate(BakutikuGroup, BakutikuPoint.transform.position, BakutikuPoint.transform.rotation);
        HigashiAnim.SetBool("AttackBool", false);
    }

    public void TrueCancell()
    {
        HigashiAnim.SetBool("AttackBool", false);
    }
}
