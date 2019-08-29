using UnityEngine;
using System;

public class MathUtil 
{
    public static Vector3 Parabola(Vector3 start, Vector3 end, float height, float t)
    {
        Func<float, float> f = x => -4 * height * x * x + 4 * height * x;

        var mid = Vector3.Lerp(start, end, t);

        return new Vector3(mid.x, f(t) + Mathf.Lerp(start.y, end.y, t), mid.z);
    }


    public static Vector3 CalculatedVelocity(Vector3 start, Vector3 end, float hight, float gravity)
    {
        float displacementY = end.y - start.y;
        Vector3 displacemnentXZ = new Vector3(end.x - start.x, 0, end.z - start.z);
        float time = Mathf.Sqrt(-2 * hight / gravity) + Mathf.Sqrt(2 * (displacementY - hight) / gravity);
        Vector3 velocityY = Vector3.up * Mathf.Sqrt(-2 * gravity * hight);
        Vector3 velocityXZ = displacemnentXZ /time;
        return velocityXZ + velocityY * - Mathf.Sign(gravity);
    }
}
