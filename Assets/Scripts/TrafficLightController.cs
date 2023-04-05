using UnityEngine;

public class TrafficLightController : MonoBehaviour
{
    [SerializeField] GameObject redLight;
    [SerializeField] GameObject yellowLight;
    [SerializeField] GameObject greenLight;

    string trafficLightState = "red";
    float loopTime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        redLight.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {

        redLight.transform.localRotation = Quaternion.Euler(0, 0, Time.time * 6);

        if (trafficLightState == "red" && Time.time % loopTime > 1f)
        {
            trafficLightState = "red and yellow";
            redLight.GetComponent<Renderer>().material.color = Color.red;
            yellowLight.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (trafficLightState == "red and yellow" && Time.time % loopTime > 3f)
        {
            trafficLightState = "green";
            redLight.GetComponent<Renderer>().material.color = Color.black;
            yellowLight.GetComponent<Renderer>().material.color = Color.black;
            greenLight.GetComponent<Renderer>().material.color = Color.green;
        }
        if (trafficLightState == "green" && Time.time % loopTime > 6f)
        {
            trafficLightState = "yellow";
            redLight.GetComponent<Renderer>().material.color = Color.black;
            yellowLight.GetComponent<Renderer>().material.color = Color.yellow;
            greenLight.GetComponent<Renderer>().material.color = Color.black;
        }
        if (trafficLightState == "yellow" && Time.time % loopTime > 7f)
        {
            trafficLightState = "red";
            redLight.GetComponent<Renderer>().material.color = Color.red;
            yellowLight.GetComponent<Renderer>().material.color = Color.black;
            greenLight.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
