using UnityEngine;

public class ExperienceLoot : Loot
{
    [SerializeField] private int _lootValue = 1;
    
    public override void TakeItem(Collector collector)
    {
        base.TakeItem(collector);
        collector.TakeExperience(_lootValue);
    }
}
