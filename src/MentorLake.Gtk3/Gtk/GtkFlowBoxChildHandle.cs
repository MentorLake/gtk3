namespace MentorLake.Gtk;


public class GtkFlowBoxChildHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkFlowBoxChild, to be used as a child
/// of a #GtkFlowBox.
/// </para>
/// </summary>

/// <return>
/// a new #GtkFlowBoxChild
/// </return>

	public static MentorLake.Gtk.GtkFlowBoxChildHandle New()
	{
		return GtkFlowBoxChildHandleExterns.gtk_flow_box_child_new();
	}

}
public static class GtkFlowBoxChildHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::activate signal is emitted when the user activates
/// a child widget in a #GtkFlowBox, either by clicking or
/// double-clicking, or by using the Space or Enter key.
/// </para>
/// <para>
/// While this signal is used as a
/// [keybinding signal][GtkBindingSignal],
/// it can be used by applications for their own purposes.
/// </para>
/// </summary>

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

public class ActivateSignal
{

	public MentorLake.Gtk.GtkFlowBoxChildHandle Self;

	public IntPtr UserData;
}
}

public static class GtkFlowBoxChildHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::activate signal is emitted when the user activates
/// a child widget in a #GtkFlowBox, either by clicking or
/// double-clicking, or by using the Space or Enter key.
/// </para>
/// <para>
/// While this signal is used as a
/// [keybinding signal][GtkBindingSignal],
/// it can be used by applications for their own purposes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle self, IntPtr user_data);

}


public static class GtkFlowBoxChildHandleExtensions
{
/// <summary>
/// <para>
/// Marks @child as changed, causing any state that depends on this
/// to be updated. This affects sorting and filtering.
/// </para>
/// <para>
/// Note that calls to this method must be in sync with the data
/// used for the sorting and filtering functions. For instance, if
/// the list is mirroring some external data set, and *two* children
/// changed in the external data set when you call
/// gtk_flow_box_child_changed() on the first child, the sort function
/// must only read the new data for the first of the two changed
/// children, otherwise the resorting of the children will be wrong.
/// </para>
/// <para>
/// This generally means that if you don’t fully control the data
/// model, you have to duplicate the data that affects the sorting
/// and filtering functions into the widgets themselves. Another
/// alternative is to call gtk_flow_box_invalidate_sort() on any
/// model change, but that is more expensive.
/// </para>
/// </summary>

/// <param name="child">
/// a #GtkFlowBoxChild
/// </param>

	public static T Changed<T>(this T child) where T : GtkFlowBoxChildHandle
	{
		if (child.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxChildHandle)");
		GtkFlowBoxChildHandleExterns.gtk_flow_box_child_changed(child);
		return child;
	}

/// <summary>
/// <para>
/// Gets the current index of the @child in its #GtkFlowBox container.
/// </para>
/// </summary>

/// <param name="child">
/// a #GtkFlowBoxChild
/// </param>
/// <return>
/// the index of the @child, or -1 if the @child is not
///     in a flow box.
/// </return>

	public static int GetIndex(this MentorLake.Gtk.GtkFlowBoxChildHandle child)
	{
		if (child.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxChildHandle)");
		return GtkFlowBoxChildHandleExterns.gtk_flow_box_child_get_index(child);
	}

/// <summary>
/// <para>
/// Returns whether the @child is currently selected in its
/// #GtkFlowBox container.
/// </para>
/// </summary>

/// <param name="child">
/// a #GtkFlowBoxChild
/// </param>
/// <return>
/// %TRUE if @child is selected
/// </return>

	public static bool IsSelected(this MentorLake.Gtk.GtkFlowBoxChildHandle child)
	{
		if (child.IsInvalid) throw new Exception("Invalid handle (GtkFlowBoxChildHandle)");
		return GtkFlowBoxChildHandleExterns.gtk_flow_box_child_is_selected(child);
	}

}

internal class GtkFlowBoxChildHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))]
	internal static extern MentorLake.Gtk.GtkFlowBoxChildHandle gtk_flow_box_child_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_flow_box_child_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_flow_box_child_get_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_flow_box_child_is_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFlowBoxChildHandle>))] MentorLake.Gtk.GtkFlowBoxChildHandle child);

}
