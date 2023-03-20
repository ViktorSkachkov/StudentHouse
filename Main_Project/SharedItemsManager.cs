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


        public void CreateSharedItem(User organizer, string itemName, double itemPrice, int itemQuantity)
        {
            SharedItems sharedItem = new SharedItems(organizer, itemName, itemPrice, itemQuantity);
            this.sharedItems.Add(sharedItem);
        }
        public void DeleteSharedItem(User organizer, String itemName)
        {
            if(this.sharedItems.Exists(x => x.ItemName == itemName))
            {
                SharedItems si = this.sharedItems.Find(x => x.ItemName == itemName);
                if (si.Organizer == organizer)
                {
                    this.sharedItems.Remove(si);
                    throw new Exception("The item was successfully deleted!");
                }
                else
                {
                    throw new Exception("You can't delete this item because you are not the one who created it!");
                }
            }
            else
            {
                throw new Exception("A shared item with this name wasn't created!");
            }
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
