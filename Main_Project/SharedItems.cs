using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Student_House
{
	public class SharedItems
	{
		private string itemName;
		private double itemPrice;
		private int itemQuantity;
		private User organizer;


		public SharedItems shared
		{
			get
			{
				return this.shared;
			}
		}

		public SharedItems(User organizer, string itemName, double itemPrice, int itemQuantity)
		{
			this.organizer = organizer;
			this.itemName = itemName;
			this.itemPrice = itemPrice;
			this.itemQuantity = itemQuantity;
		}

		public string ItemName
		{
			get { return this.itemName; }
			set { this.itemName = value; }
		}
		public User Organizer
        {
			get { return this.organizer; }
			private set { this.organizer = value; }
        }
		public double ItemPrice
		{
			get { return this.itemPrice; }
			set { this.itemPrice = value; }
		}




		public int ItemQuantity
		{
			get { return this.itemQuantity; }
			set { this.itemQuantity = value; }
		}

		public String Name
		{
			get { return this.organizer.FirstName; }
		}
		public int StudentNumber
		{
			get { return this.organizer.UserNumber; }
		}
		public override string ToString()
        {
            return $"{this.organizer.FirstName} || {this.itemName} || {this.ItemPrice} || {this.itemQuantity}";

        }
    }
}