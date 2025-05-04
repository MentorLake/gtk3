namespace MentorLake.Gtk;

public class GtkShortcutsSectionHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
}
public static class GtkShortcutsSectionHandleSignalExtensions
{

	public static IObservable<GtkShortcutsSectionHandleSignalStructs.ChangeCurrentPageSignal> Signal_ChangeCurrentPage(this GtkShortcutsSectionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkShortcutsSectionHandleSignalStructs.ChangeCurrentPageSignal> obs) =>
		{
			GtkShortcutsSectionHandleSignalDelegates.change_current_page handler = ( MentorLake.Gtk.GtkShortcutsSectionHandle self,  int @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkShortcutsSectionHandleSignalStructs.ChangeCurrentPageSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "change-current-page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkShortcutsSectionHandleSignalStructs
{

public class ChangeCurrentPageSignal
{
	public MentorLake.Gtk.GtkShortcutsSectionHandle Self;
	public int Object;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkShortcutsSectionHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool change_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutsSectionHandle>))] MentorLake.Gtk.GtkShortcutsSectionHandle self, int @object, IntPtr user_data);

}


public static class GtkShortcutsSectionHandleExtensions
{
}

internal class GtkShortcutsSectionHandleExterns
{
}
