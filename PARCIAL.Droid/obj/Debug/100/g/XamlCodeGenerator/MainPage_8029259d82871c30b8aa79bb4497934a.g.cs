// <autogenerated />
#pragma warning disable 618  // Ignore obsolete members warnings
#pragma warning disable 105  // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers.Xaml;
using PARCIAL.Droid;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif UNO_REFERENCE_API
using _View = Windows.UI.Xaml.UIElement;
#elif NET461
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace PARCIAL.Pages
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public partial class MainPage : Windows.UI.Xaml.Controls.Page
	{
		private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			IsParsing = true
			;
			// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\MainPage.xaml (Line 1:2)
			Content = 
			new global::Windows.UI.Xaml.Controls.Grid
			{
				IsParsing = true
				,
				RowDefinitions = 
				{
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\MainPage.xaml (Line 13:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\MainPage.xaml (Line 14:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\MainPage.xaml (Line 15:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\MainPage.xaml (Line 16:14)
					}
					,
				}
				,
				// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\MainPage.xaml (Line 11:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						IsParsing = true
						,
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\MainPage.xaml (Line 18:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								IsParsing = true
								,
								Text = "Sistema de votación"/* string/, Sistema de votación, TextBlock/Text */,
								HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Center/* Windows.UI.Xaml.HorizontalAlignment/, Center, TextBlock/HorizontalAlignment */,
								Foreground = SolidColorBrushHelper.Black/* Windows.UI.Xaml.Media.Brush/, Black, TextBlock/Foreground */,
								FontSize = 30d/* double/, 30, TextBlock/FontSize */,
								Padding = new global::Windows.UI.Xaml.Thickness(10)/* Windows.UI.Xaml.Thickness/, 10, TextBlock/Padding */,
								// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\MainPage.xaml (Line 19:14)
							}
							.MainPage_8029259d82871c30b8aa79bb4497934a_XamlApply((MainPage_8029259d82871c30b8aa79bb4497934aXamlApplyExtensions.XamlApplyHandler1)(c4 => 
							{
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c4, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/MainPage.xaml");
								c4.CreationComplete();
							}
							))
							,
						}
					}
					.MainPage_8029259d82871c30b8aa79bb4497934a_XamlApply((MainPage_8029259d82871c30b8aa79bb4497934aXamlApplyExtensions.XamlApplyHandler2)(c5 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c5, 0/* int/, 0, Grid/Row */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c5, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/MainPage.xaml");
						c5.CreationComplete();
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						IsParsing = true
						,
						HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Center/* Windows.UI.Xaml.HorizontalAlignment/, Center, StackPanel/HorizontalAlignment */,
						Orientation = global::Windows.UI.Xaml.Controls.Orientation.Horizontal/* Windows.UI.Xaml.Controls.Orientation/, Horizontal, StackPanel/Orientation */,
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\MainPage.xaml (Line 21:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								IsParsing = true
								,
								Name = "WelcomeTextBlock",
								Text = "Welcome"/* string/, Welcome, TextBlock/Text */,
								FontSize = 60d/* double/, 60, TextBlock/FontSize */,
								Foreground = SolidColorBrushHelper.Red/* Windows.UI.Xaml.Media.Brush/, red, TextBlock/Foreground */,
								Padding = new global::Windows.UI.Xaml.Thickness(10)/* Windows.UI.Xaml.Thickness/, 10, TextBlock/Padding */,
								FontWeight = FontWeights.Bold/* Windows.UI.Text.FontWeight/, Bold, TextBlock/FontWeight */,
								// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\MainPage.xaml (Line 22:14)
							}
							.MainPage_8029259d82871c30b8aa79bb4497934a_XamlApply((MainPage_8029259d82871c30b8aa79bb4497934aXamlApplyExtensions.XamlApplyHandler1)(c6 => 
							{
								nameScope.RegisterName("WelcomeTextBlock", c6);
								this.WelcomeTextBlock = c6;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c6, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/MainPage.xaml");
								c6.CreationComplete();
							}
							))
							,
						}
					}
					.MainPage_8029259d82871c30b8aa79bb4497934a_XamlApply((MainPage_8029259d82871c30b8aa79bb4497934aXamlApplyExtensions.XamlApplyHandler2)(c7 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c7, 1/* int/, 1, Grid/Row */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c7, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/MainPage.xaml");
						c7.CreationComplete();
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.Frame
					{
						IsParsing = true
						,
						Name = "MyFrame",
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\MainPage.xaml (Line 24:10)
					}
					.MainPage_8029259d82871c30b8aa79bb4497934a_XamlApply((MainPage_8029259d82871c30b8aa79bb4497934aXamlApplyExtensions.XamlApplyHandler3)(c8 => 
					{
						nameScope.RegisterName("MyFrame", c8);
						this.MyFrame = c8;
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c8, 2/* int/, 2, Grid/Row */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c8, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/MainPage.xaml");
						c8.CreationComplete();
					}
					))
					,
				}
			}
			.MainPage_8029259d82871c30b8aa79bb4497934a_XamlApply((MainPage_8029259d82871c30b8aa79bb4497934aXamlApplyExtensions.XamlApplyHandler4)(c9 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c9, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/MainPage.xaml");
				c9.CreationComplete();
			}
			))
			;
			
			this
			.Apply((c10 => 
			{
				// Source C:\Projects\PARCIAL\PARCIAL.Shared\Pages\MainPage.xaml (Line 1:2)
				
				// WARNING Property c10.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.Apply((c11 => 
			{
				// Class PARCIAL.Pages.MainPage
				global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c11, global::Windows.UI.Xaml.Controls.Page.BackgroundProperty, "ApplicationPageBackgroundThemeBrush", isThemeResourceExtension: true, context: global::PARCIAL.Droid.GlobalStaticResources.__ParseContext_);
				/* _isTopLevelDictionary:False */
				this._component_0 = c11;
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c11, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/MainPage.xaml");
				c11.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

			Bindings = new MainPage_Bindings(this);
			Loading += delegate
			{
				Bindings.UpdateResources();
			}
			;
		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Data.ElementNameSubject _WelcomeTextBlockSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.TextBlock WelcomeTextBlock
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_WelcomeTextBlockSubject.ElementInstance;
			}
			set
			{
				_WelcomeTextBlockSubject.ElementInstance = value;
			}
		}
		private global::Windows.UI.Xaml.Data.ElementNameSubject _MyFrameSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.Frame MyFrame
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Frame)_MyFrameSubject.ElementInstance;
			}
			set
			{
				_MyFrameSubject.ElementInstance = value;
			}
		}
		private global::Windows.UI.Xaml.Markup.ComponentHolder _component_0_Holder = new global::Windows.UI.Xaml.Markup.ComponentHolder();
		private global::Windows.UI.Xaml.Controls.Page _component_0
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.Page)_component_0_Holder.Instance;
			}
			set
			{
				_component_0_Holder.Instance = value;
			}
		}
		private interface IMainPage_Bindings
		{
			void Initialize();
			void Update();
			void UpdateResources();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private IMainPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class MainPage_Bindings : IMainPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private MainPage Owner { get => (MainPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private MainPage Owner { get; set; }
			#endif
			public MainPage_Bindings(MainPage owner)
			{
				Owner = owner;
			}
			void IMainPage_Bindings.Initialize()
			{
			}
			void IMainPage_Bindings.Update()
			{
				var owner = Owner;
			}
			void IMainPage_Bindings.UpdateResources()
			{
				var owner = Owner;
				owner._component_0.UpdateResourceBindings();
			}
			void IMainPage_Bindings.StopTracking()
			{
			}
		}
	}
}
namespace PARCIAL.Droid
{
	static class MainPage_8029259d82871c30b8aa79bb4497934aXamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.RowDefinition instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.RowDefinition MainPage_8029259d82871c30b8aa79bb4497934a_XamlApply(this global::Windows.UI.Xaml.Controls.RowDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.TextBlock instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBlock MainPage_8029259d82871c30b8aa79bb4497934a_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.StackPanel instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.StackPanel MainPage_8029259d82871c30b8aa79bb4497934a_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.Frame instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Frame MainPage_8029259d82871c30b8aa79bb4497934a_XamlApply(this global::Windows.UI.Xaml.Controls.Frame instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Grid MainPage_8029259d82871c30b8aa79bb4497934a_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
