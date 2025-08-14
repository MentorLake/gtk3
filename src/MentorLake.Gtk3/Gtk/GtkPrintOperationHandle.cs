namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkPrintOperation is the high-level, portable printing API.
/// It looks a bit different than other GTK+ dialogs such as the
/// #GtkFileChooser, since some platforms don’t expose enough
/// infrastructure to implement a good print dialog. On such
/// platforms, GtkPrintOperation uses the native print dialog.
/// On platforms which do not provide a native print dialog, GTK+
/// uses its own, see #GtkPrintUnixDialog.
/// </para>
/// <para>
/// The typical way to use the high-level printing API is to create
/// a GtkPrintOperation object with gtk_print_operation_new() when
/// the user selects to print. Then you set some properties on it,
/// e.g. the page size, any #GtkPrintSettings from previous print
/// operations, the number of pages, the current page, etc.
/// </para>
/// <para>
/// Then you start the print operation by calling gtk_print_operation_run().
/// It will then show a dialog, let the user select a printer and
/// options. When the user finished the dialog various signals will
/// be emitted on the #GtkPrintOperation, the main one being
/// #GtkPrintOperation::draw-page, which you are supposed to catch
/// and render the page on the provided #GtkPrintContext using Cairo.
/// </para>
/// <para>
/// # The high-level printing API
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static GtkPrintSettings *settings = NULL;
/// </para>
/// <para>
/// static void
/// do_print (void)
/// {
///   GtkPrintOperation *print;
///   GtkPrintOperationResult res;
/// </para>
/// <para>
///   print = gtk_print_operation_new ();
/// </para>
/// <para>
///   if (settings != NULL)
///     gtk_print_operation_set_print_settings (print, settings);
/// </para>
/// <para>
///   g_signal_connect (print, "begin_print", G_CALLBACK (begin_print), NULL);
///   g_signal_connect (print, "draw_page", G_CALLBACK (draw_page), NULL);
/// </para>
/// <para>
///   res = gtk_print_operation_run (print, GTK_PRINT_OPERATION_ACTION_PRINT_DIALOG,
///                                  GTK_WINDOW (main_window), NULL);
/// </para>
/// <para>
///   if (res == GTK_PRINT_OPERATION_RESULT_APPLY)
///     {
///       if (settings != NULL)
///         g_object_unref (settings);
///       settings = g_object_ref (gtk_print_operation_get_print_settings (print));
///     }
/// </para>
/// <para>
///   g_object_unref (print);
/// }
/// ]|
/// </para>
/// <para>
/// By default GtkPrintOperation uses an external application to do
/// print preview. To implement a custom print preview, an application
/// must connect to the preview signal. The functions
/// gtk_print_operation_preview_render_page(),
/// gtk_print_operation_preview_end_preview() and
/// gtk_print_operation_preview_is_selected()
/// are useful when implementing a print preview.
/// </para>
/// </summary>

public class GtkPrintOperationHandle : GObjectHandle, GtkPrintOperationPreviewHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkPrintOperation.
/// </para>
/// </summary>

