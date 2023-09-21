namespace SLC_AS_TDP_1
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
    using System.Text;
    using Empower.Library.Room0;
    using Skyline.DataMiner.Automation;

    /// <summary>
    /// Represents a DataMiner Automation script.
    /// </summary>
	public class Script
	{
		/// <summary>
		/// The script entry point.
		/// </summary>
		/// <param name="engine">Link with SLAutomation process.</param>
		public void Run(IEngine engine)
		{
			engine.GenerateInformation("Hello world! blabla");

			var order = OrderFactory.CreateOrder("JansChange Order 1");
			order.Dispatch("Tobe Deprez");
        }
	}
}