using UnityEngine;

public class Tilegrid : MonoBehaviour
{
   public Tilerow[] rows {  get; private set; }

    public Tilecell[] cells { get; private set; }

    public int size => cells.Length;
    public int height => rows.Length;
    public int width => size/height;

    private void Awake()
    {
        rows = GetComponentsInChildren<Tilerow>();
        cells = GetComponentsInChildren<Tilecell>();
    }
    private void Start()
    {
        for (int i = 0; i < rows.Length; i++)
        {
            for (int j = 0; j < rows[i].cells.Length; j++)
            {
                rows[i]
            }
        } 

    
}
