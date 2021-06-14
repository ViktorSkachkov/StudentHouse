using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Student_House
{
	public class SharedItems
	{
		private int studentNumber;
		private string itemName;
		private double itemPrice;
		private int itemQuantity;



		public SharedItems shared
		{
			get
			{
				return this.shared;
			}
		}

		public SharedItems(int studentNumber, string itemName, double itemPrice, int itemQuantity)
		{
			this.studentNumber = studentNumber;
			this.itemName = itemName;
			this.itemPrice = itemPrice;
			this.itemQuantity = itemQuantity;
		}

		public string ItemName
		{
			get { return this.itemName; }
			set { this.itemName = value; }
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

		public int StudentNumber
		{
			get { return this.studentNumber; }
			set { this.studentNumber = value; }
		}

		public override string ToString()
        {
            return $"{this.studentNumber} || {this.itemName} || {this.ItemPrice} || {this.itemQuantity}";

        }






    }
}