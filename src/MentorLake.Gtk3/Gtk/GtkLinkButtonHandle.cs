namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkLinkButton is a #GtkButton with a hyperlink, similar to the one
/// used by web browsers, which triggers an action when clicked. It is useful
/// to show quick links to resources.
/// </para>
/// <para>
/// A link button is created by calling either gtk_link_button_new() or
/// gtk_link_button_new_with_label(). If using the former, the URI you pass
/// to the constructor is used as a label for the widget.
/// </para>
/// <para>
/// The URI bound to a GtkLinkButton can be set specifically using
/// gtk_link_button_set_uri(), and retrieved using gtk_link_button_get_uri().
/// </para>
/// <para>
/// By default, GtkLinkButton calls gtk_show_uri_on_window() when the button is
/// clicked. This behaviour can be overridden by connecting to the
/// #GtkLinkButton::activate-link signal and returning %TRUE from the
/// signal handler.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkLinkButton has a single CSS node with name button. To differentiate
/// it from a plain #GtkButton, it gets the .link style class.
/// </para>
/// </summary>

public class GtkLinkButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkLinkButton with the URI as its text.
/// </para>
/// </summary>

/// <param name="uri">
/// a valid URI
/// </param>
/// <return>
/// a new link button widget.
/// </return>

	public static MentorLake.Gtk.GtkLinkButtonHandle New(string uri)
	{
		return GtkLinkButtonHandleExterns.gtk_link_button_new(uri);
	}

/// <summary>
/// <para>
/// Creates a new #GtkLinkButton containing a label.
/// </para>
/// </summary>

/// <param name="uri">
/// a valid URI
/// </param>
/// <param name="label">
/// the text of the button
/// </param>
/// <return>
/// a new link button widget.
/// </return>

	public static MentorLake.Gtk.GtkLinkButtonHandle NewWithLabel(string uri, string label)
	{
		return GtkLinkButtonHandleExterns.gtk_link_button_new_with_label(uri, label);
	}

}
public static class GtkLinkButtonHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::activate-link signal is emitted each time the #GtkLinkButton
/// has been clicked.
/// </para>
/// <para>
/// The default handler will call gtk_show_uri_on_window() with the URI stored inside
/// the #GtkLinkButton:uri property.
/// </para>
/// <para>
/// To override the default behavior, you can connect to the ::activate-link
/// signal and stop the propagation of the signal by returning %TRUE from
/// your handler.
/// </para>
/// </summary>

	public static IObservable<GtkLinkButtonHandleSignalStructs.ActivateLinkSignal> Signal_ActivateLink(this GtkLinkButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLinkButtonHandleSignalStructs.ActivateLinkSignal> obs) =>
		{
			GtkLinkButtonHandleSignalDelegates.activate_link handler = ( MentorLake.Gtk.GtkLinkButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLinkButtonHandleSignalStructs.ActivateLinkSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-link", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkLinkButtonHandleSignalStructs
{

public class ActivateLinkSignal
{

	public MentorLake.Gtk.GtkLinkButtonHandle Self;

	public IntPtr UserData;

	public bool ReturnValue;
}
}

public static class GtkLinkButtonHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::activate-link signal is emitted each time the #GtkLinkButton
/// has been clicked.
/// </para>
/// <para>
/// The default handler will call gtk_show_uri_on_window() with the URI stored inside
/// the #GtkLinkButton:uri property.
/// </para>
/// <para>
/// To override the default behavior, you can connect to the ::activate-link
/// signal and stop the propagation of the signal by returning %TRUE from
/// your handler.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool activate_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLinkButtonHandle>))] MentorLake.Gtk.GtkLinkButtonHandle self, IntPtr user_data);

}


public static class GtkLinkButtonHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the URI set using gtk_link_button_set_uri().
/// </para>
/// </summary>

/// <param name="link_button">
/// a #GtkLinkButton
/// </param>
/// <return>
/// a valid URI.  The returned string is owned by the link button
///   and should not be modified or freed.
/// </return>

	public static string GetUri(this MentorLake.Gtk.GtkLinkButtonHandle link_button)
	{
		if (link_button.IsInvalid) throw new Exception("Invalid handle (GtkLinkButtonHandle)");
		return GtkLinkButtonHandleExterns.gtk_link_button_get_uri(link_button);
	}

/// <summary>
/// <para>
/// Retrieves the “visited” state of the URI where the #GtkLinkButton
/// points. The button becomes visited when it is clicked. If the URI
/// is changed on the button, the “visited” state is unset again.
/// </para>
/// <para>
/// The state may also be changed using gtk_link_button_set_visited().
/// </para>
/// </summary>

/// <param name="link_button">
/// a #GtkLinkButton
/// </param>
/// <return>
/// %TRUE if the link has been visited, %FALSE otherwise
/// </return>

	public static bool GetVisited(this MentorLake.Gtk.GtkLinkButtonHandle link_button)
	{
		if (link_button.IsInvalid) throw new Exception("Invalid handle (GtkLinkButtonHandle)");
		return GtkLinkButtonHandleExterns.gtk_link_button_get_visited(link_button);
	}

/// <summary>
/// <para>
/// Sets @uri as the URI where the #GtkLinkButton points. As a side-effect
/// this unsets the “visited” state of the button.
/// </para>
/// </summary>

/// <param name="link_button">
/// a #GtkLinkButton
/// </param>
/// <param name="uri">
/// a valid URI
/// </param>

	public static T SetUri<T>(this T link_button, string uri) where T : GtkLinkButtonHandle
	{
		if (link_button.IsInvalid) throw new Exception("Invalid handle (GtkLinkButtonHandle)");
		GtkLinkButtonHandleExterns.gtk_link_button_set_uri(link_button, uri);
		return link_button;
	}

/// <summary>
/// <para>
/// Sets the “visited” state of the URI where the #GtkLinkButton
/// points.  See gtk_link_button_get_visited() for more details.
/// </para>
/// </summary>

/// <param name="link_button">
/// a #GtkLinkButton
/// </param>
/// <param name="visited">
/// the new “visited” state
/// </param>

	public static T SetVisited<T>(this T link_button, bool visited) where T : GtkLinkButtonHandle
	{
		if (link_button.IsInvalid) throw new Exception("Invalid handle (GtkLinkButtonHandle)");
		GtkLinkButtonHandleExterns.gtk_link_button_set_visited(link_button, visited);
		return link_button;
	}

}

internal class GtkLinkButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkLinkButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkLinkButtonHandle gtk_link_button_new(string uri);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkLinkButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkLinkButtonHandle gtk_link_button_new_with_label(string uri, string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_link_button_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLinkButtonHandle>))] MentorLake.Gtk.GtkLinkButtonHandle link_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_link_button_get_visited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLinkButtonHandle>))] MentorLake.Gtk.GtkLinkButtonHandle link_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_link_button_set_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLinkButtonHandle>))] MentorLake.Gtk.GtkLinkButtonHandle link_button, string uri);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_link_button_set_visited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLinkButtonHandle>))] MentorLake.Gtk.GtkLinkButtonHandle link_button, bool visited);

}
