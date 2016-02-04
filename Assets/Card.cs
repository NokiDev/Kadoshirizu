using UnityEngine;
using System;

public class Card : MonoBehaviour
{

    public enum CardElement { WATER, FIRE, WIND, LIGHTNING, EARTH };

    private CardElement element;
    private int level;

    public CardElement Element {
        get {
            return element;
        }
        set {
            element = value;
        }
    }

    public Card(CardElement p_element, int p_level)
    {
        element = p_element;
        level = p_level;
    }

    public void Effect(Player p)
    {
        switch (element)
        {
            case CardElement.WATER:
                EffectWater(p);
                break;
            case CardElement.FIRE:
                EffectFire(p);
                break;
            case CardElement.WIND:
                EffectWind(p);
                break;
            case CardElement.LIGHTNING:
                EffectLightning(p);
                break;
            case CardElement.EARTH:
                EffectEarth(p);
                break;
            default:
                Console.Error.WriteLine("This card's element does not exist : " + element + " !");
                break;
        }
    }

    private void EffectWater(Player player)
    {
        // Affects the effects of Card Water on the player
    }
    private void EffectFire(Player player)
    {
        // Affects the effects of Card Fire on the player
    }
    private void EffectWind(Player player)
    {
        // Affects the effects of Card Wind on the player
    }
    private void EffectLightning(Player player)
    {
        // Affects the effects of Card Lightning on the player
    }
    private void EffectEarth(Player player)
    {
        // Affects the effects of Card Earth on the player
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
