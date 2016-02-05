using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obj_prac
{
    class CSikaku : CZukei
    {
        private int idx;

        /** 四角形を作成*/
        public static void instantiateShikaku()
        {
            // 種類を四角形にする
            type.Add(TYPE.SHIKAKU);
            
            // 高さに1～99の乱数を求める
            takasa.Add(rand.Next(1, 11));
        }

        protected override void calc()
        {
           

            return "四角形：底辺" + teihen[idx] + " 高さ" + takasa[idx] + "=" + (takasa[idx] * teihen[idx]);
        }
    }
}
