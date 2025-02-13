﻿
using Sandbox;
using System.Linq;

[GameResource( "Unicycle Part", "upart", "A part, for a unicycle" )]
public class CustomizationPart : GameResource
{

	public PartType PartType { get; set; }
	public string DisplayName { get; set; }
	public bool IsDefault { get; set; }

	[ResourceType( "vmdl" )]
	public string Model { get; set; }
	[ResourceType( "vpcf" )]
	public string Particle { get; set; }
	[ResourceType( "png" )]
	public string Texture { get; set; }
	[ResourceType( "decal" )]
	public DecalDefinition Decal { get; set; }
	[ResourceType( "sound" )]
	public string DecalSound { get; set; }
	[ResourceType( "color" )]
	public Color ColorTint { get; set; } = Color.White;

	public bool CanEquip()
	{
		if ( TrailPassProgress.Current.IsUnlocked( this ) )
			return true;

		if ( IsDefault )
			return true;

		return false;
	}


	public static CustomizationPart Find( string resourceName )
	{
		return ResourceLibrary.GetAll<CustomizationPart>().FirstOrDefault( x => x.ResourceName == resourceName );
	}

	public static CustomizationPart FindDefaultPart( PartType type )
	{
		return ResourceLibrary.GetAll<CustomizationPart>().FirstOrDefault( x => x.PartType == type && x.IsDefault );
	}

}
