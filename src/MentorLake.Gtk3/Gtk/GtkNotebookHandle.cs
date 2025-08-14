namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkNotebook widget is a #GtkContainer whose children are pages that
/// can be switched between using tab labels along one edge.
/// </para>
/// <para>
/// There are many configuration options for GtkNotebook. Among other
/// things, you can choose on which edge the tabs appear
/// (see gtk_notebook_set_tab_pos()), whether, if there are too many
/// tabs to fit the notebook should be made bigger or scrolling
/// arrows added (see gtk_notebook_set_scrollable()), and whether there
/// will be a popup menu allowing the users to switch pages.
/// (see gtk_notebook_popup_enable(), gtk_notebook_popup_disable())
/// </para>
/// <para>
/// # GtkNotebook as GtkBuildable
/// </para>
/// <para>
/// The GtkNotebook implementation of the #GtkBuildable interface
/// supports placing children into tabs by specifying “tab” as the
/// “type” attribute of a `<child>` element. Note that the content
/// of the tab must be created before the tab can be filled.
/// A tab child can be specified without specifying a `<child>`
/// type attribute.
/// </para>
/// <para>
/// To add a child widget in the notebooks action area, specify
/// "action-start" or “action-end” as the “type” attribute of the
/// `<child>` element.
/// </para>
/// <para>
/// An example of a UI definition fragment with GtkNotebook:
/// </para>
/// <para>
/// |[<!-- language="xml" -->
/// <object class="GtkNotebook">
///   <child>
///     <object class="GtkLabel" id="notebook-content">
///       <property name="label">Content</property>
///     </object>
///   </child>
///   <child type="tab">
///     <object class="GtkLabel" id="notebook-tab">
///       <property name="label">Tab</property>
///     </object>
///   </child>
/// </object>
/// ]|
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// notebook
/// ├── header.top
/// │   ├── [<action widget>]
/// │   ├── tabs
/// │   │   ├── [arrow]
/// │   │   ├── tab
/// │   │   │   ╰── <tab label>
/// ┊   ┊   ┊
/// │   │   ├── tab[.reorderable-page]
/// │   │   │   ╰── <tab label>
/// │   │   ╰── [arrow]
/// │   ╰── [<action widget>]
/// │
/// ╰── stack
///     ├── <child>
///     ┊
///     ╰── <child>
/// ]|
/// </para>
/// <para>
/// GtkNotebook has a main CSS node with name notebook, a subnode
/// with name header and below that a subnode with name tabs which
/// contains one subnode per tab with name tab.
/// </para>
/// <para>
/// If action widgets are present, their CSS nodes are placed next
/// to the tabs node. If the notebook is scrollable, CSS nodes with
/// name arrow are placed as first and last child of the tabs node.
/// </para>
/// <para>
/// The main node gets the .frame style class when the notebook
/// has a border (see gtk_notebook_set_show_border()).
/// </para>
/// <para>
/// The header node gets one of the style class .top, .bottom,
/// .left or .right, depending on where the tabs are placed. For
/// reorderable pages, the tab node gets the .reorderable-page class.
/// </para>
/// <para>
/// A tab node gets the .dnd style class while it is moved with drag-and-drop.
/// </para>
/// <para>
/// The nodes are always arranged from left-to-right, regarldess of text direction.
/// </para>
/// </summary>

public class GtkNotebookHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkNotebook widget with no pages.
/// </para>
/// </summary>

/// <return>
/// the newly created #GtkNotebook
/// </return>

	public static MentorLake.Gtk.GtkNotebookHandle New()
	{
		return GtkNotebookHandleExterns.gtk_notebook_new();
	}

}
public static class GtkNotebookHandleSignalExtensions
{

