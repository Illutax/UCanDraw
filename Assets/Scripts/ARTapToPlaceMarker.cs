using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using System;

public class ARTapToPlaceMarker : MonoBehaviour
{
    public ARRaycastManager arraycastManager;
    public GameObject placementIndicator;
    private ARSessionOrigin arOrigin;
    private Pose placementPose;
    private bool placementPoseIsValid = false;

    void Start()
    {
        arOrigin = FindObjectOfType<ARSessionOrigin>();
    }

   
    void Update()
    {
        UpdatePlacementpose();
        UpdatePlacementIndicator();
    }

    private void UpdatePlacementIndicator()
    {
       if (placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);

        }
       else
        {
            placementIndicator.SetActive(false);
        }
    }

    private void UpdatePlacementpose()
    {
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();

        arraycastManager.Raycast(screenCenter, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        placementPoseIsValid = hits.Count > 1;

        if (placementPoseIsValid)
        {
            placementPose = hits[0].pose;
        }

    }
}
