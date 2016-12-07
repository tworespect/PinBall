using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	//ボールが見える可能性のあるz軸の最大値
	private float visiblePosZ = -6.5f;

	//ゲームオーバを表示するテキスト
	private GameObject gameoverText;

	//点数を表示するテキスト
	private GameObject pointText;

	//初期値は0
	private int point = 0;


	// Use this for initialization
	void Start () {
		//シーン中のGameOverTextオブジェクトを取得
		this.gameoverText = GameObject.Find("GameOverText");

		//シーン中のPonitTextオブジェクトを取得
		this.pointText = GameObject.Find("PointText");

		//初期は0
		this.pointText.GetComponent<Text>().text = ((int)point).ToString();


	}
		

	// Update is called once per frame
	void Update () {
		//ボールが画面外に出た場合
		if (this.transform.position.z < this.visiblePosZ) {
			//GameoverTextにゲームオーバßを表示
			this.gameoverText.GetComponent<Text> ().text = "GameOver"; 
		}

	}
			
	void OnCollisionEnter(Collision other){
			
		if (other.gameObject.tag == "SmallStarTag") {

			this.point -= 100;

			this.pointText.GetComponent<Text>().text = ((int)point).ToString();
		}

		if (other.gameObject.tag == "LargeStarTag") {

			this.point -= 10;

			this.pointText.GetComponent<Text>().text = ((int)point).ToString();
		}

		if (other.gameObject.tag == "SmallCloudTag") {

			this.point += 200;

			this.pointText.GetComponent<Text>().text = ((int)point).ToString();
		}

		if (other.gameObject.tag == "LargeCloudTag") {

			this.point += 34;

			this.pointText.GetComponent<Text>().text = ((int)point).ToString();
		}


	}


}