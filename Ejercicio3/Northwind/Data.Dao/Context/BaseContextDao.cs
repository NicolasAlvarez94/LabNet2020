using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dao.Context
{
    public abstract class BaseContextDAO
    {
        
        public static NorthwindContext dbContext = null;
        
        public NorthwindContext GetSingleInstanceContext() {
            bool validateSingleInstance = dbContext == null;
            if (validateSingleInstance) {             
                dbContext = new NorthwindContext();
            }
            return dbContext;
        }



    }
}
