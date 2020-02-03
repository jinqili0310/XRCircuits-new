using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.MagicLeap;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace MagicLeap
{

public class ResistanceValue : MonoBehaviour
{
    public LaunchManager launchManager;
    public ChangeMenu changeMenu;

    public GameObject[] values;
    private int index;

        public ImageTrackingVisualizer imageTrackingVisualizer;

        public GameObject ValueSet;

        //public string ChosenCurrentValue;

        /*public void ClickValue()
        {
            launchManager = GameObject.FindObjectOfType<LaunchManager> ();

            //ChosenCurrentValue = EventSystem.current.currentSelectedGameObject.name;

            for (int i = 0; i < values.Length; i++)
            {
                if (i == index)
                    {
                        launchManager.NextResistanceValue = i + 1;
                    }
            }

                changeMenu.ChangeResistanceValue();

        }*/

        public void ClickOne()
        {
            imageTrackingVisualizer._videoBase.SetActive(false);
            imageTrackingVisualizer._videoConf1.SetActive(true);
            imageTrackingVisualizer._videoConf2.SetActive(false);
            imageTrackingVisualizer._videoConf3.SetActive(false);
            ValueSet.SetActive(false);
        }

        public void ClickTwo()
        {
            imageTrackingVisualizer._videoConf1.SetActive(false);
            imageTrackingVisualizer._videoBase.SetActive(false);
            imageTrackingVisualizer._videoConf2.SetActive(true);
            imageTrackingVisualizer._videoConf3.SetActive(false);
            ValueSet.SetActive(false);
        }

        public void ClickThree()
        {
            imageTrackingVisualizer._videoConf1.SetActive(false);
            imageTrackingVisualizer._videoBase.SetActive(false);
            imageTrackingVisualizer._videoConf2.SetActive(false);
            imageTrackingVisualizer._videoConf3.SetActive(true);
            ValueSet.SetActive(false);
        }
}

}