/// <return>
/// a new #GtkPrintOperation
/// </return>

	public static MentorLake.Gtk.GtkPrintOperationHandle New()
	{
		return GtkPrintOperationHandleExterns.gtk_print_operation_new();
	}

}
public static class GtkPrintOperationHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted after the user has finished changing print settings
/// in the dialog, before the actual rendering starts.
/// </para>
/// <para>
/// A typical use for ::begin-print is to use the parameters from the
/// #GtkPrintContext and paginate the document accordingly, and then
/// set the number of pages with gtk_print_operation_set_n_pages().
/// </para>
/// </summary>

	public static IObservable<GtkPrintOperationHandleSignalStructs.BeginPrintSignal> Signal_BeginPrint(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.BeginPrintSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.begin_print handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.BeginPrintSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "begin-print", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when displaying the print dialog. If you return a
/// widget in a handler for this signal it will be added to a custom
/// tab in the print dialog. You typically return a container widget
/// with multiple widgets in it.
/// </para>
/// <para>
/// The print dialog owns the returned widget, and its lifetime is not
/// controlled by the application. However, the widget is guaranteed
/// to stay around until the #GtkPrintOperation::custom-widget-apply
/// signal is emitted on the operation. Then you can read out any
/// information you need from the widgets.
/// </para>
/// </summary>

	public static IObservable<GtkPrintOperationHandleSignalStructs.CreateCustomWidgetSignal> Signal_CreateCustomWidget(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.CreateCustomWidgetSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.create_custom_widget handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.CreateCustomWidgetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "create-custom-widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted right before #GtkPrintOperation::begin-print if you added
/// a custom widget in the #GtkPrintOperation::create-custom-widget handler.
/// When you get this signal you should read the information from the
/// custom widgets, as the widgets are not guaraneed to be around at a
/// later time.
/// </para>
/// </summary>

	public static IObservable<GtkPrintOperationHandleSignalStructs.CustomWidgetApplySignal> Signal_CustomWidgetApply(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.CustomWidgetApplySignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.custom_widget_apply handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkWidgetHandle widget,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.CustomWidgetApplySignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "custom-widget-apply", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the print operation run has finished doing
/// everything required for printing.
/// </para>
/// <para>
/// @result gives you information about what happened during the run.
/// If @result is %GTK_PRINT_OPERATION_RESULT_ERROR then you can call
/// gtk_print_operation_get_error() for more information.
/// </para>
/// <para>
/// If you enabled print status tracking then
/// gtk_print_operation_is_finished() may still return %FALSE
/// after #GtkPrintOperation::done was emitted.
/// </para>
/// </summary>

	public static IObservable<GtkPrintOperationHandleSignalStructs.DoneSignal> Signal_Done(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.DoneSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.done handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintOperationResult result,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.DoneSignal()
				{
					Self = self, Result = result, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted for every page that is printed. The signal handler
/// must render the @page_nr's page onto the cairo context obtained
/// from @context using gtk_print_context_get_cairo_context().
/// |[<!-- language="C" -->
/// static void
/// draw_page (GtkPrintOperation *operation,
///            GtkPrintContext   *context,
///            gint               page_nr,
///            gpointer           user_data)
/// {
///   cairo_t *cr;
///   PangoLayout *layout;
///   gdouble width, text_height;
///   gint layout_height;
///   PangoFontDescription *desc;
/// </para>
/// <para>
///   cr = gtk_print_context_get_cairo_context (context);
///   width = gtk_print_context_get_width (context);
/// </para>
/// <para>
///   cairo_rectangle (cr, 0, 0, width, HEADER_HEIGHT);
/// </para>
/// <para>
///   cairo_set_source_rgb (cr, 0.8, 0.8, 0.8);
///   cairo_fill (cr);
/// </para>
/// <para>
///   layout = gtk_print_context_create_pango_layout (context);
/// </para>
/// <para>
///   desc = pango_font_description_from_string ("sans 14");
///   pango_layout_set_font_description (layout, desc);
///   pango_font_description_free (desc);
/// </para>
/// <para>
///   pango_layout_set_text (layout, "some text", -1);
///   pango_layout_set_width (layout, width * PANGO_SCALE);
///   pango_layout_set_alignment (layout, PANGO_ALIGN_CENTER);
/// </para>
/// <para>
///   pango_layout_get_size (layout, NULL, &layout_height);
///   text_height = (gdouble)layout_height / PANGO_SCALE;
/// </para>
/// <para>
///   cairo_move_to (cr, width / 2,  (HEADER_HEIGHT - text_height) / 2);
///   pango_cairo_show_layout (cr, layout);
/// </para>
/// <para>
///   g_object_unref (layout);
/// }
/// ]|
/// </para>
/// <para>
/// Use gtk_print_operation_set_use_full_page() and
/// gtk_print_operation_set_unit() before starting the print operation
/// to set up the transformation of the cairo context according to your
/// needs.
/// </para>
/// </summary>

	public static IObservable<GtkPrintOperationHandleSignalStructs.DrawPageSignal> Signal_DrawPage(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.DrawPageSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.draw_page handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintContextHandle context,  int page_nr,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.DrawPageSignal()
				{
					Self = self, Context = context, PageNr = page_nr, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "draw-page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted after all pages have been rendered.
/// A handler for this signal can clean up any resources that have
/// been allocated in the #GtkPrintOperation::begin-print handler.
/// </para>
/// </summary>

	public static IObservable<GtkPrintOperationHandleSignalStructs.EndPrintSignal> Signal_EndPrint(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.EndPrintSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.end_print handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.EndPrintSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "end-print", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted after the #GtkPrintOperation::begin-print signal, but before
/// the actual rendering starts. It keeps getting emitted until a connected
/// signal handler returns %TRUE.
/// </para>
/// <para>
/// The ::paginate signal is intended to be used for paginating a document
/// in small chunks, to avoid blocking the user interface for a long
/// time. The signal handler should update the number of pages using
/// gtk_print_operation_set_n_pages(), and return %TRUE if the document
/// has been completely paginated.
/// </para>
/// <para>
/// If you don't need to do pagination in chunks, you can simply do
/// it all in the ::begin-print handler, and set the number of pages
/// from there.
/// </para>
/// </summary>

	public static IObservable<GtkPrintOperationHandleSignalStructs.PaginateSignal> Signal_Paginate(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.PaginateSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.paginate handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.PaginateSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "paginate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Gets emitted when a preview is requested from the native dialog.
/// </para>
/// <para>
/// The default handler for this signal uses an external viewer
/// application to preview.
/// </para>
/// <para>
/// To implement a custom print preview, an application must return
/// %TRUE from its handler for this signal. In order to use the
/// provided @context for the preview implementation, it must be
/// given a suitable cairo context with gtk_print_context_set_cairo_context().
/// </para>
/// <para>
/// The custom preview implementation can use
/// gtk_print_operation_preview_is_selected() and
/// gtk_print_operation_preview_render_page() to find pages which
/// are selected for print and render them. The preview must be
/// finished by calling gtk_print_operation_preview_end_preview()
/// (typically in response to the user clicking a close button).
/// </para>
/// </summary>

	public static IObservable<GtkPrintOperationHandleSignalStructs.PreviewSignal> Signal_Preview(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.PreviewSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.preview handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintOperationPreviewHandle preview,  MentorLake.Gtk.GtkPrintContextHandle context,  MentorLake.Gtk.GtkWindowHandle parent,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.PreviewSignal()
				{
					Self = self, Preview = preview, Context = context, Parent = parent, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "preview", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted once for every page that is printed, to give
/// the application a chance to modify the page setup. Any changes
/// done to @setup will be in force only for printing this page.
/// </para>
/// </summary>

	public static IObservable<GtkPrintOperationHandleSignalStructs.RequestPageSetupSignal> Signal_RequestPageSetup(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.RequestPageSetupSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.request_page_setup handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintContextHandle context,  int page_nr,  MentorLake.Gtk.GtkPageSetupHandle setup,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.RequestPageSetupSignal()
				{
					Self = self, Context = context, PageNr = page_nr, Setup = setup, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "request-page-setup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted at between the various phases of the print operation.
/// See #GtkPrintStatus for the phases that are being discriminated.
/// Use gtk_print_operation_get_status() to find out the current
/// status.
/// </para>
/// </summary>

	public static IObservable<GtkPrintOperationHandleSignalStructs.StatusChangedSignal> Signal_StatusChanged(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.StatusChangedSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.status_changed handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.StatusChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "status-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted after change of selected printer. The actual page setup and
/// print settings are passed to the custom widget, which can actualize
/// itself according to this change.
/// </para>
/// </summary>

	public static IObservable<GtkPrintOperationHandleSignalStructs.UpdateCustomWidgetSignal> Signal_UpdateCustomWidget(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.UpdateCustomWidgetSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.update_custom_widget handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkWidgetHandle widget,  MentorLake.Gtk.GtkPageSetupHandle setup,  MentorLake.Gtk.GtkPrintSettingsHandle settings,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.UpdateCustomWidgetSignal()
				{
					Self = self, Widget = widget, Setup = setup, Settings = settings, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "update-custom-widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::got-page-size signal is emitted once for each page
/// that gets rendered to the preview.
/// </para>
/// <para>
/// A handler for this signal should update the @context
/// according to @page_setup and set up a suitable cairo
/// context, using gtk_print_context_set_cairo_context().
/// </para>
/// </summary>

	public static IObservable<GtkPrintOperationHandleSignalStructs.GotPageSizeSignal> Signal_GotPageSize(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.GotPageSizeSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.got_page_size handler = ( MentorLake.Gtk.GtkPrintOperationPreviewHandle self,  MentorLake.Gtk.GtkPrintContextHandle context,  MentorLake.Gtk.GtkPageSetupHandle page_setup,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.GotPageSizeSignal()
				{
					Self = self, Context = context, PageSetup = page_setup, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "got-page-size", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::ready signal gets emitted once per preview operation,
/// before the first page is rendered.
/// </para>
/// <para>
/// A handler for this signal can be used for setup tasks.
/// </para>
/// </summary>

	public static IObservable<GtkPrintOperationHandleSignalStructs.ReadySignal> Signal_Ready(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.ReadySignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.ready handler = ( MentorLake.Gtk.GtkPrintOperationPreviewHandle self,  MentorLake.Gtk.GtkPrintContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.ReadySignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "ready", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkPrintOperationHandleSignalStructs
{

public class BeginPrintSignal
{

	public MentorLake.Gtk.GtkPrintOperationHandle Self;
/// <summary>
/// <para>
/// the #GtkPrintContext for the current operation
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPrintContextHandle Context;

	public IntPtr UserData;
}

public class CreateCustomWidgetSignal
{

	public MentorLake.Gtk.GtkPrintOperationHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// A custom widget that gets embedded in
///          the print dialog, or %NULL
/// </para>
/// </summary>

	public MentorLake.GObject.GObjectHandle ReturnValue;
}

public class CustomWidgetApplySignal
{

	public MentorLake.Gtk.GtkPrintOperationHandle Self;
/// <summary>
/// <para>
/// the custom widget added in create-custom-widget
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Widget;

	public IntPtr UserData;
}

public class DoneSignal
{

	public MentorLake.Gtk.GtkPrintOperationHandle Self;
/// <summary>
/// <para>
/// the result of the print operation
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPrintOperationResult Result;

	public IntPtr UserData;
}

public class DrawPageSignal
{

	public MentorLake.Gtk.GtkPrintOperationHandle Self;
/// <summary>
/// <para>
/// the #GtkPrintContext for the current operation
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPrintContextHandle Context;
/// <summary>
/// <para>
/// the number of the currently printed page (0-based)
/// </para>
/// </summary>

	public int PageNr;

	public IntPtr UserData;
}

public class EndPrintSignal
{

	public MentorLake.Gtk.GtkPrintOperationHandle Self;
/// <summary>
/// <para>
/// the #GtkPrintContext for the current operation
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPrintContextHandle Context;

	public IntPtr UserData;
}

public class PaginateSignal
{

	public MentorLake.Gtk.GtkPrintOperationHandle Self;
/// <summary>
/// <para>
/// the #GtkPrintContext for the current operation
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPrintContextHandle Context;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if pagination is complete
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class PreviewSignal
{

	public MentorLake.Gtk.GtkPrintOperationHandle Self;
/// <summary>
/// <para>
/// the #GtkPrintOperationPreview for the current operation
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPrintOperationPreviewHandle Preview;
/// <summary>
/// <para>
/// the #GtkPrintContext that will be used
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPrintContextHandle Context;
/// <summary>
/// <para>
/// the #GtkWindow to use as window parent, or %NULL
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWindowHandle Parent;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the listener wants to take over control of the preview
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class RequestPageSetupSignal
{

	public MentorLake.Gtk.GtkPrintOperationHandle Self;
/// <summary>
/// <para>
/// the #GtkPrintContext for the current operation
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPrintContextHandle Context;
/// <summary>
/// <para>
/// the number of the currently printed page (0-based)
/// </para>
/// </summary>

	public int PageNr;
/// <summary>
/// <para>
/// the #GtkPageSetup
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPageSetupHandle Setup;

	public IntPtr UserData;
}

public class StatusChangedSignal
{

	public MentorLake.Gtk.GtkPrintOperationHandle Self;

	public IntPtr UserData;
}

public class UpdateCustomWidgetSignal
{

	public MentorLake.Gtk.GtkPrintOperationHandle Self;
/// <summary>
/// <para>
/// the custom widget added in create-custom-widget
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Widget;
/// <summary>
/// <para>
/// actual page setup
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPageSetupHandle Setup;
/// <summary>
/// <para>
/// actual print settings
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPrintSettingsHandle Settings;

	public IntPtr UserData;
}

public class GotPageSizeSignal
{

	public MentorLake.Gtk.GtkPrintOperationPreviewHandle Self;
/// <summary>
/// <para>
/// the current #GtkPrintContext
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPrintContextHandle Context;
/// <summary>
/// <para>
/// the #GtkPageSetup for the current page
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPageSetupHandle PageSetup;

	public IntPtr UserData;
}

public class ReadySignal
{

	public MentorLake.Gtk.GtkPrintOperationPreviewHandle Self;
/// <summary>
/// <para>
/// the current #GtkPrintContext
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPrintContextHandle Context;

	public IntPtr UserData;
}
}

public static class GtkPrintOperationHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted after the user has finished changing print settings
/// in the dialog, before the actual rendering starts.
/// </para>
/// <para>
/// A typical use for ::begin-print is to use the parameters from the
/// #GtkPrintContext and paginate the document accordingly, and then
/// set the number of pages with gtk_print_operation_set_n_pages().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the #GtkPrintContext for the current operation
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void begin_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when displaying the print dialog. If you return a
/// widget in a handler for this signal it will be added to a custom
/// tab in the print dialog. You typically return a container widget
/// with multiple widgets in it.
/// </para>
/// <para>
/// The print dialog owns the returned widget, and its lifetime is not
/// controlled by the application. However, the widget is guaranteed
/// to stay around until the #GtkPrintOperation::custom-widget-apply
/// signal is emitted on the operation. Then you can read out any
/// information you need from the widgets.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// A custom widget that gets embedded in
///          the print dialog, or %NULL
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.GObject.GObjectHandle create_custom_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted right before #GtkPrintOperation::begin-print if you added
/// a custom widget in the #GtkPrintOperation::create-custom-widget handler.
/// When you get this signal you should read the information from the
/// custom widgets, as the widgets are not guaraneed to be around at a
/// later time.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="widget">
/// the custom widget added in create-custom-widget
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void custom_widget_apply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the print operation run has finished doing
/// everything required for printing.
/// </para>
/// <para>
/// @result gives you information about what happened during the run.
/// If @result is %GTK_PRINT_OPERATION_RESULT_ERROR then you can call
/// gtk_print_operation_get_error() for more information.
/// </para>
/// <para>
/// If you enabled print status tracking then
/// gtk_print_operation_is_finished() may still return %FALSE
/// after #GtkPrintOperation::done was emitted.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="result">
/// the result of the print operation
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, MentorLake.Gtk.GtkPrintOperationResult result, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted for every page that is printed. The signal handler
/// must render the @page_nr's page onto the cairo context obtained
/// from @context using gtk_print_context_get_cairo_context().
/// |[<!-- language="C" -->
/// static void
/// draw_page (GtkPrintOperation *operation,
///            GtkPrintContext   *context,
///            gint               page_nr,
///            gpointer           user_data)
/// {
///   cairo_t *cr;
///   PangoLayout *layout;
///   gdouble width, text_height;
///   gint layout_height;
///   PangoFontDescription *desc;
/// </para>
/// <para>
///   cr = gtk_print_context_get_cairo_context (context);
///   width = gtk_print_context_get_width (context);
/// </para>
/// <para>
///   cairo_rectangle (cr, 0, 0, width, HEADER_HEIGHT);
/// </para>
/// <para>
///   cairo_set_source_rgb (cr, 0.8, 0.8, 0.8);
///   cairo_fill (cr);
/// </para>
/// <para>
///   layout = gtk_print_context_create_pango_layout (context);
/// </para>
/// <para>
///   desc = pango_font_description_from_string ("sans 14");
///   pango_layout_set_font_description (layout, desc);
///   pango_font_description_free (desc);
/// </para>
/// <para>
///   pango_layout_set_text (layout, "some text", -1);
///   pango_layout_set_width (layout, width * PANGO_SCALE);
///   pango_layout_set_alignment (layout, PANGO_ALIGN_CENTER);
/// </para>
/// <para>
///   pango_layout_get_size (layout, NULL, &layout_height);
///   text_height = (gdouble)layout_height / PANGO_SCALE;
/// </para>
/// <para>
///   cairo_move_to (cr, width / 2,  (HEADER_HEIGHT - text_height) / 2);
///   pango_cairo_show_layout (cr, layout);
/// </para>
/// <para>
///   g_object_unref (layout);
/// }
/// ]|
/// </para>
/// <para>
/// Use gtk_print_operation_set_use_full_page() and
/// gtk_print_operation_set_unit() before starting the print operation
/// to set up the transformation of the cairo context according to your
/// needs.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the #GtkPrintContext for the current operation
/// </param>
/// <param name="page_nr">
/// the number of the currently printed page (0-based)
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void draw_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, int page_nr, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after all pages have been rendered.
/// A handler for this signal can clean up any resources that have
/// been allocated in the #GtkPrintOperation::begin-print handler.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the #GtkPrintContext for the current operation
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void end_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after the #GtkPrintOperation::begin-print signal, but before
/// the actual rendering starts. It keeps getting emitted until a connected
/// signal handler returns %TRUE.
/// </para>
/// <para>
/// The ::paginate signal is intended to be used for paginating a document
/// in small chunks, to avoid blocking the user interface for a long
/// time. The signal handler should update the number of pages using
/// gtk_print_operation_set_n_pages(), and return %TRUE if the document
/// has been completely paginated.
/// </para>
/// <para>
/// If you don't need to do pagination in chunks, you can simply do
/// it all in the ::begin-print handler, and set the number of pages
/// from there.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the #GtkPrintContext for the current operation
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if pagination is complete
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool paginate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, IntPtr user_data);


/// <summary>
/// <para>
/// Gets emitted when a preview is requested from the native dialog.
/// </para>
/// <para>
/// The default handler for this signal uses an external viewer
/// application to preview.
/// </para>
/// <para>
/// To implement a custom print preview, an application must return
/// %TRUE from its handler for this signal. In order to use the
/// provided @context for the preview implementation, it must be
/// given a suitable cairo context with gtk_print_context_set_cairo_context().
/// </para>
/// <para>
/// The custom preview implementation can use
/// gtk_print_operation_preview_is_selected() and
/// gtk_print_operation_preview_render_page() to find pages which
/// are selected for print and render them. The preview must be
/// finished by calling gtk_print_operation_preview_end_preview()
/// (typically in response to the user clicking a close button).
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="preview">
/// the #GtkPrintOperationPreview for the current operation
/// </param>
/// <param name="context">
/// the #GtkPrintContext that will be used
/// </param>
/// <param name="parent">
/// the #GtkWindow to use as window parent, or %NULL
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the listener wants to take over control of the preview
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool preview([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationPreviewHandleImpl>))] MentorLake.Gtk.GtkPrintOperationPreviewHandle preview, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted once for every page that is printed, to give
/// the application a chance to modify the page setup. Any changes
/// done to @setup will be in force only for printing this page.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the #GtkPrintContext for the current operation
/// </param>
/// <param name="page_nr">
/// the number of the currently printed page (0-based)
/// </param>
/// <param name="setup">
/// the #GtkPageSetup
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void request_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, int page_nr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted at between the various phases of the print operation.
/// See #GtkPrintStatus for the phases that are being discriminated.
/// Use gtk_print_operation_get_status() to find out the current
/// status.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void status_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after change of selected printer. The actual page setup and
/// print settings are passed to the custom widget, which can actualize
/// itself according to this change.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="widget">
/// the custom widget added in create-custom-widget
/// </param>
/// <param name="setup">
/// actual page setup
/// </param>
/// <param name="settings">
/// actual print settings
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void update_custom_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, IntPtr user_data);


/// <summary>
/// <para>
/// The ::got-page-size signal is emitted once for each page
/// that gets rendered to the preview.
/// </para>
/// <para>
/// A handler for this signal should update the @context
/// according to @page_setup and set up a suitable cairo
/// context, using gtk_print_context_set_cairo_context().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the current #GtkPrintContext
/// </param>
/// <param name="page_setup">
/// the #GtkPageSetup for the current page
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void got_page_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationPreviewHandleImpl>))] MentorLake.Gtk.GtkPrintOperationPreviewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle page_setup, IntPtr user_data);


/// <summary>
/// <para>
/// The ::ready signal gets emitted once per preview operation,
/// before the first page is rendered.
/// </para>
/// <para>
/// A handler for this signal can be used for setup tasks.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// the current #GtkPrintContext
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void ready([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationPreviewHandleImpl>))] MentorLake.Gtk.GtkPrintOperationPreviewHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, IntPtr user_data);

}


public static class GtkPrintOperationHandleExtensions
{
/// <summary>
/// <para>
/// Cancels a running print operation. This function may
/// be called from a #GtkPrintOperation::begin-print,
/// #GtkPrintOperation::paginate or #GtkPrintOperation::draw-page
/// signal handler to stop the currently running print
/// operation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>

	public static T Cancel<T>(this T op) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_cancel(op);
		return op;
	}

/// <summary>
/// <para>
/// Signalize that drawing of particular page is complete.
/// </para>
/// <para>
/// It is called after completion of page drawing (e.g. drawing in another
/// thread).
/// If gtk_print_operation_set_defer_drawing() was called before, then this function
/// has to be called by application. In another case it is called by the library
/// itself.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>

	public static T DrawPageFinish<T>(this T op) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_draw_page_finish(op);
		return op;
	}

/// <summary>
/// <para>
/// Returns the default page setup, see
/// gtk_print_operation_set_default_page_setup().
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <return>
/// the default page setup
/// </return>

	public static MentorLake.Gtk.GtkPageSetupHandle GetDefaultPageSetup(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_default_page_setup(op);
	}

/// <summary>
/// <para>
/// Gets the value of #GtkPrintOperation:embed-page-setup property.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <return>
/// whether page setup selection combos are embedded
/// </return>

	public static bool GetEmbedPageSetup(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_embed_page_setup(op);
	}

/// <summary>
/// <para>
/// Call this when the result of a print operation is
/// %GTK_PRINT_OPERATION_RESULT_ERROR, either as returned by
/// gtk_print_operation_run(), or in the #GtkPrintOperation::done signal
/// handler. The returned #GError will contain more details on what went wrong.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>

	public static T GetError<T>(this T op) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_get_error(op, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return op;
	}

/// <summary>
/// <para>
/// Gets the value of #GtkPrintOperation:has-selection property.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <return>
/// whether there is a selection
/// </return>

	public static bool GetHasSelection(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_has_selection(op);
	}

/// <summary>
/// <para>
/// Returns the number of pages that will be printed.
/// </para>
/// <para>
/// Note that this value is set during print preparation phase
/// (%GTK_PRINT_STATUS_PREPARING), so this function should never be
/// called before the data generation phase (%GTK_PRINT_STATUS_GENERATING_DATA).
/// You can connect to the #GtkPrintOperation::status-changed signal
/// and call gtk_print_operation_get_n_pages_to_print() when
/// print status is %GTK_PRINT_STATUS_GENERATING_DATA.
/// This is typically used to track the progress of print operation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <return>
/// the number of pages that will be printed
/// </return>

	public static int GetNPagesToPrint(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_n_pages_to_print(op);
	}

/// <summary>
/// <para>
/// Returns the current print settings.
/// </para>
/// <para>
/// Note that the return value is %NULL until either
/// gtk_print_operation_set_print_settings() or
/// gtk_print_operation_run() have been called.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <return>
/// the current print settings of @op.
/// </return>

	public static MentorLake.Gtk.GtkPrintSettingsHandle GetPrintSettings(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_print_settings(op);
	}

/// <summary>
/// <para>
/// Returns the status of the print operation.
/// Also see gtk_print_operation_get_status_string().
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <return>
/// the status of the print operation
/// </return>

	public static MentorLake.Gtk.GtkPrintStatus GetStatus(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_status(op);
	}

/// <summary>
/// <para>
/// Returns a string representation of the status of the
/// print operation. The string is translated and suitable
/// for displaying the print status e.g. in a #GtkStatusbar.
/// </para>
/// <para>
/// Use gtk_print_operation_get_status() to obtain a status
/// value that is suitable for programmatic use.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <return>
/// a string representation of the status
///    of the print operation
/// </return>

	public static string GetStatusString(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_status_string(op);
	}

/// <summary>
/// <para>
/// Gets the value of #GtkPrintOperation:support-selection property.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <return>
/// whether the application supports print of selection
/// </return>

	public static bool GetSupportSelection(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_support_selection(op);
	}

/// <summary>
/// <para>
/// A convenience function to find out if the print operation
/// is finished, either successfully (%GTK_PRINT_STATUS_FINISHED)
/// or unsuccessfully (%GTK_PRINT_STATUS_FINISHED_ABORTED).
/// </para>
/// <para>
/// Note: when you enable print status tracking the print operation
/// can be in a non-finished state even after done has been called, as
/// the operation status then tracks the print job status on the printer.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <return>
/// %TRUE, if the print operation is finished.
/// </return>

	public static bool IsFinished(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		return GtkPrintOperationHandleExterns.gtk_print_operation_is_finished(op);
	}

/// <summary>
/// <para>
/// Runs the print operation, by first letting the user modify
/// print settings in the print dialog, and then print the document.
/// </para>
/// <para>
/// Normally that this function does not return until the rendering of all
/// pages is complete. You can connect to the
/// #GtkPrintOperation::status-changed signal on @op to obtain some
/// information about the progress of the print operation.
/// Furthermore, it may use a recursive mainloop to show the print dialog.
/// </para>
/// <para>
/// If you call gtk_print_operation_set_allow_async() or set the
/// #GtkPrintOperation:allow-async property the operation will run
/// asynchronously if this is supported on the platform. The
/// #GtkPrintOperation::done signal will be emitted with the result of the
/// operation when the it is done (i.e. when the dialog is canceled, or when
/// the print succeeds or fails).
/// |[<!-- language="C" -->
/// if (settings != NULL)
///   gtk_print_operation_set_print_settings (print, settings);
/// </para>
/// <para>
/// if (page_setup != NULL)
///   gtk_print_operation_set_default_page_setup (print, page_setup);
/// </para>
/// <para>
/// g_signal_connect (print, "begin-print",
///                   G_CALLBACK (begin_print), &data);
/// g_signal_connect (print, "draw-page",
///                   G_CALLBACK (draw_page), &data);
/// </para>
/// <para>
/// res = gtk_print_operation_run (print,
///                                GTK_PRINT_OPERATION_ACTION_PRINT_DIALOG,
///                                parent,
///                                &error);
/// </para>
/// <para>
/// if (res == GTK_PRINT_OPERATION_RESULT_ERROR)
///  {
///    error_dialog = gtk_message_dialog_new (GTK_WINDOW (parent),
///   			                     GTK_DIALOG_DESTROY_WITH_PARENT,
/// 					     GTK_MESSAGE_ERROR,
/// 					     GTK_BUTTONS_CLOSE,
/// 					     "Error printing file:\n%s",
/// 					     error->message);
///    g_signal_connect (error_dialog, "response",
///                      G_CALLBACK (gtk_widget_destroy), NULL);
///    gtk_widget_show (error_dialog);
///    g_error_free (error);
///  }
/// else if (res == GTK_PRINT_OPERATION_RESULT_APPLY)
///  {
///    if (settings != NULL)
/// g_object_unref (settings);
///    settings = g_object_ref (gtk_print_operation_get_print_settings (print));
///  }
/// ]|
/// </para>
/// <para>
/// Note that gtk_print_operation_run() can only be called once on a
/// given #GtkPrintOperation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="action">
/// the action to start
/// </param>
/// <param name="parent">
/// Transient parent of the dialog
/// </param>
/// <return>
/// the result of the print operation. A return value of
///   %GTK_PRINT_OPERATION_RESULT_APPLY indicates that the printing was
///   completed successfully. In this case, it is a good idea to obtain
///   the used print settings with gtk_print_operation_get_print_settings()
///   and store them for reuse with the next print operation. A value of
///   %GTK_PRINT_OPERATION_RESULT_IN_PROGRESS means the operation is running
///   asynchronously, and will emit the #GtkPrintOperation::done signal when
///   done.
/// </return>

	public static MentorLake.Gtk.GtkPrintOperationResult Run(this MentorLake.Gtk.GtkPrintOperationHandle op, MentorLake.Gtk.GtkPrintOperationAction action, MentorLake.Gtk.GtkWindowHandle parent)
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		var externCallResult = GtkPrintOperationHandleExterns.gtk_print_operation_run(op, action, parent, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets whether the gtk_print_operation_run() may return
/// before the print operation is completed. Note that
/// some platforms may not allow asynchronous operation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="allow_async">
/// %TRUE to allow asynchronous operation
/// </param>

	public static T SetAllowAsync<T>(this T op, bool allow_async) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_allow_async(op, allow_async);
		return op;
	}

/// <summary>
/// <para>
/// Sets the current page.
/// </para>
/// <para>
/// If this is called before gtk_print_operation_run(),
/// the user will be able to select to print only the current page.
/// </para>
/// <para>
/// Note that this only makes sense for pre-paginated documents.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="current_page">
/// the current page, 0-based
/// </param>

	public static T SetCurrentPage<T>(this T op, int current_page) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_current_page(op, current_page);
		return op;
	}

/// <summary>
/// <para>
/// Sets the label for the tab holding custom widgets.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="label">
/// the label to use, or %NULL to use the default label
/// </param>

	public static T SetCustomTabLabel<T>(this T op, string label) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_custom_tab_label(op, label);
		return op;
	}

/// <summary>
/// <para>
/// Makes @default_page_setup the default page setup for @op.
/// </para>
/// <para>
/// This page setup will be used by gtk_print_operation_run(),
/// but it can be overridden on a per-page basis by connecting
/// to the #GtkPrintOperation::request-page-setup signal.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="default_page_setup">
/// a #GtkPageSetup, or %NULL
/// </param>

	public static T SetDefaultPageSetup<T>(this T op, MentorLake.Gtk.GtkPageSetupHandle default_page_setup) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_default_page_setup(op, default_page_setup);
		return op;
	}

/// <summary>
/// <para>
/// Sets up the #GtkPrintOperation to wait for calling of
/// gtk_print_operation_draw_page_finish() from application. It can
/// be used for drawing page in another thread.
/// </para>
/// <para>
/// This function must be called in the callback of “draw-page” signal.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>

	public static T SetDeferDrawing<T>(this T op) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_defer_drawing(op);
		return op;
	}

/// <summary>
/// <para>
/// Embed page size combo box and orientation combo box into page setup page.
/// Selected page setup is stored as default page setup in #GtkPrintOperation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="embed">
/// %TRUE to embed page setup selection in the #GtkPrintUnixDialog
/// </param>

	public static T SetEmbedPageSetup<T>(this T op, bool embed) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_embed_page_setup(op, embed);
		return op;
	}

/// <summary>
/// <para>
/// Sets up the #GtkPrintOperation to generate a file instead
/// of showing the print dialog. The indended use of this function
/// is for implementing “Export to PDF” actions. Currently, PDF
/// is the only supported format.
/// </para>
/// <para>
/// “Print to PDF” support is independent of this and is done
/// by letting the user pick the “Print to PDF” item from the list
/// of printers in the print dialog.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="filename">
/// the filename for the exported file
/// </param>

	public static T SetExportFilename<T>(this T op, string filename) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_export_filename(op, filename);
		return op;
	}

/// <summary>
/// <para>
/// Sets whether there is a selection to print.
/// </para>
/// <para>
/// Application has to set number of pages to which the selection
/// will draw by gtk_print_operation_set_n_pages() in a callback of
/// #GtkPrintOperation::begin-print.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="has_selection">
/// %TRUE indicates that a selection exists
/// </param>

	public static T SetHasSelection<T>(this T op, bool has_selection) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_has_selection(op, has_selection);
		return op;
	}

/// <summary>
/// <para>
/// Sets the name of the print job. The name is used to identify
/// the job (e.g. in monitoring applications like eggcups).
/// </para>
/// <para>
/// If you don’t set a job name, GTK+ picks a default one by
/// numbering successive print jobs.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="job_name">
/// a string that identifies the print job
/// </param>

	public static T SetJobName<T>(this T op, string job_name) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_job_name(op, job_name);
		return op;
	}

/// <summary>
/// <para>
/// Sets the number of pages in the document.
/// </para>
/// <para>
/// This must be set to a positive number
/// before the rendering starts. It may be set in a
/// #GtkPrintOperation::begin-print signal hander.
/// </para>
/// <para>
/// Note that the page numbers passed to the
/// #GtkPrintOperation::request-page-setup
/// and #GtkPrintOperation::draw-page signals are 0-based, i.e. if
/// the user chooses to print all pages, the last ::draw-page signal
/// will be for page @n_pages - 1.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="n_pages">
/// the number of pages
/// </param>

	public static T SetNPages<T>(this T op, int n_pages) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_n_pages(op, n_pages);
		return op;
	}

/// <summary>
/// <para>
/// Sets the print settings for @op. This is typically used to
/// re-establish print settings from a previous print operation,
/// see gtk_print_operation_run().
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="print_settings">
/// #GtkPrintSettings
/// </param>

	public static T SetPrintSettings<T>(this T op, MentorLake.Gtk.GtkPrintSettingsHandle print_settings) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_print_settings(op, print_settings);
		return op;
	}

/// <summary>
/// <para>
/// If @show_progress is %TRUE, the print operation will show a
/// progress dialog during the print operation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="show_progress">
/// %TRUE to show a progress dialog
/// </param>

	public static T SetShowProgress<T>(this T op, bool show_progress) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_show_progress(op, show_progress);
		return op;
	}

/// <summary>
/// <para>
/// Sets whether selection is supported by #GtkPrintOperation.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="support_selection">
/// %TRUE to support selection
/// </param>

	public static T SetSupportSelection<T>(this T op, bool support_selection) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_support_selection(op, support_selection);
		return op;
	}

