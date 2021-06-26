using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Player : MonoBehaviour {

    public string name;
    public int HP;
    public int energy;
    public List<Card> cards;
    public List<Hero> heroes;

    public Player(string name)
    {
        this.name = name;
        this.cards = new List<Card>();
        this.HP = 100;
        this.heroes = new List<Hero>();
        this.energy = 0;
    }

    public Player(string name, int HP, int energy, List<Card> cards, List<Hero> heroes) {
        this.name = name;
        this.cards = cards; 
        this.HP = HP;
        this.heroes = heroes;
        this.energy = energy;
    }

    public Player attacked(int hp) {
        if (this.heroes.Capacity == 0) {
            if (this.HP <= hp) {
                return null;
            } else {
                this.HP -= hp;
                return this;
            }
        } else { //always attacks hero with lowest HP
            Hero attackedHero = this.heroes[0];
            Hero newHero = attackedHero.attacked(hp);
            if (newHero == null) {
                this.heroes.RemoveAt(0);
            } else {
                this.heroes.RemoveAt(0);
                this.heroes.Add(newHero);
                this.heroes.Sort();
            }
            return this;
        }
    }
}
