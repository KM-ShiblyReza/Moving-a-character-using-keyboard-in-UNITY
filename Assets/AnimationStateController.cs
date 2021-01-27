using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    int isWavingHash;
    int isDancingHash;
    int isClappingHash;
    int isBowingHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        //Increasing Preformance
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isWavingHash = Animator.StringToHash("isWaving");
        isDancingHash = Animator.StringToHash("isDancing");
        isClappingHash = Animator.StringToHash("isClapping");
        isBowingHash = Animator.StringToHash("isBowing");

    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWaving = animator.GetBool(isWavingHash);
        bool isDancing = animator.GetBool(isDancingHash);
        bool isClapping = animator.GetBool(isClappingHash);
        bool isBowing = animator.GetBool(isBowingHash);
        bool waving = Input.GetKey("1");
        bool dancing = Input.GetKey("2");
        bool clapping = Input.GetKey("3");
        bool bowing = Input.GetKey("4");
        bool walking = Input.GetKey("5");
        bool running = Input.GetKey("6");


        // When Button 1 Is Pressed.
        if (!isWaving && waving)
        {
            // Setting isWaving1 Boolean To True.
            animator.SetBool(isWavingHash, true);

        }
        // When Button 1 Isn't Pressed.
        if (isWaving && !waving)
        {
            // Setting isWaving1 Boolean To False.
            animator.SetBool(isWavingHash, false);

        }

        // When Button 2 Is Pressed.
        if (!isDancing && dancing)
        {
            // Setting isDancing Boolean To True.
            animator.SetBool(isDancingHash, true);
        }
        // When Button 2 Isn't Pressed.
        if (isDancing && !dancing)
        {
            // Setting isDancing Boolean To False.
            animator.SetBool(isDancingHash, false);
        }

        // When Button 3 Is Pressed.
        if (!isClapping && clapping)
        {
            // Setting isClapping Boolean To True.
            animator.SetBool(isClappingHash, true);
        }
        // When Button 3 Isn't Pressed.
        if (isClapping && !clapping)
        {
            // Setting isClapping Boolean To False.
            animator.SetBool(isClappingHash, false);
        }
        // When Button 4 Is Pressed.
        if (!isBowing && bowing)
        {
            // Setting isBowing Boolean To True.
            animator.SetBool(isBowingHash, true);
        }
        // When Button 4 Isn't Pressed.
        if (isBowing && !bowing)
        {
            // Setting isBowing Boolean To False.
            animator.SetBool(isBowingHash, false);
        }

        // When Button 5 Is Pressed.
        if (!isWalking && walking)
        {
            // Setting isWalking Boolean To True.
            animator.SetBool(isWalkingHash, true);
        }
        // When Button 5 Isn't Pressed.
        if (isWalking && !walking)
        {
            // Setting isWalking Boolean To False.
            animator.SetBool(isWalkingHash, false);
        }

        // When Button 6 Is Pressed.
        if (!isRunning && running)
        {
            // Setting isRunning Boolean To True.
            animator.SetBool(isRunningHash, true);
        }
        // When Button 6 Isn't Pressed.
        if (isRunning && !running)
        {
            // Setting isRunning Boolean To False.
            animator.SetBool(isRunningHash, false);
        }


    }
}
