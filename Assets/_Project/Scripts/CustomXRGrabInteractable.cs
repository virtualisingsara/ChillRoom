using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using DG.Tweening;

public class CustomXRGrabInteractable : XRGrabInteractable
{
    AudioSource audioData;
    [SerializeField] private GameObject cat1;
    [SerializeField] private GameObject cat2;
    [SerializeField] private GameObject cat3;
    [SerializeField] private GameObject toy;
    [SerializeField] private Transform target; // Target to follow
    Vector3 initialPos = new Vector3(1.66f, 0.62f, 4.233f);
    Quaternion initialRot = new Quaternion(0, -0.537196338f, 0, 0.843457282f);
    Vector3 catPos;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);

        bool isDirectInteractor = interactor is XRDirectInteractor;
        if (isDirectInteractor)
        {
            cat1.GetComponent<ObjectLooker>().enabled = true;
        }

    }

    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);

        bool isDirectInteractor = interactor is XRDirectInteractor;
        if (isDirectInteractor)
        {
            cat1.GetComponent<ObjectLooker>().enabled = false;
            
        }

        toy.transform.position = initialPos;
        toy.transform.rotation = initialRot;
    }

    protected override void OnActivate(XRBaseInteractor interactor)
    {
        base.OnActivate(interactor);

        audioData.Play(0);

        cat1.GetComponent<AudioSource>().Play();

        //Revisar

        cat1.GetComponent<Animation>().Play("Walk");
        catPos = new Vector3(target.position.x, 0, target.position.z);
        cat1.transform.DOMove(catPos, 4);
      }

}