	public static IObservable<GtkNotebookHandleSignalStructs.ChangeCurrentPageSignal> Signal_ChangeCurrentPage(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.ChangeCurrentPageSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.change_current_page handler = ( MentorLake.Gtk.GtkNotebookHandle self,  int @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.ChangeCurrentPageSignal()
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
/// <summary>
/// <para>
/// The ::create-window signal is emitted when a detachable
/// tab is dropped on the root window.
/// </para>
/// <para>
/// A handler for this signal can create a window containing
/// a notebook where the tab will be attached. It is also
/// responsible for moving/resizing the window and adding the
/// necessary properties to the notebook (e.g. the
/// #GtkNotebook:group-name ).
/// </para>
/// </summary>

	public static IObservable<GtkNotebookHandleSignalStructs.CreateWindowSignal> Signal_CreateWindow(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.CreateWindowSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.create_window handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkWidgetHandle page,  int x,  int y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.CreateWindowSignal()
				{
					Self = self, Page = page, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "create-window", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkNotebookHandleSignalStructs.FocusTabSignal> Signal_FocusTab(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.FocusTabSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.focus_tab handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkNotebookTab @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.FocusTabSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus-tab", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkNotebookHandleSignalStructs.MoveFocusOutSignal> Signal_MoveFocusOut(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.MoveFocusOutSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.move_focus_out handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkDirectionType @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.MoveFocusOutSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-focus-out", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// the ::page-added signal is emitted in the notebook
/// right after a page is added to the notebook.
/// </para>
/// </summary>

	public static IObservable<GtkNotebookHandleSignalStructs.PageAddedSignal> Signal_PageAdded(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.PageAddedSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.page_added handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkWidgetHandle child,  uint page_num,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.PageAddedSignal()
				{
					Self = self, Child = child, PageNum = page_num, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "page-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// the ::page-removed signal is emitted in the notebook
/// right after a page is removed from the notebook.
/// </para>
/// </summary>

	public static IObservable<GtkNotebookHandleSignalStructs.PageRemovedSignal> Signal_PageRemoved(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.PageRemovedSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.page_removed handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkWidgetHandle child,  uint page_num,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.PageRemovedSignal()
				{
					Self = self, Child = child, PageNum = page_num, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "page-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// the ::page-reordered signal is emitted in the notebook
/// right after a page has been reordered.
/// </para>
/// </summary>

	public static IObservable<GtkNotebookHandleSignalStructs.PageReorderedSignal> Signal_PageReordered(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.PageReorderedSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.page_reordered handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkWidgetHandle child,  uint page_num,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.PageReorderedSignal()
				{
					Self = self, Child = child, PageNum = page_num, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "page-reordered", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkNotebookHandleSignalStructs.ReorderTabSignal> Signal_ReorderTab(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.ReorderTabSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.reorder_tab handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkDirectionType @object,  bool p0,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.ReorderTabSignal()
				{
					Self = self, Object = @object, P0 = p0, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "reorder-tab", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkNotebookHandleSignalStructs.SelectPageSignal> Signal_SelectPage(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.SelectPageSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.select_page handler = ( MentorLake.Gtk.GtkNotebookHandle self,  bool @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.SelectPageSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "select-page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the user or a function changes the current page.
/// </para>
/// </summary>

	public static IObservable<GtkNotebookHandleSignalStructs.SwitchPageSignal> Signal_SwitchPage(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.SwitchPageSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.switch_page handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkWidgetHandle page,  uint page_num,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.SwitchPageSignal()
				{
					Self = self, Page = page, PageNum = page_num, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "switch-page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkNotebookHandleSignalStructs
{

public class ChangeCurrentPageSignal
{

	public MentorLake.Gtk.GtkNotebookHandle Self;

	public int Object;

	public IntPtr UserData;

	public bool ReturnValue;
}

public class CreateWindowSignal
{

	public MentorLake.Gtk.GtkNotebookHandle Self;
/// <summary>
/// <para>
/// the tab of @notebook that is being detached
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Page;
/// <summary>
/// <para>
/// the X coordinate where the drop happens
/// </para>
/// </summary>

	public int X;
/// <summary>
/// <para>
/// the Y coordinate where the drop happens
/// </para>
/// </summary>

	public int Y;

	public IntPtr UserData;
/// <summary>
/// <para>
/// a #GtkNotebook that @page should be
///     added to, or %NULL.
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkNotebookHandle ReturnValue;
}

public class FocusTabSignal
{

	public MentorLake.Gtk.GtkNotebookHandle Self;

	public MentorLake.Gtk.GtkNotebookTab Object;

	public IntPtr UserData;

	public bool ReturnValue;
}

public class MoveFocusOutSignal
{

	public MentorLake.Gtk.GtkNotebookHandle Self;

	public MentorLake.Gtk.GtkDirectionType Object;

	public IntPtr UserData;
}

public class PageAddedSignal
{

	public MentorLake.Gtk.GtkNotebookHandle Self;
/// <summary>
/// <para>
/// the child #GtkWidget affected
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Child;
/// <summary>
/// <para>
/// the new page number for @child
/// </para>
/// </summary>

	public uint PageNum;

	public IntPtr UserData;
}

public class PageRemovedSignal
{

	public MentorLake.Gtk.GtkNotebookHandle Self;
/// <summary>
/// <para>
/// the child #GtkWidget affected
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Child;
/// <summary>
/// <para>
/// the @child page number
/// </para>
/// </summary>

	public uint PageNum;

	public IntPtr UserData;
}

public class PageReorderedSignal
{

	public MentorLake.Gtk.GtkNotebookHandle Self;
/// <summary>
/// <para>
/// the child #GtkWidget affected
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Child;
/// <summary>
/// <para>
/// the new page number for @child
/// </para>
/// </summary>

	public uint PageNum;

	public IntPtr UserData;
}

public class ReorderTabSignal
{

	public MentorLake.Gtk.GtkNotebookHandle Self;

	public MentorLake.Gtk.GtkDirectionType Object;

	public bool P0;

	public IntPtr UserData;

	public bool ReturnValue;
}

public class SelectPageSignal
{

	public MentorLake.Gtk.GtkNotebookHandle Self;

	public bool Object;

	public IntPtr UserData;

	public bool ReturnValue;
}

public class SwitchPageSignal
{

	public MentorLake.Gtk.GtkNotebookHandle Self;
/// <summary>
/// <para>
/// the new current page
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Page;
/// <summary>
/// <para>
/// the index of the page
/// </para>
/// </summary>

	public uint PageNum;

	public IntPtr UserData;
}
}

public static class GtkNotebookHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool change_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, int @object, IntPtr user_data);


/// <summary>
/// <para>
/// The ::create-window signal is emitted when a detachable
/// tab is dropped on the root window.
/// </para>
/// <para>
/// A handler for this signal can create a window containing
/// a notebook where the tab will be attached. It is also
/// responsible for moving/resizing the window and adding the
/// necessary properties to the notebook (e.g. the
/// #GtkNotebook:group-name ).
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="page">
/// the tab of @notebook that is being detached
/// </param>
/// <param name="x">
/// the X coordinate where the drop happens
/// </param>
/// <param name="y">
/// the Y coordinate where the drop happens
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// a #GtkNotebook that @page should be
///     added to, or %NULL.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gtk.GtkNotebookHandle create_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, int x, int y, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus_tab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, MentorLake.Gtk.GtkNotebookTab @object, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_focus_out([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, MentorLake.Gtk.GtkDirectionType @object, IntPtr user_data);


/// <summary>
/// <para>
/// the ::page-added signal is emitted in the notebook
/// right after a page is added to the notebook.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="child">
/// the child #GtkWidget affected
/// </param>
/// <param name="page_num">
/// the new page number for @child
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void page_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, uint page_num, IntPtr user_data);


/// <summary>
/// <para>
/// the ::page-removed signal is emitted in the notebook
/// right after a page is removed from the notebook.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="child">
/// the child #GtkWidget affected
/// </param>
/// <param name="page_num">
/// the @child page number
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void page_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, uint page_num, IntPtr user_data);


/// <summary>
/// <para>
/// the ::page-reordered signal is emitted in the notebook
/// right after a page has been reordered.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="child">
/// the child #GtkWidget affected
/// </param>
/// <param name="page_num">
/// the new page number for @child
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void page_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, uint page_num, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="p0">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool reorder_tab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, MentorLake.Gtk.GtkDirectionType @object, bool p0, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool select_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, bool @object, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the user or a function changes the current page.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="page">
/// the new current page
/// </param>
/// <param name="page_num">
/// the index of the page
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void switch_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, uint page_num, IntPtr user_data);

}


public static class GtkNotebookHandleExtensions
{
/// <summary>
/// <para>
/// Appends a page to @notebook.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// the #GtkWidget to use as the contents of the page
/// </param>
/// <param name="tab_label">
/// the #GtkWidget to be used as the label
///     for the page, or %NULL to use the default label, “page N”
/// </param>
/// <return>
/// the index (starting from 0) of the appended
///     page in the notebook, or -1 if function fails
/// </return>

	public static int AppendPage(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_append_page(notebook, child, tab_label);
	}

/// <summary>
/// <para>
/// Appends a page to @notebook, specifying the widget to use as the
/// label in the popup menu.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// the #GtkWidget to use as the contents of the page
/// </param>
/// <param name="tab_label">
/// the #GtkWidget to be used as the label
///     for the page, or %NULL to use the default label, “page N”
/// </param>
/// <param name="menu_label">
/// the widget to use as a label for the
///     page-switch menu, if that is enabled. If %NULL, and @tab_label
///     is a #GtkLabel or %NULL, then the menu label will be a newly
///     created label with the same text as @tab_label; if @tab_label
///     is not a #GtkLabel, @menu_label must be specified if the
///     page-switch menu is to be used.
/// </param>
/// <return>
/// the index (starting from 0) of the appended
///     page in the notebook, or -1 if function fails
/// </return>

	public static int AppendPageMenu(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label, MentorLake.Gtk.GtkWidgetHandle menu_label)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_append_page_menu(notebook, child, tab_label, menu_label);
	}

/// <summary>
/// <para>
/// Removes the child from the notebook.
/// </para>
/// <para>
/// This function is very similar to gtk_container_remove(),
/// but additionally informs the notebook that the removal
/// is happening as part of a tab DND operation, which should
/// not be cancelled.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// a child
/// </param>

	public static T DetachTab<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_detach_tab(notebook, child);
		return notebook;
	}

/// <summary>
/// <para>
/// Gets one of the action widgets. See gtk_notebook_set_action_widget().
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="pack_type">
/// pack type of the action widget to receive
/// </param>
/// <return>
/// The action widget with the given
/// @pack_type or %NULL when this action widget has not been set
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetActionWidget(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkPackType pack_type)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_action_widget(notebook, pack_type);
	}

/// <summary>
/// <para>
/// Returns the page number of the current page.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <return>
/// the index (starting from 0) of the current
///     page in the notebook. If the notebook has no pages,
///     then -1 will be returned.
/// </return>

	public static int GetCurrentPage(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_current_page(notebook);
	}

/// <summary>
/// <para>
/// Gets the current group name for @notebook.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <return>
/// the group name, or %NULL if none is set
/// </return>

	public static string GetGroupName(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_group_name(notebook);
	}

/// <summary>
/// <para>
/// Retrieves the menu label widget of the page containing @child.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// a widget contained in a page of @notebook
/// </param>
/// <return>
/// the menu label, or %NULL if the
/// notebook page does not have a menu label other than the default (the tab
/// label).
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetMenuLabel(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_menu_label(notebook, child);
	}

/// <summary>
/// <para>
/// Retrieves the text of the menu label for the page containing
/// @child.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// the child widget of a page of the notebook.
/// </param>
/// <return>
/// the text of the tab label, or %NULL if the widget does
/// not have a menu label other than the default menu label, or the menu label
/// widget is not a #GtkLabel. The string is owned by the widget and must not be
/// freed.
/// </return>

	public static string GetMenuLabelText(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_menu_label_text(notebook, child);
	}

/// <summary>
/// <para>
/// Gets the number of pages in a notebook.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <return>
/// the number of pages in the notebook
/// </return>

	public static int GetNPages(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_n_pages(notebook);
	}

/// <summary>
/// <para>
/// Returns the child widget contained in page number @page_num.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="page_num">
/// the index of a page in the notebook, or -1
///     to get the last page
/// </param>
/// <return>
/// the child widget, or %NULL if @page_num
/// is out of bounds
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetNthPage(this MentorLake.Gtk.GtkNotebookHandle notebook, int page_num)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_nth_page(notebook, page_num);
	}

/// <summary>
/// <para>
/// Returns whether the tab label area has arrows for scrolling.
/// See gtk_notebook_set_scrollable().
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <return>
/// %TRUE if arrows for scrolling are present
/// </return>

	public static bool GetScrollable(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_scrollable(notebook);
	}

/// <summary>
/// <para>
/// Returns whether a bevel will be drawn around the notebook pages.
/// See gtk_notebook_set_show_border().
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <return>
/// %TRUE if the bevel is drawn
/// </return>

	public static bool GetShowBorder(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_show_border(notebook);
	}

/// <summary>
/// <para>
/// Returns whether the tabs of the notebook are shown.
/// See gtk_notebook_set_show_tabs().
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <return>
/// %TRUE if the tabs are shown
/// </return>

	public static bool GetShowTabs(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_show_tabs(notebook);
	}

/// <summary>
/// <para>
/// Returns whether the tab contents can be detached from @notebook.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// a child #GtkWidget
/// </param>
/// <return>
/// %TRUE if the tab is detachable.
/// </return>

	public static bool GetTabDetachable(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_detachable(notebook, child);
	}

/// <summary>
/// <para>
/// Returns the horizontal width of a tab border.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <return>
/// horizontal width of a tab border
/// </return>

	public static ushort GetTabHborder(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_hborder(notebook);
	}

/// <summary>
/// <para>
/// Returns the tab label widget for the page @child.
/// %NULL is returned if @child is not in @notebook or
/// if no tab label has specifically been set for @child.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// the page
/// </param>
/// <return>
/// the tab label
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetTabLabel(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_label(notebook, child);
	}

/// <summary>
/// <para>
/// Retrieves the text of the tab label for the page containing
/// @child.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// a widget contained in a page of @notebook
/// </param>
/// <return>
/// the text of the tab label, or %NULL if the tab label
/// widget is not a #GtkLabel. The string is owned by the widget and must not be
/// freed.
/// </return>

	public static string GetTabLabelText(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_label_text(notebook, child);
	}

/// <summary>
/// <para>
/// Gets the edge at which the tabs for switching pages in the
/// notebook are drawn.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <return>
/// the edge at which the tabs are drawn
/// </return>

	public static MentorLake.Gtk.GtkPositionType GetTabPos(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_pos(notebook);
	}

/// <summary>
/// <para>
/// Gets whether the tab can be reordered via drag and drop or not.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// a child #GtkWidget
/// </param>
/// <return>
/// %TRUE if the tab is reorderable.
/// </return>

	public static bool GetTabReorderable(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_reorderable(notebook, child);
	}

/// <summary>
/// <para>
/// Returns the vertical width of a tab border.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <return>
/// vertical width of a tab border
/// </return>

	public static ushort GetTabVborder(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_vborder(notebook);
	}

/// <summary>
/// <para>
/// Insert a page into @notebook at the given position.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// the #GtkWidget to use as the contents of the page
/// </param>
/// <param name="tab_label">
/// the #GtkWidget to be used as the label
///     for the page, or %NULL to use the default label, “page N”
/// </param>
/// <param name="position">
/// the index (starting at 0) at which to insert the page,
///     or -1 to append the page after all other pages
/// </param>
/// <return>
/// the index (starting from 0) of the inserted
///     page in the notebook, or -1 if function fails
/// </return>

	public static int InsertPage(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label, int position)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_insert_page(notebook, child, tab_label, position);
	}

/// <summary>
/// <para>
/// Insert a page into @notebook at the given position, specifying
/// the widget to use as the label in the popup menu.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// the #GtkWidget to use as the contents of the page
/// </param>
/// <param name="tab_label">
/// the #GtkWidget to be used as the label
///     for the page, or %NULL to use the default label, “page N”
/// </param>
/// <param name="menu_label">
/// the widget to use as a label for the
///     page-switch menu, if that is enabled. If %NULL, and @tab_label
///     is a #GtkLabel or %NULL, then the menu label will be a newly
///     created label with the same text as @tab_label; if @tab_label
///     is not a #GtkLabel, @menu_label must be specified if the
///     page-switch menu is to be used.
/// </param>
/// <param name="position">
/// the index (starting at 0) at which to insert the page,
///     or -1 to append the page after all other pages.
/// </param>
/// <return>
/// the index (starting from 0) of the inserted
///     page in the notebook
/// </return>

	public static int InsertPageMenu(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label, MentorLake.Gtk.GtkWidgetHandle menu_label, int position)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_insert_page_menu(notebook, child, tab_label, menu_label, position);
	}

/// <summary>
/// <para>
/// Switches to the next page. Nothing happens if the current page is
/// the last page.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>

	public static T NextPage<T>(this T notebook) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_next_page(notebook);
		return notebook;
	}

/// <summary>
/// <para>
/// Finds the index of the page which contains the given child
/// widget.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// a #GtkWidget
/// </param>
/// <return>
/// the index of the page containing @child, or
///     -1 if @child is not in the notebook
/// </return>

	public static int PageNum(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_page_num(notebook, child);
	}

/// <summary>
/// <para>
/// Disables the popup menu.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>

	public static T PopupDisable<T>(this T notebook) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_popup_disable(notebook);
		return notebook;
	}

/// <summary>
/// <para>
/// Enables the popup menu: if the user clicks with the right
/// mouse button on the tab labels, a menu with all the pages
/// will be popped up.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>

	public static T PopupEnable<T>(this T notebook) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_popup_enable(notebook);
		return notebook;
	}

/// <summary>
/// <para>
/// Prepends a page to @notebook.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// the #GtkWidget to use as the contents of the page
/// </param>
/// <param name="tab_label">
/// the #GtkWidget to be used as the label
///     for the page, or %NULL to use the default label, “page N”
/// </param>
/// <return>
/// the index (starting from 0) of the prepended
///     page in the notebook, or -1 if function fails
/// </return>

	public static int PrependPage(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_prepend_page(notebook, child, tab_label);
	}

/// <summary>
/// <para>
/// Prepends a page to @notebook, specifying the widget to use as the
/// label in the popup menu.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// the #GtkWidget to use as the contents of the page
/// </param>
/// <param name="tab_label">
/// the #GtkWidget to be used as the label
///     for the page, or %NULL to use the default label, “page N”
/// </param>
/// <param name="menu_label">
/// the widget to use as a label for the
///     page-switch menu, if that is enabled. If %NULL, and @tab_label
///     is a #GtkLabel or %NULL, then the menu label will be a newly
///     created label with the same text as @tab_label; if @tab_label
///     is not a #GtkLabel, @menu_label must be specified if the
///     page-switch menu is to be used.
/// </param>
/// <return>
/// the index (starting from 0) of the prepended
///     page in the notebook, or -1 if function fails
/// </return>

	public static int PrependPageMenu(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label, MentorLake.Gtk.GtkWidgetHandle menu_label)
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_prepend_page_menu(notebook, child, tab_label, menu_label);
	}

/// <summary>
/// <para>
/// Switches to the previous page. Nothing happens if the current page
/// is the first page.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>

	public static T PrevPage<T>(this T notebook) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_prev_page(notebook);
		return notebook;
	}

/// <summary>
/// <para>
/// Removes a page from the notebook given its index
/// in the notebook.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="page_num">
/// the index of a notebook page, starting
///     from 0. If -1, the last page will be removed.
/// </param>

	public static T RemovePage<T>(this T notebook, int page_num) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_remove_page(notebook, page_num);
		return notebook;
	}

/// <summary>
/// <para>
/// Reorders the page containing @child, so that it appears in position
/// @position. If @position is greater than or equal to the number of
/// children in the list or negative, @child will be moved to the end
/// of the list.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// the child to move
/// </param>
/// <param name="position">
/// the new position, or -1 to move to the end
/// </param>

	public static T ReorderChild<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, int position) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_reorder_child(notebook, child, position);
		return notebook;
	}

