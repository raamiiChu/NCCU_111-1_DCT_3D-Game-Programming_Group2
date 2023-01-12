using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Youth_Books_Manager : MonoBehaviour
{
    // 獎盃
    public GameObject trophy;
    // UI
    public GameObject trophy_UI;
    public GameObject books_UI;
    public RawImage[] images;
    int current_image = 0;
    public float duration = 1f;

    // 紀錄選取的書籍
    public List<GameObject> choose_book = new List<GameObject> {};

    // 紀錄是否位於正確的位置
    public Dictionary<string, bool> spot_correct = new Dictionary<string, bool>();

    // 各書籍正確的位置
    public Dictionary<string, Vector3> book_pos = new Dictionary<string, Vector3>()
    {
        {"Book_1.001", new Vector3(-5.814f, 5.082201f, 12.2f)},
        {"Book_1.002", new Vector3(-5.7208f, 5.082201f, 12.2f)},
        {"Book_1.016", new Vector3(-5.6186f, 5.082201f, 12.2f)},
        {"Book_1.004", new Vector3(-5.5188f, 5.082201f, 12.2f)},
        {"Book_1.005", new Vector3(-5.4179f, 5.082201f, 12.1777f)},
        {"Book_1.006", new Vector3(-5.3295f, 5.082201f, 12.2f)},
        {"Book_1.007", new Vector3(-5.231f, 5.082201f, 12.2f)},
        {"Book_1.008", new Vector3(-5.1275f, 5.082201f, 12.1882f)},
        {"Book_1.013", new Vector3(-5.03f, 5.082201f, 12.149f)},
        {"Book_1.010", new Vector3(-4.937f, 5.082201f, 12.2f)},
        {"Book_1.011", new Vector3(-4.8385f, 5.082201f, 12.1628f)},
        {"Book_1.012", new Vector3(-4.735f, 5.082201f, 12.2f)},
        {"Book_1.009", new Vector3(-4.6341f, 5.082201f, 12.17f)},
        {"Book_1.014", new Vector3(-4.5306f, 5.082201f, 12.2f)},
        {"Book_1.015", new Vector3(-4.4321f, 5.082201f, 12.2131f)},
        {"Book_1.003", new Vector3(-4.3393f, 5.082201f, 12.2f)},
        {"Book_1.017", new Vector3(-4.2363f, 5.082201f, 12.2f)},
        {"Book_1.018", new Vector3(-4.1443f, 5.082201f, 12.2f)},
        {"Book_1.019", new Vector3(-4.056201f, 5.082201f, 12.2f)}
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 選取兩個物件
        if (choose_book.Count == 2) {
            Vector3 pos_0 = choose_book[0].transform.position;
            Vector3 pos_1 = choose_book[1].transform.position;

            // 交換位置
            choose_book[0].transform.position = pos_1;
            choose_book[1].transform.position = pos_0;

            // 重製紀錄器
            choose_book.Clear();
        }

        // 如果位置全部正確，則顯示獎盃
        if (spot_correct.Values.Count(ele => ele == true) == 19) {
            gameObject.SetActive(false);

            if (trophy != null) {
                trophy.transform.DOLocalMove(new Vector3(-4.943f, 5.256f, 11.371f), 1f);
                DOTween.Kill(trophy);
            }
        
            // 更換對話框
            books_UI.SetActive(false);
            // images[current_image].gameObject.SetActive(true);
            // trophy_UI.SetActive(true);

            Video0_Player();              
            
            // 5 秒後切換場景
            Invoke("Switch_Scene", 12f);
        }
    }

    void Switch_Scene() {
        SceneManager.LoadScene(2);
    }

    void Video0_Player()  {
        images[0].gameObject.SetActive(true);
        Invoke("Video1_Player", 3f);
    }

    void Video1_Player()  {
        images[1].gameObject.SetActive(true);
        Invoke("Video2_Player", 3f);
    }

    void Video2_Player()  {
        images[2].gameObject.SetActive(true);
    }
}
