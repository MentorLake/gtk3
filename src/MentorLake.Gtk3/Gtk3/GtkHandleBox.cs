namespace MentorLake.Gtk3.Gtk3;

public class GtkHandleBoxHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkHandleBoxHandle New()
	{
		return GtkHandleBoxExterns.gtk_handle_box_new();
	}

}

public static class GtkHandleBoxSignalExtensions
{

	public static IObservable<GtkHandleBoxSignalStructs.ChildAttachedSignal> Signal_ChildAttached(this GtkHandleBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkHandleBoxSignalStructs.ChildAttachedSignal> obs) =>
		{
			GtkHandleBoxSignalDelegates.child_attached handler = (GtkHandleBoxHandle self, GtkWidgetHandle widget, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkHandleBoxSignalStructs.ChildAttachedSignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "child_attached", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkHandleBoxSignalStructs.ChildDetachedSignal> Signal_ChildDetached(this GtkHandleBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkHandleBoxSignalStructs.ChildDetachedSignal> obs) =>
		{
			GtkHandleBoxSignalDelegates.child_detached handler = (GtkHandleBoxHandle self, GtkWidgetHandle widget, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkHandleBoxSignalStructs.ChildDetachedSignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "child_detached", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkHandleBoxSignalStructs
{

public struct ChildAttachedSignal
{
	public GtkHandleBoxHandle Self;
	public GtkWidgetHandle Widget;
	public IntPtr UserData;
}

public struct ChildDetachedSignal
{
	public GtkHandleBoxHandle Self;
	public GtkWidgetHandle Widget;
	public IntPtr UserData;
}
}

public static class GtkHandleBoxSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void child_attached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkHandleBoxHandle>))] GtkHandleBoxHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle widget, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void child_detached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkHandleBoxHandle>))] GtkHandleBoxHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle widget, IntPtr user_data);

}


public static class GtkHandleBoxHandleExtensions
{
	public static bool GetChildDetached(this GtkHandleBoxHandle handle_box)
	{
		return GtkHandleBoxExterns.gtk_handle_box_get_child_detached(handle_box);
	}

	public static GtkPositionType GetHandlePosition(this GtkHandleBoxHandle handle_box)
	{
		return GtkHandleBoxExterns.gtk_handle_box_get_handle_position(handle_box);
	}

	public static GtkShadowType GetShadowType(this GtkHandleBoxHandle handle_box)
	{
		return GtkHandleBoxExterns.gtk_handle_box_get_shadow_type(handle_box);
	}

	public static GtkPositionType GetSnapEdge(this GtkHandleBoxHandle handle_box)
	{
		return GtkHandleBoxExterns.gtk_handle_box_get_snap_edge(handle_box);
	}

	public static GtkHandleBoxHandle SetHandlePosition(this GtkHandleBoxHandle handle_box, GtkPositionType position)
	{
		GtkHandleBoxExterns.gtk_handle_box_set_handle_position(handle_box, position);
		return handle_box;
	}

	public static GtkHandleBoxHandle SetShadowType(this GtkHandleBoxHandle handle_box, GtkShadowType type)
	{
		GtkHandleBoxExterns.gtk_handle_box_set_shadow_type(handle_box, type);
		return handle_box;
	}

	public static GtkHandleBoxHandle SetSnapEdge(this GtkHandleBoxHandle handle_box, GtkPositionType edge)
	{
		GtkHandleBoxExterns.gtk_handle_box_set_snap_edge(handle_box, edge);
		return handle_box;
	}

}

internal class GtkHandleBoxExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkHandleBoxHandle gtk_handle_box_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_handle_box_get_child_detached(GtkHandleBoxHandle handle_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPositionType gtk_handle_box_get_handle_position(GtkHandleBoxHandle handle_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkShadowType gtk_handle_box_get_shadow_type(GtkHandleBoxHandle handle_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPositionType gtk_handle_box_get_snap_edge(GtkHandleBoxHandle handle_box);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_handle_box_set_handle_position(GtkHandleBoxHandle handle_box, GtkPositionType position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_handle_box_set_shadow_type(GtkHandleBoxHandle handle_box, GtkShadowType type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_handle_box_set_snap_edge(GtkHandleBoxHandle handle_box, GtkPositionType edge);

}
