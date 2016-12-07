using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour {


	//回転速度を指定する
	private float rotSpeed = 1.0f;


	//Start関数内に立ち上げ時の状態を設定
	void Start() {

		//回転する開始角度を指定する　＊複数回転させたい対象物がある
		this.transform.Rotate(0 , Random.Range(0,360) , 0);

	}

	//回転対象物の状態を設定

	void Update(){

		this.transform.Rotate (0, this.rotSpeed, 0);
	



	}





}
