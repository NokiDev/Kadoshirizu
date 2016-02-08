using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System;

public class Player : MonoBehaviour
{
    public int lifePoints;
    private int nbDots;
    List<Card> cards; // Represent the deck of cards
    Card[] hand = { null, null, null }; // Represent the hand of the player

    // Use this for initialization
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }


    public int LifePoints
    {
        get
        { return lifePoints; }

        set
        { lifePoints = value; }
    }

    public void StartGame()
    {
        nbDots = 0;
        lifePoints = 10000;
        ShuffleDeck();
        Draw(3);
    }

    void Damage(int damage)
    {
        this.lifePoints -= damage;
    }



    public void Win()
    {

    }

    public void Loose()
    {

    }

    public void Draw(int number = 1)
    {
        for (int i = 0; i < number; i++)
        {
            if (cards.Count > 0)
            {
                hand[0] = cards[0];
                cards.RemoveAt(0);
            }
        }
    }

    public Card GetHandCard(int index)
    {
        return null;
    }

    public void ComputeDamage(Card card)
    {

    }

    
    public void ShuffleDeck()
    {
        RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
        int n = cards.Count;
        while (n > 1)
        {
            byte[] box = new byte[1];
            do provider.GetBytes(box);
            while (!(box[0] < n * (Byte.MaxValue / n)));
            int k = (box[0] % n);
            n--;
            Card value = cards[k];
            cards[k] = cards[n];
            cards[n] = value;
        }
    }


    public void Effect(Card card)
    {
        switch (card.Element)
        {
            case Card.CardElement.WATER:
                // Affects the effects of Card Water on the player
                BlockFireSpellForMultipleRound(card.Level);
                break;
            case Card.CardElement.FIRE:
                // Affects the effects of Card Fire on the player
                DamageForMultipleRound(100, card.Level);
                break;
            case Card.CardElement.WIND:
                // Affects the effects of Card Wind on the player
                ReturnSpell(0.25 * card.Level);
                break;
            case Card.CardElement.LIGHTNING:
                // Affects the effects of Card Lightning on the player
                Stun(0.25 * (Math.Pow(2, card.Level - 1)));
                break;
            case Card.CardElement.EARTH:
                // Affects the effects of Card Earth on the player
                int damages = 0;
                switch (card.Level)
                {
                    case 1:
                        damages = 100;
                        break;
                    case 2:
                        damages = 250;
                        break;
                    case 3:
                        damages = 500;
                        break;
                    default:
                        Console.Error.WriteLine("This card's level does not exist : " + card.Level + " !");
                        break;

                }
                if (damages != 0)
                {
                    DamageForMultipleRound(damages, 1);
                }
                break;
            default:
                Console.Error.WriteLine("This card's element does not exist : " + card.Element + " !");
                break;
        }
    }

    // Methodes utilisées par les effets des cartes
    public void BlockFireSpellForMultipleRound(int nbRounds)
    {

    }
    public void DamageForMultipleRound(int damages, int nbRounds)
    {

    }
    public void ReturnSpell(double percent)
    {

    }
    public void Stun(double percent)
    {
        
    }
}
