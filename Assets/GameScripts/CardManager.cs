using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class CardManager : MonoBehaviour {
    public Card Card1 = new HeroCard("Villager", 1, 1, 1, 1);
    public Card Card2 = new HeroCard("Medic", 2, 2, 1, 1);
    
    public Card draw() {
        float r = Random.Range(-10.0f, 10.0f);
        Debug.Log(r);
        if (r <= 0) {
            return Card1;
        } else {
            return Card2;
        }
    }
}