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
        {
            return lifePoints;
        }

        set
        {
            lifePoints = value;
        }
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
}
