using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BOX : MonoBehaviour
{
    private static BOX instace;
    private int Score;
    public int score => Score;
    public static BOX Instace => instace;

    private void Awake()
    {
        if (instace == null)
        {
            instace = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Addscore(int Newscore)
    {
        Score += Newscore;
    }
    
}
