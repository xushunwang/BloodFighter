using UnityEngine;
using System.Collections;

public class BFActor : BFHitSprite {
	static readonly string[] actorAnimationNames  = new string[]{
		"Idle","Walk","Run","Jump","x_combo_1","y_combo_1",
		"y_combo_2","y_combo_3","jump_x_attack","jump_y_attack",
		"run_attack","knock_down","stand_up"
	};
	public override string[] GetAnimationNames ()
	{
		return actorAnimationNames;
	}
}
