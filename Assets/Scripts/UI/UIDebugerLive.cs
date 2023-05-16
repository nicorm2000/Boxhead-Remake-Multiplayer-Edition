using System;
using UnityEngine;
using UnityEngine.UI;

public class UIDebugerLive : MonoBehaviour
{
    [SerializeField] private Button damagePlayer;
    [SerializeField] private Button damagePlayer2;
    [SerializeField] private Button damagePlayer3;
    [SerializeField] private Slider playerLive;
    [SerializeField] private Player player;
    private void Start()
    {
        damagePlayer.onClick.AddListener(() => { player.TakeDamage(1); });
        damagePlayer2.onClick.AddListener(() => { player.TakeDamage(10); });
        damagePlayer3.onClick.AddListener(() => { player.TakeDamage(20); });


        player.InitCanvasLive((float a) => playerLive.value = a); //this line need to use in new scripts whe life load.
    }
}