/// <summary>
/// <para>
/// Sets @widget as one of the action widgets. Depending on the pack type
/// the widget will be placed before or after the tabs. You can use
/// a #GtkBox if you need to pack more than one widget on the same side.
/// </para>
/// <para>
/// Note that action widgets are “internal” children of the notebook and thus
/// not included in the list returned from gtk_container_foreach().
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="pack_type">
/// pack type of the action widget
/// </param>

	public static T SetActionWidget<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkPackType pack_type) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_action_widget(notebook, widget, pack_type);
		return notebook;
	}

/// <summary>
/// <para>
/// Switches to the page number @page_num.
/// </para>
/// <para>
/// Note that due to historical reasons, GtkNotebook refuses
/// to switch to a page unless the child widget is visible.
/// Therefore, it is recommended to show child widgets before
/// adding them to a notebook.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="page_num">
/// index of the page to switch to, starting from 0.
///     If negative, the last page will be used. If greater
///     than the number of pages in the notebook, nothing
///     will be done.
/// </param>

	public static T SetCurrentPage<T>(this T notebook, int page_num) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_current_page(notebook, page_num);
		return notebook;
	}

/// <summary>
/// <para>
/// Sets a group name for @notebook.
/// </para>
/// <para>
/// Notebooks with the same name will be able to exchange tabs
/// via drag and drop. A notebook with a %NULL group name will
/// not be able to exchange tabs with any other notebook.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="group_name">
/// the name of the notebook group,
///     or %NULL to unset it
/// </param>

	public static T SetGroupName<T>(this T notebook, string group_name) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_group_name(notebook, group_name);
		return notebook;
	}

