using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
	public class dataTarget : MonoBehaviour
	{
		public Transform TextTargetName;
		public Transform TextTargetNameUI;
		public Transform TextDescription;
		public Transform ButtonAction;
		public Transform PanelDescription;
        public Transform PanelDescriptionInside;
        public Transform ButtonActionShow;
        public Transform Panel_Text;

		public AudioSource soundTarget;
		public AudioClip clipTarget;

		// Use this for initialization
		void Start()
		{
			//add Audio Source as new game object component
			soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
		}

		// Update is called once per frame
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

				TextTargetName.GetComponent<Text>().text = name;
                Panel_Text.GetComponent<Text>().text = name;
				TextTargetNameUI.GetComponent<Text>().text = name;
				ButtonAction.gameObject.SetActive(true);
				TextDescription.gameObject.SetActive(true);

				PanelDescription.gameObject.SetActive(true);
                PanelDescriptionInside.gameObject.SetActive(true);
                ButtonActionShow.gameObject.SetActive(true);


				if (name == "Mercury")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mercury_final"); });
					TextDescription.GetComponent<Text>().text = "   The smallest planet in our solar system and the nearest to the Sun. " +
						"Mercury is only slightly larger than the Earth's moon. From the surface of Mercury, the Sun would appear more than three " +
						"times as large as it does when viewed from Earth and the sunlight would be as much as 11 times brighter." +
						"\nAge: 4.503 billion years" +
						"\nRadius(Size): 2,440 km" +
						"\nDistance from Sun: 57.91 million km" +
						"\nNumber of moon/s: no moon";
				}
				if (name == "Venus")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Venus_final"); });
					TextDescription.GetComponent<Text>().text = "   The second planet from the Sun and our closest planetary neighbor. Venus " +
						"is similar in structure and size to Earth. Venus spins slowly in the opposite direction most planets do. Its thick atmosphere " +
						"traps heat with greenhouse effect, making it the hottest planet in our solar system." +
						"\nAge: 4.503 billion years" +
						"\nRadius(Size): 6,052 km " +
						"\nDistance from Sun: 108.2 million km" +
						"\nNumber of moon/s: no moon";
				}
				if (name == "Earth")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Earth_final"); });
					TextDescription.GetComponent<Text>().text = "   Our home planet is the third planet from the Sun and the only planet we know " +
						"so far that is inhabited by living things. It is the only world in our solar system with liquid water on the surface. It is just " +
						"slightly larger than nearby Venus. " +
						"\nAge: 4.543 billion years" +
						"\nRadius(Size): 6,371 km " +
						"\nDistance from Sun: 149.6 million km" +
						"\nNumber of moon/s: 1 moon";
				}
				if (name == "Mars")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Mars_final"); });
					TextDescription.GetComponent<Text>().text = "   The fourth planet, and it is a dusty,cold, dessert world with a very thin atmosphere. " +
						"This dynamic planet has seasons, polar ice caps, extinct volcanoes, canyons and weather. Mars is one of the most explored bodies in our " +
						"solar system and it is the only planet where we've sent rovers to roam the alien landscape. " +
						"\nAge: 4.603 billion years" +
						"\nRadius(Size): 3,390 km" +
						"\nDistance from Sun: 227.9 million km" +
						"\nNumber of moon/s: 2 moons (Phobos and Deimos)";
				}
				if (name == "Jupiter")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Jupiter_final"); });
					TextDescription.GetComponent<Text>().text = "   The fifth planet from the Sun and is, by far, the largest planet in the solar system. " +
						"It is more than twice as massive as all the other planets combined. Jupiter's stripes and swirls are actually cold. windy clouds of ammonia " +
						"and water, floating in an atmosphere of hydrogen and helium. Jupiter's iconic Great Red Spot is a giant " +
						"storm bigger than Earth that has raged for hundreds of years." +
						"\nAge: 4.503 billion years" +
						"\nRadius(Size): 69,911 km" +
						"\nDistance from Sun: 778.5 million km" +
						"\nNumber of moon/s: 79 moons";
				}
				if (name == "Saturn")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Saturn_final"); });
					TextDescription.GetComponent<Text>().text = "   The sixth planet from the Sun and the second largest planet in our solar system. Adorned with " +
						"a dazzling system of icy rings, Saturn is unique among the planets. It is not the only planet to have rings but none are as spectacular or as " +
						"complex as Saturn. Saturn is home to some of the most fascinating landscapes in our solar system." +
						"\nAge: 4.503 billion years" +
						"\nRadius(Size): 58,232 km" +
						"\nDistance from Sun: 1.443 billion km" +
						"\nNumber of moon/s: 62 moons";
				}
				if (name == "Uranus")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Uranus_final"); });
					TextDescription.GetComponent<Text>().text = "   The seventh planet from the Sun and the third largest planet in our solar system. Uranus is " +
						"very cold and windy. The ice giant is surrounded by 13 faint rings and 27 small moons as it rotates at a nearby 90 degree angle from the plane of " +
						"its orbit. This unique tilt make Uranus appear to spin on its side, orbiting the Sun like a rolling ball." +
						"\nAge: 4.503 billion years" +
						"\nRadius(Size): 25,362 km" +
						"\nDistance from Sun: 2.871 billion km" +
						"\nNumber of moon/s: 27 moons";
					
				}
				if (name == "Neptune")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Neptune_final"); });
					TextDescription.GetComponent<Text>().text = "   Dark, cold and whipped by supersonic winds, ice giant Neptune is the eighth and the most " +
						"distant planet in our solar system. More than 30 times as far from the Sun as Earth. Neptune is the only planet in our solar system that is not visible " +
						"to the naked eye. Neptune is so far from the Sun that high noon on the big blue planet would seem like dim twilight to us." +
						"\nAge: 4.503 billion years" +
						"\nRadius(Size): 24,622 km" +
						"\nDistance from the Sun: 4.492 billion km" +
						"\nNumber of moon/s: 14 moons";
				}
				if (name == "Sun")
				{
					ButtonAction.GetComponent<Button>().onClick.AddListener(delegate { playSound("sounds/Sun_final"); });
					TextDescription.GetComponent<Text>().text = "   The Sun is the star at the center of the Solar System. It is a nearly perfect sphere of hot plasma, with " +
						"internal convective motion that generates a magnetic field via a dynamo process. " +
						"\nAge: 4.5 billion years" +
						"\nRadius(Size): 695,508 km";
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
