using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SlashAttack : MonoBehaviour
{
    [SerializeField] GameObject SlashObject;


    

    public void Attack()
    {
        StartCoroutine(nameof(AttackColutine));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AttackColutine()
    {
        SlashObject.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        SlashObject.SetActive(false);
    }
}