/// <summary>
/// <para>
/// Changes the menu label for the page containing @child.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// the child widget
/// </param>
/// <param name="menu_label">
/// the menu label, or %NULL for default
/// </param>

	public static T SetMenuLabel<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle menu_label) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_menu_label(notebook, child, menu_label);
		return notebook;
	}

/// <summary>
/// <para>
/// Creates a new label and sets it as the menu label of @child.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// the child widget
/// </param>
/// <param name="menu_text">
/// the label text
/// </param>

	public static T SetMenuLabelText<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, string menu_text) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_menu_label_text(notebook, child, menu_text);
		return notebook;
	}

/// <summary>
/// <para>
/// Sets whether the tab label area will have arrows for
/// scrolling if there are too many tabs to fit in the area.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="scrollable">
/// %TRUE if scroll arrows should be added
/// </param>

	public static T SetScrollable<T>(this T notebook, bool scrollable) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_scrollable(notebook, scrollable);
		return notebook;
	}

/// <summary>
/// <para>
/// Sets whether a bevel will be drawn around the notebook pages.
/// This only has a visual effect when the tabs are not shown.
/// See gtk_notebook_set_show_tabs().
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="show_border">
/// %TRUE if a bevel should be drawn around the notebook
/// </param>

	public static T SetShowBorder<T>(this T notebook, bool show_border) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_show_border(notebook, show_border);
		return notebook;
	}

