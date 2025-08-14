namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkCellRendererToggle renders a toggle button in a cell. The
/// button is drawn as a radio or a checkbutton, depending on the
/// #GtkCellRendererToggle:radio property.
/// When activated, it emits the #GtkCellRendererToggle::toggled signal.
/// </para>
/// </summary>

public class GtkCellRendererToggleHandle : GtkCellRendererHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkCellRendererToggle. Adjust rendering
/// parameters using object properties. Object properties can be set
/// globally (with g_object_set()). Also, with #GtkTreeViewColumn, you
/// can bind a property to a value in a #GtkTreeModel. For example, you
/// can bind the “active” property on the cell renderer to a boolean value
/// in the model, thus causing the check button to reflect the state of
/// the model.
/// </para>
/// </summary>

/// <return>
/// the new cell renderer
/// </return>

	public static MentorLake.Gtk.GtkCellRendererToggleHandle New()
	{
		return GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_new();
	}

}
public static class GtkCellRendererToggleHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::toggled signal is emitted when the cell is toggled.
/// </para>
/// <para>
/// It is the responsibility of the application to update the model
/// with the correct value to store at @path.  Often this is simply the
/// opposite of the value currently stored at @path.
/// </para>
/// </summary>

	public static IObservable<GtkCellRendererToggleHandleSignalStructs.ToggledSignal> Signal_Toggled(this GtkCellRendererToggleHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellRendererToggleHandleSignalStructs.ToggledSignal> obs) =>
		{
			GtkCellRendererToggleHandleSignalDelegates.toggled handler = ( MentorLake.Gtk.GtkCellRendererToggleHandle self,  string path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererToggleHandleSignalStructs.ToggledSignal()
				{
					Self = self, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkCellRendererToggleHandleSignalStructs
{

public class ToggledSignal
{

	public MentorLake.Gtk.GtkCellRendererToggleHandle Self;
/// <summary>
/// <para>
/// string representation of #GtkTreePath describing the
///        event location
/// </para>
/// </summary>

	public string Path;

	public IntPtr UserData;
}
}

public static class GtkCellRendererToggleHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::toggled signal is emitted when the cell is toggled.
/// </para>
/// <para>
/// It is the responsibility of the application to update the model
/// with the correct value to store at @path.  Often this is simply the
/// opposite of the value currently stored at @path.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path">
/// string representation of #GtkTreePath describing the
///        event location
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle self, string path, IntPtr user_data);

}


public static class GtkCellRendererToggleHandleExtensions
{
/// <summary>
/// <para>
/// Returns whether the cell renderer is activatable. See
/// gtk_cell_renderer_toggle_set_activatable().
/// </para>
/// </summary>

/// <param name="toggle">
/// a #GtkCellRendererToggle
/// </param>
/// <return>
/// %TRUE if the cell renderer is activatable.
/// </return>

	public static bool GetActivatable(this MentorLake.Gtk.GtkCellRendererToggleHandle toggle)
	{
		if (toggle.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererToggleHandle)");
		return GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_get_activatable(toggle);
	}

/// <summary>
/// <para>
/// Returns whether the cell renderer is active. See
/// gtk_cell_renderer_toggle_set_active().
/// </para>
/// </summary>

/// <param name="toggle">
/// a #GtkCellRendererToggle
/// </param>
/// <return>
/// %TRUE if the cell renderer is active.
/// </return>

	public static bool GetActive(this MentorLake.Gtk.GtkCellRendererToggleHandle toggle)
	{
		if (toggle.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererToggleHandle)");
		return GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_get_active(toggle);
	}

/// <summary>
/// <para>
/// Returns whether we’re rendering radio toggles rather than checkboxes.
/// </para>
/// </summary>

/// <param name="toggle">
/// a #GtkCellRendererToggle
/// </param>
/// <return>
/// %TRUE if we’re rendering radio toggles rather than checkboxes
/// </return>

	public static bool GetRadio(this MentorLake.Gtk.GtkCellRendererToggleHandle toggle)
	{
		if (toggle.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererToggleHandle)");
		return GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_get_radio(toggle);
	}

/// <summary>
/// <para>
/// Makes the cell renderer activatable.
/// </para>
/// </summary>

/// <param name="toggle">
/// a #GtkCellRendererToggle.
/// </param>
/// <param name="setting">
/// the value to set.
/// </param>

	public static T SetActivatable<T>(this T toggle, bool setting) where T : GtkCellRendererToggleHandle
	{
		if (toggle.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererToggleHandle)");
		GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_set_activatable(toggle, setting);
		return toggle;
	}

/// <summary>
/// <para>
/// Activates or deactivates a cell renderer.
/// </para>
/// </summary>

/// <param name="toggle">
/// a #GtkCellRendererToggle.
/// </param>
/// <param name="setting">
/// the value to set.
/// </param>

	public static T SetActive<T>(this T toggle, bool setting) where T : GtkCellRendererToggleHandle
	{
		if (toggle.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererToggleHandle)");
		GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_set_active(toggle, setting);
		return toggle;
	}

/// <summary>
/// <para>
/// If @radio is %TRUE, the cell renderer renders a radio toggle
/// (i.e. a toggle in a group of mutually-exclusive toggles).
/// If %FALSE, it renders a check toggle (a standalone boolean option).
/// This can be set globally for the cell renderer, or changed just
/// before rendering each cell in the model (for #GtkTreeView, you set
/// up a per-row setting using #GtkTreeViewColumn to associate model
/// columns with cell renderer properties).
/// </para>
/// </summary>

/// <param name="toggle">
/// a #GtkCellRendererToggle
/// </param>
/// <param name="radio">
/// %TRUE to make the toggle look like a radio button
/// </param>

	public static T SetRadio<T>(this T toggle, bool radio) where T : GtkCellRendererToggleHandle
	{
		if (toggle.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererToggleHandle)");
		GtkCellRendererToggleHandleExterns.gtk_cell_renderer_toggle_set_radio(toggle, radio);
		return toggle;
	}

}

internal class GtkCellRendererToggleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererToggleHandle gtk_cell_renderer_toggle_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_renderer_toggle_get_activatable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle toggle);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_renderer_toggle_get_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle toggle);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_renderer_toggle_get_radio([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle toggle);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_toggle_set_activatable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle toggle, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_toggle_set_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle toggle, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_toggle_set_radio([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererToggleHandle>))] MentorLake.Gtk.GtkCellRendererToggleHandle toggle, bool radio);

}
