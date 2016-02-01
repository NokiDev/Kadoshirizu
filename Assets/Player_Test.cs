using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System;

public class Player_Test : MonoBehaviour {

    List<Card_Test> m_Cards; // Represent the deck of cards
    Card_Test[] m_Hand = { null, null, null }; // Represent the hand of the player
    int m_LifePoints; // Represent health point of the player
    int m_Dot=0; //Represent the number of dot the player have on him

    public int LifePoints
    {
        get
        {
            return m_LifePoints;
        }

        set
        {
            m_LifePoints = value;
        }
    }


    // Use this for initialization
    void Start () {
	    //Init deck

	}

    /****/
    public void StartGame()
    {
        m_Dot = 0;
        m_LifePoints = 10000;
        ShuffleDeck();
        Draw(3);
    }

    public void Win()
    {

    }

    public void Loose()
    {

    }

    /****/
    public void Draw(int number =1)
    {
        for(int i =0; i< number; i++)
        {
            if (m_Cards.Count > 0)
            {
                m_Hand[0] = m_Cards[0];
                m_Cards.RemoveAt(0);
            }
        }
    }

    public Card_Test GetHandCard(int index)
    {
        return null;
    }

    public void ComputeDamage(Card_Test card)
    {

    }

    /****/
    public void ShuffleDeck()
    {
        RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
        int n = m_Cards.Count;
        while (n > 1)
        {
            byte[] box = new byte[1];
            do provider.GetBytes(box);
            while (!(box[0] < n * (Byte.MaxValue / n)));
            int k = (box[0] % n);
            n--;
            Card_Test value = m_Cards[k];
            m_Cards[k] = m_Cards[n];
            m_Cards[n] = value;
        }
    }


    // Update is called once per frame
    void Update () {
	
	}
}
