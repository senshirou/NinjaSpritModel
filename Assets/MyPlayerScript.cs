using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerScript : MonoBehaviour
{
	private Animator anim;
	private CharacterController controller;

	[SerializeField] GameObject Camera;

	//public float speed = 600.0f;
	//public float turnSpeed = 400.0f;
	//private Vector3 moveDirection = Vector3.zero;
	//public float gravity = 20.0f;

	float MySpeed;
	float MySpeedRate = 0.02f;
	float MyJumpRate = 700f;
	float MyUpDown;

	bool Jumpbool = true;

	[SerializeField ]GameObject ClearText;

	[SerializeField] GameObject BakutikuGroup;
	[SerializeField] GameObject BakutikuPoint;
	

	Rigidbody rb;

	bool IronballAttack = true;


	//Animation
	Animator HigashiAnim;

	[SerializeField] Animator Tekkyuu;



	//�|���t�H�[�t�B�Y�����K
	AttackBakutiku _AttackBakutiku;
	

	void Start()
	{
		controller = GetComponent<CharacterController>();
		anim = gameObject.GetComponentInChildren<Animator>();
		HigashiAnim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody>();
		_AttackBakutiku = GetComponent<AttackBakutiku>();

	}

	void Update()
	{
		//Animation�̐ݒ�
		if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
		{
			anim.SetInteger("AnimationPar", 1);
		}
		else
		{
			anim.SetInteger("AnimationPar", 0);
		}

		//Player�̓���
		//�����]��
        if (Input.GetKeyDown(KeyCode.A) && gameObject.tag == "Player")
        {
			transform.rotation = Quaternion.Euler(0, -90, 0);
        }

        else if (Input.GetKeyDown(KeyCode.D) && gameObject.tag == "Player")
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

		//�W�����v
		else if((Input.GetKeyDown(KeyCode.Space) && Jumpbool == true) && gameObject.tag == "Player")
        {
			rb.AddForce(transform.up * MyJumpRate);
			Jumpbool = false;
        }

		//�v���C���[�݈̂ړ�����
		else if(gameObject.tag == "Player")
        {
			MySpeed = Input.GetAxis("Horizontal") * MySpeedRate;
			MyUpDown = Input.GetAxis("Vertical") * MySpeedRate;
			transform.position += new Vector3(MySpeed, 0, 0);
		}

		//����̑���
		//���|
		if(Input.GetKeyDown(KeyCode.J))
        {
			_AttackBakutiku.Attack();
        }

		//�S��
        if (Input.GetKeyDown(KeyCode.K))
        {
			Tekkyuu.SetBool("IronballAttack", true);
            Invoke(nameof(TimeCount), 0.1f);
        }

		if(Input.GetKey(KeyCode.S))
        {
			Tekkyuu.transform.localRotation= Quaternion.Euler(180, 0, 0);
        }

		else if(Input.GetKey(KeyCode.W))
        {
			Tekkyuu.transform.localRotation = Quaternion.Euler(0, 0, 0);
		}

		else
        {
			Tekkyuu.transform.localRotation = Quaternion.Euler(90, 0, 0);
		}

	}

    private void OnCollisionEnter(Collision collision)
    {
        Jumpbool = true;
        //Debug.Log(Jumpbool);
        if (collision.gameObject.tag == "MoveCloud")
        {
            Debug.Log("MOVECLOUD");
            transform.parent = collision.gameObject.transform;
        }
    }

	public void TrueCancell()
    {
		HigashiAnim.SetBool("AttackBool", false);
	}

	public void TimeCount()
    {
		Tekkyuu.SetBool("IronballAttack", false);
	}


    private void OnCollisionExit(Collision collision)
    {
		transform.parent = null;
    }

    private void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Ladder")
		{
			rb.useGravity = false;
			Debug.Log("HIT");
			transform.position += new Vector3(0, MyUpDown, 0);
		}
	}

    private void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag == "Clear")
		{
			ClearText.SetActive(true);
		}
	}

    private void OnTriggerExit(Collider other)
    {
		Debug.Log("kaijyo");
        if(other.gameObject.tag == "Ladder")
        {
			rb.useGravity = true;
        }	
    }
}