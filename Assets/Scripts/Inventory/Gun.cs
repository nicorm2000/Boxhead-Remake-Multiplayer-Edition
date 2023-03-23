
public class Gun : Item
{
    private int bullets; 
    public Gun(string name, int bullets) : base(name)
    {
        this.bullets = bullets;
    }

    public override bool use()
    {
        if (bullets>0)
        {
            bullets--;
            return true;
        }
        return false;
    }
}
