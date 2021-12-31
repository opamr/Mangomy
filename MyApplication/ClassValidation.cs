using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPro;
namespace MyApplication
{
    class ClassValidation
    {
        public string Allow;
        public ClassValidation(int userId , int validationID)
        {
            if (userId == 1)
            {
                Allow = "yes";
            }
            else
            {
                TblValidationForUsers po = new TblValidationForUsers();
                po.Where.User_ID.Value = userId;
                po.Where.Validation_ID.Value = validationID;
                if (po.Query.Load())
                {
                    Allow = "yes";
                }
                else
                {
                    Allow = "no";
                }
            }
        }
    }
}
