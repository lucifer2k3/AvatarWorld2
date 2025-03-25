using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicYSort : MonoBehaviour
{
    
    private int _baseSortingOrder;
    [SerializeField]private SortableSprite[] _sortableSprite;
    private float _ySortingOffset;
    [SerializeField]private Transform _sortOffsetMarker;
    void Start(){
        _ySortingOffset =transform.position.y- _sortOffsetMarker.position.y;
    }
    void FixedUpdate()
    {
        _baseSortingOrder = _sortOffsetMarker.GetSortingOrder();
        foreach (var sortableSprite in _sortableSprite){
            sortableSprite.spriteRenderer.sortingOrder =
                _baseSortingOrder +sortableSprite.relativeOrder;
        }
    }
    [Serializable]
    public struct SortableSprite{
        public SpriteRenderer spriteRenderer;
        public int relativeOrder;
        
    }
}
