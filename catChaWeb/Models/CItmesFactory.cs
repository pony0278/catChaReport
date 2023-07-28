using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace catChaWeb.Models
{
    public class CItmesFactory
    {
        //呼叫所有包含機率的物品的方法
        public CItems 計算機率道具()
        {
            catchaEntities db = new catchaEntities();
            var datas = from p in db.Game_Product_Total
                        where p.Lottery_Probability !=0
                        select p;
            return "";
        }
    }
}