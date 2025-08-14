namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkAssistant is a widget used to represent a generally complex
/// operation splitted in several steps, guiding the user through its
/// pages and controlling the page flow to collect the necessary data.
/// </para>
/// <para>
/// The design of GtkAssistant is that it controls what buttons to show
/// and to make sensitive, based on what it knows about the page sequence
/// and the [type][GtkAssistantPageType] of each page,
/// in addition to state information like the page
/// [completion][gtk-assistant-set-page-complete]
/// and [committed][gtk-assistant-commit] status.
/// </para>
/// <para>
/// If you have a case that doesn’t quite fit in #GtkAssistants way of
/// handling buttons, you can use the #GTK_ASSISTANT_PAGE_CUSTOM page
/// type and handle buttons yourself.
/// </para>
/// <para>
/// # GtkAssistant as GtkBuildable
/// </para>
/// <para>
/// The GtkAssistant implementation of the #GtkBuildable interface
/// exposes the @action_area as internal children with the name
/// “action_area”.
/// </para>
/// <para>
/// To add pages to an assistant in #GtkBuilder, simply add it as a
/// child to the GtkAssistant object, and set its child properties
/// as necessary.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkAssistant has a single CSS node with the name assistant.
/// </para>
/// </summary>

public class GtkAssistantHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkAssistant.
/// </para>
/// </summary>

