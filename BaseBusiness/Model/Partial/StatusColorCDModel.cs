
using System;
namespace BMS.Model
{
	public partial class StatusColorCDModel : BaseModel
	{
		[IsNotUse]
		public object this[string propertyName]
		{
			get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
			set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
		}

	}
}
	