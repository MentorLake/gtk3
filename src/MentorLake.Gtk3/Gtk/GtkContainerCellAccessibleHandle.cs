namespace MentorLake.Gtk;

public class GtkContainerCellAccessibleHandle : GtkCellAccessibleHandle, AtkActionHandle, AtkComponentHandle, AtkTableCellHandle
{
	public static MentorLake.Gtk.GtkContainerCellAccessibleHandle New()
	{
		return GtkContainerCellAccessibleHandleExterns.gtk_container_cell_accessible_new();
	}

}
public static class GtkContainerCellAccessibleHandleSignalExtensions
{

	public static IObservable<GtkContainerCellAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkContainerCellAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkContainerCellAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkContainerCellAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkContainerCellAccessibleHandleSignalStructs.BoundsChangedSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "bounds-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkContainerCellAccessibleHandleSignalStructs
{

public class BoundsChangedSignal
{
	public MentorLake.Atk.AtkComponentHandle Self;
	public MentorLake.Atk.AtkRectangleHandle Arg1;
	public IntPtr UserData;
}
}

public static class GtkContainerCellAccessibleHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);

}


public static class GtkContainerCellAccessibleHandleExtensions
{
	public static T AddChild<T>(this T container, MentorLake.Gtk.GtkCellAccessibleHandle child) where T : GtkContainerCellAccessibleHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerCellAccessibleHandle)");
		GtkContainerCellAccessibleHandleExterns.gtk_container_cell_accessible_add_child(container, child);
		return container;
	}

	public static MentorLake.GLib.GListHandle GetChildren(this MentorLake.Gtk.GtkContainerCellAccessibleHandle container)
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerCellAccessibleHandle)");
		return GtkContainerCellAccessibleHandleExterns.gtk_container_cell_accessible_get_children(container);
	}

	public static T RemoveChild<T>(this T container, MentorLake.Gtk.GtkCellAccessibleHandle child) where T : GtkContainerCellAccessibleHandle
	{
		if (container.IsInvalid) throw new Exception("Invalid handle (GtkContainerCellAccessibleHandle)");
		GtkContainerCellAccessibleHandleExterns.gtk_container_cell_accessible_remove_child(container, child);
		return container;
	}

}

internal class GtkContainerCellAccessibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkContainerCellAccessibleHandle>))]
	internal static extern MentorLake.Gtk.GtkContainerCellAccessibleHandle gtk_container_cell_accessible_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_cell_accessible_add_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerCellAccessibleHandle>))] MentorLake.Gtk.GtkContainerCellAccessibleHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle child);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_container_cell_accessible_get_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerCellAccessibleHandle>))] MentorLake.Gtk.GtkContainerCellAccessibleHandle container);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_container_cell_accessible_remove_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkContainerCellAccessibleHandle>))] MentorLake.Gtk.GtkContainerCellAccessibleHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAccessibleHandle>))] MentorLake.Gtk.GtkCellAccessibleHandle child);

}
