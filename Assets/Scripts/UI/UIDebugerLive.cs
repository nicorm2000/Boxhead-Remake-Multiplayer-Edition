using System;
using UnityEngine;
using UnityEngine.UI;

public class UIDebugerLive : MonoBehaviour
{
    [SerializeField] private Button damagePlayer;
    [SerializeField] private Slider playerLive;
    [SerializeField] private Player player;
    private void Start()
    {
        damagePlayer.onClick.AddListener(() => { player.TakeDamage(1); });
        player.InitCanvasLive((float a) => playerLive.value = a);
    }
}
