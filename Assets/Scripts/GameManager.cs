using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour, IPointerClickHandler
{
    public GameObject TitleImage; // タイトル画面
    public GameObject DifficultyLevel_Image; // 難易度選択画面
    public GameObject Easy;
    public GameObject Normal;

    private GameObject ju;

    void Start()
    {
        ju = GameObject.Find("GameObject");
    }

    // クリックされたときに呼び出されるメソッド
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("aaa");
    }

    // タイトル画面のボタン処理
    public void OnClick_title()
    {
        TitleImage.SetActive(false);
        DifficultyLevel_Image.SetActive(true);
    }

    // ゲームクリア画面のボタン処理
    public void OnClick_clear()
    {
        ju.GetComponent<Judgement>().ClearImage.SetActive(false);
        TitleImage.SetActive(true);
    }

    // "かんたん"を選択したとき
    public void OnClick_easy()
    {
        DifficultyLevel_Image.SetActive(false);
        Easy.SetActive(true);
        Normal.SetActive(false);
    }

    // "ふつう"を選択したとき
    public void OnClick_normal()
    {
        DifficultyLevel_Image.SetActive(false);
        Easy.SetActive(false);
        Normal.SetActive(true);
    }
}
