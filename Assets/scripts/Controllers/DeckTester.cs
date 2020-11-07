using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckTester : MonoBehaviour
{
    [SerializeField] List<AbilityCardData> _abilityDeckConfig
        = new List<AbilityCardData>();
    [SerializeField] AbilityCardView _abilityCardView = null;

    Deck<AbilityCard> _abilityDeck = new Deck<AbilityCard>();
    Deck<AbilityCard> _abilityDiscard = new Deck<AbilityCard>();

    Deck<AbilityCard> _playerHand = new Deck<AbilityCard>();
    private void Start()
    {
        SetupAbilityDeck();
    }

    private void SetupAbilityDeck()
    {
       foreach(AbilityCardData abilitydata in _abilityDeckConfig)
        {
            AbilityCard newAbilityCard = new AbilityCard(abilitydata);
            _abilityDeck.Add(newAbilityCard);
        }

        _abilityDeck.Shuffle();
    }

    private void Update()
    {
        /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "Deck" && Input.GetMouseButtonDown(0))
            {
               
                    Draw();
            }
            
        }
        */
        if (Input.GetKeyDown(KeyCode.W))
        {
            PrintPlayerHand();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayTopCard();
        }
    }

    private void Draw()
    {
        AbilityCard newCard = _abilityDeck.Draw(DeckPosition.Top);
        Debug.Log("Drew card: " + newCard.Name);
        _playerHand.Add(newCard, DeckPosition.Top);

        _abilityCardView.DisplayFirstCard(newCard);
    }

    private void PrintPlayerHand()
    {
        for (int i = 0; i < _playerHand.Count; i++)
        {
            Debug.Log("Player Hand Card: " + _playerHand.GetCard(i).Name);
        }
    }

    void PlayTopCard()
    {
        AbilityCard targetCard = _playerHand.TopItem;
        targetCard.Play();
        //TODO consider explanding REmove to accept a deck position
        _playerHand.Remove(_playerHand.LastIndex);
        _abilityDiscard.Add(targetCard);
        Debug.Log("Card added to discard: " + targetCard.Name);
    }
}
