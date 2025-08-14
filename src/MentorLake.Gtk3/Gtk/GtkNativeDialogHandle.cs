namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Native dialogs are platform dialogs that don't use #GtkDialog or
/// #GtkWindow. They are used in order to integrate better with a
/// platform, by looking the same as other native applications and
/// supporting platform specific features.
/// </para>
/// <para>
/// The #GtkDialog functions cannot be used on such objects, but we
/// need a similar API in order to drive them. The #GtkNativeDialog
/// object is an API that allows you to do this. It allows you to set
/// various common properties on the dialog, as well as show and hide
/// it and get a #GtkNativeDialog::response signal when the user finished
/// with the dialog.
/// </para>
/// <para>
/// There is also a gtk_native_dialog_run() helper that makes it easy
/// to run any native dialog in a modal way with a recursive mainloop,
/// similar to gtk_dialog_run().
/// </para>
/// </summary>

public class GtkNativeDialogHandle : GObjectHandle
{
}
public static class GtkNativeDialogHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the user responds to the dialog.
/// </para>
/// <para>
/// When this is called the dialog has been hidden.
/// </para>
/// <para>
/// If you call gtk_native_dialog_hide() before the user responds to
/// the dialog this signal will not be emitted.
/// </para>
/// </summary>

	public static IObservable<GtkNativeDialogHandleSignalStructs.ResponseSignal> Signal_Response(this GtkNativeDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNativeDialogHandleSignalStructs.ResponseSignal> obs) =>
		{
			GtkNativeDialogHandleSignalDelegates.response handler = ( MentorLake.Gtk.GtkNativeDialogHandle self,  MentorLake.Gtk.GtkResponseType response_id,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNativeDialogHandleSignalStructs.ResponseSignal()
				{
					Self = self, ResponseId = response_id, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "response", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkNativeDialogHandleSignalStructs
{

public class ResponseSignal
{

	public MentorLake.Gtk.GtkNativeDialogHandle Self;
/// <summary>
/// <para>
/// the response ID
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkResponseType ResponseId;

	public IntPtr UserData;
}
}

public static class GtkNativeDialogHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the user responds to the dialog.
/// </para>
/// <para>
/// When this is called the dialog has been hidden.
/// </para>
/// <para>
/// If you call gtk_native_dialog_hide() before the user responds to
/// the dialog this signal will not be emitted.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="response_id">
/// the response ID
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self, MentorLake.Gtk.GtkResponseType response_id, IntPtr user_data);

}


public static class GtkNativeDialogHandleExtensions
{
/// <summary>
/// <para>
/// Destroys a dialog.
/// </para>
/// <para>
/// When a dialog is destroyed, it will break any references it holds
/// to other objects. If it is visible it will be hidden and any underlying
/// window system resources will be destroyed.
/// </para>
/// <para>
/// Note that this does not release any reference to the object (as opposed to
/// destroying a GtkWindow) because there is no reference from the windowing
/// system to the #GtkNativeDialog.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNativeDialog
/// </param>

	public static T Destroy<T>(this T self) where T : GtkNativeDialogHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNativeDialogHandle)");
		GtkNativeDialogHandleExterns.gtk_native_dialog_destroy(self);
		return self;
	}

/// <summary>
/// <para>
/// Returns whether the dialog is modal. See gtk_native_dialog_set_modal().
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNativeDialog
/// </param>
/// <return>
/// %TRUE if the dialog is set to be modal
/// </return>

	public static bool GetModal(this MentorLake.Gtk.GtkNativeDialogHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNativeDialogHandle)");
		return GtkNativeDialogHandleExterns.gtk_native_dialog_get_modal(self);
	}

/// <summary>
/// <para>
/// Gets the title of the #GtkNativeDialog.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNativeDialog
/// </param>
/// <return>
/// the title of the dialog, or %NULL if none has
///    been set explicitly. The returned string is owned by the widget
///    and must not be modified or freed.
/// </return>

	public static string GetTitle(this MentorLake.Gtk.GtkNativeDialogHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNativeDialogHandle)");
		return GtkNativeDialogHandleExterns.gtk_native_dialog_get_title(self);
	}

/// <summary>
/// <para>
/// Fetches the transient parent for this window. See
/// gtk_native_dialog_set_transient_for().
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNativeDialog
/// </param>
/// <return>
/// the transient parent for this window,
/// or %NULL if no transient parent has been set.
/// </return>

	public static MentorLake.Gtk.GtkWindowHandle GetTransientFor(this MentorLake.Gtk.GtkNativeDialogHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNativeDialogHandle)");
		return GtkNativeDialogHandleExterns.gtk_native_dialog_get_transient_for(self);
	}

/// <summary>
/// <para>
/// Determines whether the dialog is visible.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNativeDialog
/// </param>
/// <return>
/// %TRUE if the dialog is visible
/// </return>

	public static bool GetVisible(this MentorLake.Gtk.GtkNativeDialogHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNativeDialogHandle)");
		return GtkNativeDialogHandleExterns.gtk_native_dialog_get_visible(self);
	}

