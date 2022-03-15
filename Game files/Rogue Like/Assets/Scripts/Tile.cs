using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color primary, secondary;

    [SerializeField] private SpriteRenderer thisSprite;

    public void InitColor(bool isOffSet)
    {
        thisSprite.color = isOffSet ? primary : secondary;
    }
}
