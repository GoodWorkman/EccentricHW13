using UnityEngine;

public abstract class Effect : ScriptableObject
{
    public string Name;
    [TextArea(1, 3)] 
    public string Description;
    public Sprite Sprite;
    public int Level = 0;

    private int _maxLevel = 10;

    public bool ReachedMaxLevel()
    {
        return Level >= _maxLevel;
    }

    public virtual void Activate()
    {
        Level++;
    }
}
