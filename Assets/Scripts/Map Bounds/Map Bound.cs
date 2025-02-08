using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapBound : MonoBehaviour
{
    public Tilemap[] mapTilemaps;
    public Transform player;

    private void LateUpdate()
    {
        Vector3 cameraPosition = transform.position;

        foreach (Tilemap tilemap in mapTilemaps)
        {
            if (tilemap.localBounds.Contains(tilemap.WorldToLocal(player.position)))
            {
                Bounds bounds = tilemap.localBounds;
                cameraPosition.x = Mathf.Clamp(cameraPosition.x, tilemap.transform.TransformPoint(bounds.min).x, tilemap.transform.TransformPoint(bounds.max).x);
                cameraPosition.y = Mathf.Clamp(cameraPosition.y, tilemap.transform.TransformPoint(bounds.min).y, tilemap.transform.TransformPoint(bounds.max).y);
                break;
            }
        }

        transform.position = cameraPosition;
    }
}
