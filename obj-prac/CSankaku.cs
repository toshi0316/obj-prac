﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace obj_prac
{
    class CSankaku : CZukei
    {
      

        /** 三角形を作成*/
        public static void instantiateSankaku()
        {
            // 種類を三角形にする
            type.Add(TYPE.SANKAKU);
           
            // 高さに1～10の乱数を求める
            takasa.Add(rand.Next(1, 11));
        }

        public override void calc()
        {
            return "三角形：底辺" + teihen[idx] + " 高さ" + takasa[idx] + "=" + (teihen[idx] * takasa[idx] / 2f);
        }
    }
}
