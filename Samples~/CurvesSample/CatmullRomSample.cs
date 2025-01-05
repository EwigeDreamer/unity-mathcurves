using System.Collections.Generic;
using UnityEngine;

namespace ED.Curves.Samples
{
    public class CatmullRomSample : MonoBehaviour
    {
        public List<Transform> points;

        private void OnDrawGizmos()
        {
            if (points.Count == 0) return;
            for (int i = 0; i < points.Count; ++i) {
                var a = points[i];
                var b = points[(i + 1) % points.Count];
                var c = points[(i + 2) % points.Count];
                var d = points[(i + 3) % points.Count];
                
                if (a && b && c && d)
                {
                    var color_tmp = Gizmos.color;
                    Gizmos.color = Color.yellow.SetA(0.5f);
                    Gizmos.DrawLine(a.position, b.position);
                    Gizmos.DrawLine(b.position, c.position);
                    Gizmos.DrawLine(c.position, d.position);
                    Gizmos.color = Color.Lerp(Color.green, Color.white, 0.25f);
                    for (int j = 0; j < 100; ++j)
                    {
                        var p1 = CatmullRomUtility.GetPointV3(a.position, b.position, c.position, d.position, j / 100f);
                        var p2 = CatmullRomUtility.GetPointV3(a.position, b.position, c.position, d.position, (j + 1) / 100f);
                        Gizmos.DrawLine(p1, p2);
                    }
                    Gizmos.color = Color.white.SetA(0.25f);
                    for (int j = 0; j < 10; ++j) {
                        CatmullRomUtility.GetPointV3(a.position, b.position, c.position, d.position, j / 10f, out var p, out var t);
                        Gizmos.DrawLine(p, p + t * 0.25f);
                    }
                    Gizmos.color = color_tmp;
                }
            }
        }
    }
}
