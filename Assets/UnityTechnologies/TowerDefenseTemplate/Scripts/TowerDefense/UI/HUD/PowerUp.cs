using Core.Economy;
using System.Collections;
using System.Collections.Generic;
using TowerDefense.Level;
using UnityEngine;
using UnityEngine.UI;


public class PowerUp : MonoBehaviour
{
	public Button powerUpButton;

	Currency m_Currency;

	public int powerUpCost = 12;

    public int powerUpResetCost = 12;

    public int powerUpReset = 100;

    public int newPowerUpCost = 12;

   

   

    private void Start()
    {
		powerUpButton.interactable = false;
        powerUpButton.onClick.AddListener(powerUpButton_onClick);
    }


    // Update is called once per frame
    void Update()
    {
		m_Currency = LevelManager.instance.currency;
     
        powerUpButton.onClick.AddListener(() => powerUpButton_onClick());
        UpdatePowerUPButton();

	}

    void powerUpButton_onClick()
    {
        //powerUpButton.onClick.AddListener(() => powerUpButton_onClick());
            powerUpButton.interactable = false;

            powerUpCost = powerUpReset;

            Debug.Log("Button clicked");
            Debug.Log(powerUpCost);
        
    }

    void UpdatePowerUPButton()
    {
        {
            // Enable button
                if (m_Currency.currentCurrency >= powerUpCost && !powerUpButton.interactable)
                {
                    powerUpButton.interactable = true;
                }

                else if (m_Currency.currentCurrency == powerUpResetCost)
                {
                    powerUpCost = newPowerUpCost;
                }
               
        }

    }
}


    // Co-routine? - logic for - if powerUP used, then updatePowerUPButton is deactivated until currency = 0.

    //  IEnumerator PowerUpCoolDown()
    //  {
    //      while (!powerUpCoolDownEnabled)
    //      {
    //	if (m_Currency.currentCurrency >= powerUpCost && !powerUpButton.interactable)
    //	{
    //		powerUpButton.interactable = true;
    //	}

    //	else if (m_Currency.currentCurrency != powerUpRestart && powerUpButton.interactable)
    //	{
    //		powerUpButton.interactable = false;
    //	}

    //	yield return new WaitUntil(() => powerUpButton.interactable == false);


    //}

    //  }

    //void ResetPowerUpButton()
    //   {
    //	if(m_Currency.currentCurrency == 0)
    //       {
    //		powerUpCoolDownEnabled = false;
    //		powerUpEnabled = false;
    //       }
    //	else
    //       {
    //		powerUpCoolDownEnabled = true;
    //       }
    //   }


    //private void Start()
    //{
    //	powerUpButton.interactable = false;
    //}


    //// Update is called once per frame
    //void Update()
    //{
    //	m_Currency = LevelManager.instance.currency;
    //	UpdatePowerUPButton();

    //}

    //// Co-routine? - logic for - if powerUP used, then updatePowerUPButton is deactivated until currency = 0.

    //void UpdatePowerUPButton()
    //{

    //	// Enable button
    //	if (m_Currency.currentCurrency >= powerUpCost && !powerUpButton.interactable)
    //	{
    //		powerUpButton.interactable = true;
    //	}
    //	else if (m_Currency.currentCurrency < powerUpCost && powerUpButton.interactable)
    //	{
    //		powerUpButton.interactable = false;

    //	}
    //}

