using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
namespace Contracts
{
    [ServiceContract(Name="MyCalculatorTest")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double x,double y);
    }
}
