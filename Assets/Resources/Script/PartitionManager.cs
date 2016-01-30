﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PartitionManager : MonoBehaviour {

    static PartitionManager instance;

	GameObject[] constel;
	Transform[] stars;

    public static PartitionManager Instance
    {
        get
        {
            return instance;
        }
    }
    
    public enum constellationType
    {
        PONCTUELS,
        EFFETS,
        INTERACTIONS,
        AMBIANCE,
        GAMEPLAY
    }

    public Dictionary<string, bool> discoveredSongs;

    public Dictionary<constellationType, List<string>> constellations;

    void Awake()
    {
        instance = this;
        discoveredSongs = new Dictionary<string, bool>();
        constellations = new Dictionary<constellationType, List<string>>();
        
        InitConstellations();
		constel = GameObject.FindGameObjectsWithTag("Const");
    }
    
    void InitConstellations()
    {
        constellations[constellationType.PONCTUELS] = new List<string>();
        constellations[constellationType.PONCTUELS].Add("element");
        constellations[constellationType.PONCTUELS].Add("plante");
        constellations[constellationType.PONCTUELS].Add("plante2");
        constellations[constellationType.PONCTUELS].Add("petitRocher");
        constellations[constellationType.PONCTUELS].Add("papillon");
        constellations[constellationType.PONCTUELS].Add("arbres");
        constellations[constellationType.PONCTUELS].Add("buissons");
        constellations[constellationType.PONCTUELS].Add("oiseaux");

        constellations[constellationType.EFFETS] = new List<string>();
        constellations[constellationType.EFFETS].Add("empreintesPlantes");
        constellations[constellationType.EFFETS].Add("feuArtifice");
        constellations[constellationType.EFFETS].Add("couleur");
        constellations[constellationType.EFFETS].Add("feuillir");
        constellations[constellationType.EFFETS].Add("fleurir");
        constellations[constellationType.EFFETS].Add("effacer");

        constellations[constellationType.INTERACTIONS] = new List<string>();
        constellations[constellationType.INTERACTIONS].Add("ouvrir");
        constellations[constellationType.INTERACTIONS].Add("fermer");
        constellations[constellationType.INTERACTIONS].Add("eteindre");
        constellations[constellationType.INTERACTIONS].Add("allumer");
        constellations[constellationType.INTERACTIONS].Add("remplirEau");
        constellations[constellationType.INTERACTIONS].Add("assecher");
        constellations[constellationType.INTERACTIONS].Add("retirerGrosRocher");

        constellations[constellationType.AMBIANCE] = new List<string>();
        constellations[constellationType.AMBIANCE].Add("meteo4");
        constellations[constellationType.AMBIANCE].Add("pluie");
        constellations[constellationType.AMBIANCE].Add("neige");
        constellations[constellationType.AMBIANCE].Add("auroreBoreale");
        constellations[constellationType.AMBIANCE].Add("meteoClaire");
        constellations[constellationType.AMBIANCE].Add("jour");
        constellations[constellationType.AMBIANCE].Add("nuit");

        constellations[constellationType.GAMEPLAY] = new List<string>();
        constellations[constellationType.GAMEPLAY].Add("constellations");
        constellations[constellationType.GAMEPLAY].Add("boussole");
        constellations[constellationType.GAMEPLAY].Add("voler");
        constellations[constellationType.GAMEPLAY].Add("credit");
    }

	public void doAction(string song)
	{
		int IDCONST = 0;
		int IDSTAR = 0;
		switch (song) 
		{
		case "element":
				IDCONST = 1;
				IDSTAR = 1;
                Element();
			break;
		case "plante":
				IDCONST = 1;
				IDSTAR = 2;
                Plante();
			break;
		case "destroyplante":
                DestroyPlante();
			break;
		case "plante2":
				IDCONST = 1;
				IDSTAR = 3;
                PlanteDeux();
			break;
		case "destroyplante2":
                DestroyPlanteDeux();
			break;
		case "empreintesPlantes":
                EmpreintesPlantes();
			break;
		case "petitRocher":
				IDCONST = 1;
				IDSTAR = 4;
                PetitRocher();
			break;
		case "destroypetitRocher":
                DestroyPetitRocher();
			break;
		case "papillon":
				IDCONST = 1;
				IDSTAR = 5;
                Papillon();
			break;
		case "luciole":
				IDCONST = 1;
				IDSTAR = 6;
				Luciole();
			break;
		case "ouvrir":
                Ouvrir();
			Debug.Log("ouvrir");
			break;
		case "fermer":
                Fermer();
			Debug.Log("fermer");
			break;
		case "arbres":
				IDCONST = 1;
				IDSTAR = 7;
                Arbres();
			break;
		case "destroyArbres":
                DestroyArbres();
			break;
		case "buissons":
				IDCONST = 1;
				IDSTAR = 8;
                Buissons();
			break;
		case "destroybuissons":
                DestroyBuissons();
			break;
		case "constellations":
                Constellations();
			break;
		case "feuArtifice":
                FeuArtifice();
			break;
		case "meteo4":
                MeteoQuatre();
			break;
		case "couleur":
                Couleur();
			Debug.Log("couleur");
			break;
		case "pluie":
                Pluie();
			break;
		case "neige":
                Neige();
			break;
		case "boussole":
                Boussole();
			Debug.Log("boussole");
			break;
		case "meteoClaire":
                MeteoClaire();
			break;
		case "voler":
                Voler();
			break;
		case "fleurir":
                Fleurir();
			Debug.Log("fleurir");
			break;
		case "feuillir":
                Feuillir();
			Debug.Log("feuillir");
			break;
		case "eteindre":
                Eteindre();
			Debug.Log("eteindre");
			break;
		case "oiseaux":
				IDCONST = 1;
				IDSTAR = 9;
                Oiseaux();
			break;
		case "allumer":
                Allumer();
			Debug.Log("allumer");
			break;
		case "auroreBoreale":
                AuroreBoreale();
			Debug.Log("auroreBoreale");
			break;
		case "assecher":
                Assecher();
			Debug.Log("assecher");
			break;
		case "jour":
                Jour();
			break;
		case "credit":
                Credit();
			Debug.Log("credit");
			break;
		case "retirerGrosRocher":
                RetirerGrosRocher();
			Debug.Log("retirerGrosRocher");
			break;
		case "effacer":
                Effacer();
			Debug.Log("effacer");
			break;
		case "remplirEau":
                RemplirEau();
			Debug.Log("remplirEau");
			break;
		case "nuit":
                Nuit();
			break;
		}

        UnlockSong(song, IDCONST, IDSTAR);

	}

    private void Nuit()
    {
        MeteoManager.Instance.SetDay(false);
    }

    private void RemplirEau()
    {
        throw new NotImplementedException();
    }

    private void RetirerGrosRocher()
    {
        throw new NotImplementedException();
    }

    private void Credit()
    {
        throw new NotImplementedException();
    }

    private void Jour()
    {
        MeteoManager.Instance.SetDay(true);
    }

    private void Assecher()
    {
        throw new NotImplementedException();
    }

    private void AuroreBoreale()
    {
        throw new NotImplementedException();
    }

    private void Allumer()
    {
        throw new NotImplementedException();
    }

    private void Oiseaux()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.OISEAUX);
    }

    private void Eteindre()
    {
        throw new NotImplementedException();
    }

    private void Feuillir()
    {
        throw new NotImplementedException();
    }

    private void Fleurir()
    {
        throw new NotImplementedException();
    }

    private void Voler()
    {
        FindObjectOfType<PlayerController>().Fly();
    }

    private void MeteoClaire()
    {
        MeteoManager.Instance.SwitchWeather(MeteoManager.Weather.CLEAR);
    }

    private void Boussole()
    {
        throw new NotImplementedException();
    }

    private void Neige()
    {
        MeteoManager.Instance.SwitchWeather(MeteoManager.Weather.SNOW);
    }

    private void Pluie()
    {
        MeteoManager.Instance.SwitchWeather(MeteoManager.Weather.RAIN);
    }

    private void Couleur()
    {
        throw new NotImplementedException();
    }

    private void MeteoQuatre()
    {
        MeteoManager.Instance.SwitchWeather(MeteoManager.Weather.OTHER);
    }

    private void FeuArtifice()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.ARTIFICE);
    }

    private void Constellations()
    {
		GameObject[] constel = GameObject.FindGameObjectsWithTag("Const");
		foreach(GameObject go in constel)
		{
			go.GetComponent<ConstScript>().showLink();
		}
    }

    private void DestroyBuissons()
    {
		FindObjectOfType<Invocation>().Uninvoc(SpellManager.spellType.BUISSON);
    }

    private void Buissons()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.BUISSON);
    }

    private void DestroyArbres()
    {
        FindObjectOfType<Invocation>().Uninvoc(SpellManager.spellType.TREE);
    }

    private void Fermer()
    {
        throw new NotImplementedException();
    }

    private void Ouvrir()
    {
        throw new NotImplementedException();
    }

    private void Papillon()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.PAPILLON);
    }

	private void Luciole()
	{
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.LUCIOLE);
	}

    private void DestroyPetitRocher()
    {
        FindObjectOfType<Invocation>().Uninvoc(SpellManager.spellType.ROCK);
    }

    private void EmpreintesPlantes()
    {
		GameObject.FindGameObjectWithTag ("FlowerTrail").GetComponent<FlowerTrailScript> ().startTrail ();
    }

    private void DestroyPlanteDeux()
    {
		FindObjectOfType<Invocation>().Uninvoc(SpellManager.spellType.PLANTE2);
    }

    private void PlanteDeux()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.PLANTE2);
    }

    private void DestroyPlante()
    {
		FindObjectOfType<Invocation>().Uninvoc(SpellManager.spellType.PLANTE);
    }

    private void Plante()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.PLANTE);
    }

    private void Element()
    {
		FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.ELEMENT);
    }

    void Effacer()
    {
        FindObjectOfType<Invocation>().Uninvoc(SpellManager.spellType.ALL);
    }

    void Arbres()
    {
        FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.TREE);
    }

    void PetitRocher()
    {
        FindObjectOfType<Invocation>().Invoc(SpellManager.spellType.ROCK);
    }

    void UnlockSong(string song, int idConst, int idStar)
    {
		if (idConst > 0 && idStar > 0)
		{
			if (!discoveredSongs.ContainsKey(song))
			{
				discoveredSongs[song] = true;
				activeConstellations(idConst, idStar);
			}
		}
    }

    void activeConstellations(int ConstID, int StarID)
    {
		foreach(GameObject co in constel)
		{
			if (co.GetComponent<ConstScript>().ID == ConstID)
			{
				stars = co.GetComponentsInChildren<Transform>();
				foreach(Transform st in stars)
				{
					if (st.tag == "Star" && st.GetComponent<StarScript>().ID == StarID)
					{
						st.GetComponent<StarScript>().isActive = true;
						checkConst(ConstID);
					}
				}
			}
		}
    }

	void checkConst(int ConstID)
	{
		bool allIsFound = true;
		foreach(GameObject co in constel)
		{
			if (co.GetComponent<ConstScript>().ID == ConstID && co.GetComponent<ConstScript>().revealed == false)
			{
				stars = co.GetComponentsInChildren<Transform>();
				foreach(Transform st in stars)
				{
					if (st.tag == "Star" && st.GetComponent<StarScript>().isActive == false)
					{
						allIsFound = false;
					}
				}
				if (allIsFound)
				{
					co.GetComponent<ConstScript>().showLinkForever();
				}
			}
		}
	}

	public bool GetConstellation(int ConstID, int StarID)
    {
		foreach(GameObject co in constel)
		{
			if (co.GetComponent<ConstScript>().ID == ConstID)
			{
				stars = co.GetComponentsInChildren<Transform>();
				foreach(Transform st in stars)
				{
					if (st.GetComponent<StarScript>().ID == StarID)
					{
						if (st.GetComponent<StarScript>().isActive){return true;}
						else{return false;}
					}
				}
			}
		}
		return false;
    }
}
