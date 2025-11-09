using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judgement : MonoBehaviour
{
    public List<GameObject> List = new List<GameObject>();
    public List<GameObject> List2 = new List<GameObject>();

    // マルのゲームオブジェクトを入れるリスト
    public List<GameObject> circleList = new List<GameObject>();
    public List<GameObject> circleList2 = new List<GameObject>();

    GameObject clickedGameObject; // クリックされたゲームオブジェクトを代入する変数

    public GameObject ClearImage; // ゲームクリア画面

    private PolygonCollider2D Col;
    private PolygonCollider2D Col2;
    private PolygonCollider2D Col3;
    private PolygonCollider2D Col4;
    private PolygonCollider2D Col5;
    private PolygonCollider2D Col6;

    public float count;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d)
            {
                clickedGameObject = hit2d.transform.gameObject;
                Debug.Log(clickedGameObject.name); // ゲームオブジェクトの名前を出力
                // "かんたん"
                if (clickedGameObject.name == "セミ")
                {
                    Col = List[0].GetComponent<PolygonCollider2D>();
                    Col2 = List[1].GetComponent<PolygonCollider2D>();
                    Col.enabled = false;
                    Col2.enabled = false;
                    circleList[0].SetActive(true);
                    circleList[1].SetActive(true);
                    count++;
                }
                if (clickedGameObject.name == "ピンクの花_2" || clickedGameObject.name == "赤い花_2")
                {
                    Col3 = List[2].GetComponent<PolygonCollider2D>();
                    Col4 = List[3].GetComponent<PolygonCollider2D>();
                    Col3.enabled = false;
                    Col4.enabled = false;
                    circleList[2].SetActive(true);
                    circleList[3].SetActive(true);
                    count++;
                }
                if (clickedGameObject.name == "太陽")
                {
                    Col5 = List[4].GetComponent<PolygonCollider2D>();
                    Col6 = List[5].GetComponent<PolygonCollider2D>();
                    Col5.enabled = false;
                    Col6.enabled = false;
                    circleList[4].SetActive(true);
                    circleList[5].SetActive(true);
                    count++;
                }
                // "ふつう"
                if (clickedGameObject.name == "ウニ" || clickedGameObject.name == "ガンガゼ")
                {
                    Col = List2[0].GetComponent<PolygonCollider2D>();
                    Col2 = List2[1].GetComponent<PolygonCollider2D>();
                    Col.enabled = false;
                    Col2.enabled = false;
                    circleList2[0].SetActive(true);
                    circleList2[1].SetActive(true);
                    count++;
                }
                if (clickedGameObject.name == "海藻")
                {
                    Col3 = List2[2].GetComponent<PolygonCollider2D>();
                    Col4 = List2[3].GetComponent<PolygonCollider2D>();
                    Col3.enabled = false;
                    Col4.enabled = false;
                    circleList2[2].SetActive(true);
                    circleList2[3].SetActive(true);
                    count++;
                }
                if (clickedGameObject.name == "ノコギリエイ" || clickedGameObject.name == "ノコギリザメ")
                {
                    Col5 = List2[4].GetComponent<PolygonCollider2D>();
                    Col6 = List2[5].GetComponent<PolygonCollider2D>();
                    Col5.enabled = false;
                    Col6.enabled = false;
                    circleList2[4].SetActive(true);
                    circleList2[5].SetActive(true);
                    count++;
                }
            }
        }

        // 間違いを３つ見つけたら
        if (count == 3)
        {
            // １秒後にゲームクリア
            Invoke("GameClear", 1.0f);
        }
    }

    private void GameClear()
    {
        ClearImage.SetActive(true);
        count = 0;
        for (int i = 0; i < 6; i++)
        {
            circleList[i].SetActive(false);
            circleList2[i].SetActive(false);
        }

        Col.enabled = true;
        Col2.enabled = true;
        Col3.enabled = true;
        Col4.enabled = true;
        Col5.enabled = true;
        Col6.enabled = true;
    }
}
