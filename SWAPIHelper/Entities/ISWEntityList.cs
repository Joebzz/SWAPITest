using System.Collections.Generic;

namespace SWAPIHelper.Entities
{
    interface ISWEntityList<T>
    {
        int count { get; set; }
        string next { get; set; }
        string previous { get; set; }
        List<T> results { get; set; }
    }
}