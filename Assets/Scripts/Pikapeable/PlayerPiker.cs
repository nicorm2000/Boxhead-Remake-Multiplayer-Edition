using System;
using UnityEngine;

public class PlayerPiker : MonoBehaviour
{
    [SerializeField] private LayerMask Pickapeablelayer;
    [SerializeField] private Player player;
    private void OnTriggerEnter(Collider other)
    {
        if (IsInLayerMask(other.gameObject,Pickapeablelayer))
        {
             player.Onpick(); Destroy(other.gameObject);
        }
    }

    public bool IsInLayerMask(GameObject obj, LayerMask layerMask)
    {
        return ((layerMask.value & (1 << obj.layer)) > 0);
    }
}