/// <summary>
/// <para>
/// Sets whether to show the tabs for the notebook or not.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="show_tabs">
/// %TRUE if the tabs should be shown
/// </param>

	public static T SetShowTabs<T>(this T notebook, bool show_tabs) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_show_tabs(notebook, show_tabs);
		return notebook;
	}

/// <summary>
/// <para>
/// Sets whether the tab can be detached from @notebook to another
/// notebook or widget.
/// </para>
/// <para>
/// Note that 2 notebooks must share a common group identificator
/// (see gtk_notebook_set_group_name()) to allow automatic tabs
/// interchange between them.
/// </para>
/// <para>
/// If you want a widget to interact with a notebook through DnD
/// (i.e.: accept dragged tabs from it) it must be set as a drop
/// destination and accept the target “GTK_NOTEBOOK_TAB”. The notebook
/// will fill the selection with a GtkWidget** pointing to the child
/// widget that corresponds to the dropped tab.
/// </para>
/// <para>
/// Note that you should use gtk_notebook_detach_tab() instead
/// of gtk_container_remove() if you want to remove the tab from
/// the source notebook as part of accepting a drop. Otherwise,
/// the source notebook will think that the dragged tab was
/// removed from underneath the ongoing drag operation, and
/// will initiate a drag cancel animation.
/// </para>
/// <para>
/// |[<!-- language="C" -->
///  static void
///  on_drag_data_received (GtkWidget        *widget,
///                         GdkDragContext   *context,
///                         gint              x,
///                         gint              y,
///                         GtkSelectionData *data,
///                         guint             info,
///                         guint             time,
///                         gpointer          user_data)
///  {
///    GtkWidget *notebook;
///    GtkWidget **child;
/// </para>
/// <para>
///    notebook = gtk_drag_get_source_widget (context);
///    child = (void*) gtk_selection_data_get_data (data);
/// </para>
/// <para>
///    // process_widget (*child);
/// </para>
/// <para>
///    gtk_notebook_detach_tab (GTK_NOTEBOOK (notebook), *child);
///  }
/// ]|
/// </para>
/// <para>
/// If you want a notebook to accept drags from other widgets,
/// you will have to set your own DnD code to do it.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// a child #GtkWidget
/// </param>
/// <param name="detachable">
/// whether the tab is detachable or not
/// </param>

	public static T SetTabDetachable<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, bool detachable) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_tab_detachable(notebook, child, detachable);
		return notebook;
	}

