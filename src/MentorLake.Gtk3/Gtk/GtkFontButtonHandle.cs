namespace MentorLake.Gtk;

public class GtkFontButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle, GtkFontChooserHandle
{
	public static MentorLake.Gtk.GtkFontButtonHandle New()
	{
		return GtkFontButtonHandleExterns.gtk_font_button_new();
	}

	public static MentorLake.Gtk.GtkFontButtonHandle NewWithFont(string fontname)
	{
		return GtkFontButtonHandleExterns.gtk_font_button_new_with_font(fontname);
	}

}
public static class GtkFontButtonHandleSignalExtensions
{

	public static IObservable<GtkFontButtonHandleSignalStructs.FontSetSignal> Signal_FontSet(this GtkFontButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFontButtonHandleSignalStructs.FontSetSignal> obs) =>
		{
			GtkFontButtonHandleSignalDelegates.font_set handler = ( MentorLake.Gtk.GtkFontButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFontButtonHandleSignalStructs.FontSetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "font-set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkFontButtonHandleSignalStructs.FontActivatedSignal> Signal_FontActivated(this GtkFontButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFontButtonHandleSignalStructs.FontActivatedSignal> obs) =>
		{
			GtkFontButtonHandleSignalDelegates.font_activated handler = ( MentorLake.Gtk.GtkFontChooserHandle self,  string fontname,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFontButtonHandleSignalStructs.FontActivatedSignal()
				{
					Self = self, Fontname = fontname, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "font-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkFontButtonHandleSignalStructs
{

public class FontSetSignal
{
	public MentorLake.Gtk.GtkFontButtonHandle Self;
	public IntPtr UserData;
}

public class FontActivatedSignal
{
	public MentorLake.Gtk.GtkFontChooserHandle Self;
	public string Fontname;
	public IntPtr UserData;
}
}

public static class GtkFontButtonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void font_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void font_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontChooserHandleImpl>))] MentorLake.Gtk.GtkFontChooserHandle self, string fontname, IntPtr user_data);

}


public static class GtkFontButtonHandleExtensions
{
	public static string GetFontName(this MentorLake.Gtk.GtkFontButtonHandle font_button)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_get_font_name(font_button);
	}

	public static bool GetShowSize(this MentorLake.Gtk.GtkFontButtonHandle font_button)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_get_show_size(font_button);
	}

	public static bool GetShowStyle(this MentorLake.Gtk.GtkFontButtonHandle font_button)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_get_show_style(font_button);
	}

	public static string GetTitle(this MentorLake.Gtk.GtkFontButtonHandle font_button)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_get_title(font_button);
	}

	public static bool GetUseFont(this MentorLake.Gtk.GtkFontButtonHandle font_button)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_get_use_font(font_button);
	}

	public static bool GetUseSize(this MentorLake.Gtk.GtkFontButtonHandle font_button)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_get_use_size(font_button);
	}

	public static bool SetFontName(this MentorLake.Gtk.GtkFontButtonHandle font_button, string fontname)
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		return GtkFontButtonHandleExterns.gtk_font_button_set_font_name(font_button, fontname);
	}

	public static T SetShowSize<T>(this T font_button, bool show_size) where T : GtkFontButtonHandle
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		GtkFontButtonHandleExterns.gtk_font_button_set_show_size(font_button, show_size);
		return font_button;
	}

	public static T SetShowStyle<T>(this T font_button, bool show_style) where T : GtkFontButtonHandle
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		GtkFontButtonHandleExterns.gtk_font_button_set_show_style(font_button, show_style);
		return font_button;
	}

	public static T SetTitle<T>(this T font_button, string title) where T : GtkFontButtonHandle
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		GtkFontButtonHandleExterns.gtk_font_button_set_title(font_button, title);
		return font_button;
	}

	public static T SetUseFont<T>(this T font_button, bool use_font) where T : GtkFontButtonHandle
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		GtkFontButtonHandleExterns.gtk_font_button_set_use_font(font_button, use_font);
		return font_button;
	}

	public static T SetUseSize<T>(this T font_button, bool use_size) where T : GtkFontButtonHandle
	{
		if (font_button.IsInvalid) throw new Exception("Invalid handle (GtkFontButtonHandle)");
		GtkFontButtonHandleExterns.gtk_font_button_set_use_size(font_button, use_size);
		return font_button;
	}

}

internal class GtkFontButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkFontButtonHandle gtk_font_button_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkFontButtonHandle gtk_font_button_new_with_font(string fontname);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_button_get_font_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_button_get_show_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_button_get_show_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_button_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_button_get_use_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_button_get_use_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_button_set_font_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button, string fontname);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_button_set_show_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button, bool show_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_button_set_show_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button, bool show_style);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_button_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_button_set_use_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button, bool use_font);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_button_set_use_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontButtonHandle>))] MentorLake.Gtk.GtkFontButtonHandle font_button, bool use_size);

}
