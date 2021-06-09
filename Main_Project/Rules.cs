using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_House
{
    public class Rules
    {
        private List<String> rules;
        public Rules()
        {
            this.rules = new List<string>();
        }
        public void AddRule(String rule)
        {
                this.rules.Add(rule);
        }
        public bool CheckRule(String rule)
        {
            if (this.rules.Contains(rule))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RemoveRule(String rule)
        {
            this.rules.Remove(rule);
        }
        public void EditRule(int index, String oldRule, String newRule)
        {
            this.RemoveRule(oldRule);
            this.rules.Insert(index, newRule);
        }
        public List<String> GetRules
        {
            get { return this.rules; }
        }
    }
}
