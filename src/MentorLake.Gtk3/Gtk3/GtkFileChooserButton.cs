namespace MentorLake.Gtk3.Gtk3;

public class GtkFileChooserButtonHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFileChooserHandle, GtkOrientableHandle
{
	public static GtkFileChooserButtonHandle New(string title, GtkFileChooserAction action)
	{
		return GtkFileChooserButtonExterns.gtk_file_chooser_button_new(title, action);
	}

	public static GtkFileChooserButtonHandle NewWithDialog(GtkWidgetHandle dialog)
	{
		return GtkFileChooserButtonExterns.gtk_file_chooser_button_new_with_dialog(dialog);
	}

}

public static class GtkFileChooserButtonSignalExtensions
{

	public static IObservable<GtkFileChooserButtonSignalStructs.FileSetSignal> Signal_FileSet(this GtkFileChooserButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkFileChooserButtonSignalStructs.FileSetSignal> obs) =>
		{
			GtkFileChooserButtonSignalDelegates.file_set handler = (GtkFileChooserButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserButtonSignalStructs.FileSetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "file_set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkFileChooserButtonSignalStructs
{

public struct FileSetSignal
{
	public GtkFileChooserButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkFileChooserButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void file_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserButtonHandle>))] GtkFileChooserButtonHandle self, IntPtr user_data);

}


public static class GtkFileChooserButtonHandleExtensions
{
	public static bool GetFocusOnClick(this GtkFileChooserButtonHandle button)
	{
		return GtkFileChooserButtonExterns.gtk_file_chooser_button_get_focus_on_click(button);
	}

	public static string GetTitle(this GtkFileChooserButtonHandle button)
	{
		return GtkFileChooserButtonExterns.gtk_file_chooser_button_get_title(button);
	}

	public static int GetWidthChars(this GtkFileChooserButtonHandle button)
	{
		return GtkFileChooserButtonExterns.gtk_file_chooser_button_get_width_chars(button);
	}

	public static T SetFocusOnClick<T>(this T button, bool focus_on_click) where T : GtkFileChooserButtonHandle
	{
		GtkFileChooserButtonExterns.gtk_file_chooser_button_set_focus_on_click(button, focus_on_click);
		return button;
	}

	public static T SetTitle<T>(this T button, string title) where T : GtkFileChooserButtonHandle
	{
		GtkFileChooserButtonExterns.gtk_file_chooser_button_set_title(button, title);
		return button;
	}

	public static T SetWidthChars<T>(this T button, int n_chars) where T : GtkFileChooserButtonHandle
	{
		GtkFileChooserButtonExterns.gtk_file_chooser_button_set_width_chars(button, n_chars);
		return button;
	}

}

internal class GtkFileChooserButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFileChooserButtonHandle gtk_file_chooser_button_new(string title, GtkFileChooserAction action);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFileChooserButtonHandle gtk_file_chooser_button_new_with_dialog(GtkWidgetHandle dialog);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_file_chooser_button_get_focus_on_click(GtkFileChooserButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_button_get_title(GtkFileChooserButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_file_chooser_button_get_width_chars(GtkFileChooserButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_button_set_focus_on_click(GtkFileChooserButtonHandle button, bool focus_on_click);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_button_set_title(GtkFileChooserButtonHandle button, string title);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_file_chooser_button_set_width_chars(GtkFileChooserButtonHandle button, int n_chars);

}
