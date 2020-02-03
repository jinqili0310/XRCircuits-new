using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.MagicLeap;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace MagicLeap
{
    public class instructorControl : MonoBehaviour
    {
        public GameObject InstructorVideo;

        bool InsIsOn = false;

        public ImageTrackingVisualizer imageTrackingVisualizer;

        void Start()
        {
            //InstructorVideo.SetActive(false);
            InsIsOn = false;
        }

        public void ShowInstructor()
        {
            if (InsIsOn == false)
            {
                InstructorVideo.SetActive(true);

                imageTrackingVisualizer._videoBase.SetActive(false);
                imageTrackingVisualizer._videoConf1.SetActive(false);
                imageTrackingVisualizer._videoConf2.SetActive(false);
                imageTrackingVisualizer._videoConf3.SetActive(false);

                InsIsOn = true;

            }
            else if (InsIsOn == true)
            {
                InstructorVideo.SetActive(false);

                imageTrackingVisualizer._videoBase.SetActive(true);

                InsIsOn = false;

            }


        }
    }
}
