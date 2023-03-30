using UnityEngine;
[System.Serializable]

public class Gun : Item
{
    [SerializeField] private int maxDistance;
    [SerializeField] private int layerEnemyMask;
    [SerializeField] private int damage;
    [SerializeField] private float shootRate;
    private Timer timeToNextShot;
    private bool loockToShoot = true;
    public Gun(string name, int bullets, int maxDistance, int layerEnemyMask, int damage) : base(name)
    {
        this.bullets = bullets;
        this.maxDistance = maxDistance;
        this.layerEnemyMask = layerEnemyMask;
        this.damage = damage;
        timeToNextShot = new Timer();
        ResetShootDown();
    }
    private void ResetShootDown()
    {
        timeToNextShot.Pause();
        timeToNextShot.Start(1, () => { loockToShoot = false; }, 1, false);
        timeToNextShot.Resume();
    }
    public override void Update()
    {
        timeToNextShot.Update();
    }
    public override bool use(Vector3 shootPosition, Vector3 dir)
    {
        if (loockToShoot)
            return false;
        
        if (bullets>0)
        {
            bullets--;
            loockToShoot = true;
            ResetShootDown();
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
