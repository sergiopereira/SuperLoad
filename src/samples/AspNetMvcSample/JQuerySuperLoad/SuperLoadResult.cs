using System.Collections.Generic;
using System.Net.Mime;
using System.Web.Mvc;

namespace JQuerySuperLoad
{
	public class SuperLoadResult : ActionResult
	{
		public IEnumerable<SuperLoadAjaxContent> ContentItems { get; private set; }

		public SuperLoadResult(params SuperLoadAjaxContent[] contentItems)
		{
			ContentItems = new List<SuperLoadAjaxContent>();
			((List<SuperLoadAjaxContent>)ContentItems).AddRange(contentItems);
		}

		public override void ExecuteResult(ControllerContext context)
		{
			context.HttpContext.Response.ContentType = MediaTypeNames.Text.Html;

			context.HttpContext.Response.Write("<div class=\"ajax-response\">");
			foreach (var item in ContentItems)
			{
				context.HttpContext.Response.Write(string.Format("<div class=\"ajax-content\" title=\"{0} {1}\">",
				                                                 item.Command.CommandText, item.Selector));
				item.GetResult().ExecuteResult(context);
				context.HttpContext.Response.Write("</div>");
			}
			context.HttpContext.Response.Write( "</div>");
		}
	}
}