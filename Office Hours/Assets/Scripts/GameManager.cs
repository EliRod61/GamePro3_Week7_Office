using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI energyDisplay;
    public TextMeshProUGUI companyRepDisplay;
    public int energy = 100;
    public int companyRep = 0;

    float startingTimer = 1f;
    float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = startingTimer;
    }

    // Update is called once per frame
    void Update()
    {   
        energyDisplay.text = energy.ToString("");
        companyRepDisplay.text = companyRep.ToString("");

        if (energy < 100)
        {
            timer -= 1 * Time.deltaTime;

            if (timer <= 0)
            {
                energy += Random.Range(2,3);
                timer = startingTimer;
            }
        }
        if (energy > 100)
        {
            energy = 100;
        }
        if (energy <= 0)
        {
            energy = 0;
        }

    }
}
