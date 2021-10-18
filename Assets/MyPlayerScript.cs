using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerScript : MonoBehaviour
{
	//�v���C���[�̃A�j���[�V����
	private Animator anim;

	//�v���C���[�̃X�s�[�h
	float MySpeed;
	float MySpeedRate = 0.02f;
	float MyJumpRate = 700f;

	//2�i�W�����v�֎~�΍�
	bool Jumpbool = true;
	[SerializeField] GameObject BakutikuPoint;


	Rigidbody rb;

	//����̊֐��ݒ�
	public delegate void Attack();
	Attack PlayerAttack;
	IronBallAttack _IronBallAttack;
	AttackBakutiku _AttackBakutiku;
	SlashAttack _SlashAttack;

	//�v���C���[�I�u�W�F�N�g��
	string PlayerName = "Player";

	void Start()
	{
		//�e���GetComponent����
		anim = gameObject.GetComponentInChildren<Animator>();
		_IronBallAttack = GetComponent<IronBallAttack>();
		_AttackBakutiku = GetComponent<AttackBakutiku>();
		_SlashAttack = GetComponent<SlashAttack>();
		rb = GetComponent<Rigidbody>();

	}

	void Update()
	{
		
		//���s����Animation�̐ݒ�
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
        if (Input.GetKeyDown(KeyCode.A) && gameObject.tag == PlayerName)
        {
			transform.rotation = Quaternion.Euler(0, -90, 0);
        }

        else if (Input.GetKeyDown(KeyCode.D) && gameObject.tag == PlayerName)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

		else if (Input.GetKey(KeyCode.W) && gameObject.tag == PlayerName)
        {
			BakutikuPoint.transform.rotation = new Quaternion(0, 90, 90, 0);
		}

		else
        {
			BakutikuPoint.transform.rotation = new Quaternion(0, 0, 0, 0);
        }

		//�W�����v
		if((Input.GetKeyDown(KeyCode.Space) && Jumpbool == true) && gameObject.tag == PlayerName)
        {
			Jumpbool = false;
			rb.AddForce(transform.up * MyJumpRate);
			
        }

		//�v���C���[�݈̂ړ�����
		else if(gameObject.tag == "Player")
        {
			MySpeed = Input.GetAxis("Horizontal") * MySpeedRate;
			transform.position += new Vector3(MySpeed, 0, 0);
		}

		//����̑���
		if(Input.GetKeyDown(KeyCode.J))
        {
			PlayerAttack();
		}

		//���픚�|�̃C���X�^���X��
        if (Input.GetKeyDown(KeyCode.P))
        {
			PlayerAttack = _AttackBakutiku.Attack;
        }

		//����S���̃C���X�^���X��
		else if(Input.GetKeyDown(KeyCode.O))
        {
			PlayerAttack = _IronBallAttack.Attack;
        }

		else if(Input.GetKeyDown(KeyCode.U))
        {
			PlayerAttack = _SlashAttack.Attack;
        }


	}

	//�v���C���[���I�u�W�F�N�g�ɐڐG�����ꍇ�̓���
    private void OnCollisionEnter(Collision collision)
	{
		Jumpbool = true;
		transform.parent = null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bakutiku")
        {
			
        }

		else if(other.gameObject.tag == "IronBall")
        {
			
        }
    }
}