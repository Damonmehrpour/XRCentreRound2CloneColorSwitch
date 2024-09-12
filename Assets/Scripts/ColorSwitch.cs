using UnityEngine;

public class ColorSwitch : MonoBehaviour
{
    public SpriteRenderer sr;
    public Color CRed;
    public Color CBlue;
    public Color CGreen;
    public Color CPink;
    private int previousIndex = -1;
    public string CurrentColor;
    void Start()
    {
        SetColor(); 
    }
    public void SetColor() // Called to set a new color
    {
        int index;

        do
        {
            index = Random.Range(0, 4);
        } while (index == previousIndex);

        previousIndex = index;

        if (index == 0)
        {
            CurrentColor = "Blue";
            sr.color = CBlue;
        }
        else if (index == 1)
        {
            CurrentColor = "Green";
            sr.color = CGreen;
        }
        else if (index == 2)
        {
            CurrentColor = "Red";
            sr.color = CRed;
        }
        else if (index == 3)
        {
            CurrentColor = "Pink";
            sr.color = CPink;
        }
    }
}
