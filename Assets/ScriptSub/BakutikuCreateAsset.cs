using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakutikuCreateAsset : AttackScript
{
    [SerializeField] GameObject BakutikuGroup;
    [SerializeField] GameObject BakutikuPoint;

    public override void Attack()
    {
        Instantiate(BakutikuGroup,BakutikuPoint.transform.position,BakutikuPoint.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
