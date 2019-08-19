using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
public class FactsTarget : MonoBehaviour {
		public Transform TextTargetNameFacts;
        public Transform TextTargetNamePanelFacts;
		public Transform TextDescriptionFacts;
		public Transform PanelDescriptionFacts;

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

				TextTargetNameFacts.GetComponent<Text>().text = name;
                TextTargetNamePanelFacts.GetComponent<Text>().text = name;
				TextDescriptionFacts.gameObject.SetActive(true);
				PanelDescriptionFacts.gameObject.SetActive(true);


				if(name == "Mercury"){
					TextDescriptionFacts.GetComponent<Text>().text = "Did you know? \n" +
						"\n1. Mercury is named after the Roman deity Mercury, the messenger of the gods." +
						"\n2. Mercury has no moon." +
						"\n3. Only two spacecraft have ever visited Mercury. The Mariner 10 and MESSENGER." +
						"\n4. A day on the surface of Mercury lasts 176 Earth days and A year on Mercury takes 88 Earth days.";
				}

				if (name == "Venus")
				{
					TextDescriptionFacts.GetComponent<Text>().text = "Did you know? \n" +
						"\n1. Venus is named for the ancient Roman goddess of love anf beauty." +
						"\n2. Venus has no moon." +
						"\n3. Venus is the hottest planet in our Solar System." +
						"\n4. Venus is often called the Earth's sister planet." +
						"\n5. Venus has the longest rotation period of any planet int he Solar System and rotates in the opposite direction to most other planets.";
				}

				if (name == "Earth")
				{
					TextDescriptionFacts.GetComponent<Text>().text = "Did you know? \n" +
						"\n1. Earth is the only planet not named after a god." +
						"\n2. There is only natural satellite of the planet Earth." +
						"\n3. The Earth was once believed to be the centre of the universe. " +
						"\n4. There is only one natural satellite of the planet Earth." +
						"\n5. The Earth is the densest planet in the Solar System.";
				}

				if (name == "Mars")
				{
					TextDescriptionFacts.GetComponent<Text>().text = "Did you know? \n" +
						"\n1. Befitting the red planet's bloody color, the Romans named Mars after their god of war, Ares." +
						"\n2. Only 18 missions to Mars have been successful." +
						"\n3. Mars is home to the tallest mountain in the solar system." +
						"\n4. Mars was once believed to be home to intelligent life." +
						"\n5. Pieces of Mars have been found on Earth." +
						"\n6. MArs has the largest dust storms in the solar system.";
				}

				if (name == "Jupiter")
				{
					TextDescriptionFacts.GetComponent<Text>().text = "Did you know? \n" +
						"\n1. Jupiter was named after the king of gods in Roman mythology. In a similar manner, the ancient Greeks named the planet after Zeus, the king of the Greek pantheon." +
						"\n2. Jupiter has a unique cloud features." +
						"\n3. Eight spcaecraft have visited Jupiter. The Pioneer 10 and 11, Voyager 1 and 2, Galileo, Cassini, Ulysses, and New Horizons missions. " +
						"\n4. The Great Red spot is a huge storm on Jupiter. ";
				}

				if (name == "Saturn")
				{
					TextDescriptionFacts.GetComponent<Text>().text = "Did you know? \n" +
						"\n1. Saturn is named after a character in Roman mythology. Saturn is named after the god Saturns, the god of agriculture and harvest." +
						"\n2. Saturn has oval-shaped storms similar to Jupiter." +
						"\n3. Saturn is made mostly of hydrogen." +
						"\n4. Saturn has the most extensive rings in the solar system. " +
						"\n5. Saturn is the flattest planet. " +
						"\n6. Four spacecraft have visited Saturn. The Pioneer 11, Voyager 1 and 2, and the Cassini-Hyugens missions.";
				}

				if (name == "Uranus")
				{
					TextDescriptionFacts.GetComponent<Text>().text = "Did you know? \n" +
						"\n1. The name Uranus was first proposed by German astronomer Johann Elert Bode." +
						"\n2. Uranus is often referred to as an ice giant planet." +
						"\n3. Uranus hits the coldest temperatures of any planet. " +
						"\n4. Uranus has two sets of very thin dark coloured rings." +
						"\n5. Only one spacecraft has flown by Uranus. It is the Voyager 2." +
						"\n6. It has 27 known moons, all of which are named after characters from the works of William Shakespeare and Alexander Pope.";
				}

				if (name == "Neptune")
				{
					TextDescriptionFacts.GetComponent<Text>().text = "Did you know? \n" +
						"\n1. In Roman Mythology, Neptune was the god of the sea." +
						"\n2. Neptune is the smallest of the ice giants. " +
						"\n3. Neptune has a very active climate. " +
						"\n4. Neptune has a very thin collection of rings." +
						"\n5. Only one spacecraft has flown by Neptune. It is the Voyager 2 spacecraft.";
				}

				if (name == "Pluto")
				{
					TextDescriptionFacts.GetComponent<Text>().text = "Did you know? \n" +
						"\n1. Pluto is named after the greek god of the underworld. " +
						"\n2. Pluto was reclassified from a planet to a dwarf planet in 2006." +
						"\n3. Pluto has been visited by one spacecraft. It is the New Horizons spacecraft." +
						"\n4. Pluto is the largest dwarf planet." +
						"\n5. Pluto is one third water. " +
						"\n6. Pluto has a eccentric and inclined orbit.";
				}

				if (name == "Sun") {
					TextDescriptionFacts.GetComponent<Text> ().text = "Did you know? \n" +
					"\n1. Sun was named after the God of Enlightenment, Apollo." +
					"\n2. As its centre, the Sun reaches temperatures of 15 million degrees C." +
					"\n3. The Sun is all the colours mized together, this appears white to our eyes." +
					"\n4. One million Earths could fit inside the Sun." +
					"\n5. The Sun is an almost perfect square.";
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
