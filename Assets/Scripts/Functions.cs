using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update

    int c = 0;
    string name = "";
    void SetName(string newName)
    {
        name = newName;
    }

    void Start()
    {
        Debug.Log("testi start");
        int a = 0;

        if(a < 10)
        {
		}

		PrintName("matti");
		PrintName("teppo");

        Debug.Log(GenerateBandName("matti"));
        Debug.Log(GenerateBandName("teppo"));

        string bandName = GenerateBandName("pasi");
        Debug.Log(bandName);

        string firstName = "matteus";
        Debug.Log(GenerateBetterBandName(
            firstName,
            "markus",
            "luukas"
        ));

        Debug.Log(Hypotenuse(3f, 4f));
    }

    void PrintName(string name)
    {
        Debug.Log($"My name is {name}");
    }

    string GenerateBandName(string name)
    {
        return $"{name} ja teppo";
    }

    string GenerateBetterBandName(
        string name1,
        string name2,
        string name3
    )
    {
        return $"{name1}, {name2}, {name3} ja pasi";
    }

    // function overload:
    string GenerateBetterBandName(
        string name1,
        string name2,
        int number
    )
    {
        return $"{name1}, {name2}, {number} ja pasi";
    }

    public static float Hypotenuse(float a, float b) // a^2 + b^2 = c^2
    {
        float c = Mathf.Sqrt(Mathf.Pow(a,2) + Mathf.Pow(b,2));
        return c;
    }

    float ShorterHypotenuse(float a, float b) // a^2 + b^2 = c^2
    {
        return Mathf.Sqrt(Mathf.Pow(a,2) + Mathf.Pow(b,2));
    }




    // Update is called once per frame
    
    void Update()
    {
        PrintName("matti");
    }
}