/// <summary>
/// <para>
/// Hides the dialog if it is visilbe, aborting any interaction. Once this
/// is called the  #GtkNativeDialog::response signal will not be emitted
/// until after the next call to gtk_native_dialog_show().
/// </para>
/// <para>
/// If the dialog is not visible this does nothing.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNativeDialog
/// </param>

	public static T Hide<T>(this T self) where T : GtkNativeDialogHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNativeDialogHandle)");
		GtkNativeDialogHandleExterns.gtk_native_dialog_hide(self);
		return self;
	}

/// <summary>
/// <para>
/// Blocks in a recursive main loop until @self emits the
/// #GtkNativeDialog::response signal. It then returns the response ID
/// from the ::response signal emission.
/// </para>
/// <para>
/// Before entering the recursive main loop, gtk_native_dialog_run()
/// calls gtk_native_dialog_show() on the dialog for you.
/// </para>
/// <para>
/// After gtk_native_dialog_run() returns, then dialog will be hidden.
/// </para>
/// <para>
/// Typical usage of this function might be:
/// |[<!-- language="C" -->
///   gint result = gtk_native_dialog_run (GTK_NATIVE_DIALOG (dialog));
///   switch (result)
///     {
///       case GTK_RESPONSE_ACCEPT:
///          do_application_specific_something ();
///          break;
///       default:
///          do_nothing_since_dialog_was_cancelled ();
///          break;
///     }
///   g_object_unref (dialog);
/// ]|
/// </para>
/// <para>
/// Note that even though the recursive main loop gives the effect of a
/// modal dialog (it prevents the user from interacting with other
/// windows in the same window group while the dialog is run), callbacks
/// such as timeouts, IO channel watches, DND drops, etc, will
/// be triggered during a gtk_native_dialog_run() call.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNativeDialog
/// </param>
/// <return>
/// response ID
/// </return>

	public static int Run(this MentorLake.Gtk.GtkNativeDialogHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNativeDialogHandle)");
		return GtkNativeDialogHandleExterns.gtk_native_dialog_run(self);
	}

/// <summary>
/// <para>
/// Sets a dialog modal or non-modal. Modal dialogs prevent interaction
/// with other windows in the same application. To keep modal dialogs
/// on top of main application windows, use
/// gtk_native_dialog_set_transient_for() to make the dialog transient for the
/// parent; most [window managers][gtk-X11-arch]
/// will then disallow lowering the dialog below the parent.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNativeDialog
/// </param>
/// <param name="modal">
/// whether the window is modal
/// </param>

	public static T SetModal<T>(this T self, bool modal) where T : GtkNativeDialogHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNativeDialogHandle)");
		GtkNativeDialogHandleExterns.gtk_native_dialog_set_modal(self, modal);
		return self;
	}

/// <summary>
/// <para>
/// Sets the title of the #GtkNativeDialog.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNativeDialog
/// </param>
/// <param name="title">
/// title of the dialog
/// </param>

	public static T SetTitle<T>(this T self, string title) where T : GtkNativeDialogHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNativeDialogHandle)");
		GtkNativeDialogHandleExterns.gtk_native_dialog_set_title(self, title);
		return self;
	}

/// <summary>
/// <para>
/// Dialog windows should be set transient for the main application
/// window they were spawned from. This allows
/// [window managers][gtk-X11-arch] to e.g. keep the
/// dialog on top of the main window, or center the dialog over the
/// main window.
/// </para>
/// <para>
/// Passing %NULL for @parent unsets the current transient window.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNativeDialog
/// </param>
/// <param name="parent">
/// parent window, or %NULL
/// </param>

	public static T SetTransientFor<T>(this T self, MentorLake.Gtk.GtkWindowHandle parent) where T : GtkNativeDialogHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNativeDialogHandle)");
		GtkNativeDialogHandleExterns.gtk_native_dialog_set_transient_for(self, parent);
		return self;
	}

/// <summary>
/// <para>
/// Shows the dialog on the display, allowing the user to interact with
/// it. When the user accepts the state of the dialog the dialog will
/// be automatically hidden and the #GtkNativeDialog::response signal
/// will be emitted.
/// </para>
/// <para>
/// Multiple calls while the dialog is visible will be ignored.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNativeDialog
/// </param>

	public static T Show<T>(this T self) where T : GtkNativeDialogHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNativeDialogHandle)");
		GtkNativeDialogHandleExterns.gtk_native_dialog_show(self);
		return self;
	}

}

internal class GtkNativeDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_native_dialog_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_native_dialog_get_modal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_native_dialog_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_native_dialog_get_transient_for([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_native_dialog_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_native_dialog_hide([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_native_dialog_run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_native_dialog_set_modal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self, bool modal);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_native_dialog_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_native_dialog_set_transient_for([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_native_dialog_show([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

}
