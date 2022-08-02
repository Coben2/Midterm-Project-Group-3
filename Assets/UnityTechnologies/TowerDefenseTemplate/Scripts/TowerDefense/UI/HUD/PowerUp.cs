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
    public int powerUpCost = 20; //currency required to powerUp

    [SerializeField] private int powerUpResetCost = 5; //value that remains fixed to restart the powerUp
    [SerializeField] private int powerUpReset = 100; //prevents user from being able to click again if score is >= powerUpCost
    [SerializeField] private int defaultPowerUpCost = 20; //if currency <= powerUpResetCost then currency required to powerUp resets to default

    private void Start()
    {
		powerUpButton.interactable = false;
        powerUpButton.onClick.AddListener(powerUpButton_onClick);
    }

    void Update()
    {
		m_Currency = LevelManager.instance.currency;
        powerUpButton.onClick.AddListener(() => powerUpButton_onClick());
        UpdatePowerUpButton();
	}

    void powerUpButton_onClick()
    {
        powerUpButton.interactable = false;
        powerUpCost = powerUpReset;
    }

    // Enable button
    void UpdatePowerUpButton()
    {
        { 
            if (m_Currency.currentCurrency >= powerUpCost && !powerUpButton.interactable)
            {
                powerUpButton.interactable = true;
            }
            else if (m_Currency.currentCurrency <= powerUpResetCost)
            {
                powerUpCost = defaultPowerUpCost;
            } 
        }
    }
}