/// <return>
/// a newly created #GtkAssistant
/// </return>

	public static MentorLake.Gtk.GtkAssistantHandle New()
	{
		return GtkAssistantHandleExterns.gtk_assistant_new();
	}

}
public static class GtkAssistantHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::apply signal is emitted when the apply button is clicked.
/// </para>
/// <para>
/// The default behavior of the #GtkAssistant is to switch to the page
/// after the current page, unless the current page is the last one.
/// </para>
/// <para>
/// A handler for the ::apply signal should carry out the actions for
/// which the wizard has collected data. If the action takes a long time
/// to complete, you might consider putting a page of type
/// %GTK_ASSISTANT_PAGE_PROGRESS after the confirmation page and handle
/// this operation within the #GtkAssistant::prepare signal of the progress
/// page.
/// </para>
/// </summary>

	public static IObservable<GtkAssistantHandleSignalStructs.ApplySignal> Signal_Apply(this GtkAssistantHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAssistantHandleSignalStructs.ApplySignal> obs) =>
		{
			GtkAssistantHandleSignalDelegates.apply handler = ( MentorLake.Gtk.GtkAssistantHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantHandleSignalStructs.ApplySignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "apply", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::cancel signal is emitted when then the cancel button is clicked.
/// </para>
/// </summary>

	public static IObservable<GtkAssistantHandleSignalStructs.CancelSignal> Signal_Cancel(this GtkAssistantHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAssistantHandleSignalStructs.CancelSignal> obs) =>
		{
			GtkAssistantHandleSignalDelegates.cancel handler = ( MentorLake.Gtk.GtkAssistantHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantHandleSignalStructs.CancelSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cancel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::close signal is emitted either when the close button of
/// a summary page is clicked, or when the apply button in the last
/// page in the flow (of type %GTK_ASSISTANT_PAGE_CONFIRM) is clicked.
/// </para>
/// </summary>

	public static IObservable<GtkAssistantHandleSignalStructs.CloseSignal> Signal_Close(this GtkAssistantHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAssistantHandleSignalStructs.CloseSignal> obs) =>
		{
			GtkAssistantHandleSignalDelegates.close handler = ( MentorLake.Gtk.GtkAssistantHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantHandleSignalStructs.CloseSignal()
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

	public static IObservable<GtkAssistantHandleSignalStructs.EscapeSignal> Signal_Escape(this GtkAssistantHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAssistantHandleSignalStructs.EscapeSignal> obs) =>
		{
			GtkAssistantHandleSignalDelegates.escape handler = ( MentorLake.Gtk.GtkAssistantHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantHandleSignalStructs.EscapeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "escape", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::prepare signal is emitted when a new page is set as the
/// assistant's current page, before making the new page visible.
/// </para>
/// <para>
/// A handler for this signal can do any preparations which are
/// necessary before showing @page.
/// </para>
/// </summary>

	public static IObservable<GtkAssistantHandleSignalStructs.PrepareSignal> Signal_Prepare(this GtkAssistantHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAssistantHandleSignalStructs.PrepareSignal> obs) =>
		{
			GtkAssistantHandleSignalDelegates.prepare handler = ( MentorLake.Gtk.GtkAssistantHandle self,  MentorLake.Gtk.GtkWidgetHandle page,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAssistantHandleSignalStructs.PrepareSignal()
				{
					Self = self, Page = page, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "prepare", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkAssistantHandleSignalStructs
{

public class ApplySignal
{

	public MentorLake.Gtk.GtkAssistantHandle Self;

	public IntPtr UserData;
}

public class CancelSignal
{

	public MentorLake.Gtk.GtkAssistantHandle Self;

	public IntPtr UserData;
}

public class CloseSignal
{

	public MentorLake.Gtk.GtkAssistantHandle Self;

	public IntPtr UserData;
}

public class EscapeSignal
{

	public MentorLake.Gtk.GtkAssistantHandle Self;

	public IntPtr UserData;
}

public class PrepareSignal
{

	public MentorLake.Gtk.GtkAssistantHandle Self;
/// <summary>
/// <para>
/// the current page
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Page;

	public IntPtr UserData;
}
}

public static class GtkAssistantHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::apply signal is emitted when the apply button is clicked.
/// </para>
/// <para>
/// The default behavior of the #GtkAssistant is to switch to the page
/// after the current page, unless the current page is the last one.
/// </para>
/// <para>
/// A handler for the ::apply signal should carry out the actions for
/// which the wizard has collected data. If the action takes a long time
/// to complete, you might consider putting a page of type
/// %GTK_ASSISTANT_PAGE_PROGRESS after the confirmation page and handle
/// this operation within the #GtkAssistant::prepare signal of the progress
/// page.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void apply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::cancel signal is emitted when then the cancel button is clicked.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::close signal is emitted either when the close button of
/// a summary page is clicked, or when the apply button in the last
/// page in the flow (of type %GTK_ASSISTANT_PAGE_CONFIRM) is clicked.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void escape([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::prepare signal is emitted when a new page is set as the
/// assistant's current page, before making the new page visible.
/// </para>
/// <para>
/// A handler for this signal can do any preparations which are
/// necessary before showing @page.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="page">
/// the current page
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void prepare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, IntPtr user_data);

}


public static class GtkAssistantHandleExtensions
{
/// <summary>
/// <para>
/// Adds a widget to the action area of a #GtkAssistant.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="child">
/// a #GtkWidget
/// </param>

	public static T AddActionWidget<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_add_action_widget(assistant, child);
		return assistant;
	}

/// <summary>
/// <para>
/// Appends a page to the @assistant.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a #GtkWidget
/// </param>
/// <return>
/// the index (starting at 0) of the inserted page
/// </return>

	public static int AppendPage(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_append_page(assistant, page);
	}

/// <summary>
/// <para>
/// Erases the visited page history so the back button is not
/// shown on the current page, and removes the cancel button
/// from subsequent pages.
/// </para>
/// <para>
/// Use this when the information provided up to the current
/// page is hereafter deemed permanent and cannot be modified
/// or undone. For example, showing a progress page to track
/// a long-running, unreversible operation after the user has
/// clicked apply on a confirmation page.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>

	public static T Commit<T>(this T assistant) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_commit(assistant);
		return assistant;
	}

/// <summary>
/// <para>
/// Returns the page number of the current page.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <return>
/// The index (starting from 0) of the current
///     page in the @assistant, or -1 if the @assistant has no pages,
///     or no current page.
/// </return>

	public static int GetCurrentPage(this MentorLake.Gtk.GtkAssistantHandle assistant)
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_current_page(assistant);
	}

/// <summary>
/// <para>
/// Returns the number of pages in the @assistant
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <return>
/// the number of pages in the @assistant
/// </return>

	public static int GetNPages(this MentorLake.Gtk.GtkAssistantHandle assistant)
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_n_pages(assistant);
	}

/// <summary>
/// <para>
/// Returns the child widget contained in page number @page_num.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page_num">
/// the index of a page in the @assistant,
///     or -1 to get the last page
/// </param>
/// <return>
/// the child widget, or %NULL
///     if @page_num is out of bounds
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetNthPage(this MentorLake.Gtk.GtkAssistantHandle assistant, int page_num)
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_nth_page(assistant, page_num);
	}

/// <summary>
/// <para>
/// Gets whether @page is complete.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a page of @assistant
/// </param>
/// <return>
/// %TRUE if @page is complete.
/// </return>

	public static bool GetPageComplete(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_page_complete(assistant, page);
	}

/// <summary>
/// <para>
/// Gets whether page has padding.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a page of @assistant
/// </param>
/// <return>
/// %TRUE if @page has padding
/// </return>

	public static bool GetPageHasPadding(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_page_has_padding(assistant, page);
	}

/// <summary>
/// <para>
/// Gets the header image for @page.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a page of @assistant
/// </param>
/// <return>
/// the header image for @page,
///     or %NULL if there’s no header image for the page
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPageHeaderImage(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_page_header_image(assistant, page);
	}

/// <summary>
/// <para>
/// Gets the side image for @page.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a page of @assistant
/// </param>
/// <return>
/// the side image for @page,
///     or %NULL if there’s no side image for the page
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPageSideImage(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_page_side_image(assistant, page);
	}

/// <summary>
/// <para>
/// Gets the title for @page.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a page of @assistant
/// </param>
/// <return>
/// the title for @page
/// </return>

	public static string GetPageTitle(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_page_title(assistant, page);
	}

/// <summary>
/// <para>
/// Gets the page type of @page.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a page of @assistant
/// </param>
/// <return>
/// the page type of @page
/// </return>

	public static MentorLake.Gtk.GtkAssistantPageType GetPageType(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_get_page_type(assistant, page);
	}

/// <summary>
/// <para>
/// Inserts a page in the @assistant at a given position.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a #GtkWidget
/// </param>
/// <param name="position">
/// the index (starting at 0) at which to insert the page,
///     or -1 to append the page to the @assistant
/// </param>
/// <return>
/// the index (starting from 0) of the inserted page
/// </return>

	public static int InsertPage(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page, int position)
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_insert_page(assistant, page, position);
	}

/// <summary>
/// <para>
/// Navigate to the next page.
/// </para>
/// <para>
/// It is a programming error to call this function when
/// there is no next page.
/// </para>
/// <para>
/// This function is for use when creating pages of the
/// #GTK_ASSISTANT_PAGE_CUSTOM type.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>

	public static T NextPage<T>(this T assistant) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_next_page(assistant);
		return assistant;
	}

/// <summary>
/// <para>
/// Prepends a page to the @assistant.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a #GtkWidget
/// </param>
/// <return>
/// the index (starting at 0) of the inserted page
/// </return>

	public static int PrependPage(this MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkWidgetHandle page)
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		return GtkAssistantHandleExterns.gtk_assistant_prepend_page(assistant, page);
	}

/// <summary>
/// <para>
/// Navigate to the previous visited page.
/// </para>
/// <para>
/// It is a programming error to call this function when
/// no previous page is available.
/// </para>
/// <para>
/// This function is for use when creating pages of the
/// #GTK_ASSISTANT_PAGE_CUSTOM type.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>

	public static T PreviousPage<T>(this T assistant) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_previous_page(assistant);
		return assistant;
	}

/// <summary>
/// <para>
/// Removes a widget from the action area of a #GtkAssistant.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="child">
/// a #GtkWidget
/// </param>

	public static T RemoveActionWidget<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_remove_action_widget(assistant, child);
		return assistant;
	}

