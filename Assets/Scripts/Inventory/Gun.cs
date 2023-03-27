using UnityEngine;
public class Gun : Item
{
    private int bullets;
    private int maxDistance;
    private int layerEnemyMask;
    private int damage;
    public Gun(string name, int bullets) : base(name)
    {
        this.bullets = bullets;
    }

    public override bool use(Vector3 pos, Vector3 dir)
    {
        if (bullets>0)
        {
            bullets--;
            RaycastHit[] hits = Physics.RaycastAll(new Ray(pos, dir), maxDistance, layerEnemyMask);
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
