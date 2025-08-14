namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkShortcutsWindow shows brief information about the keyboard shortcuts
/// and gestures of an application. The shortcuts can be grouped, and you can
/// have multiple sections in this window, corresponding to the major modes of
/// your application.
/// </para>
/// <para>
/// Additionally, the shortcuts can be filtered by the current view, to avoid
/// showing information that is not relevant in the current application context.
/// </para>
/// <para>
/// The recommended way to construct a GtkShortcutsWindow is with GtkBuilder,
/// by populating a #GtkShortcutsWindow with one or more #GtkShortcutsSection
/// objects, which contain #GtkShortcutsGroups that in turn contain objects of
/// class #GtkShortcutsShortcut.
/// </para>
/// <para>
/// # A simple example:
/// </para>
/// <para>
/// ![](gedit-shortcuts.png)
/// </para>
/// <para>
/// This example has as single section. As you can see, the shortcut groups
/// are arranged in columns, and spread across several pages if there are too
/// many to find on a single page.
/// </para>
/// <para>
/// The .ui file for this example can be found [here](https://git.gnome.org/browse/gtk+/tree/demos/gtk-demo/shortcuts-gedit.ui).
/// </para>
/// <para>
/// # An example with multiple views:
/// </para>
/// <para>
/// ![](clocks-shortcuts.png)
/// </para>
/// <para>
/// This example shows a #GtkShortcutsWindow that has been configured to show only
/// the shortcuts relevant to the "stopwatch" view.
/// </para>
/// <para>
/// The .ui file for this example can be found [here](https://git.gnome.org/browse/gtk+/tree/demos/gtk-demo/shortcuts-clocks.ui).
/// </para>
/// <para>
/// # An example with multiple sections:
/// </para>
/// <para>
/// ![](builder-shortcuts.png)
/// </para>
/// <para>
/// This example shows a #GtkShortcutsWindow with two sections, "Editor Shortcuts"
/// and "Terminal Shortcuts".
/// </para>
/// <para>
/// The .ui file for this example can be found [here](https://git.gnome.org/browse/gtk+/tree/demos/gtk-demo/shortcuts-builder.ui).
/// </para>
/// </summary>

public class GtkShortcutsWindowHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}
public static class GtkShortcutsWindowHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::close signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user uses a keybinding to close
/// the window.
/// </para>
/// <para>
/// The default binding for this signal is the Escape key.
/// </para>
/// </summary>

	public static IObservable<GtkShortcutsWindowHandleSignalStructs.CloseSignal> Signal_Close(this GtkShortcutsWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkShortcutsWindowHandleSignalStructs.CloseSignal> obs) =>
		{
			GtkShortcutsWindowHandleSignalDelegates.close handler = ( MentorLake.Gtk.GtkShortcutsWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkShortcutsWindowHandleSignalStructs.CloseSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "close", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::search signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user uses a keybinding to start a search.
/// </para>
/// <para>
/// The default binding for this signal is Control-F.
/// </para>
/// </summary>

	public static IObservable<GtkShortcutsWindowHandleSignalStructs.SearchSignal> Signal_Search(this GtkShortcutsWindowHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkShortcutsWindowHandleSignalStructs.SearchSignal> obs) =>
		{
			GtkShortcutsWindowHandleSignalDelegates.search handler = ( MentorLake.Gtk.GtkShortcutsWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkShortcutsWindowHandleSignalStructs.SearchSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "search", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkShortcutsWindowHandleSignalStructs
{

public class CloseSignal
{

	public MentorLake.Gtk.GtkShortcutsWindowHandle Self;

	public IntPtr UserData;
}

public class SearchSignal
{

	public MentorLake.Gtk.GtkShortcutsWindowHandle Self;

	public IntPtr UserData;
}
}

public static class GtkShortcutsWindowHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::close signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user uses a keybinding to close
/// the window.
/// </para>
/// <para>
/// The default binding for this signal is the Escape key.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutsWindowHandle>))] MentorLake.Gtk.GtkShortcutsWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::search signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user uses a keybinding to start a search.
/// </para>
/// <para>
/// The default binding for this signal is Control-F.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutsWindowHandle>))] MentorLake.Gtk.GtkShortcutsWindowHandle self, IntPtr user_data);

}


public static class GtkShortcutsWindowHandleExtensions
{
}

internal class GtkShortcutsWindowHandleExterns
{
}
