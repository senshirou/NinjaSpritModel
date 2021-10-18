using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBallAttack : MonoBehaviour
{
    [SerializeField] Animator Tekkyuu;
	bool Attacks = false;
	float IronBallAnimationTime = 0.45f;


    public void Attack()
    {
		//“S‹…
		Tekkyuu.transform.localRotation = Quaternion.Euler(90, 0, 0);
		Attacks = true;
		Tekkyuu.SetBool("IronballAttack", true);
		Invoke(nameof(TimeCount), IronBallAnimationTime);

	}

    private void Update()
    {
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D ))
		{
			Tekkyuu.transform.localRotation = Quaternion.Euler(90, 0, 0);
		}

		else if (Input.GetKey(KeyCode.S) && Attacks == true)
		{
			Tekkyuu.transform.localRotation = Quaternion.Euler(180, 0, 0);
		}

		else if (Input.GetKey(KeyCode.W) && Attacks == true)
		{
			Tekkyuu.transform.localRotation = Quaternion.Euler(0, 0, 0);
		}

        
    }

    public void TimeCount()
    {
        Tekkyuu.SetBool("IronballAttack", false);
		Attacks = false;
    }

    
}
