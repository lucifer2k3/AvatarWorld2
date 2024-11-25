using UnityEngine;

public static class TransformExtensions{
    public static int GetSortingOrder(this Transform transform, float yOffset = 0f){
        return -(int)((transform.position.y+yOffset)*100);
    }
}