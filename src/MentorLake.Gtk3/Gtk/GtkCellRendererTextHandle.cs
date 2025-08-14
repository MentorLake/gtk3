namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkCellRendererText renders a given text in its cell, using the font, color and
/// style information provided by its properties. The text will be ellipsized if it is
/// too long and the #GtkCellRendererText:ellipsize property allows it.
/// </para>
/// <para>
/// If the #GtkCellRenderer:mode is %GTK_CELL_RENDERER_MODE_EDITABLE,
/// the #GtkCellRendererText allows to edit its text using an entry.
/// </para>
/// </summary>

public class GtkCellRendererTextHandle : GtkCellRendererHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkCellRendererText. Adjust how text is drawn using
/// object properties. Object properties can be
/// set globally (with g_object_set()). Also, with #GtkTreeViewColumn,
/// you can bind a property to a value in a #GtkTreeModel. For example,
/// you can bind the “text” property on the cell renderer to a string
/// value in the model, thus rendering a different string in each row
/// of the #GtkTreeView
/// </para>
/// </summary>

/// <return>
/// the new cell renderer
/// </return>

	public static MentorLake.Gtk.GtkCellRendererTextHandle New()
	{
		return GtkCellRendererTextHandleExterns.gtk_cell_renderer_text_new();
	}

}
public static class GtkCellRendererTextHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted after @renderer has been edited.
/// </para>
/// <para>
/// It is the responsibility of the application to update the model
/// and store @new_text at the position indicated by @path.
/// </para>
/// </summary>

	public static IObservable<GtkCellRendererTextHandleSignalStructs.EditedSignal> Signal_Edited(this GtkCellRendererTextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellRendererTextHandleSignalStructs.EditedSignal> obs) =>
		{
			GtkCellRendererTextHandleSignalDelegates.edited handler = ( MentorLake.Gtk.GtkCellRendererTextHandle self,  string path,  string new_text,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererTextHandleSignalStructs.EditedSignal()
				{
					Self = self, Path = path, NewText = new_text, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "edited", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkCellRendererTextHandleSignalStructs
{

public class EditedSignal
{

	public MentorLake.Gtk.GtkCellRendererTextHandle Self;
/// <summary>
/// <para>
/// the path identifying the edited cell
/// </para>
/// </summary>

	public string Path;
/// <summary>
/// <para>
/// the new text
/// </para>
/// </summary>

	public string NewText;

	public IntPtr UserData;
}
}

public static class GtkCellRendererTextHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted after @renderer has been edited.
/// </para>
/// <para>
/// It is the responsibility of the application to update the model
/// and store @new_text at the position indicated by @path.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path">
/// the path identifying the edited cell
/// </param>
/// <param name="new_text">
/// the new text
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void edited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererTextHandle>))] MentorLake.Gtk.GtkCellRendererTextHandle self, string path, string new_text, IntPtr user_data);

}


public static class GtkCellRendererTextHandleExtensions
{
/// <summary>
/// <para>
/// Sets the height of a renderer to explicitly be determined by the “font” and
/// “y_pad” property set on it.  Further changes in these properties do not
/// affect the height, so they must be accompanied by a subsequent call to this
/// function.  Using this function is unflexible, and should really only be used
/// if calculating the size of a cell is too slow (ie, a massive number of cells
/// displayed).  If @number_of_rows is -1, then the fixed height is unset, and
/// the height is determined by the properties again.
/// </para>
/// </summary>

/// <param name="renderer">
/// A #GtkCellRendererText
/// </param>
/// <param name="number_of_rows">
/// Number of rows of text each cell renderer is allocated, or -1
/// </param>

	public static T SetFixedHeightFromFont<T>(this T renderer, int number_of_rows) where T : GtkCellRendererTextHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererTextHandle)");
		GtkCellRendererTextHandleExterns.gtk_cell_renderer_text_set_fixed_height_from_font(renderer, number_of_rows);
		return renderer;
	}

}

internal class GtkCellRendererTextHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererTextHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererTextHandle gtk_cell_renderer_text_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_text_set_fixed_height_from_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererTextHandle>))] MentorLake.Gtk.GtkCellRendererTextHandle renderer, int number_of_rows);

}