/// <summary>
/// <para>
/// Changes the tab label for @child.
/// If %NULL is specified for @tab_label, then the page will
/// have the label “page N”.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// the page
/// </param>
/// <param name="tab_label">
/// the tab label widget to use, or %NULL
///     for default tab label
/// </param>

	public static T SetTabLabel<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_tab_label(notebook, child, tab_label);
		return notebook;
	}

/// <summary>
/// <para>
/// Creates a new label and sets it as the tab label for the page
/// containing @child.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// the page
/// </param>
/// <param name="tab_text">
/// the label text
/// </param>

	public static T SetTabLabelText<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, string tab_text) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_tab_label_text(notebook, child, tab_text);
		return notebook;
	}

/// <summary>
/// <para>
/// Sets the edge at which the tabs for switching pages in the
/// notebook are drawn.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook.
/// </param>
/// <param name="pos">
/// the edge to draw the tabs at
/// </param>

	public static T SetTabPos<T>(this T notebook, MentorLake.Gtk.GtkPositionType pos) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_tab_pos(notebook, pos);
		return notebook;
	}

/// <summary>
/// <para>
/// Sets whether the notebook tab can be reordered
/// via drag and drop or not.
/// </para>
/// </summary>

/// <param name="notebook">
/// a #GtkNotebook
/// </param>
/// <param name="child">
/// a child #GtkWidget
/// </param>
/// <param name="reorderable">
/// whether the tab is reorderable or not
/// </param>

	public static T SetTabReorderable<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, bool reorderable) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid) throw new Exception("Invalid handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_tab_reorderable(notebook, child, reorderable);
		return notebook;
	}

}

