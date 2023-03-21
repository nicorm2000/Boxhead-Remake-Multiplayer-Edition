using System;
using UnityEngine;

public class PlayerPiker : MonoBehaviour
{
    [SerializeField] private LayerMask Pickapeablelayer;
    private void OnTriggerEnter(Collider other)
    {
        if (IsInLayerMask(other.gameObject,Pickapeablelayer))
        {
            IPicapeable pic = this.gameObject.GetComponent<IPicapeable>();
            if (pic != null ) { pic.Onpick(); Destroy(other.gameObject); }
        }
    }

    public bool IsInLayerMask(GameObject obj, LayerMask layerMask)
    {
        return ((layerMask.value & (1 << obj.layer)) > 0);
    }
}
