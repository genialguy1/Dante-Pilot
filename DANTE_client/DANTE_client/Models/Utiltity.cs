using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DANTE_client.Models
{
    public static class Utiltity
    {
        public static List<Defect> getDefectList()
        {
            List<Defect> lst_defect = new List<Defect>();

            Defect obj_defect = new Defect(81256, "HUG.High_ENG", "Browse does not load URL", "supplier 1",
                new DateTime(2018, 09, 15), Status.Rejected, Priority.High, Occurence.Sometimes);
            lst_defect.Add(obj_defect);

            obj_defect = new Defect(81257, "HUG.High_ENG", "global search resuls shows several time", "supplier 1",
                new DateTime(2018, 09, 15), Status.Open, Priority.High, Occurence.Always);
            lst_defect.Add(obj_defect);

            return lst_defect;
        }
    }
}