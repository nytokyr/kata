using System.Collections.Generic;

namespace Christmas_Light
{

    public class Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public class ChristmasLights
    {
        public bool[,] _LightsMatrix { get; } = new bool[1000, 1000];

        public List<bool> ToggleLightsInArea(Point leftUpperCorner, Point downRightCorner)
        {
            List<bool> lstStatusResult = new List<bool>();
            for (int x = leftUpperCorner.X; x < downRightCorner.X; x++)
            {
                for (int y = leftUpperCorner.Y; y < downRightCorner.Y; y++)
                {
                    _LightsMatrix[x, y] = !_LightsMatrix[x, y];
                    lstStatusResult.Add(_LightsMatrix[x, y]);
                }
            }
            return lstStatusResult;
        }

        public List<bool> CheckLightStatus(Point leftUpperCorner, Point downRightCorner)
        {
            List<bool> lstStatus = new List<bool>();
            for (int x = leftUpperCorner.X; x < downRightCorner.X; x++)
            {
                for (int y = leftUpperCorner.Y; y < downRightCorner.Y; y++)
                {
                    lstStatus.Add(this._LightsMatrix[x, y]);
                }
            }

            return lstStatus;
        }
    }
}