/// <summary>
/// <para>
/// Removes the @page_num’s page from @assistant.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page_num">
/// the index of a page in the @assistant,
///     or -1 to remove the last page
/// </param>

	public static T RemovePage<T>(this T assistant, int page_num) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_remove_page(assistant, page_num);
		return assistant;
	}

/// <summary>
/// <para>
/// Switches the page to @page_num.
/// </para>
/// <para>
/// Note that this will only be necessary in custom buttons,
/// as the @assistant flow can be set with
/// gtk_assistant_set_forward_page_func().
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page_num">
/// index of the page to switch to, starting from 0.
///     If negative, the last page will be used. If greater
///     than the number of pages in the @assistant, nothing
///     will be done.
/// </param>

	public static T SetCurrentPage<T>(this T assistant, int page_num) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_current_page(assistant, page_num);
		return assistant;
	}

/// <summary>
/// <para>
/// Sets the page forwarding function to be @page_func.
/// </para>
/// <para>
/// This function will be used to determine what will be
/// the next page when the user presses the forward button.
/// Setting @page_func to %NULL will make the assistant to
/// use the default forward function, which just goes to the
/// next visible page.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page_func">
/// the #GtkAssistantPageFunc, or %NULL
///     to use the default one
/// </param>
/// <param name="data">
/// user data for @page_func
/// </param>
/// <param name="destroy">
/// destroy notifier for @data
/// </param>

	public static T SetForwardPageFunc<T>(this T assistant, MentorLake.Gtk.GtkAssistantPageFunc page_func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_forward_page_func(assistant, page_func, data, destroy);
		return assistant;
	}

