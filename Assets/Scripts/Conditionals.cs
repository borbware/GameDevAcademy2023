using UnityEngine;

public class Conditionals : MonoBehaviour
{

    string testi1 = "terve";
    string testi2 = "terve";

    int someNumberVariable = 100;
    float someOtherNumberVariable = 50f;
	private bool itIsFriday;
	private bool iHaveBeer;
	private double beerTemperature = 3;

	// Start is called before the first frame update
	void Start()
    {
        Debug.Log(testi1 == testi2);
        Debug.Log("testaus" == "testaus");
        Debug.Log(122 == 123);
        bool result = testi1 != testi2;
        Debug.Log(result);

        Debug.Log(someNumberVariable > someOtherNumberVariable);

        float temperatureInOulu = 2.3f;
        float temperatureInIvalo = -45.9f;
        bool saunaIsWarm = true;

        if (temperatureInOulu > temperatureInIvalo)
        {
            Debug.Log("Oulu is warmer than Ivalo");
            if (someNumberVariable > someOtherNumberVariable)
            {
                Debug.Log("a is greater than b!");
            }
        }
        else if (temperatureInOulu == temperatureInIvalo)
        {
            Debug.Log("Ivalo and Oulu have the same temperature");
        }
        else
        {
            Debug.Log("Ivalo is warmer than Oulu!");
        }

        if (temperatureInOulu != temperatureInIvalo)
        {
            Debug.Log("temperatures are not the same");
        }

        if (!(temperatureInOulu == temperatureInIvalo))
        {
            Debug.Log("temperatures are not the same");
        }
        
        someNumberVariable = someNumberVariable + 1;
        someNumberVariable += 1;
        someNumberVariable++;
        ++someNumberVariable;

        someNumberVariable -= 2;
        someNumberVariable *= 2;
        Debug.Log(someNumberVariable); // prints something

        if (temperatureInIvalo <= 20f)
        {
            if (saunaIsWarm)
            {
                Debug.Log("mennään saunaan");
            }
        }
        if (temperatureInIvalo <= 20f && saunaIsWarm)
        {
            Debug.Log("mennään saunaan");
        }
        bool iWantToGoToSauna = true;

        if (
            (temperatureInIvalo <= 20f || temperatureInOulu <= 20f)
            && saunaIsWarm
            && iWantToGoToSauna
            && itIsFriday
            && iHaveBeer
            && beerTemperature < 8
        )
        {
            Debug.Log("mennään saunaan");
        }

        float temperature = 50f;

        if (60f < temperature && temperature < 80f)
        {
            Debug.Log("saanassako myö ollaan");
        }
        string message = (60f < temperature && temperature < 80f) 
            ? "saanassako myö ollaan"
            : "ei vissiin olla saanassa";
        Debug.Log(message);

        string animal = "Dog";
        string sound = "Woof";
        Debug.Log($"{animal} says {sound}!!!!!");
        Debug.Log(animal + " says " + sound + "!");
        // Dog says Woof!
        Debug.Log($"animal: {animal}, sound: {sound}");
        // animal: Dog, sound: Woof

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
