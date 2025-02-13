﻿using Sandbox;
using Editor;
using System.ComponentModel.DataAnnotations;

[Library( "uf_trigger_fall", Description = "Makes the player fall" )]
[AutoApplyMaterial("materials/editor/uf_trigger_fall.vmat")]
[Display( Name = "Trigger Fall", GroupName = "Unicycle Frenzy", Description = "Makes the player fall." )]
[HammerEntity]
internal partial class FallTrigger : BaseTrigger
{

	public override void StartTouch( Entity other )
	{
		base.StartTouch( other );

		if ( !Game.IsServer ) return;
		if ( other is not UnicyclePlayer pl ) return;

		pl.Fall();
	}

}
