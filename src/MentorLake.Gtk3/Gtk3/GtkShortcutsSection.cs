namespace MentorLake.Gtk3.Gtk3;

public class GtkShortcutsSectionHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
}

public static class GtkShortcutsSectionSignalExtensions
{

	public static IObservable<GtkShortcutsSectionSignalStructs.ChangeCurrentPageSignal> Signal_ChangeCurrentPage(this GtkShortcutsSectionHandle instance)
	{
		return Observable.Create((IObserver<GtkShortcutsSectionSignalStructs.ChangeCurrentPageSignal> obs) =>
		{
			GtkShortcutsSectionSignalDelegates.change_current_page handler = (GtkShortcutsSectionHandle self, int @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkShortcutsSectionSignalStructs.ChangeCurrentPageSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "change_current_page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkShortcutsSectionSignalStructs
{

public struct ChangeCurrentPageSignal
{
	public GtkShortcutsSectionHandle Self;
	public int Object;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkShortcutsSectionSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool change_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkShortcutsSectionHandle>))] GtkShortcutsSectionHandle self, int @object, IntPtr user_data);

}


public static class GtkShortcutsSectionHandleExtensions
{
}

internal class GtkShortcutsSectionExterns
{
}
