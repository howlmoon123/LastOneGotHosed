using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(NPCMovement))]
[RequireComponent(typeof(GenerateGUID))]
public class NPC : MonoBehaviour
{
   
 
    private NPCMovement npcMovement;

    private void OnEnable()
    {
       
    }

    private void OnDisable()
    {
       
    }

    private void Awake()
    {
      
    }

    private void Start()
    {
        // get npc movement component
        npcMovement = GetComponent<NPCMovement>();
    }


}