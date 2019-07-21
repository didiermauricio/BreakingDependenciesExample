using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BreakingDependencies.Example
    {
    public class InformationService
    {
        public bool RequestInfomation(IDataReader dataReader)
        {
            //var Info = ReadUserInfoFromDB("123456");
            var info = dataReader.ReadUserInfoFromDB("123456");
            if (info == null)
                return false;
            else
                return true;
            
        }
        
    }
}
