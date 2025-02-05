namespace MentorLake.Gtk3.Gtk3;

public class GtkExpanderHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkExpanderHandle New(string label)
	{
		return GtkExpanderExterns.gtk_expander_new(label);
	}

	public static GtkExpanderHandle NewWithMnemonic(string label)
	{
		return GtkExpanderExterns.gtk_expander_new_with_mnemonic(label);
	}

}

public static class GtkExpanderSignalExtensions
{

	public static IObservable<GtkExpanderSignalStructs.ActivateSignal> Signal_Activate(this GtkExpanderHandle instance)
	{
		return Observable.Create((IObserver<GtkExpanderSignalStructs.ActivateSignal> obs) =>
		{
			GtkExpanderSignalDelegates.activate handler = (GtkExpanderHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkExpanderSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkExpanderSignalStructs
{

public struct ActivateSignal
{
	public GtkExpanderHandle Self;
	public IntPtr UserData;
}
}

public static class GtkExpanderSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkExpanderHandle>))] GtkExpanderHandle self, IntPtr user_data);

}


public static class GtkExpanderHandleExtensions
{
	public static bool GetExpanded(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_expanded(expander);
	}

	public static string GetLabel(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_label(expander);
	}

	public static bool GetLabelFill(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_label_fill(expander);
	}

	public static GtkWidgetHandle GetLabelWidget(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_label_widget(expander);
	}

	public static bool GetResizeToplevel(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_resize_toplevel(expander);
	}

	public static int GetSpacing(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_spacing(expander);
	}

	public static bool GetUseMarkup(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_use_markup(expander);
	}

	public static bool GetUseUnderline(this GtkExpanderHandle expander)
	{
		return GtkExpanderExterns.gtk_expander_get_use_underline(expander);
	}

	public static T SetExpanded<T>(this T expander, bool expanded) where T : GtkExpanderHandle
	{
		GtkExpanderExterns.gtk_expander_set_expanded(expander, expanded);
		return expander;
	}

	public static T SetLabel<T>(this T expander, string label) where T : GtkExpanderHandle
	{
		GtkExpanderExterns.gtk_expander_set_label(expander, label);
		return expander;
	}

	public static T SetLabelFill<T>(this T expander, bool label_fill) where T : GtkExpanderHandle
	{
		GtkExpanderExterns.gtk_expander_set_label_fill(expander, label_fill);
		return expander;
	}

	public static T SetLabelWidget<T>(this T expander, GtkWidgetHandle label_widget) where T : GtkExpanderHandle
	{
		GtkExpanderExterns.gtk_expander_set_label_widget(expander, label_widget);
		return expander;
	}

	public static T SetResizeToplevel<T>(this T expander, bool resize_toplevel) where T : GtkExpanderHandle
	{
		GtkExpanderExterns.gtk_expander_set_resize_toplevel(expander, resize_toplevel);
		return expander;
	}

	public static T SetSpacing<T>(this T expander, int spacing) where T : GtkExpanderHandle
	{
		GtkExpanderExterns.gtk_expander_set_spacing(expander, spacing);
		return expander;
	}

	public static T SetUseMarkup<T>(this T expander, bool use_markup) where T : GtkExpanderHandle
	{
		GtkExpanderExterns.gtk_expander_set_use_markup(expander, use_markup);
		return expander;
	}

	public static T SetUseUnderline<T>(this T expander, bool use_underline) where T : GtkExpanderHandle
	{
		GtkExpanderExterns.gtk_expander_set_use_underline(expander, use_underline);
		return expander;
	}

}

internal class GtkExpanderExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkExpanderHandle gtk_expander_new(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkExpanderHandle gtk_expander_new_with_mnemonic(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_expander_get_expanded(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_expander_get_label(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_expander_get_label_fill(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_expander_get_label_widget(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_expander_get_resize_toplevel(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_expander_get_spacing(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_expander_get_use_markup(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_expander_get_use_underline(GtkExpanderHandle expander);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_expander_set_expanded(GtkExpanderHandle expander, bool expanded);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_expander_set_label(GtkExpanderHandle expander, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_expander_set_label_fill(GtkExpanderHandle expander, bool label_fill);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_expander_set_label_widget(GtkExpanderHandle expander, GtkWidgetHandle label_widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_expander_set_resize_toplevel(GtkExpanderHandle expander, bool resize_toplevel);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_expander_set_spacing(GtkExpanderHandle expander, int spacing);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_expander_set_use_markup(GtkExpanderHandle expander, bool use_markup);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_expander_set_use_underline(GtkExpanderHandle expander, bool use_underline);

}
