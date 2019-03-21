using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ufo_moving : MonoBehaviour {
  public Rigidbody rb;
  public GameObject panda;
  public GameObject armRight;
  public GameObject armLeft;
  GameObject dai;
  public static int moveFlag = 8;

  private int NowState;

  enum state {
    idle,
    getDown,
    getUp,
    move2,
  }

  //public static int cre = 0;
  float debugMode = 1;
  //public GameObject Slider;
  int subOpen = 0;
  int open = 0;
  Vector3 Move;
  float timeleft;
  // public Text creText;

  private bool button;  //押されてるか

  //x:-5~6.5
  //y:6
  //z:6~0

  //x2:-5~-2
  //z:6~-6

  //public Vector3 center = new Vector3(0, 1000, 0);

  // Use this for initialization
  void Start() {
    NowState = 0;
    button = false;
    /*
    float x;
    float z;
    Vector3 pos;
    Quaternion rotate;
    int i;
    for (i = 0; i < 6; i++) {
      x = Random.Range(-5f, 6.5f);
      z = Random.Range(6f, 0);
      pos = new Vector3(x, 6, z);
      rotate = new Quaternion(Random.Range(0, 360f), Random.Range(0, 360f), Random.Range(0, 360f), 0);
      Instantiate(panda, pos, rotate);
    }
    for (i = 0; i < 2; i++) {
      x = Random.Range(-5f, -2f);
      z = Random.Range(-6f, 0);
      pos = new Vector3(x, 6, z);
      rotate = new Quaternion(Random.Range(0, 360f), Random.Range(0, 360f), Random.Range(0, 360f), 0);
      Instantiate(panda, pos, rotate);
    }*/

    //creText.text = "残りプレイ:0";


  }

  // Update is called once per frame
  void Update() {

    if (moveFlag == 8) {
      moveFlag = 1;
    }

    //debugMode = Slider.GetComponent<Slider>().value;

    ////だいたい1秒ごとに処理を行う
    //timeleft -= Time.deltaTime;
    //if (timeleft <= 0.0) {
    //    timeleft = 2.0f;
    //    Debug.Log("moveflag"+moveFlag);
    //    Debug.Log("cre" + cre);
    //    //ここに処理
    //}

    /*
    if (moveFlag == 5 || (debugMode == 1f && (Input.GetKey("right") || Input.GetKey("d")))) {
      Move = new Vector3(3f, 0, 0);
      rb.velocity = Move;
    }
    else if ((debugMode == 1 && (Input.GetKey("left") || Input.GetKey("a"))) || (Input.GetKey("space") && moveFlag == 2)) {
      Move = new Vector3(-3f, 0, 0);
      rb.velocity = Move;
    }
    else if ((moveFlag == 1 && Input.GetKey("space")) || Input.GetKey("w")) {
      rb.velocity = getVec("L");
    }
    else if (moveFlag == 6 || Input.GetKey("s")) {    //左右
      if (subOpen == 0) {
        subOpen++;
        Invoke("sub", 3f);
      }
      rb.velocity = getVec("R");
    }
    else if ((debugMode == 1f && Input.GetKey("down")) || moveFlag == 3) {
      Move = new Vector3(0, -3f, 0);
      rb.velocity = Move;
    }
    else if ((debugMode == 1f && Input.GetKey("up")) || (moveFlag == 4 && this.transform.position.y < 8f) && open == 0) {
      Move = new Vector3(0, 3f, 0);
      rb.velocity = Move;
      if (debugMode == 0 && this.transform.position.y >= 7.5f) moveFlag++;//5
    }
    else {
      Move = new Vector3(0, 0, 0);
      rb.velocity = Move;
    }*/

    //最初
    if ((button || Input.GetKey("space")) && NowState == (int)state.idle) {
      rb.velocity = getVec("L");
    }

    if (NowState == (int)state.getUp) {
      //rb.velocity = getVec("UP");
    }

    //閉じる
    if (debugMode == 1 && Input.GetKey("q") || open == -1) {
      armRight.transform.Rotate(new Vector3(0, 0, -1f));
      armLeft.transform.Rotate(new Vector3(0, 0, 1f));
    }
    //開く
    else if (debugMode == 1 && Input.GetKey("e") || open == 1) {
      armRight.transform.Rotate(new Vector3(0, 0, 1f));
      armLeft.transform.Rotate(new Vector3(0, 0, -1f));
    }

    //新規書き直し
    if (NowState == (int)state.idle && Input.GetKeyUp("space")) {
      buttonUp();
    }

  }

  void timer() {
    open = -1;
    Invoke("openTimer", 0.7f);
    NowState++;//2
  }
  void openTimer() {
    open = 0;
    if (NowState == (int)state.getUp) { //取った後
      rb.velocity = getVec("UP");
      Invoke("back", 2.5f);
    }
  }

  //取った後左移動
  void back() {
    rb.velocity = getVec("L");
    NowState++; //3
    Invoke("end", 3f);
  }
  void end() {  //終了
    open = 1;
    Invoke("openTimer", 0.7f);
    Invoke("timer", 3f);
  }


  private Vector3 getVec(string str) {
    if (str == "L") return new Vector3(0, 0, -5f);
    else if (str == "R") return new Vector3(0, 0, 5f);
    else if (str == "UP") return new Vector3(0, 5f, 0);
    else if (str == "DOWN") return new Vector3(0, -5f, 0);

    return new Vector3(0, 0, 0);
  }

  public void buttonDown() {
    button = true;
  }
  public void buttonUp() {
    if (NowState == (int)state.idle) {
      Debug.Log("降りる" + NowState);
      NowState++;  //1
      open = 1;
      rb.velocity = getVec("DOWN");
      Invoke("openTimer", 0.7f);
      Invoke("timer", 2.5f);
    }
  }
}