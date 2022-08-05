[System.Serializable]
public abstract class ItemObject
{
    public string Name;
    public string FlavorText;

    public abstract void OnActivate();
}
