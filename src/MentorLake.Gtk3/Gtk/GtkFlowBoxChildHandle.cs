namespace MentorLake.Gtk;

public class GtkFlowBoxChildHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkFlowBoxChildHandle New()
	{
		return GtkFlowBoxChildHandleExterns.gtk_flow_box_child_new();
	}

}
public static class GtkFlowBoxChildHandleSignalExtensions
{

	public static IObservable<GtkFlowBoxChildHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkFlowBoxChildHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFlowBoxChildHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkFlowBoxChildHandleSignalDelegates.activate handler = ( MentorLake.Gtk.GtkFlowBoxChildHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxChildHandleSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkFlowBoxChildHandleSignalStructs
{

public struct ActivateSignal
{
	public MentorLake.Gtk.GtkFlowBoxChildHandle Self;
	public IntPtr UserData;
}
}

public static class GtkFlowBoxChildHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle self, IntPtr user_data);

}


public static class GtkFlowBoxChildHandleExtensions
{
	public static T Changed<T>(this T child) where T : GtkFlowBoxChildHandle
	{
		if (child.IsInvalid || child.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxChildHandle)");
		GtkFlowBoxChildHandleExterns.gtk_flow_box_child_changed(child);
		return child;
	}

	public static int GetIndex(this MentorLake.Gtk.GtkFlowBoxChildHandle child)
	{
		if (child.IsInvalid || child.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxChildHandle)");
		return GtkFlowBoxChildHandleExterns.gtk_flow_box_child_get_index(child);
	}

	public static bool IsSelected(this MentorLake.Gtk.GtkFlowBoxChildHandle child)
	{
		if (child.IsInvalid || child.IsClosed) throw new Exception("Invalid or closed handle (GtkFlowBoxChildHandle)");
		return GtkFlowBoxChildHandleExterns.gtk_flow_box_child_is_selected(child);
	}

}

internal class GtkFlowBoxChildHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFlowBoxChildHandle gtk_flow_box_child_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_child_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_flow_box_child_get_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_flow_box_child_is_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child);

}
