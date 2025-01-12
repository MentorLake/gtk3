namespace MentorLake.Gtk3.Gtk3;

public class GtkFontButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle, GtkFontChooserHandle
{
	public static GtkFontButtonHandle New()
	{
		return GtkFontButtonExterns.gtk_font_button_new();
	}

	public static GtkFontButtonHandle NewWithFont(string fontname)
	{
		return GtkFontButtonExterns.gtk_font_button_new_with_font(fontname);
	}

}

public static class GtkFontButtonSignalExtensions
{

	public static IObservable<GtkFontButtonSignalStructs.FontSetSignal> Signal_FontSet(this GtkFontButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkFontButtonSignalStructs.FontSetSignal> obs) =>
		{
			GtkFontButtonSignalDelegates.font_set handler = (GtkFontButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFontButtonSignalStructs.FontSetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "font_set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkFontButtonSignalStructs
{

public struct FontSetSignal
{
	public GtkFontButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkFontButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void font_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFontButtonHandle>))] GtkFontButtonHandle self, IntPtr user_data);

}


public static class GtkFontButtonHandleExtensions
{
	public static string GetFontName(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_font_name(font_button);
	}

	public static bool GetShowSize(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_show_size(font_button);
	}

	public static bool GetShowStyle(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_show_style(font_button);
	}

	public static string GetTitle(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_title(font_button);
	}

	public static bool GetUseFont(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_use_font(font_button);
	}

	public static bool GetUseSize(this GtkFontButtonHandle font_button)
	{
		return GtkFontButtonExterns.gtk_font_button_get_use_size(font_button);
	}

	public static bool SetFontName(this GtkFontButtonHandle font_button, string fontname)
	{
		return GtkFontButtonExterns.gtk_font_button_set_font_name(font_button, fontname);
	}

	public static T SetShowSize<T>(this T font_button, bool show_size) where T : GtkFontButtonHandle
	{
		GtkFontButtonExterns.gtk_font_button_set_show_size(font_button, show_size);
		return font_button;
	}

	public static T SetShowStyle<T>(this T font_button, bool show_style) where T : GtkFontButtonHandle
	{
		GtkFontButtonExterns.gtk_font_button_set_show_style(font_button, show_style);
		return font_button;
	}

	public static T SetTitle<T>(this T font_button, string title) where T : GtkFontButtonHandle
	{
		GtkFontButtonExterns.gtk_font_button_set_title(font_button, title);
		return font_button;
	}

	public static T SetUseFont<T>(this T font_button, bool use_font) where T : GtkFontButtonHandle
	{
		GtkFontButtonExterns.gtk_font_button_set_use_font(font_button, use_font);
		return font_button;
	}

	public static T SetUseSize<T>(this T font_button, bool use_size) where T : GtkFontButtonHandle
	{
		GtkFontButtonExterns.gtk_font_button_set_use_size(font_button, use_size);
		return font_button;
	}

}

internal class GtkFontButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFontButtonHandle gtk_font_button_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFontButtonHandle gtk_font_button_new_with_font(string fontname);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_button_get_font_name(GtkFontButtonHandle font_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_font_button_get_show_size(GtkFontButtonHandle font_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_font_button_get_show_style(GtkFontButtonHandle font_button);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_button_get_title(GtkFontButtonHandle font_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_font_button_get_use_font(GtkFontButtonHandle font_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_font_button_get_use_size(GtkFontButtonHandle font_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_font_button_set_font_name(GtkFontButtonHandle font_button, string fontname);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_button_set_show_size(GtkFontButtonHandle font_button, bool show_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_button_set_show_style(GtkFontButtonHandle font_button, bool show_style);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_button_set_title(GtkFontButtonHandle font_button, string title);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_button_set_use_font(GtkFontButtonHandle font_button, bool use_font);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_button_set_use_size(GtkFontButtonHandle font_button, bool use_size);

}
