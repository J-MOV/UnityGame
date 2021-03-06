﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script belongs on dropped loot (in game)
public class Loot : MonoBehaviour
{
    public BaseItem itemStatsSO;
    LootCollected inGameInventory;

    Rigidbody rb;

    public ParticleSystem commonParticle, rareParticle, epicParticle, 
        legendaryParticle, mythicParticle;

    private void Start()
    {
        inGameInventory = FindObjectOfType<LootCollected>();
        rb = GetComponent<Rigidbody>();
    }

   /* private void OnEnable()
    {
        SetRarityColor(itemStatsSO.itemRarity);
    }*/

    public void SetRarityColor(ItemRarity rarity)
    {
        if(rarity == ItemRarity.Common)
        {
            //Common
            commonParticle.gameObject.SetActive(true);
        }
        else if(rarity == ItemRarity.Rare)
        {
            rareParticle.gameObject.SetActive(true);
        }
        else if (rarity == ItemRarity.Epic)
        {
            epicParticle.gameObject.SetActive(true);
        }
        else if (rarity == ItemRarity.Legendary)
        {
            legendaryParticle.gameObject.SetActive(true);
        }
        else if (rarity == ItemRarity.Mythic)
        {
            mythicParticle.gameObject.SetActive(true);
        }

    }

    

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + -Vector3.right * Time.deltaTime);
    }

    public void AddToInventory(LootCollected inventory)
    {
        inventory.loot.Add(itemStatsSO);
        Destroy(gameObject);
    }
}
