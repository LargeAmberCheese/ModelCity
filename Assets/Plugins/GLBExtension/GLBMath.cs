using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GLBExtensions.Math
{
    public static class GLBMath
    {
        public static bool IsFull(this Vector2 ratio) => ratio.y != 0f && Mathf.Approximately(ratio.x, ratio.y);
    }
}