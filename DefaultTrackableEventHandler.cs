using UnityEngine;
using Vuforia;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Vuforia
{
    public class DefaultTrackableEventHandler : MonoBehaviour,
    ITrackableEventHandler
    {
        //------------Begin Sound----------
        public AudioSource soundTarget;
        public AudioClip clipTarget;
        private AudioSource[] allAudioSources;

        //function to stop all sounds
        void StopAllAudio()
        {
            allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
            foreach (AudioSource audioS in allAudioSources)
            {
                audioS.Stop();
            }
        }

        //function to play sound
        void playSound(string ss)
        {
            soundTarget.clip = clipTarget;
            soundTarget.loop = false;
            soundTarget.playOnAwake = false;
            soundTarget.Play();
        }

        //-----------End Sound------------

        public Transform TextTargetName;
        public Transform TextTargetNameUI;
        public Transform TextDescription;
        public Transform ButtonAction;
        public Transform PanelDescription;
        public Transform PanelDescriptionInside;
        public Transform ButtonActionShow;
        public Transform Panel_Text;

        //----2nd
        public Transform TextTargetNameFacts;
        public Transform TextTargetNamePanelFacts;
        public Transform TextDescriptionFacts;
        public Transform PanelDescriptionFacts;

        //---4th
        public Transform TextTargetNameMoon;
        public Transform TextTargetNamePanelMoon;
        public Transform TextDescriptionMoon;
        public Transform PanelDescriptionMoon;

        //-----------Start Canvas----------

        //--------

        #region PRIVATE_MEMBER_VARIABLES

        private TrackableBehaviour mTrackableBehaviour;
        public AudioSource Sounds;

        #endregion

        #region UNTIY_MONOBEHAVIOUR_METHODS

        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
            soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
            clipTarget = (AudioClip)Resources.Load("sounds/Kids");
        }

        #endregion

        #region PUBLIC_METHODS

        public void OnTrackableStateChanged(
            TrackableBehaviour.Status previousStatus,
            TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
                Sounds.Play();
            }
            else
            {
                OnTrackingLost();
                Sounds.Stop();
            }
        }

        #endregion

        #region PRIVATE_METHODS

        private void OnTrackingFound()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Enable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = true;
            }

            // Enable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = true;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");

            if (mTrackableBehaviour.TrackableName == "20180806_131643")
            {
                playSound("sounds/Kids");
            }
        }

        private void OnTrackingLost()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Disable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = false;
            }

            // Disable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = false;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            StopAllAudio();

            TextTargetName.GetComponent<Text>().text = "";
            Panel_Text.GetComponent<Text>().text = "";
            TextTargetNameUI.GetComponent<Text>().text = "";
            ButtonAction.gameObject.SetActive(false);
            TextDescription.gameObject.SetActive(false);
            PanelDescription.gameObject.SetActive(false);
            PanelDescriptionInside.gameObject.SetActive(false);
            ButtonActionShow.gameObject.SetActive(false);

            //----2nd
            TextTargetNameFacts.GetComponent<Text>().text = "";
            TextTargetNamePanelFacts.GetComponent<Text>().text = "";
            TextDescriptionFacts.gameObject.SetActive(false);
            PanelDescriptionFacts.gameObject.SetActive(false);

            //---4th
            TextTargetNameMoon.GetComponent<Text>().text = "";
            TextTargetNamePanelMoon.GetComponent<Text>().text = "";
            TextDescriptionMoon.gameObject.SetActive(false);
            PanelDescriptionMoon.gameObject.SetActive(false);

        }

        #endregion
    }
}
