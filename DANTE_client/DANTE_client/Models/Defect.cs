using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DANTE_client.Models
{
    public enum Status { New = 1, Open = 2, Closed = 3, Rejected = 4 }
    public enum Priority { High = 1, Medium = 2, Low = 3 }
    public enum Occurence { Always = 1, Once = 2, Sometimes = 3 }
    public class Defect
    {
        private int i_defectid;
        private string str_defectdevice;
        private string str_defecttitle;
        private string str_defectsupplier;
        private DateTime dt_defectdate;

        private Priority enum_defectpriority;
        private Status enum_defectstatus;
        private Occurence enum_defectoccurence;

        public Defect(int id, string device, string title, string supplier, DateTime date,
            Status status, Priority priority, Occurence occurence)
        {
            this.Defectid = id;
            this.defectdevice = device;
            this.Defectitle = title;
            this.Defectsupplier = supplier;
            this.Defectdate = date;
            this.enum_defectoccurence = occurence;
            this.enum_defectpriority = priority;
            this.enum_defectstatus = status;
        }

        public string getOccurence()
        {
            return this.enum_defectoccurence.ToString();
        }
        public string getPriority()
        {
            return this.enum_defectpriority.ToString();
        }
        public string getStatus()
        {
            return this.enum_defectstatus.ToString();
        }

        public int Defectid
        {
            get
            {
                return i_defectid;
            }

            set
            {
                i_defectid = value;
            }
        }

        public string defectdevice
        {
            get
            {
                return str_defectdevice;
            }

            set
            {
                str_defectdevice = value;
            }
        }

        public string Defectitle
        {
            get
            {
                return str_defecttitle;
            }

            set
            {
                str_defecttitle = value;
            }
        }

        public string Defectsupplier
        {
            get
            {
                return str_defectsupplier;
            }

            set
            {
                str_defectsupplier = value;
            }
        }

        public DateTime Defectdate
        {
            get
            {
                return dt_defectdate;
            }

            set
            {
                dt_defectdate = value;
            }
        }
    }
}