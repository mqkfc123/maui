using System;

using System.Maui.CustomAttributes;
using System.Maui.Internals;

#if UITEST
using NUnit.Framework;
#endif


namespace System.Maui.Controls.Issues
{
	[Preserve(AllMembers = true)]
	[Issue(IssueTracker.Github, 1583, "NavigationPage.TitleIcon broken", PlatformAffected.Android | PlatformAffected.iOS | PlatformAffected.WinPhone)]
	public class Issue1583 : TestContentPage
	{
		protected override void  Init()
		{
			Title = "Test";
			BackgroundColor = Color.Pink;
			Content = new Label { Text = "Hello", AutomationId ="lblHello" };
			NavigationPage.SetTitleIconImageSource(this, "bank.png");
		}

#if UITEST
		[Test]
		public void Issue1583TitleIconTest ()
		{
			RunningApp.WaitForElement(q => q.Marked ("lblHello"));			
		}
#endif
	}
}

