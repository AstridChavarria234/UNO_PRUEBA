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
using PARCIAL.Skia.Wpf;

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
	public partial class LoginPage : Windows.UI.Xaml.Controls.Page
	{
		private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			IsParsing = true
			;
			// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 1:2)
			Content = 
			new global::Windows.UI.Xaml.Controls.Grid
			{
				IsParsing = true
				,
				RowDefinitions = 
				{
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 13:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 14:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 15:14)
					}
					,
				}
				,
				ColumnDefinitions = 
				{
					new global::Windows.UI.Xaml.Controls.ColumnDefinition
					{
						Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, ColumnDefinition/Width */,
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 18:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.ColumnDefinition
					{
						Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Auto)/* Windows.UI.Xaml.GridLength/, Auto, ColumnDefinition/Width */,
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 19:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.ColumnDefinition
					{
						Width = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, ColumnDefinition/Width */,
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 20:14)
					}
					,
				}
				,
				// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 11:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						IsParsing = true
						,
						// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 22:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								IsParsing = true
								,
								Text = "Login"/* string/, Login, TextBlock/Text */,
								FontSize = 20d/* double/, 20, TextBlock/FontSize */,
								HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Center/* Windows.UI.Xaml.HorizontalAlignment/, Center, TextBlock/HorizontalAlignment */,
								// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 23:14)
							}
							.LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply((LoginPage_42208210cc81610cb1c6c53dcf2685a9XamlApplyExtensions.XamlApplyHandler2)(c6 => 
							{
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c6, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/LoginPage.xaml");
								c6.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								IsParsing = true
								,
								Text = "Email"/* string/, Email, TextBlock/Text */,
								// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 24:14)
							}
							.LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply((LoginPage_42208210cc81610cb1c6c53dcf2685a9XamlApplyExtensions.XamlApplyHandler2)(c7 => 
							{
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c7, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/LoginPage.xaml");
								c7.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.TextBox
							{
								IsParsing = true
								,
								Name = "EmailTextBox",
								PlaceholderText = "Ingresa tu email..."/* string/, Ingresa tu email..., TextBox/PlaceholderText */,
								Margin = new global::Windows.UI.Xaml.Thickness(0,5)/* Windows.UI.Xaml.Thickness/, 0,5, TextBox/Margin */,
								// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 25:14)
							}
							.LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply((LoginPage_42208210cc81610cb1c6c53dcf2685a9XamlApplyExtensions.XamlApplyHandler3)(c8 => 
							{
								nameScope.RegisterName("EmailTextBox", c8);
								this.EmailTextBox = c8;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c8, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/LoginPage.xaml");
								c8.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								IsParsing = true
								,
								Text = "Password"/* string/, Password, TextBlock/Text */,
								// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 26:14)
							}
							.LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply((LoginPage_42208210cc81610cb1c6c53dcf2685a9XamlApplyExtensions.XamlApplyHandler2)(c9 => 
							{
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c9, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/LoginPage.xaml");
								c9.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.PasswordBox
							{
								IsParsing = true
								,
								Name = "PasswordPasswordBox",
								PlaceholderText = "Ingresa tu contraseña..."/* string/, Ingresa tu contraseña..., PasswordBox/PlaceholderText */,
								Margin = new global::Windows.UI.Xaml.Thickness(0,5)/* Windows.UI.Xaml.Thickness/, 0,5, PasswordBox/Margin */,
								// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 27:14)
							}
							.LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply((LoginPage_42208210cc81610cb1c6c53dcf2685a9XamlApplyExtensions.XamlApplyHandler4)(c10 => 
							{
								nameScope.RegisterName("PasswordPasswordBox", c10);
								this.PasswordPasswordBox = c10;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c10, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/LoginPage.xaml");
								c10.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.StackPanel
							{
								IsParsing = true
								,
								Orientation = global::Windows.UI.Xaml.Controls.Orientation.Horizontal/* Windows.UI.Xaml.Controls.Orientation/, Horizontal, StackPanel/Orientation */,
								Margin = new global::Windows.UI.Xaml.Thickness(0,10)/* Windows.UI.Xaml.Thickness/, 0,10, StackPanel/Margin */,
								HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Center/* Windows.UI.Xaml.HorizontalAlignment/, Center, StackPanel/HorizontalAlignment */,
								// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 28:14)
								Children = 
								{
									new global::Windows.UI.Xaml.Controls.Button
									{
										IsParsing = true
										,
										Content = @"Iniciar Sesión"/* object/, Iniciar Sesión, Button/Content */,
										Margin = new global::Windows.UI.Xaml.Thickness(5)/* Windows.UI.Xaml.Thickness/, 5, Button/Margin */,
										HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Stretch/* Windows.UI.Xaml.HorizontalAlignment/, Stretch, Button/HorizontalAlignment */,
										Background = SolidColorBrushHelper.Navy/* Windows.UI.Xaml.Media.Brush/, Navy, Button/Background */,
										Foreground = SolidColorBrushHelper.White/* Windows.UI.Xaml.Media.Brush/, White, Button/Foreground */,
										// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 29:18)
									}
									.LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply((LoginPage_42208210cc81610cb1c6c53dcf2685a9XamlApplyExtensions.XamlApplyHandler5)(c11 => 
									{
										var Click_LoginButton_Click_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
										/* second level */ c11.Click += (LoginButton_Click_sender,LoginButton_Click_e) => (Click_LoginButton_Click_That.Target as LoginPage)?.LoginButton_Click(LoginButton_Click_sender,LoginButton_Click_e);
										global::Uno.UI.FrameworkElementHelper.SetBaseUri(c11, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/LoginPage.xaml");
										c11.CreationComplete();
									}
									))
									,
									new global::Windows.UI.Xaml.Controls.Button
									{
										IsParsing = true
										,
										Content = @"Recuperar Contraseña"/* object/, Recuperar Contraseña, Button/Content */,
										Margin = new global::Windows.UI.Xaml.Thickness(5)/* Windows.UI.Xaml.Thickness/, 5, Button/Margin */,
										HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Stretch/* Windows.UI.Xaml.HorizontalAlignment/, Stretch, Button/HorizontalAlignment */,
										Background = SolidColorBrushHelper.Orange/* Windows.UI.Xaml.Media.Brush/, Orange, Button/Background */,
										Foreground = SolidColorBrushHelper.White/* Windows.UI.Xaml.Media.Brush/, White, Button/Foreground */,
										// Source ..\..\..\..\..\..\..\PARCIAL.Shared\Pages\LoginPage.xaml (Line 30:18)
									}
									.LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply((LoginPage_42208210cc81610cb1c6c53dcf2685a9XamlApplyExtensions.XamlApplyHandler5)(c12 => 
									{
										var Click_RecoverButton_Click_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
										/* second level */ c12.Click += (RecoverButton_Click_sender,RecoverButton_Click_e) => (Click_RecoverButton_Click_That.Target as LoginPage)?.RecoverButton_Click(RecoverButton_Click_sender,RecoverButton_Click_e);
										global::Uno.UI.FrameworkElementHelper.SetBaseUri(c12, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/LoginPage.xaml");
										c12.CreationComplete();
									}
									))
									,
								}
							}
							.LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply((LoginPage_42208210cc81610cb1c6c53dcf2685a9XamlApplyExtensions.XamlApplyHandler6)(c13 => 
							{
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c13, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/LoginPage.xaml");
								c13.CreationComplete();
							}
							))
							,
						}
					}
					.LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply((LoginPage_42208210cc81610cb1c6c53dcf2685a9XamlApplyExtensions.XamlApplyHandler6)(c14 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c14, 1/* int/, 1, Grid/Row */);
						global::Windows.UI.Xaml.Controls.Grid.SetColumn(c14, 1/* int/, 1, Grid/Column */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c14, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/LoginPage.xaml");
						c14.CreationComplete();
					}
					))
					,
				}
			}
			.LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply((LoginPage_42208210cc81610cb1c6c53dcf2685a9XamlApplyExtensions.XamlApplyHandler7)(c15 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c15, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/LoginPage.xaml");
				c15.CreationComplete();
			}
			))
			;
			
			this
			.Apply((c16 => 
			{
				// Source C:\Projects\PARCIAL\PARCIAL.Shared\Pages\LoginPage.xaml (Line 1:2)
				
				// WARNING Property c16.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.Apply((c17 => 
			{
				// Class PARCIAL.Pages.LoginPage
				global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c17, global::Windows.UI.Xaml.Controls.Page.BackgroundProperty, "ApplicationPageBackgroundThemeBrush", isThemeResourceExtension: true, context: global::PARCIAL.Skia.Wpf.GlobalStaticResources.__ParseContext_);
				/* _isTopLevelDictionary:False */
				this._component_0 = c17;
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c17, "file:///C:/Projects/PARCIAL/PARCIAL.Shared/Pages/LoginPage.xaml");
				c17.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

			Bindings = new LoginPage_Bindings(this);
			Loading += delegate
			{
				Bindings.UpdateResources();
			}
			;
		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Data.ElementNameSubject _EmailTextBoxSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.TextBox EmailTextBox
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBox)_EmailTextBoxSubject.ElementInstance;
			}
			set
			{
				_EmailTextBoxSubject.ElementInstance = value;
			}
		}
		private global::Windows.UI.Xaml.Data.ElementNameSubject _PasswordPasswordBoxSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.PasswordBox PasswordPasswordBox
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.PasswordBox)_PasswordPasswordBoxSubject.ElementInstance;
			}
			set
			{
				_PasswordPasswordBoxSubject.ElementInstance = value;
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
		private interface ILoginPage_Bindings
		{
			void Initialize();
			void Update();
			void UpdateResources();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private ILoginPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class LoginPage_Bindings : ILoginPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private LoginPage Owner { get => (LoginPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private LoginPage Owner { get; set; }
			#endif
			public LoginPage_Bindings(LoginPage owner)
			{
				Owner = owner;
			}
			void ILoginPage_Bindings.Initialize()
			{
			}
			void ILoginPage_Bindings.Update()
			{
				var owner = Owner;
			}
			void ILoginPage_Bindings.UpdateResources()
			{
				var owner = Owner;
				owner._component_0.UpdateResourceBindings();
			}
			void ILoginPage_Bindings.StopTracking()
			{
			}
		}
	}
}
namespace PARCIAL.Skia.Wpf
{
	static class LoginPage_42208210cc81610cb1c6c53dcf2685a9XamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.RowDefinition instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.RowDefinition LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply(this global::Windows.UI.Xaml.Controls.RowDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.ColumnDefinition instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.ColumnDefinition LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply(this global::Windows.UI.Xaml.Controls.ColumnDefinition instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.TextBlock instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBlock LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.TextBox instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBox LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply(this global::Windows.UI.Xaml.Controls.TextBox instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.PasswordBox instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.PasswordBox LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply(this global::Windows.UI.Xaml.Controls.PasswordBox instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler5(global::Windows.UI.Xaml.Controls.Button instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Button LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply(this global::Windows.UI.Xaml.Controls.Button instance, XamlApplyHandler5 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler6(global::Windows.UI.Xaml.Controls.StackPanel instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.StackPanel LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler6 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler7(global::Windows.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Grid LoginPage_42208210cc81610cb1c6c53dcf2685a9_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler7 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
