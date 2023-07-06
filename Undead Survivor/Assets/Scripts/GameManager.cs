using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    [SerializeField] Player m_Player;
    public Player GetPlayer() => m_Player;
    
    void Awake()
    {
        Instance = this; 
    }
}