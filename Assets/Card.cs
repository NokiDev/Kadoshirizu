using UnityEngine;
using System;

public class Card : MonoBehaviour
{

    public enum CardElement { WATER, FIRE, WIND, LIGHTNING, EARTH };

    private CardElement element;
    private int level;

    public CardElement Element
    {
        get { return element; }
        set { element = value; }
    }
    public int Level
    {
        get { return level; }
        set { level = value; }
    }

    public Card(CardElement p_element, int p_level)
    {
        element = p_element;
        level = p_level;
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
