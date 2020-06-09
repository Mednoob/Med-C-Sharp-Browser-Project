using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Timers;
using System.Windows.Threading;
using Jint;
using Jint.Native.Json;
using Jint.Parser;
using Jint.Runtime.Debugger;
using Jint.Runtime.Environments;
using CK.Core.Impl;
using CK;
using CK.Core;
using CK.Javascript;
using AdvancedStringBuilder;
using JavaScriptEngineSwitcher.Core.Resources;
using JavaScriptEngineSwitcher.V8;
using JavaScriptEngineSwitcher;
using JavaScriptEngineSwitcher.Core.Utilities;
using JavaScriptEngineSwitcher.Core.Constants;
using JavaScriptEngineSwitcher.Core.Extensions;
using JavaScriptEngineSwitcher.Core.Helpers;
using ScreenshotTaker;

namespace WFATests
{ 
	public partial class BrowserForm : Form
	{
		
		public BrowserForm()
		{
			InitializeComponent();
			this.Load += new EventHandler(BrowserForm_Load);
			webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
		}

		private void dispatcherTimer_Tick(object sender, EventArgs e)
		{ 
		
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void GoButton_Click(object sender, EventArgs e)
		{
			if (WebpageTextBox.Text == "")
			{
				string errornowebtext = "No webpage to be surfed!";
				ErrorLabel.Text = "" + errornowebtext;
				System.Threading.Thread.Sleep(3000);
				ErrorLabel.Text = "";
			}
			else
			{
				webBrowser1.Navigate(WebpageTextBox.Text);
			}
		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			string searchqueue = SearchQueueTextBox.Text;
			if (SearchEngineComboBox.Text == (""))
			{
				string errornosearchqueue = "No search queue to be searched!";
				ErrorLabel.Text = errornosearchqueue;
				System.Threading.Thread.Sleep(3000);
				ErrorLabel.Text = "";
			}
			else if (SearchEngineComboBox.SelectedItem == "Google")
			{
				string gugleserch = "https://www.google.com/search?q=" + searchqueue;
				webBrowser1.Navigate(gugleserch);
				WebpageTextBox.Text = gugleserch;
			}
			else if (SearchEngineComboBox.SelectedItem == "Bing")
			{
				string bingserch = "https://www.bing.com/search?q=" + searchqueue;
				webBrowser1.Navigate(bingserch);
				WebpageTextBox.Text = bingserch;
			}
			else if (SearchEngineComboBox.SelectedItem == "Yahoo")
			{
				string yhooserch = "https://search.yahoo.com/search?p=" + searchqueue;
				webBrowser1.Navigate(yhooserch);
				WebpageTextBox.Text = yhooserch;
			}
			else if (SearchEngineComboBox.SelectedItem == "DuckDuckGo")
			{
				string dckdckgoserch = "https://duckduckgo.com/?q=" + searchqueue;
				webBrowser1.Navigate(dckdckgoserch);
				WebpageTextBox.Text = dckdckgoserch;
			}
			else if (SearchEngineComboBox.SelectedItem == "Wikipedia")
			{
				string wikipedserch = "https://en.wikipedia.org/w/index.php?cirrusUserTesting=control&search=" + searchqueue;
				webBrowser1.Navigate(wikipedserch);

			}
			else if (SearchEngineComboBox.SelectedItem == "Youtube")
			{
				string ytserch = "https://www.youtube.com/results?search_query=" + searchqueue;
				webBrowser1.Navigate(ytserch);
				WebpageTextBox.Text = ytserch;
			}
			else if (SearchEngineComboBox.SelectedItem == "Academia.edu")
			{
				string academiaserch = "https://www.academia.edu/search?utf8=✓&q=" + searchqueue + "&q" + searchqueue;
				webBrowser1.Navigate(academiaserch);
				WebpageTextBox.Text = academiaserch;
			}
			else if (SearchEngineComboBox.SelectedItem == "osu!")
			{
				string osuserch = "https://osu.ppy.sh/home/search?mode=all&query=" + searchqueue;
				webBrowser1.Navigate(osuserch);
				WebpageTextBox.Text = osuserch;
			}
			else if (SearchEngineComboBox.SelectedItem == "osu! Beatmaps")
			{
				string osubmserch = "https://osu.ppy.sh/beatmapsets?q=" + searchqueue;
				webBrowser1.Navigate(osubmserch);
				WebpageTextBox.Text = osubmserch;
			}
			else if (SearchEngineComboBox.SelectedItem == "Github")
			{
				string githubserch = "https://github.com/search?q=" + searchqueue;
				webBrowser1.Navigate(githubserch);
				WebpageTextBox.Text = githubserch;
			}
			else if (SearchEngineComboBox.SelectedItem == "Ahmia")
			{
				string ahmiaserch = "https://ahmia.fi/search/?q=" + searchqueue;
				webBrowser1.Navigate(ahmiaserch);
				WebpageTextBox.Text = ahmiaserch;
			}
			else if (SearchEngineComboBox.SelectedItem == "WEBTOON")
			{
				string webtoonserch = "https://www.webtoons.com/search?keyword=" + searchqueue;
				webBrowser1.Navigate(webtoonserch);
				WebpageTextBox.Text = webtoonserch;
			}
		}

		private void WebpageTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void WebpageTextBox_Click(object sender, EventArgs e)
		{
			if (WebpageTextBox.Text == ("Webpage"))
			{
				string oof = "";
				WebpageTextBox.Text = (oof);
			}
		}

		private void WebpageTextBox_MouseCaptureChanged(object sender, EventArgs e)
		{
			
		}

		private void WebpageTextBox_MouseHover(object sender, EventArgs e)
		{
			
		}

		private void WebpageTextBox_MouseLeave(object sender, EventArgs e)
		{
			
		}

		private void SearchQueueTextBox_Click(object sender, EventArgs e)
		{
			if (SearchQueueTextBox.Text == "Search Queue")
			{
				string kui = "";
				SearchQueueTextBox.Text = ("" + kui);
			}
		}

		private void javasciptread(object sender, EventArgs e)
		{
			
		}

		private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
		{
			
		}

		private void BrowserForm_Load(object sender, EventArgs e)
		{
			string CurrentDirectory = Directory.GetCurrentDirectory();
			webBrowser1.Navigate(Path.Combine(CurrentDirectory, "Front1.html"));
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{

		}
	}
}