/// <summary>
/// <para>
/// If track_status is %TRUE, the print operation will try to continue report
/// on the status of the print job in the printer queues and printer. This
/// can allow your application to show things like “out of paper” issues,
/// and when the print job actually reaches the printer.
/// </para>
/// <para>
/// This function is often implemented using some form of polling, so it should
/// not be enabled unless needed.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="track_status">
/// %TRUE to track status after printing
/// </param>

	public static T SetTrackPrintStatus<T>(this T op, bool track_status) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_track_print_status(op, track_status);
		return op;
	}

/// <summary>
/// <para>
/// Sets up the transformation for the cairo context obtained from
/// #GtkPrintContext in such a way that distances are measured in
/// units of @unit.
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="unit">
/// the unit to use
/// </param>

	public static T SetUnit<T>(this T op, MentorLake.Gtk.GtkUnit unit) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_unit(op, unit);
		return op;
	}

/// <summary>
/// <para>
/// If @full_page is %TRUE, the transformation for the cairo context
/// obtained from #GtkPrintContext puts the origin at the top left
/// corner of the page (which may not be the top left corner of the
/// sheet, depending on page orientation and the number of pages per
/// sheet). Otherwise, the origin is at the top left corner of the
/// imageable area (i.e. inside the margins).
/// </para>
/// </summary>

