using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_House
{
    public class SharedItemsManager
    {
        private List<SharedItems> sharedItems;
        public SharedItemsManager()
        {
            this.sharedItems = new List<SharedItems>();
        }


        public void CreateSharedItem(int studentNumber, string itemName, double itemPrice, int itemQuantity)
        {
            SharedItems sharedItem = new SharedItems(studentNumber, itemName, itemPrice, itemQuantity);
            this.sharedItems.Add(sharedItem);
        }

        public List<SharedItems> GetSharedItems()
        {
            return this.sharedItems;
            
        }

        

        public double splittingAmmount(double allPrice, int numberOfStudents) {
            double partOfPrice = allPrice/numberOfStudents;
            return partOfPrice;
        }

    }
}
