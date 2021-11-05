using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ARInteraction : MonoBehaviour, ITrackableEventHandler
{
    TrackableBehaviour mTrackableBehaviour;
    protected OrderList orderInstance;
    public Canvas canvasRef;
    //public string scanName;

    void Awake(){
        orderInstance = OrderList.GetInstance();
    }

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();

        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

        canvasRef = GetComponentInChildren<Canvas>();
        if (canvasRef)
        {
            canvasRef.enabled = false;
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus){
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            orderInstance._targetName = mTrackableBehaviour.TrackableName;
            Debug.Log("El nombre es " + orderInstance._targetName);
            Debug.Log("ON");
            canvasRef.enabled = true;
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED && newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            Debug.Log("OFF");
            canvasRef.enabled = false;
        }
        else
        {
            Debug.Log("START");
        }
    }
}
