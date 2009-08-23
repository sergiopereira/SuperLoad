using System;
using System.Web.Mvc;

namespace JQuerySuperLoad
{
	public class SuperLoadAjaxContent
	{
		public SuperLoadAjaxContent(string selector, SuperLoadCommand updateCommand, Func<ActionResult> getResult)
		{
			Command = updateCommand;
			Selector = selector;
			GetResult = getResult;
		}

		public string Selector { get; set; }
		public SuperLoadCommand Command { get; set; }
		public Func<ActionResult> GetResult { get; set; }
	}
}