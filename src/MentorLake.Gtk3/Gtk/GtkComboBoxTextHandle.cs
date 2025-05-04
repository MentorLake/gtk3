namespace MentorLake.Gtk;

public class GtkComboBoxTextHandle : GtkComboBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkCellLayoutHandle
{
	public static MentorLake.Gtk.GtkComboBoxTextHandle New()
	{
		return GtkComboBoxTextHandleExterns.gtk_combo_box_text_new();
	}

	public static MentorLake.Gtk.GtkComboBoxTextHandle NewWithEntry()
	{
		return GtkComboBoxTextHandleExterns.gtk_combo_box_text_new_with_entry();
	}

}
public static class GtkComboBoxTextHandleSignalExtensions
{

	public static IObservable<GtkComboBoxTextHandleSignalStructs.EditingDoneSignal> Signal_EditingDone(this GtkComboBoxTextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxTextHandleSignalStructs.EditingDoneSignal> obs) =>
		{
			GtkComboBoxTextHandleSignalDelegates.editing_done handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxTextHandleSignalStructs.EditingDoneSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "editing-done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkComboBoxTextHandleSignalStructs.RemoveWidgetSignal> Signal_RemoveWidget(this GtkComboBoxTextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkComboBoxTextHandleSignalStructs.RemoveWidgetSignal> obs) =>
		{
			GtkComboBoxTextHandleSignalDelegates.remove_widget handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxTextHandleSignalStructs.RemoveWidgetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "remove-widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkComboBoxTextHandleSignalStructs
{

public class EditingDoneSignal
{
	public MentorLake.Gtk.GtkCellEditableHandle Self;
	public IntPtr UserData;
}

public class RemoveWidgetSignal
{
	public MentorLake.Gtk.GtkCellEditableHandle Self;
	public IntPtr UserData;
}
}

public static class GtkComboBoxTextHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void editing_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);

}


public static class GtkComboBoxTextHandleExtensions
{
	public static T Append<T>(this T combo_box, string id, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_append(combo_box, id, text);
		return combo_box;
	}

	public static T AppendText<T>(this T combo_box, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_append_text(combo_box, text);
		return combo_box;
	}

	public static string GetActiveText(this MentorLake.Gtk.GtkComboBoxTextHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		return GtkComboBoxTextHandleExterns.gtk_combo_box_text_get_active_text(combo_box);
	}

	public static T Insert<T>(this T combo_box, int position, string id, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_insert(combo_box, position, id, text);
		return combo_box;
	}

	public static T InsertText<T>(this T combo_box, int position, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_insert_text(combo_box, position, text);
		return combo_box;
	}

	public static T Prepend<T>(this T combo_box, string id, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_prepend(combo_box, id, text);
		return combo_box;
	}

	public static T PrependText<T>(this T combo_box, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_prepend_text(combo_box, text);
		return combo_box;
	}

	public static T Remove<T>(this T combo_box, int position) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_remove(combo_box, position);
		return combo_box;
	}

	public static T RemoveAll<T>(this T combo_box) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_remove_all(combo_box);
		return combo_box;
	}

}

internal class GtkComboBoxTextHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkComboBoxTextHandle gtk_combo_box_text_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkComboBoxTextHandle gtk_combo_box_text_new_with_entry();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, string id, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_append_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, string text);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_combo_box_text_get_active_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, int position, string id, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_insert_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, int position, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, string id, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_prepend_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box);

}