/// <param name="op">
/// a #GtkPrintOperation
/// </param>
/// <param name="full_page">
/// %TRUE to set up the #GtkPrintContext for the full page
/// </param>

	public static T SetUseFullPage<T>(this T op, bool full_page) where T : GtkPrintOperationHandle
	{
		if (op.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationHandle)");
		GtkPrintOperationHandleExterns.gtk_print_operation_set_use_full_page(op, full_page);
		return op;
	}

}

internal class GtkPrintOperationHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))]
	internal static extern MentorLake.Gtk.GtkPrintOperationHandle gtk_print_operation_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_draw_page_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle gtk_print_operation_get_default_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_operation_get_embed_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_get_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_operation_get_has_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_print_operation_get_n_pages_to_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))]
	internal static extern MentorLake.Gtk.GtkPrintSettingsHandle gtk_print_operation_get_print_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPrintStatus gtk_print_operation_get_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_operation_get_status_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_operation_get_support_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_operation_is_finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPrintOperationResult gtk_print_operation_run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, MentorLake.Gtk.GtkPrintOperationAction action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_allow_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool allow_async);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, int current_page);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_custom_tab_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_default_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle default_page_setup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_defer_drawing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_embed_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool embed);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_export_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_has_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool has_selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_job_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, string job_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_n_pages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, int n_pages);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_print_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle print_settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_show_progress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool show_progress);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_support_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool support_selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_track_print_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool track_status);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_unit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_use_full_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool full_page);

}
