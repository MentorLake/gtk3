namespace MentorLake.Gtk;


public class GtkNotebookPageAccessibleHandle : AtkObjectHandle, AtkComponentHandle
{

/// <param name="notebook">
/// </param>
/// <param name="child">
/// </param>

	public static MentorLake.Gtk.GtkNotebookPageAccessibleHandle New(MentorLake.Gtk.GtkNotebookAccessibleHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		return GtkNotebookPageAccessibleHandleExterns.gtk_notebook_page_accessible_new(notebook, child);
	}

}
public static class GtkNotebookPageAccessibleHandleSignalExtensions
{
/// <summary>
/// <para>
/// The &apos;bounds-changed&quot; signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

	public static IObservable<GtkNotebookPageAccessibleHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this GtkNotebookPageAccessibleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookPageAccessibleHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			GtkNotebookPageAccessibleHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookPageAccessibleHandleSignalStructs.BoundsChangedSignal()
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

public static class GtkNotebookPageAccessibleHandleSignalStructs
{

public class BoundsChangedSignal
{

	public MentorLake.Atk.AtkComponentHandle Self;
/// <summary>
/// <para>
/// The AtkRectangle giving the new position and size.
/// </para>
/// </summary>

	public MentorLake.Atk.AtkRectangleHandle Arg1;

	public IntPtr UserData;
}
}

public static class GtkNotebookPageAccessibleHandleSignalDelegates
{

/// <summary>
/// <para>
/// The &apos;bounds-changed&quot; signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The AtkRectangle giving the new position and size.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);

}


public static class GtkNotebookPageAccessibleHandleExtensions
{

/// <param name="page">
/// </param>

	public static T Invalidate<T>(this T page) where T : GtkNotebookPageAccessibleHandle
	{
		if (page.IsInvalid) throw new Exception("Invalid handle (GtkNotebookPageAccessibleHandle)");
		GtkNotebookPageAccessibleHandleExterns.gtk_notebook_page_accessible_invalidate(page);
		return page;
	}

}

internal class GtkNotebookPageAccessibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookPageAccessibleHandle>))]
	internal static extern MentorLake.Gtk.GtkNotebookPageAccessibleHandle gtk_notebook_page_accessible_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookAccessibleHandle>))] MentorLake.Gtk.GtkNotebookAccessibleHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_page_accessible_invalidate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookPageAccessibleHandle>))] MentorLake.Gtk.GtkNotebookPageAccessibleHandle page);

}
