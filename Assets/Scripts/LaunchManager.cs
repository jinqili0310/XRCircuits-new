using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.MagicLeap;


namespace MagicLeap
{
    public class LaunchManager : MonoBehaviour
    {
        public ImageTrackingVisualizer imageTrackingVisualizer;

        public int NextCurrentValue;
        public int NextResistanceValue;


        public void LaunchButton()
        {
            if (NextResistanceValue == 1)
            {
                imageTrackingVisualizer._videoBase.SetActive(false);
                imageTrackingVisualizer._videoConf1.SetActive(true);
                imageTrackingVisualizer._videoConf2.SetActive(false);
                imageTrackingVisualizer._videoConf3.SetActive(false);

            }
            else if (NextResistanceValue == 2)
            {
                imageTrackingVisualizer._videoConf1.SetActive(false);
                imageTrackingVisualizer._videoBase.SetActive(false);
                imageTrackingVisualizer._videoConf2.SetActive(true);
                imageTrackingVisualizer._videoConf3.SetActive(false);

            }
            else if (NextResistanceValue == 3)
            {
                imageTrackingVisualizer._videoConf1.SetActive(false);
                imageTrackingVisualizer._videoBase.SetActive(false);
                imageTrackingVisualizer._videoConf2.SetActive(false);
                imageTrackingVisualizer._videoConf3.SetActive(true);

            }
        }

    }
}

