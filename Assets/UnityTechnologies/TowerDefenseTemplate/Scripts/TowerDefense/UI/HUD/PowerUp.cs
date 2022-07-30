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

	[SerializeField] private int powerUpCost = 12;


    private void Start()
    {
		powerUpButton.interactable = false;
    }


    // Update is called once per frame
    void Update()
    {
		//if (LevelManager.instanceExists)
		//{
		//	m_Currency = LevelManager.instance.currency;

		//}
		m_Currency = LevelManager.instance.currency;
		UpdatePowerUPButton();

	}


	// create new script attach to Debug bar
	// attach UpdatePowerUPButton - should then turn on/off the interactable
	// logic for - if player currency = 20, if AddCurrency clicked initiate cooldown period until playerCurrency = 0.

	void UpdatePowerUPButton()
	{
		
		// Enable button
		if (m_Currency.currentCurrency >= powerUpCost && !powerUpButton.interactable)
		{
			powerUpButton.interactable = true;
		}
		else if (m_Currency.currentCurrency < powerUpCost && powerUpButton.interactable)
		{
			powerUpButton.interactable = false;

		}
	}
}
