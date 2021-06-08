using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_House
{
    class Complaint
    {
        public static List<string[]> complaintlist = new List<string[]>();
        private string description;
        private DateTime time;

        public Complaint(string description, DateTime time)
        {
            complaintlist.Add(new string[] { description, time.ToString() });
        }

        public static void RemoveCom(int index)
        {
            Complaint.complaintlist.RemoveAt(index);
        }
        public static List<string[]> GetComplaints()
        {
            return complaintlist;
        }
    }
}
