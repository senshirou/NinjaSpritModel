using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerScript : MonoBehaviour
{
	//プレイヤーのアニメーション
	private Animator anim;

	//プレイヤーのスピード
	float MySpeed;
	float MySpeedRate = 0.02f;
	float MyJumpRate = 700f;

	//2段ジャンプ禁止対策
	bool Jumpbool = true;
	[SerializeField] GameObject BakutikuPoint;


	Rigidbody rb;

	//武器の関数設定
	public delegate void Attack();
	Attack PlayerAttack;
	IronBallAttack _IronBallAttack;
	AttackBakutiku _AttackBakutiku;
	SlashAttack _SlashAttack;

	//プレイヤーオブジェクト名
	string PlayerName = "Player";

	void Start()
	{
		//各種をGetComponentする
		anim = gameObject.GetComponentInChildren<Animator>();
		_IronBallAttack = GetComponent<IronBallAttack>();
		_AttackBakutiku = GetComponent<AttackBakutiku>();
		_SlashAttack = GetComponent<SlashAttack>();
		rb = GetComponent<Rigidbody>();

	}

	void Update()
	{
		
		//歩行時のAnimationの設定
		if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
		{
			anim.SetInteger("AnimationPar", 1);
		}
		else
		{
			anim.SetInteger("AnimationPar", 0);
		}

		//Playerの動作
		//方向転換
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

		//ジャンプ
		if((Input.GetKeyDown(KeyCode.Space) && Jumpbool == true) && gameObject.tag == PlayerName)
        {
			Jumpbool = false;
			rb.AddForce(transform.up * MyJumpRate);
			
        }

		//プレイヤーのみ移動操作
		else if(gameObject.tag == "Player")
        {
			MySpeed = Input.GetAxis("Horizontal") * MySpeedRate;
			transform.position += new Vector3(MySpeed, 0, 0);
		}

		//武器の操作
		if(Input.GetKeyDown(KeyCode.J))
        {
			PlayerAttack();
		}

		//武器爆竹のインスタンス化
        if (Input.GetKeyDown(KeyCode.P))
        {
			PlayerAttack = _AttackBakutiku.Attack;
        }

		//武器鉄球のインスタンス化
		else if(Input.GetKeyDown(KeyCode.O))
        {
			PlayerAttack = _IronBallAttack.Attack;
        }

		else if(Input.GetKeyDown(KeyCode.U))
        {
			PlayerAttack = _SlashAttack.Attack;
        }


	}

	//プレイヤーがオブジェクトに接触した場合の動作
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