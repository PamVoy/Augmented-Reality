using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
public class MoonPanelTarget : MonoBehaviour {
		public Transform TextTargetNameMoon;
        public Transform TextTargetNamePanelMoon;
		public Transform TextDescriptionMoon;
		public Transform PanelDescriptionMoon;

		public AudioSource soundTarget;
		public AudioClip clipTarget;

		void Start()
		{
			//add Audio Source as new game object component
			soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
		}
			
		void Update()
		{
			StateManager sm = TrackerManager.Instance.GetStateManager();
			IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

			foreach (TrackableBehaviour tb in tbs)
			{
				string name = tb.TrackableName;
				ImageTarget it = tb.Trackable as ImageTarget;
				Vector2 size = it.GetSize();

				Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

				TextTargetNameMoon.GetComponent<Text>().text = name;
                TextTargetNamePanelMoon.GetComponent<Text>().text = name;
				TextDescriptionMoon.gameObject.SetActive(true);
				PanelDescriptionMoon.gameObject.SetActive(true);


				if(name == "Mercury"){
					TextDescriptionMoon.GetComponent<Text>().text = "Layers of Mercury\n" +
						"\nMercury’s interior has a larger ratio of metallic core material to silicate rock material than the Earth. " +
						"Mercury also appears to have a solid layer of iron sulfide that lies at the top of the core. The presence of this solid layer places " +
						"important constraints on the temperatures within Mercury’s interior and may influence the generation of the planet’s magnetic field." +
						"\nScientists believe that the interior structure of Mercury includes a metallic core, an intermediate rocky layer, and a thin brittle crust.";
				}

				if (name == "Venus")
				{
					TextDescriptionMoon.GetComponent<Text>().text = "Layers of Venus \n" +
						"\nThe interior of Venus is probably similar to Earth's interior and probably has a partly molten metallic core, a rocky mantle, and a crust.\n";
				}

				if (name == "Earth")
				{
					TextDescriptionMoon.GetComponent<Text>().text = "Earth's moon \n" +
						"\nEarth has one moon. Earth's Moon is the only place beyond Earth where humans have set foot, so far. The Earth's moon radius is 1,079.6 miles and it is less than a third the width of Earth. " +
						"The moon is farther away from Earth than most people realize. The moon is an average of 238,855 miles away. The moon is rotating at the same rate that it revolves around Earth and is called synchronous rotation." +
						"\nLayers of Earth" +
						"\nThe layers of the earth based on chemical composition are Crust, Mantle, Inner Core and Outer Core.";
				}
					
				if (name == "Mars")
				{
					TextDescriptionMoon.GetComponent<Text>().text = "Mar's moons \n" +
						"\nMoon has two moons named Phobos and Delmos. " +
						"\nPhobos is the larger of Mars' two moons and is 17 x 14 x 11 miles in diameter. It orbits Mars three times a day. Phobos was discovered on Aug. 17, 1877 by Asaph Hall." +
						"Hall named Mars' moons for the mythological sons of Ares, the Greek counterpart of the Roman god, Mars. Phobos, whose name means fear or panic, is the brother of Deimos." +
						"\nDelmos is the smaller of Mars' two moons. Being only 9 by 7 by 6.8 miles in size (15 by 12 by 11 kilometers), Deimos whirls around Mars every 30 hours. " +
						"Deimos was discovered on Aug. 11, 1877 by Asaph Hall. " +
						"Hall named Mars' moons for the mythological sons of Ares, the Greek counterpart of the Roman god, Mars. Deimos, whose name means dread, is the brother of Phobos.";
				}

				if (name == "Jupiter")
				{
					TextDescriptionMoon.GetComponent<Text>().text = "Jupiter's Moons \n" +
						"\nJupiter has 79 Moons and 53 of them are named. The Galilean moons are the four largest moons named Jupiter—Io, Europa, Ganymede, and Callisto. " +
						"\n\nThe 53 named planets are:" +
						"\nAndrastea, Altne, Amalthea, Ananke, Aoede, Arche, Autonoe, Callirrhoe, Callisto, Carme, Carpo, Chaldene, Cyllene, Dla, Elara, Erlnome, Euantine, Eukelade, Euporie, Europa, Eurydome, " +
						"Ganymede, Harpalyke, Hegemone, Helike, Hermippe, Herse, Himalia, Io, Iocaste, Isonoe, Jupiter Ll, Jupiter LII, Kale, Kallichore, Kalyke, Kore, Leda, Lyslthea, Megaclite. ";
				}

				if (name == "Saturn")
				{
					TextDescriptionMoon.GetComponent<Text>().text = "Saturn's Moons \n " +
						"\nThe planet Saturn has 53 named moons, and another nine which are still being studied. Titan is the largest moon of Saturn." +
						"\nThe 53 named planets are: " +
						"\nAegaeon,Aegir,Albiorix,Anthe,Atlas,Bebhionn,Bergelmir,Bestla,Calipso,Daphnis,Dione,Erriapo,Enceladus,Epimetheus,Farbauti,Fenrir,Fornjot,Greip,Hati,Helene,Hyperion,Hyrrokkin,Ijiraq,Janus," +
						"Jarnsaxa,Kari,Kiviuq,Lapetus,Loge,Methone,Mimas,Mundilfari,Narvi,Paaliaq,Pallene,Pan,Pandora,Phoebe,Polydeuces,Prometheus,Rhea,Tarvos,Titan,Siarnaq,Skathi,Skoll,Surtur,Suttungr,Tarqeq," +
						"Telesto,Tethys,Thrymr,Ymir";
				}

				if (name == "Uranus")
				{
					TextDescriptionMoon.GetComponent<Text>().text = "Uranus's Moons \n" +
						"\nUranus has 27 moons. Uranus has five major moons: Miranda, Ariel, Umbriel, Titania, and Oberon." +
						"\nThe 27 moons are:" +
						"\nAriel, Belinda, Bianca, Caliban, Cressida, Cordelia, Cupid,Desdemona, Ferdinand, Francisco, Juliet, Mab, Margaret, Miranda, Oberon, Ophelia, Perdita, Portia, Prospero, Puck, Rosalind, Setebos, " +
						"Stephano, Sycorax, Titania, Trinculo, Umbriel.";
				}

				if (name == "Neptune")
				{
					TextDescriptionMoon.GetComponent<Text>().text = "Neptune's Moons \n" +
						"\nNeptune has 14 moons. The largest moon is Triton which was discovered by William Lassell just seventeen days after Neptune was found." +
						"\nThe 14 moons are:" +
						"\nDespina,Galatea,Halimede,Larissa,Laomedeia,Naiad,Nereid,Neso,Proteus,Psamathe,Thalassa,Triton,S/2004 N1,Sao";
				}

				if (name == "Sun") {
					TextDescriptionMoon.GetComponent<Text> ().text = "Sun \n" +
						"\nThe sun and its atmosphere are divided into several zones and layers. The solar interior is made up of the core, radiative zone and the convective zone. " +
						"\nThe solar atmosphere above that consists of the photosphere, chromosphere, a transition region and the corona. Beyond that is the solar wind, an outflow of gas from the corona." +
						"\nThe core extends from the sun's center to about a quarter of the way to its surface." +
						"\nThe radiative zone, which extends from the core to 70 percent of the way to the sun's surface, making up 32 percent of the sun's volume and 48 percent of its mass." +
						"\nThe convection zone reaches up to the sun's surface, and makes up 66 percent of the sun's volume but only a little more than 2 percent of its mass. ";
				}

			}
		}

		void playSound(string ss){
			clipTarget = (AudioClip)Resources.Load(ss);
			soundTarget.clip = clipTarget;
			soundTarget.loop = false;
			soundTarget.playOnAwake = false;
			soundTarget.Play();
		}

	}
}
