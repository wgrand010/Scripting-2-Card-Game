using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class CardGameUIController : MonoBehaviour
{
    [SerializeField] Text _enemyThinkingTextUI = null;
    [SerializeField] Text _ActionTextUI = null;
    [SerializeField] Text _HealthTextUI = null;
    [SerializeField] PlayerControl _playerTextUI = null;

    [SerializeField]
    List<AbilityCardData> _abilityDeckConfig
        = new List<AbilityCardData>();
    [SerializeField] AbilityCardView _abilityCardView = null;

    Deck<AbilityCard> _abilityDeck = new Deck<AbilityCard>();
    Deck<AbilityCard> _abilityDiscard = new Deck<AbilityCard>();

    Deck<AbilityCard> _playerHand = new Deck<AbilityCard>();


    private void Start()
    {
        SetupAbilityDeck();
        _enemyThinkingTextUI.gameObject.SetActive(false);
    }

    private void SetupAbilityDeck()
    {
        foreach (AbilityCardData abilitydata in _abilityDeckConfig)
        {
            AbilityCard newAbilityCard = new AbilityCard(abilitydata);
            _abilityDeck.Add(newAbilityCard);
        }

        _abilityDeck.Shuffle();
    }
    public void DrawFirstCards()
    {
        AbilityCard newCard = _abilityDeck.Draw(DeckPosition.Top);
        Debug.Log("Drew card: " + newCard.Name);
        _playerHand.Add(newCard, DeckPosition.Top);
        _abilityCardView.DisplayFirstCard(newCard);

        /*AbilityCard newCard2 = _abilityDeck.Draw(DeckPosition.Top);
        Debug.Log("Drew card: " + newCard2.Name);
        _playerHand.Add(newCard2, DeckPosition.Top);
        _abilityCardView.DisplaySecondCard(newCard2);

        AbilityCard newCard3 = _abilityDeck.Draw(DeckPosition.Top);
        Debug.Log("Drew card: " + newCard3.Name);
        _playerHand.Add(newCard3, DeckPosition.Top);
        _abilityCardView.DisplayThirdCard(newCard3);

        AbilityCard newCard4 = _abilityDeck.Draw(DeckPosition.Top);
        Debug.Log("Drew card: " + newCard4.Name);
        _playerHand.Add(newCard4, DeckPosition.Top);
        _abilityCardView.DisplayFourthCard(newCard4);

        AbilityCard newCard5 = _abilityDeck.Draw(DeckPosition.Top);
        Debug.Log("Drew card: " + newCard5.Name);
        _playerHand.Add(newCard5, DeckPosition.Top);
        _abilityCardView.DisplayFifthCard(newCard5);*/

    }



    private void OnEnable()
    {
        EnemyTurnCardGameState.EnemyTurnBegan += OnEnemyTurnBegan;
        EnemyTurnCardGameState.EnemyTurnEnded += OnEnemyTurnEnded;
    }
    private void OnDisable()
    {
        EnemyTurnCardGameState.EnemyTurnBegan -= OnEnemyTurnBegan;
        EnemyTurnCardGameState.EnemyTurnEnded -= OnEnemyTurnEnded;
    }

  
    void OnEnemyTurnBegan()
    {
        _enemyThinkingTextUI.gameObject.SetActive(true);
    }

    void OnEnemyTurnEnded()
    {
        _enemyThinkingTextUI.gameObject.SetActive(false);
    }

    public void Draw()
    {
        AbilityCard newCard = _abilityDeck.Draw(DeckPosition.Top);
        Debug.Log("Drew card: " + newCard.Name);
        _playerHand.Add(newCard, DeckPosition.Top);

        _abilityCardView.DisplayFirstCard(newCard);
    }
}
