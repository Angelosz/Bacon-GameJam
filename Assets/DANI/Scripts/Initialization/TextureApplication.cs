using UnityEngine;
using System.Collections.Generic;


public class TextureApplication : MonoBehaviour
{

	private GameObject[] appFactories;

	private Object[] sideQuadTextures;
	private Object[] upperQuadTextures;

	private List<int> randomValues = new List<int>(0);
	private System.Random rand = new System.Random();


	void Start()
	{
		SetupCollections();

		if (sideQuadTextures.Length != upperQuadTextures.Length)
			Debug.LogError("The number of textures in sideQuad and upperQuad differ! Did you forgot to add one?");

		foreach (var tex in sideQuadTextures)

		SetupTextures();
	}


	private void SetupCollections()
	{
		appFactories = GameObject.FindGameObjectsWithTag("AppFactory");

		sideQuadTextures = Resources.LoadAll("Textures/SideQuad_Textures");
		upperQuadTextures = Resources.LoadAll("Textures/UpperQuad_Textures");
	}


	private void SetupTextures()
	{
		foreach (var app in appFactories)
		{
			Transform[] trs = app.gameObject.GetComponentsInChildren<Transform>();
			int randomValue = GetUniqueRandom();

			if (trs[1].gameObject.name == "SideQuad")
			{
				trs[1].renderer.material.mainTexture = (Texture2D)sideQuadTextures[randomValue];
				trs[2].renderer.material.mainTexture = (Texture2D)upperQuadTextures[randomValue];
			}
			else
			{
				trs[1].renderer.material.mainTexture = (Texture2D)upperQuadTextures[randomValue];
				trs[2].renderer.material.mainTexture = (Texture2D)sideQuadTextures[randomValue];
			}
		}
	}


	private int GetUniqueRandom()
	{
		if (randomValues.Count == 0)
			SetupPossibleRandomValues();

		int random = rand.Next(0, randomValues.Count - 1);
		int result = randomValues[random];

		randomValues.RemoveAt(random);

		return result;
	}


	private void SetupPossibleRandomValues()
	{
		int numberOfTextures = sideQuadTextures.Length;

		for (int i = 0; i < numberOfTextures; i++)
			randomValues.Add(i);
	}
}
