using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	// 移動スピード
	public float speed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// みぎ・ひだり
		float x = Input.GetAxisRaw("Horizontal");

		// 上・下
		float y = Input.GetAxisRaw("Vertical");

		// 移動する向きを求める
		// normalizedとは、ベクトルの長さを1にすること。
		// 任意の速度の方向を持ったベクトルをnormalizedして、
		// 長さを1にする。
		// それに欲しい速度などの長さを掛けることで、
		// 欲しい方向の欲しい長さのベクトルを得ることができる。
		Vector2 direction = new Vector2(x,y).normalized;

		// 移動する向きとスピードを代入する
		rigidbody2D.velocity = direction*speed;
	}
}
