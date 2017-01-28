using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace WebApplication1
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		public string GetPageHTML(string url)
		{
			string PageHTML;
			HttpWebRequest resq = (HttpWebRequest)WebRequest.Create(url);

			WebResponse resp = resq.GetResponse();
			StreamReader sr = new StreamReader(resp.GetResponseStream(), System.Text.Encoding.UTF8);
			PageHTML = sr.ReadToEnd();
			resp.Close();
			return PageHTML;
		}

		public string GetPageHTML(string url, string region)
		{
			string PageHTML;
			HttpWebRequest resq = (HttpWebRequest)WebRequest.Create(url);

			WebResponse resp = resq.GetResponse();
			StreamReader sr = new StreamReader(resp.GetResponseStream(), System.Text.Encoding.UTF8);
			PageHTML = sr.ReadToEnd();
			resp.Close();
			//return PageHTML;


			var doc = new HtmlAgilityPack.HtmlDocument();
			doc.LoadHtml(PageHTML);

			HtmlAgilityPack.HtmlNode node = doc.QuerySelector(region);

			HtmlAgilityPack.HtmlNode DateNode = doc.QuerySelector(".comic-title-date");
			string ComicDate = DateNode.InnerText;
			ComicDate = ComicDate.Replace("            2017", "");
			ComicDate = ComicDate.Replace("\n", "");
			DateTime comicDate = Convert.ToDateTime(ComicDate);

			if (comicDate.Date == DateTime.Now.Date)
				return node.InnerHtml;
			else
				return "";
		}

		public string GetPageHTMLID(string url, string region)
		{
			string PageHTML;
			HttpWebRequest resq = (HttpWebRequest)WebRequest.Create(url);

			WebResponse resp = resq.GetResponse();
			StreamReader sr = new StreamReader(resp.GetResponseStream(), System.Text.Encoding.UTF8);
			PageHTML = sr.ReadToEnd();
			resp.Close();
			//return PageHTML;


			var doc = new HtmlAgilityPack.HtmlDocument();
			doc.LoadHtml(PageHTML);

			HtmlAgilityPack.HtmlNode node = doc.GetElementbyId(region);

			HtmlAgilityPack.HtmlNode DateNode = doc.GetElementbyId("comic-date");
			string ComicDate = DateNode.InnerText;
			DateTime comicDate = Convert.ToDateTime(ComicDate);

			if (comicDate.Date == DateTime.Now.Date)
				return node.InnerHtml;
			else
				return "";
		}
	}
}