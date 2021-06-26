using System;
using UnityEngine;
public class WeaponCard : Card {
    private int additionalCost;
    private int additionalPower;
    public WeaponCard(string name, int deploymentCost, int additionalCost, int additionalPower) : base(name, deploymentCost) {
        this.additionalCost = additionalCost;
        this.additionalPower = additionalPower;
    }
}