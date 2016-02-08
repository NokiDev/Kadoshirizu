using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

    Player[] m_Players = { null, null };
    Player m_CurrentTurn;
	// Use this for initialization
	void Start () {
	
	}

    public void NewGame(Player player1, Player player2)
    {
        player1.StartGame();
        player2.StartGame();
        float rand = Random.value;
        m_Players[0] = player1;
        m_Players[1] = player2;
        m_CurrentTurn = (rand >= 5.0) ? player1 : player2;
    }

    public void NextTurn()
    {
        m_CurrentTurn = (m_CurrentTurn == m_Players[0]) ? m_Players[1] : m_Players[0];
    }

    public void PlayCard(int index)
    {
        Card cardPlayed = m_CurrentTurn.GetHandCard(index);
        Player waitingPlayer = (m_CurrentTurn == m_Players[0]) ? m_Players[0] : m_Players[1];

        waitingPlayer.ComputeDamage(cardPlayed);
        if(waitingPlayer.LifePoints <0)
        {
            waitingPlayer.Loose();
            m_CurrentTurn.Win();
        }
    }

    
	
	// Update is called once per frame
	void Update () {
	
	}
}
