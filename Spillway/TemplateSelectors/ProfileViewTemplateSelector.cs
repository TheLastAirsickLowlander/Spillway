﻿using Spillway.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Spillway.TemplateSelectors
{
	public class ProfileViewTemplateSelector : DataTemplateSelector
	{
		public DataTemplate Authorize { get; set; }
		public DataTemplate RequestToken { get; set; }
		public DataTemplate CurrentProfile { get; set; }

		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			//ProfileViewState valueToCompare = (ProfileViewState)VisualTreeHelper.GetParent(container).GetValue(ProfileViewStateAttachedProperty.ValueToCompareProperty);
			if (item != null)
			{
				var pvm = item as ProfileViewModel;
				if (pvm != null)
				{
					switch (pvm.ViewState)
					{
						case ProfileViewState.Authorize:
							return Authorize;
						case ProfileViewState.RequestToken:
							return RequestToken;
						case ProfileViewState.CurrentProfile:
							return CurrentProfile;
					}
				}
			}
			return base.SelectTemplate(item, container);
		}
	}
}
