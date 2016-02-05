using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace obj_prac
{
    abstract class CZukei
    {
        /** 自分のインスタンス*/
        protected static List<CZukei> we = new List<CZukei>();

        /** 乱数*/
        protected static Random rand = new Random();

        /** データの種類*/
        protected enum TYPE
        {
            SHIKAKU,     // 四角形
            SANKAKU     // 三角形
        };

        /** 種類。処理を分けるのに利用する*/
        protected TYPE type;
        /** 底辺*/
        protected float teihen;
        /** 高さ*/
        protected float takasa;

        public CZukei()
        {
            // 底辺に1～10の乱数を求める
            teihen.Add(rand.Next(1, 11));
        }

        protected abstract void calc();
    }
}
