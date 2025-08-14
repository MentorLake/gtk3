namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkCellRendererAccel displays a keyboard accelerator (i.e. a key
/// combination like `Control + a`). If the cell renderer is editable,
/// the accelerator can be changed by simply typing the new combination.
/// </para>
/// <para>
/// The #GtkCellRendererAccel cell renderer was added in GTK+ 2.10.
/// </para>
/// </summary>

public class GtkCellRendererAccelHandle : GtkCellRendererTextHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkCellRendererAccel.
/// </para>
/// </summary>

/// <return>
/// the new cell renderer
/// </return>

	public static MentorLake.Gtk.GtkCellRendererAccelHandle New()
	{
		return GtkCellRendererAccelHandleExterns.gtk_cell_renderer_accel_new();
	}

}
public static class GtkCellRendererAccelHandleSignalExtensions
{
/// <summary>
/// <para>
/// Gets emitted when the user has removed the accelerator.
/// </para>
/// </summary>

	public static IObservable<GtkCellRendererAccelHandleSignalStructs.AccelClearedSignal> Signal_AccelCleared(this GtkCellRendererAccelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellRendererAccelHandleSignalStructs.AccelClearedSignal> obs) =>
		{
			GtkCellRendererAccelHandleSignalDelegates.accel_cleared handler = ( MentorLake.Gtk.GtkCellRendererAccelHandle self,  string path_string,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererAccelHandleSignalStructs.AccelClearedSignal()
				{
					Self = self, PathString = path_string, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "accel-cleared", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// Gets emitted when the user has selected a new accelerator.
/// </para>
/// </summary>

	public static IObservable<GtkCellRendererAccelHandleSignalStructs.AccelEditedSignal> Signal_AccelEdited(this GtkCellRendererAccelHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCellRendererAccelHandleSignalStructs.AccelEditedSignal> obs) =>
		{
			GtkCellRendererAccelHandleSignalDelegates.accel_edited handler = ( MentorLake.Gtk.GtkCellRendererAccelHandle self,  string path_string,  uint accel_key,  MentorLake.Gdk.GdkModifierType accel_mods,  uint hardware_keycode,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCellRendererAccelHandleSignalStructs.AccelEditedSignal()
				{
					Self = self, PathString = path_string, AccelKey = accel_key, AccelMods = accel_mods, HardwareKeycode = hardware_keycode, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "accel-edited", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkCellRendererAccelHandleSignalStructs
{

public class AccelClearedSignal
{

	public MentorLake.Gtk.GtkCellRendererAccelHandle Self;
/// <summary>
/// <para>
/// the path identifying the row of the edited cell
/// </para>
/// </summary>

	public string PathString;

	public IntPtr UserData;
}

public class AccelEditedSignal
{

	public MentorLake.Gtk.GtkCellRendererAccelHandle Self;
/// <summary>
/// <para>
/// the path identifying the row of the edited cell
/// </para>
/// </summary>

	public string PathString;
/// <summary>
/// <para>
/// the new accelerator keyval
/// </para>
/// </summary>

	public uint AccelKey;
/// <summary>
/// <para>
/// the new acclerator modifier mask
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkModifierType AccelMods;
/// <summary>
/// <para>
/// the keycode of the new accelerator
/// </para>
/// </summary>

	public uint HardwareKeycode;

	public IntPtr UserData;
}
}

public static class GtkCellRendererAccelHandleSignalDelegates
{

/// <summary>
/// <para>
/// Gets emitted when the user has removed the accelerator.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path_string">
/// the path identifying the row of the edited cell
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void accel_cleared([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererAccelHandle>))] MentorLake.Gtk.GtkCellRendererAccelHandle self, string path_string, IntPtr user_data);


/// <summary>
/// <para>
/// Gets emitted when the user has selected a new accelerator.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path_string">
/// the path identifying the row of the edited cell
/// </param>
/// <param name="accel_key">
/// the new accelerator keyval
/// </param>
/// <param name="accel_mods">
/// the new acclerator modifier mask
/// </param>
/// <param name="hardware_keycode">
/// the keycode of the new accelerator
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void accel_edited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererAccelHandle>))] MentorLake.Gtk.GtkCellRendererAccelHandle self, string path_string, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, uint hardware_keycode, IntPtr user_data);

}


public static class GtkCellRendererAccelHandleExtensions
{
}

internal class GtkCellRendererAccelHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererAccelHandle>))]
	internal static extern MentorLake.Gtk.GtkCellRendererAccelHandle gtk_cell_renderer_accel_new();

}
