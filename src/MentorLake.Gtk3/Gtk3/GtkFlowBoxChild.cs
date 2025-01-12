namespace MentorLake.Gtk3.Gtk3;

public class GtkFlowBoxChildHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkFlowBoxChildHandle New()
	{
		return GtkFlowBoxChildExterns.gtk_flow_box_child_new();
	}

}

public static class GtkFlowBoxChildSignalExtensions
{

	public static IObservable<GtkFlowBoxChildSignalStructs.ActivateSignal> Signal_Activate(this GtkFlowBoxChildHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxChildSignalStructs.ActivateSignal> obs) =>
		{
			GtkFlowBoxChildSignalDelegates.activate handler = (GtkFlowBoxChildHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxChildSignalStructs.ActivateSignal()
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

public static class GtkFlowBoxChildSignalStructs
{

public struct ActivateSignal
{
	public GtkFlowBoxChildHandle Self;
	public IntPtr UserData;
}
}

public static class GtkFlowBoxChildSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxChildHandle>))] GtkFlowBoxChildHandle self, IntPtr user_data);

}


public static class GtkFlowBoxChildHandleExtensions
{
	public static GtkFlowBoxChildHandle Changed(this GtkFlowBoxChildHandle child)
	{
		GtkFlowBoxChildExterns.gtk_flow_box_child_changed(child);
		return child;
	}

	public static int GetIndex(this GtkFlowBoxChildHandle child)
	{
		return GtkFlowBoxChildExterns.gtk_flow_box_child_get_index(child);
	}

	public static bool IsSelected(this GtkFlowBoxChildHandle child)
	{
		return GtkFlowBoxChildExterns.gtk_flow_box_child_is_selected(child);
	}

}

internal class GtkFlowBoxChildExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFlowBoxChildHandle gtk_flow_box_child_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_flow_box_child_changed(GtkFlowBoxChildHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_flow_box_child_get_index(GtkFlowBoxChildHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_flow_box_child_is_selected(GtkFlowBoxChildHandle child);

}
