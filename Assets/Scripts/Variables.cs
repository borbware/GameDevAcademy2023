using UnityEngine;

public class Variables : MonoBehaviour
{

    int testNumber = 0;
    bool isItWednesday = false;

    double exampleDouble = 0.123123;
    const double exampleFloat = 0.123;
    string sampleText = "terveppä terve";

    /* Start is called before the first frame update
    hommat hoituu */

    double a = 4;
    double b = 2.2345;

    void Start()
    {
        // method 1
        Debug.Log("a / b = " + (a / b));
        Debug.Log("a + b = " + (a + b));
        Debug.Log("a - b = " + (a - b));
        Debug.Log("a * b = " + (a * b));
        // method 2 (better :D)
        Debug.Log($"a / b = {a / b}");
        Debug.Log($"a + b = {a + b}");
        Debug.Log($"a - b = {a - b}");
        Debug.Log($"a * b = {a * b}");
        // Debug.LogError("SOS");
    }
    

    // Update is called once per frame
    void Update()
    {
    }
}
