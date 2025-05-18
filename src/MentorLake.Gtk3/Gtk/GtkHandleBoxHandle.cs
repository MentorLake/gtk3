namespace MentorLake.Gtk;

public class GtkHandleBoxHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkHandleBoxHandle New()
	{
		return GtkHandleBoxHandleExterns.gtk_handle_box_new();
	}

}
public static class GtkHandleBoxHandleSignalExtensions
{

	public static IObservable<GtkHandleBoxHandleSignalStructs.ChildAttachedSignal> Signal_ChildAttached(this GtkHandleBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkHandleBoxHandleSignalStructs.ChildAttachedSignal> obs) =>
		{
			GtkHandleBoxHandleSignalDelegates.child_attached handler = ( MentorLake.Gtk.GtkHandleBoxHandle self,  MentorLake.Gtk.GtkWidgetHandle widget,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkHandleBoxHandleSignalStructs.ChildAttachedSignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "child-attached", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkHandleBoxHandleSignalStructs.ChildDetachedSignal> Signal_ChildDetached(this GtkHandleBoxHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkHandleBoxHandleSignalStructs.ChildDetachedSignal> obs) =>
		{
			GtkHandleBoxHandleSignalDelegates.child_detached handler = ( MentorLake.Gtk.GtkHandleBoxHandle self,  MentorLake.Gtk.GtkWidgetHandle widget,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkHandleBoxHandleSignalStructs.ChildDetachedSignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "child-detached", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkHandleBoxHandleSignalStructs
{

public class ChildAttachedSignal
{
	public MentorLake.Gtk.GtkHandleBoxHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Widget;
	public IntPtr UserData;
}

public class ChildDetachedSignal
{
	public MentorLake.Gtk.GtkHandleBoxHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Widget;
	public IntPtr UserData;
}
}

public static class GtkHandleBoxHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void child_attached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void child_detached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, IntPtr user_data);

}


public static class GtkHandleBoxHandleExtensions
{
	public static bool GetChildDetached(this MentorLake.Gtk.GtkHandleBoxHandle handle_box)
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		return GtkHandleBoxHandleExterns.gtk_handle_box_get_child_detached(handle_box);
	}

	public static MentorLake.Gtk.GtkPositionType GetHandlePosition(this MentorLake.Gtk.GtkHandleBoxHandle handle_box)
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		return GtkHandleBoxHandleExterns.gtk_handle_box_get_handle_position(handle_box);
	}

	public static MentorLake.Gtk.GtkShadowType GetShadowType(this MentorLake.Gtk.GtkHandleBoxHandle handle_box)
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		return GtkHandleBoxHandleExterns.gtk_handle_box_get_shadow_type(handle_box);
	}

	public static MentorLake.Gtk.GtkPositionType GetSnapEdge(this MentorLake.Gtk.GtkHandleBoxHandle handle_box)
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		return GtkHandleBoxHandleExterns.gtk_handle_box_get_snap_edge(handle_box);
	}

	public static T SetHandlePosition<T>(this T handle_box, MentorLake.Gtk.GtkPositionType position) where T : GtkHandleBoxHandle
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		GtkHandleBoxHandleExterns.gtk_handle_box_set_handle_position(handle_box, position);
		return handle_box;
	}

	public static T SetShadowType<T>(this T handle_box, MentorLake.Gtk.GtkShadowType type) where T : GtkHandleBoxHandle
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		GtkHandleBoxHandleExterns.gtk_handle_box_set_shadow_type(handle_box, type);
		return handle_box;
	}

	public static T SetSnapEdge<T>(this T handle_box, MentorLake.Gtk.GtkPositionType edge) where T : GtkHandleBoxHandle
	{
		if (handle_box.IsInvalid) throw new Exception("Invalid handle (GtkHandleBoxHandle)");
		GtkHandleBoxHandleExterns.gtk_handle_box_set_snap_edge(handle_box, edge);
		return handle_box;
	}

}

internal class GtkHandleBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkHandleBoxHandle gtk_handle_box_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_handle_box_get_child_detached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPositionType gtk_handle_box_get_handle_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkShadowType gtk_handle_box_get_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPositionType gtk_handle_box_get_snap_edge([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_handle_box_set_handle_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box, MentorLake.Gtk.GtkPositionType position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_handle_box_set_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box, MentorLake.Gtk.GtkShadowType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_handle_box_set_snap_edge([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkHandleBoxHandle>))] MentorLake.Gtk.GtkHandleBoxHandle handle_box, MentorLake.Gtk.GtkPositionType edge);

}
