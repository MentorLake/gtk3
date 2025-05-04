namespace MentorLake.Gtk;

public class GtkTextTagTableHandle : GObjectHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkTextTagTableHandle New()
	{
		return GtkTextTagTableHandleExterns.gtk_text_tag_table_new();
	}

}
public static class GtkTextTagTableHandleSignalExtensions
{

	public static IObservable<GtkTextTagTableHandleSignalStructs.TagAddedSignal> Signal_TagAdded(this GtkTextTagTableHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextTagTableHandleSignalStructs.TagAddedSignal> obs) =>
		{
			GtkTextTagTableHandleSignalDelegates.tag_added handler = ( MentorLake.Gtk.GtkTextTagTableHandle self,  MentorLake.Gtk.GtkTextTagHandle tag,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextTagTableHandleSignalStructs.TagAddedSignal()
				{
					Self = self, Tag = tag, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "tag-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextTagTableHandleSignalStructs.TagChangedSignal> Signal_TagChanged(this GtkTextTagTableHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextTagTableHandleSignalStructs.TagChangedSignal> obs) =>
		{
			GtkTextTagTableHandleSignalDelegates.tag_changed handler = ( MentorLake.Gtk.GtkTextTagTableHandle self,  MentorLake.Gtk.GtkTextTagHandle tag,  bool size_changed,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextTagTableHandleSignalStructs.TagChangedSignal()
				{
					Self = self, Tag = tag, SizeChanged = size_changed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "tag-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkTextTagTableHandleSignalStructs.TagRemovedSignal> Signal_TagRemoved(this GtkTextTagTableHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTextTagTableHandleSignalStructs.TagRemovedSignal> obs) =>
		{
			GtkTextTagTableHandleSignalDelegates.tag_removed handler = ( MentorLake.Gtk.GtkTextTagTableHandle self,  MentorLake.Gtk.GtkTextTagHandle tag,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextTagTableHandleSignalStructs.TagRemovedSignal()
				{
					Self = self, Tag = tag, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "tag-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkTextTagTableHandleSignalStructs
{

public class TagAddedSignal
{
	public MentorLake.Gtk.GtkTextTagTableHandle Self;
	public MentorLake.Gtk.GtkTextTagHandle Tag;
	public IntPtr UserData;
}

public class TagChangedSignal
{
	public MentorLake.Gtk.GtkTextTagTableHandle Self;
	public MentorLake.Gtk.GtkTextTagHandle Tag;
	public bool SizeChanged;
	public IntPtr UserData;
}

public class TagRemovedSignal
{
	public MentorLake.Gtk.GtkTextTagTableHandle Self;
	public MentorLake.Gtk.GtkTextTagHandle Tag;
	public IntPtr UserData;
}
}

public static class GtkTextTagTableHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tag_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tag_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, bool size_changed, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void tag_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag, IntPtr user_data);

}


public static class GtkTextTagTableHandleExtensions
{
	public static bool Add(this MentorLake.Gtk.GtkTextTagTableHandle table, MentorLake.Gtk.GtkTextTagHandle tag)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (GtkTextTagTableHandle)");
		return GtkTextTagTableHandleExterns.gtk_text_tag_table_add(table, tag);
	}

	public static T Foreach<T>(this T table, MentorLake.Gtk.GtkTextTagTableForeach func, IntPtr data) where T : GtkTextTagTableHandle
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (GtkTextTagTableHandle)");
		GtkTextTagTableHandleExterns.gtk_text_tag_table_foreach(table, func, data);
		return table;
	}

	public static int GetSize(this MentorLake.Gtk.GtkTextTagTableHandle table)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (GtkTextTagTableHandle)");
		return GtkTextTagTableHandleExterns.gtk_text_tag_table_get_size(table);
	}

	public static MentorLake.Gtk.GtkTextTagHandle Lookup(this MentorLake.Gtk.GtkTextTagTableHandle table, string name)
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (GtkTextTagTableHandle)");
		return GtkTextTagTableHandleExterns.gtk_text_tag_table_lookup(table, name);
	}

	public static T Remove<T>(this T table, MentorLake.Gtk.GtkTextTagHandle tag) where T : GtkTextTagTableHandle
	{
		if (table.IsInvalid || table.IsClosed) throw new Exception("Invalid or closed handle (GtkTextTagTableHandle)");
		GtkTextTagTableHandleExterns.gtk_text_tag_table_remove(table, tag);
		return table;
	}

}

internal class GtkTextTagTableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextTagTableHandle gtk_text_tag_table_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_tag_table_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle table, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_tag_table_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle table, MentorLake.Gtk.GtkTextTagTableForeach func, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_text_tag_table_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle table);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextTagHandle gtk_text_tag_table_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle table, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_tag_table_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagTableHandle>))] MentorLake.Gtk.GtkTextTagTableHandle table, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextTagHandle>))] MentorLake.Gtk.GtkTextTagHandle tag);

}