/// <summary>
/// <para>
/// Sets whether @page contents are complete.
/// </para>
/// <para>
/// This will make @assistant update the buttons state
/// to be able to continue the task.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a page of @assistant
/// </param>
/// <param name="complete">
/// the completeness status of the page
/// </param>

	public static T SetPageComplete<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle page, bool complete) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_page_complete(assistant, page, complete);
		return assistant;
	}

/// <summary>
/// <para>
/// Sets whether the assistant is adding padding around
/// the page.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a page of @assistant
/// </param>
/// <param name="has_padding">
/// whether this page has padding
/// </param>

	public static T SetPageHasPadding<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle page, bool has_padding) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_page_has_padding(assistant, page, has_padding);
		return assistant;
	}

/// <summary>
/// <para>
/// Sets a header image for @page.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a page of @assistant
/// </param>
/// <param name="pixbuf">
/// the new header image @page
/// </param>

	public static T SetPageHeaderImage<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle page, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_page_header_image(assistant, page, pixbuf);
		return assistant;
	}

/// <summary>
/// <para>
/// Sets a side image for @page.
/// </para>
/// <para>
/// This image used to be displayed in the side area of the assistant
/// when @page is the current page.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a page of @assistant
/// </param>
/// <param name="pixbuf">
/// the new side image @page
/// </param>

	public static T SetPageSideImage<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle page, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_page_side_image(assistant, page, pixbuf);
		return assistant;
	}

/// <summary>
/// <para>
/// Sets a title for @page.
/// </para>
/// <para>
/// The title is displayed in the header area of the assistant
/// when @page is the current page.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a page of @assistant
/// </param>
/// <param name="title">
/// the new title for @page
/// </param>

	public static T SetPageTitle<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle page, string title) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_page_title(assistant, page, title);
		return assistant;
	}

/// <summary>
/// <para>
/// Sets the page type for @page.
/// </para>
/// <para>
/// The page type determines the page behavior in the @assistant.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>
/// <param name="page">
/// a page of @assistant
/// </param>
/// <param name="type">
/// the new type for @page
/// </param>

	public static T SetPageType<T>(this T assistant, MentorLake.Gtk.GtkWidgetHandle page, MentorLake.Gtk.GtkAssistantPageType type) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_set_page_type(assistant, page, type);
		return assistant;
	}

/// <summary>
/// <para>
/// Forces @assistant to recompute the buttons state.
/// </para>
/// <para>
/// GTK+ automatically takes care of this in most situations,
/// e.g. when the user goes to a different page, or when the
/// visibility or completeness of a page changes.
/// </para>
/// <para>
/// One situation where it can be necessary to call this
/// function is when changing a value on the current page
/// affects the future page flow of the assistant.
/// </para>
/// </summary>

/// <param name="assistant">
/// a #GtkAssistant
/// </param>

	public static T UpdateButtonsState<T>(this T assistant) where T : GtkAssistantHandle
	{
		if (assistant.IsInvalid) throw new Exception("Invalid handle (GtkAssistantHandle)");
		GtkAssistantHandleExterns.gtk_assistant_update_buttons_state(assistant);
		return assistant;
	}

}

internal class GtkAssistantHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))]
	internal static extern MentorLake.Gtk.GtkAssistantHandle gtk_assistant_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_add_action_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_assistant_append_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_commit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_assistant_get_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_assistant_get_n_pages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_assistant_get_nth_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, int page_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_assistant_get_page_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_assistant_get_page_has_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_assistant_get_page_header_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_assistant_get_page_side_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_assistant_get_page_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAssistantPageType gtk_assistant_get_page_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_assistant_insert_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_next_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_assistant_prepend_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_previous_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_remove_action_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_remove_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, int page_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, int page_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_forward_page_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, MentorLake.Gtk.GtkAssistantPageFunc page_func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_page_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, bool complete);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_page_has_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, bool has_padding);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_page_header_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_page_side_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_page_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_set_page_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, MentorLake.Gtk.GtkAssistantPageType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_assistant_update_buttons_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAssistantHandle>))] MentorLake.Gtk.GtkAssistantHandle assistant);

}
