using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

    Player_Test[] m_Players = { null, null };
    Player_Test m_CurrentTurn;
	// Use this for initialization
	void Start () {
	
	}

    public void NewGame(Player_Test player1, Player_Test player2)
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
        if (m_CurrentTurn == m_Players[0])
            m_CurrentTurn = m_Players[1];
        else
            m_CurrentTurn = (m_CurrentTurn == m_Players[0]) ? m_Players[1] : m_Players[0];
    }

    public void PlayCard(int index)
    {
        Card_Test cardPlayed = m_CurrentTurn.GetHandCard(index);
        Player_Test waitingPlayer = (m_CurrentTurn == m_Players[0]) ? m_Players[0] : m_Players[1];
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
