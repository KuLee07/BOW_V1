using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BOW
{
    public class Detection
    {
        //周圍碰撞檢測:true通過,flase發生碰撞
        public bool LeaderDetection(int X,int Y,int Width ,int Height, DataTable WorldLocation)
        {
            int X_large = X + Width;
            int Y_large = Y + Height;

            int TmpeCount = WorldLocation.Rows.Count;
            for (int i = 0; i <= TmpeCount - 1; i++)
            {
                if (WorldLocation.Rows[i][0].ToString().Replace(" ","") == "Wall")
                {
                    if (X <= Convert.ToInt32(WorldLocation.Rows[i][2].ToString())) return false;
                    else if (X_large >= Convert.ToInt32(WorldLocation.Rows[i][4].ToString())) return false;
                    else if (Y <= Convert.ToInt32(WorldLocation.Rows[i][3].ToString())) return false;
                    else if (Y_large >= Convert.ToInt32(WorldLocation.Rows[i][5].ToString())) return false;
                }
                else if(WorldLocation.Rows[i][0].ToString().Replace(" ", "") != "Leader")
                {
                    int ObjectX = Convert.ToInt32(WorldLocation.Rows[i][2].ToString());
                    int ObjectY = Convert.ToInt32(WorldLocation.Rows[i][3].ToString());
                    int ObjectWidth = Convert.ToInt32(WorldLocation.Rows[i][4].ToString());
                    int ObjectHeight = Convert.ToInt32(WorldLocation.Rows[i][5].ToString());

                    if (X_large > ObjectX && X < ObjectX + ObjectWidth && Y_large > ObjectY && Y < ObjectY + ObjectHeight )
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //周圍碰撞檢測:true通過,flase發生碰撞
        public bool EnemyDetection(int X, int Y, int Width, int Height, DataTable WorldLocation)
        {
            int X_large = X + Width;
            int Y_large = Y + Height;

            int TmpeCount = WorldLocation.Rows.Count;
            for (int i = 0; i <= TmpeCount - 1; i++)
            {
                if (WorldLocation.Rows[i][0].ToString().Replace(" ", "") == "CityWall")
                {
                    int ObjectX = Convert.ToInt32(WorldLocation.Rows[i][2].ToString());
                    int ObjectY = Convert.ToInt32(WorldLocation.Rows[i][3].ToString());
                    int ObjectWidth = Convert.ToInt32(WorldLocation.Rows[i][4].ToString());
                    int ObjectHeight = Convert.ToInt32(WorldLocation.Rows[i][5].ToString());

                    if (X_large > ObjectX && X < ObjectX + ObjectWidth && Y_large > ObjectY && Y < ObjectY + ObjectHeight)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool BowToEnemyDetection(int X, int Y, int Width, int Height, string BowLocation)
        {
            int X_large = X + Width;
            int Y_large = Y + Height;

            int TmpeCount = BowLocation.Split(';').Length;
            string[] TempBowLocation = BowLocation.Split(';');

            for (int i = 0; i <= TmpeCount - 1; i++)
            {
                int ObjectX = Convert.ToInt32(TempBowLocation[i].Split(',')[1]);
                int ObjectY = Convert.ToInt32(TempBowLocation[i].Split(',')[2]);
                int ObjectWidth = Convert.ToInt32(TempBowLocation[i].Split(',')[3]);
                int ObjectHeight = Convert.ToInt32(TempBowLocation[i].Split(',')[4]);

                if (X_large > ObjectX && X < ObjectX + ObjectWidth && Y_large > ObjectY && Y < ObjectY + ObjectHeight)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
