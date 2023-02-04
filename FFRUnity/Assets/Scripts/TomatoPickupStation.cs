using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoPickupStation : SeedPickupStation
{
    public GameObject seedVisualPrefab;

    public override void GivePlayerSeed(GameObject player)
    {
          Debug.Log("ahahahahaghahahahahahahaha");
        Vector3 pos = player.transform.position;
        pos.z -= 0.1f;
        Instantiate(seedVisualPrefab, pos, Quaternion.identity, player.transform); //create visual
        player.GetComponent<PlayerController>().SetCurrentSeed(new Tomato());
    }
}
