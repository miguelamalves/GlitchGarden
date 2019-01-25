using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{

    [SerializeField] int currentStars = 100;
    Text starText; 

    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = currentStars.ToString(); ;
    }

    public bool HaveEnoughStars(int starsToSpend)
    {
        return currentStars >= starsToSpend;
    }

    public void AddStars(int starsToAdd)
    {
        currentStars += starsToAdd;
        UpdateDisplay();
    }

    public void SpendStars(int starsToSpend)
    {

        if (currentStars >= starsToSpend)
        {
            currentStars -= starsToSpend;
        }

        UpdateDisplay();
    }

}
