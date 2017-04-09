﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegendaryEnemy : Enemy {

	public LegendaryEnemy(string name,float speed,float health, int money, int attack, int score) : base(name,speed,health,money,attack,score) {

	}

	public override void specialAbility() {
		Debug.Log ("ADVANCED");
	}
}
