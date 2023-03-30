using UnityEngine;

public class ScriptingGameObjects : MonoBehaviour
{

    [Header("Muokkaa näitä:")]
    [SerializeField] [Range(0,10)] int someNumber = 0;
    public string myName = "matti";
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        DoStuffThatWeWant();
        Debug.Log(myName);
        Debug.Log(gameObject.name);

        rend = gameObject.GetComponent<Renderer>();
        SetColor(Color.red);
    }
    void SetColor(Color newColor)
    {
        if (rend != null && rend.material.color != newColor)
        {
            Debug.Log($"new color is {newColor.ToString()}");
            rend.material.color = newColor;
        }
    }
    void Awake()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > 1f)
        {
            SetColor(Color.yellow);
        }
    }
    void FixedUpdate()
    {

    }
    void DoStuffThatWeWant()
    {
        Debug.Log("terve");
        someNumber = 10;
    }
}
