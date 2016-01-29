using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace obj_prac
{
    abstract class CZukei
    {
        /** 乱数*/
        public static Random rand = new Random();

        /** データの種類*/
        public enum TYPE
        {
            SHIKAKU,     // 四角形
            SANKAKU     // 三角形
        };
        /** 種類。処理を分けるのに利用する*/
        public TYPE type;
        /** 底辺*/
        public float teihen;
        /** 高さ*/
        public float takasa;

        public CZukei()
        {
            // 底辺に1～10の乱数を求める
            teihen.Add(rand.Next(1, 11));
        }

        public abstract calc(int ind);

        public static void calcAll(TextBox text)
        {

        }
    }
}
