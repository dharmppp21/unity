using UnityEngine;

public class Tilerow : MonoBehaviour
{
    public Tilecell[] cells { get; private set; }

    private void Awake()
    {
        cells = GetComponentsInChildren<Tilecell>();
    }
}
