using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPro;
using MyGeneration.dOOdads;

namespace MyApplication.StoreReview
{
    class ClassStoreReview
    {
        public double Plus = 0;
        public double Minuse = 0;       
        public ClassStoreReview(int MyReviewID)
        {
            TblStoreReviewSummary obj = new TblStoreReviewSummary();
            obj.Where.Review_Id.Value = MyReviewID;
            obj.Where.Detail_Type.Value = "زيادة";
            obj.Aggregate.Detail_Total.Function = AggregateParameter.Func.Sum;
            if (obj.Query.Load() && obj.s_Detail_Total != "")
            {
                Plus = double.Parse(obj.s_Detail_Total);
            }

            obj = new TblStoreReviewSummary();
            obj.Where.Review_Id.Value = MyReviewID;
            obj.Where.Detail_Type.Value = "عجز";
            obj.Aggregate.Detail_Total.Function = AggregateParameter.Func.Sum;
            if (obj.Query.Load() && obj.s_Detail_Total != "")
            {
                Minuse = double.Parse(obj.s_Detail_Total);
            }         
        }
    }
}
