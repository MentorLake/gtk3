namespace MentorLake.Gtk;

public class GtkFileChooserButtonHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFileChooserHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkFileChooserButtonHandle New(string title, MentorLake.Gtk.GtkFileChooserAction action)
	{
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_new(title, action);
	}

	public static MentorLake.Gtk.GtkFileChooserButtonHandle NewWithDialog(MentorLake.Gtk.GtkWidgetHandle dialog)
	{
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_new_with_dialog(dialog);
	}

}
public static class GtkFileChooserButtonHandleSignalExtensions
{

	public static IObservable<GtkFileChooserButtonHandleSignalStructs.FileSetSignal> Signal_FileSet(this GtkFileChooserButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserButtonHandleSignalStructs.FileSetSignal> obs) =>
		{
			GtkFileChooserButtonHandleSignalDelegates.file_set handler = ( MentorLake.Gtk.GtkFileChooserButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserButtonHandleSignalStructs.FileSetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "file-set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkFileChooserButtonHandleSignalStructs
{

public class FileSetSignal
{
	public MentorLake.Gtk.GtkFileChooserButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkFileChooserButtonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void file_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle self, IntPtr user_data);

}


public static class GtkFileChooserButtonHandleExtensions
{
	public static bool GetFocusOnClick(this MentorLake.Gtk.GtkFileChooserButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserButtonHandle)");
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_get_focus_on_click(button);
	}

	public static string GetTitle(this MentorLake.Gtk.GtkFileChooserButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserButtonHandle)");
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_get_title(button);
	}

	public static int GetWidthChars(this MentorLake.Gtk.GtkFileChooserButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserButtonHandle)");
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_get_width_chars(button);
	}

	public static T SetFocusOnClick<T>(this T button, bool focus_on_click) where T : GtkFileChooserButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserButtonHandle)");
		GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_set_focus_on_click(button, focus_on_click);
		return button;
	}

	public static T SetTitle<T>(this T button, string title) where T : GtkFileChooserButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserButtonHandle)");
		GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_set_title(button, title);
		return button;
	}

	public static T SetWidthChars<T>(this T button, int n_chars) where T : GtkFileChooserButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserButtonHandle)");
		GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_set_width_chars(button, n_chars);
		return button;
	}

}

internal class GtkFileChooserButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFileChooserButtonHandle gtk_file_chooser_button_new(string title, MentorLake.Gtk.GtkFileChooserAction action);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFileChooserButtonHandle gtk_file_chooser_button_new_with_dialog([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle dialog);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_button_get_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_button_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_file_chooser_button_get_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_button_set_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle button, bool focus_on_click);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_button_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle button, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_button_set_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle button, int n_chars);

}
