using UnityEngine;
[System.Serializable]
public class Gun : Item
{
    [SerializeField] private int maxDistance;
    [SerializeField] private int layerEnemyMask;
    [SerializeField] private int damage;
    public Gun(string name, int bullets, int maxDistance, int layerEnemyMask, int damage) : base(name)
    {
        this.bullets = bullets;
        this.maxDistance = maxDistance;
        this.layerEnemyMask = layerEnemyMask;
        this.damage = damage;
    }

    public override bool use(Vector3 shootPosition, Vector3 dir)
    {
        if (bullets>0)
        {
            bullets--;
            RaycastHit[] hits = Physics.RaycastAll(new Ray(shootPosition, dir), maxDistance, layerEnemyMask);
            if (hits != null)
            {
                foreach (RaycastHit hit in hits)
                {
                    IDamageable idamageable = hit.collider.gameObject.GetComponent<IDamageable>();
                    if (idamageable!=null)
                    {
                        idamageable.TakeDamage(damage);
                    }
                }
            }
            return true;
        }
        return false;
    }
}
