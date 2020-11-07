using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityCardView : MonoBehaviour
{
    [SerializeField] Text _nameTextUI = null;
    [SerializeField] Text _costTextUI = null;
    [SerializeField] Image _graphicUI = null;

  /*  [SerializeField] Text _nameTextUI2 = null;
    [SerializeField] Text _costTextUI2 = null;
    [SerializeField] Image _graphicUI2 = null;

    [SerializeField] Text _nameTextUI3 = null;
    [SerializeField] Text _costTextUI3 = null;
    [SerializeField] Image _graphicUI3 = null;

    [SerializeField] Text _nameTextUI4 = null;
    [SerializeField] Text _costTextUI4 = null;
    [SerializeField] Image _graphicUI4 = null;

    [SerializeField] Text _nameTextUI5 = null;
    [SerializeField] Text _costTextUI5 = null;
    [SerializeField] Image _graphicUI5= null;

    [SerializeField] Text _nameTextUI6 = null;
    [SerializeField] Text _costTextUI6 = null;
    [SerializeField] Image _graphicUI6 = null;*/

    public void DisplayFirstCard(AbilityCard abilityCard)
    {
        _nameTextUI.text = abilityCard.Name;
        _costTextUI.text = abilityCard.Cost.ToString();
        _graphicUI.sprite = abilityCard.Graphic;
    }
    /*public void DisplaySecondCard(AbilityCard abilityCard)
    {
        _nameTextUI2.text = abilityCard.Name;
        _costTextUI2.text = abilityCard.Cost.ToString();
        _graphicUI2.sprite = abilityCard.Graphic;
    }
    public void DisplayThirdCard(AbilityCard abilityCard)
    {
        _nameTextUI3.text = abilityCard.Name;
        _costTextUI3.text = abilityCard.Cost.ToString();
        _graphicUI3.sprite = abilityCard.Graphic;
    }
    public void DisplayFourthCard(AbilityCard abilityCard)
    {
        _nameTextUI4.text = abilityCard.Name;
        _costTextUI4.text = abilityCard.Cost.ToString();
        _graphicUI4.sprite = abilityCard.Graphic;
    }
    public void DisplayFifthCard(AbilityCard abilityCard)
    {
        _nameTextUI5.text = abilityCard.Name;
        _costTextUI5.text = abilityCard.Cost.ToString();
        _graphicUI5.sprite = abilityCard.Graphic;

    }
    public void DisplayDiscardCard(AbilityCard abilityCard)
    {
        _nameTextUI6.text = abilityCard.Name;
        _costTextUI6.text = abilityCard.Cost.ToString();
        _graphicUI6.sprite = abilityCard.Graphic;
    }

    public void Display(AbilityCard abilityCard)
    {
        _nameTextUI6.text = abilityCard.Name;
        _costTextUI6.text = abilityCard.Cost.ToString();
        _graphicUI6.sprite = abilityCard.Graphic;
    */
}
