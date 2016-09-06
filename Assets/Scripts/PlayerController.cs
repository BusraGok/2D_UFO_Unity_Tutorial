using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb2d;
	public float speed;


	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>(); 	//hangi object e bağlıysan onun componentini göster, nesnesini oluşturmak gibi
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");	//kullanıcı A'ya basıyorsa -1, D'ye basıyorsa +1, hiçbiriyse 0
		float moveVertical = Input.GetAxis ("Vertical");		//kullanıcı W'ye basıyorsa +1, S'ye basıyorsa -1, hiçbiriyse 0

		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		rb2d.AddForce (movement*speed);      //AddForce Rigidbody nin fonksiyonudur ve rigidbody objelerinden çağrılabilir, kuvvet ekleme metodudur.
	}									    //Parametresi vektördür.


	void OnTriggerEnter2D(Collider2D other) {
		GameObject			//setActive	//tag
	}


}
