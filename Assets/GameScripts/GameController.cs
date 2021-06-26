using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    //implement player deploy cards to the board and player attacking other players. 
    private static Player p1;
    private static Player p2;

    private CardManager cardManager = new CardManager();

    public GameObject HeroCard1; 
    public GameObject HeroCard2;
    public GameObject Hero1; 
    public GameObject Hero2; 
    public GameObject P1Hand;
    public GameObject P2Hand;

    private List<GameObject> generatedObjects;

    public void Start() {
        if (SceneManager.GetActiveScene().name == "P1_Card") {
            p1ShowCard();
        } else if (SceneManager.GetActiveScene().name == "P2_Card") {
            p2ShowCard();
        }
    }

    public void initialize() {
        GameController.p1 = new Player("P1");
        for (int i = 0; i < 5; i++) {
            GameController.p1.cards.Add(cardManager.draw());
        }
        GameController.p2 = new Player("P2");
        for (int i = 0; i < 5; i++) {
            GameController.p2.cards.Add(cardManager.draw());
        }
    }

    public void destroyItems() {
        if (generatedObjects == null) {
        } else {
            foreach (GameObject c in generatedObjects) {
                Destroy(c);
            }
        }
    }

    public void loadP1Hand() {
        SceneManager.LoadScene("P1_Card");
        p1ShowCard();
    }

    public void p1ShowCard() {
        destroyItems();
        this.generatedObjects = new List<GameObject>();
        foreach (Card c in GameController.p1.cards) {
            if (c.getName() == "Villager") {
                GameObject currCard = Instantiate(HeroCard1, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
                this.generatedObjects.Add(currCard);
            } else if (c.getName() == "Medic") {
                GameObject currCard = Instantiate(HeroCard2, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P1Hand.transform, false);
                this.generatedObjects.Add(currCard);
            }
        }
    }

    public void p2ShowCard() {
        foreach (Card c in GameController.p2.cards) {
            if (c.getName() == "Villager") {
                GameObject currCard = Instantiate(HeroCard1, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            } else if (c.getName() == "Medic") {
                GameObject currCard = Instantiate(HeroCard2, new Vector3(0,0,0), Quaternion.identity);
                currCard.transform.SetParent(P2Hand.transform, false);
            }
        }
    }
    public void p1DrawCard() { //Goes to P1 hand draw button
        GameController.p1.cards.Add(cardManager.draw());
        p1ShowCard();
    }

    public void p2DrawCard() {//Goes to P2 hand draw button
        GameController.p2.cards.Add(cardManager.draw());
        p2ShowCard();
    }


    // pencet hero -> kurangin energy p1, serang p2. 
    // pencet kartu hero -> deploy kartu hero.
    // pencet kartu weapon -> tanya mau ke hero mana -> update hero. 
    // pencet kartu spell -> jalanin efek spell 
}

