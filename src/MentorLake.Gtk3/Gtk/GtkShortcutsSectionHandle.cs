namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkShortcutsSection collects all the keyboard shortcuts and gestures
/// for a major application mode. If your application needs multiple sections,
/// you should give each section a unique #GtkShortcutsSection:section-name and
/// a #GtkShortcutsSection:title that can be shown in the section selector of
/// the GtkShortcutsWindow.
/// </para>
/// <para>
/// The #GtkShortcutsSection:max-height property can be used to influence how
/// the groups in the section are distributed over pages and columns.
/// </para>
/// <para>
/// This widget is only meant to be used with #GtkShortcutsWindow.
/// </para>
/// </summary>

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


/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool change_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutsSectionHandle>))] MentorLake.Gtk.GtkShortcutsSectionHandle self, int @object, IntPtr user_data);

}


public static class GtkShortcutsSectionHandleExtensions
{
}

internal class GtkShortcutsSectionHandleExterns
{
}