internal class GtkNotebookHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))]
	internal static extern MentorLake.Gtk.GtkNotebookHandle gtk_notebook_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_append_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_append_page_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_detach_tab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_notebook_get_action_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkPackType pack_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_get_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_notebook_get_group_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_notebook_get_menu_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_notebook_get_menu_label_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_get_n_pages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_notebook_get_nth_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, int page_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_notebook_get_scrollable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_notebook_get_show_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_notebook_get_show_tabs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_notebook_get_tab_detachable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern ushort gtk_notebook_get_tab_hborder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_notebook_get_tab_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_notebook_get_tab_label_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPositionType gtk_notebook_get_tab_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_notebook_get_tab_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern ushort gtk_notebook_get_tab_vborder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_insert_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_insert_page_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_label, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_next_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_page_num([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_popup_disable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_popup_enable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_prepend_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_prepend_page_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_prev_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_remove_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, int page_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_reorder_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_action_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkPackType pack_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, int page_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_group_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, string group_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_menu_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_menu_label_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string menu_text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_scrollable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, bool scrollable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_show_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, bool show_border);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_show_tabs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, bool show_tabs);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_tab_detachable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool detachable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_tab_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_tab_label_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string tab_text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_tab_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkPositionType pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_tab_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool reorderable);

}
