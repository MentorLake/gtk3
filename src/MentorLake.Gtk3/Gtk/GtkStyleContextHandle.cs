namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkStyleContext is an object that stores styling information affecting
/// a widget defined by #GtkWidgetPath.
/// </para>
/// <para>
/// In order to construct the final style information, #GtkStyleContext
/// queries information from all attached #GtkStyleProviders. Style providers
/// can be either attached explicitly to the context through
/// gtk_style_context_add_provider(), or to the screen through
/// gtk_style_context_add_provider_for_screen(). The resulting style is a
/// combination of all providers’ information in priority order.
/// </para>
/// <para>
/// For GTK+ widgets, any #GtkStyleContext returned by
/// gtk_widget_get_style_context() will already have a #GtkWidgetPath, a
/// #GdkScreen and RTL/LTR information set. The style context will also be
/// updated automatically if any of these settings change on the widget.
/// </para>
/// <para>
/// If you are using the theming layer standalone, you will need to set a
/// widget path and a screen yourself to the created style context through
/// gtk_style_context_set_path() and possibly gtk_style_context_set_screen(). See
/// the “Foreign drawing“ example in gtk3-demo.
/// </para>
/// <para>
/// # Style Classes # {#gtkstylecontext-classes}
/// </para>
/// <para>
/// Widgets can add style classes to their context, which can be used to associate
/// different styles by class. The documentation for individual widgets lists
/// which style classes it uses itself, and which style classes may be added by
/// applications to affect their appearance.
/// </para>
/// <para>
/// GTK+ defines macros for a number of style classes.
/// </para>
/// <para>
/// # Style Regions
/// </para>
/// <para>
/// Widgets can also add regions with flags to their context. This feature is
/// deprecated and will be removed in a future GTK+ update. Please use style
/// classes instead.
/// </para>
/// <para>
/// GTK+ defines macros for a number of style regions.
/// </para>
/// <para>
/// # Custom styling in UI libraries and applications
/// </para>
/// <para>
/// If you are developing a library with custom #GtkWidgets that
/// render differently than standard components, you may need to add a
/// #GtkStyleProvider yourself with the %GTK_STYLE_PROVIDER_PRIORITY_FALLBACK
/// priority, either a #GtkCssProvider or a custom object implementing the
/// #GtkStyleProvider interface. This way themes may still attempt
/// to style your UI elements in a different way if needed so.
/// </para>
/// <para>
/// If you are using custom styling on an applications, you probably want then
/// to make your style information prevail to the theme’s, so you must use
/// a #GtkStyleProvider with the %GTK_STYLE_PROVIDER_PRIORITY_APPLICATION
/// priority, keep in mind that the user settings in
/// `XDG_CONFIG_HOME/gtk-3.0/gtk.css` will
/// still take precedence over your changes, as it uses the
/// %GTK_STYLE_PROVIDER_PRIORITY_USER priority.
/// </para>
/// </summary>

public class GtkStyleContextHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a standalone #GtkStyleContext, this style context
/// won’t be attached to any widget, so you may want
/// to call gtk_style_context_set_path() yourself.
/// </para>
/// <para>
/// This function is only useful when using the theming layer
/// separated from GTK+, if you are using #GtkStyleContext to
/// theme #GtkWidgets, use gtk_widget_get_style_context()
/// in order to get a style context ready to theme the widget.
/// </para>
/// </summary>

/// <return>
/// A newly created #GtkStyleContext.
/// </return>

	public static MentorLake.Gtk.GtkStyleContextHandle New()
	{
		return GtkStyleContextHandleExterns.gtk_style_context_new();
	}

/// <summary>
/// <para>
/// Adds a global style provider to @screen, which will be used
/// in style construction for all #GtkStyleContexts under @screen.
/// </para>
/// <para>
/// GTK+ uses this to make styling information from #GtkSettings
/// available.
/// </para>
/// <para>
/// Note: If both priorities are the same, A #GtkStyleProvider
/// added through gtk_style_context_add_provider() takes precedence
/// over another added through this function.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <param name="provider">
/// a #GtkStyleProvider
/// </param>
/// <param name="priority">
/// the priority of the style provider. The lower
///            it is, the earlier it will be used in the style
///            construction. Typically this will be in the range
///            between %GTK_STYLE_PROVIDER_PRIORITY_FALLBACK and
///            %GTK_STYLE_PROVIDER_PRIORITY_USER
/// </param>

	public static void AddProviderForScreen(MentorLake.Gdk.GdkScreenHandle screen, MentorLake.Gtk.GtkStyleProviderHandle provider, uint priority)
	{
		GtkStyleContextHandleExterns.gtk_style_context_add_provider_for_screen(screen, provider, priority);
	}

/// <summary>
/// <para>
/// Removes @provider from the global style providers list in @screen.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>
/// <param name="provider">
/// a #GtkStyleProvider
/// </param>

	public static void RemoveProviderForScreen(MentorLake.Gdk.GdkScreenHandle screen, MentorLake.Gtk.GtkStyleProviderHandle provider)
	{
		GtkStyleContextHandleExterns.gtk_style_context_remove_provider_for_screen(screen, provider);
	}

/// <summary>
/// <para>
/// This function recomputes the styles for all widgets under a particular
/// #GdkScreen. This is useful when some global parameter has changed that
/// affects the appearance of all widgets, because when a widget gets a new
/// style, it will both redraw and recompute any cached information about
/// its appearance. As an example, it is used when the color scheme changes
/// in the related #GtkSettings object.
/// </para>
/// </summary>

/// <param name="screen">
/// a #GdkScreen
/// </param>

	public static void ResetWidgets(MentorLake.Gdk.GdkScreenHandle screen)
	{
		GtkStyleContextHandleExterns.gtk_style_context_reset_widgets(screen);
	}

}
public static class GtkStyleContextHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::changed signal is emitted when there is a change in the
/// #GtkStyleContext.
/// </para>
/// <para>
/// For a #GtkStyleContext returned by gtk_widget_get_style_context(), the
/// #GtkWidget::style-updated signal/vfunc might be more convenient to use.
/// </para>
/// <para>
/// This signal is useful when using the theming layer standalone.
/// </para>
/// </summary>

	public static IObservable<GtkStyleContextHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkStyleContextHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkStyleContextHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkStyleContextHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkStyleContextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkStyleContextHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkStyleContextHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.Gtk.GtkStyleContextHandle Self;

	public IntPtr UserData;
}
}

public static class GtkStyleContextHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::changed signal is emitted when there is a change in the
/// #GtkStyleContext.
/// </para>
/// <para>
/// For a #GtkStyleContext returned by gtk_widget_get_style_context(), the
/// #GtkWidget::style-updated signal/vfunc might be more convenient to use.
/// </para>
/// <para>
/// This signal is useful when using the theming layer standalone.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle self, IntPtr user_data);

}


public static class GtkStyleContextHandleExtensions
{
/// <summary>
/// <para>
/// Adds a style class to @context, so posterior calls to
/// gtk_style_context_get() or any of the gtk_render_*()
/// functions will make use of this new class for styling.
/// </para>
/// <para>
/// In the CSS file format, a #GtkEntry defining a “search”
/// class, would be matched by:
/// </para>
/// <para>
/// |[ <!-- language="CSS" -->
/// entry.search { ... }
/// ]|
/// </para>
/// <para>
/// While any widget defining a “search” class would be
/// matched by:
/// |[ <!-- language="CSS" -->
/// .search { ... }
/// ]|
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="class_name">
/// class name to use in styling
/// </param>

	public static T AddClass<T>(this T context, string class_name) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_add_class(context, class_name);
		return context;
	}

/// <summary>
/// <para>
/// Adds a style provider to @context, to be used in style construction.
/// Note that a style provider added by this function only affects
/// the style of the widget to which @context belongs. If you want
/// to affect the style of all widgets, use
/// gtk_style_context_add_provider_for_screen().
/// </para>
/// <para>
/// Note: If both priorities are the same, a #GtkStyleProvider
/// added through this function takes precedence over another added
/// through gtk_style_context_add_provider_for_screen().
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="provider">
/// a #GtkStyleProvider
/// </param>
/// <param name="priority">
/// the priority of the style provider. The lower
///            it is, the earlier it will be used in the style
///            construction. Typically this will be in the range
///            between %GTK_STYLE_PROVIDER_PRIORITY_FALLBACK and
///            %GTK_STYLE_PROVIDER_PRIORITY_USER
/// </param>

	public static T AddProvider<T>(this T context, MentorLake.Gtk.GtkStyleProviderHandle provider, uint priority) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_add_provider(context, provider, priority);
		return context;
	}

/// <summary>
/// <para>
/// Adds a region to @context, so posterior calls to
/// gtk_style_context_get() or any of the gtk_render_*()
/// functions will make use of this new region for styling.
/// </para>
/// <para>
/// In the CSS file format, a #GtkTreeView defining a “row”
/// region, would be matched by:
/// </para>
/// <para>
/// |[ <!-- language="CSS" -->
/// treeview row { ... }
/// ]|
/// </para>
/// <para>
/// Pseudo-classes are used for matching @flags, so the two
/// following rules:
/// |[ <!-- language="CSS" -->
/// treeview row:nth-child(even) { ... }
/// treeview row:nth-child(odd) { ... }
/// ]|
/// </para>
/// <para>
/// would apply to even and odd rows, respectively.
/// </para>
/// <para>
/// Region names must only contain lowercase letters
/// and “-”, starting always with a lowercase letter.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="region_name">
/// region name to use in styling
/// </param>
/// <param name="flags">
/// flags that apply to the region
/// </param>

	public static T AddRegion<T>(this T context, string region_name, MentorLake.Gtk.GtkRegionFlags flags) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_add_region(context, region_name, flags);
		return context;
	}

/// <summary>
/// <para>
/// Stops all running animations for @region_id and all animatable
/// regions underneath.
/// </para>
/// <para>
/// A %NULL @region_id will stop all ongoing animations in @context,
/// when dealing with a #GtkStyleContext obtained through
/// gtk_widget_get_style_context(), this is normally done for you
/// in all circumstances you would expect all widget to be stopped,
/// so this should be only used in complex widgets with different
/// animatable regions.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="region_id">
/// animatable region to stop, or %NULL.
///     See gtk_style_context_push_animatable_region()
/// </param>

	public static T CancelAnimations<T>(this T context, IntPtr region_id) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_cancel_animations(context, region_id);
		return context;
	}

/// <summary>
/// <para>
/// Retrieves several style property values from @context for a
/// given state.
/// </para>
/// <para>
/// See gtk_style_context_get_property() for details.
/// </para>
/// <para>
/// For the property name / return value pairs, it works similarly as
/// g_object_get(). Example:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// GdkRGBA *background_color = NULL;
/// PangoFontDescription *font_desc = NULL;
/// gint border_radius = 0;
/// </para>
/// <para>
/// gtk_style_context_get (style_context,
///                        gtk_style_context_get_state (style_context),
///                        GTK_STYLE_PROPERTY_BACKGROUND_COLOR, &background_color,
///                        GTK_STYLE_PROPERTY_FONT, &font_desc,
///                        GTK_STYLE_PROPERTY_BORDER_RADIUS, &border_radius,
///                        NULL);
/// </para>
/// <para>
/// // Do something with the property values.
/// </para>
/// <para>
/// if (background_color != NULL)
///   gdk_rgba_free (background_color);
/// if (font_desc != NULL)
///   pango_font_description_free (font_desc);
/// ]|
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="state">
/// state to retrieve the property values for
/// </param>
/// <param name="@__arglist">
/// property name / return value pairs, followed by %NULL
/// </param>

	public static T Get<T>(this T context, MentorLake.Gtk.GtkStateFlags state, IntPtr @__arglist) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get(context, state, @__arglist);
		return context;
	}

/// <summary>
/// <para>
/// Gets the background color for a given state.
/// </para>
/// <para>
/// This function is far less useful than it seems, and it should not be used in
/// newly written code. CSS has no concept of "background color", as a background
/// can be an image, or a gradient, or any other pattern including solid colors.
/// </para>
/// <para>
/// The only reason why you would call gtk_style_context_get_background_color() is
/// to use the returned value to draw the background with it; the correct way to
/// achieve this result is to use gtk_render_background() instead, along with CSS
/// style classes to modify the color to be rendered.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="state">
/// state to retrieve the color for
/// </param>
/// <param name="color">
/// return value for the background color
/// </param>

	public static T GetBackgroundColor<T>(this T context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_background_color(context, state, out color);
		return context;
	}

/// <summary>
/// <para>
/// Gets the border for a given state as a #GtkBorder.
/// </para>
/// <para>
/// See gtk_style_context_get_property() and
/// #GTK_STYLE_PROPERTY_BORDER_WIDTH for details.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="state">
/// state to retrieve the border for
/// </param>
/// <param name="border">
/// return value for the border settings
/// </param>

	public static T GetBorder<T>(this T context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder border) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_border(context, state, out border);
		return context;
	}

/// <summary>
/// <para>
/// Gets the border color for a given state.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="state">
/// state to retrieve the color for
/// </param>
/// <param name="color">
/// return value for the border color
/// </param>

	public static T GetBorderColor<T>(this T context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_border_color(context, state, out color);
		return context;
	}

/// <summary>
/// <para>
/// Gets the foreground color for a given state.
/// </para>
/// <para>
/// See gtk_style_context_get_property() and
/// #GTK_STYLE_PROPERTY_COLOR for details.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="state">
/// state to retrieve the color for
/// </param>
/// <param name="color">
/// return value for the foreground color
/// </param>

	public static T GetColor<T>(this T context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_color(context, state, out color);
		return context;
	}

/// <summary>
/// <para>
/// Returns the widget direction used for rendering.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <return>
/// the widget direction
/// </return>

	public static MentorLake.Gtk.GtkTextDirection GetDirection(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_direction(context);
	}

/// <summary>
/// <para>
/// Returns the font description for a given state. The returned
/// object is const and will remain valid until the
/// #GtkStyleContext::changed signal happens.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="state">
/// state to retrieve the font for
/// </param>
/// <return>
/// the #PangoFontDescription for the given
///          state.  This object is owned by GTK+ and should not be
///          freed.
/// </return>

	public static MentorLake.Pango.PangoFontDescriptionHandle GetFont(this MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_font(context, state);
	}

/// <summary>
/// <para>
/// Returns the #GdkFrameClock to which @context is attached.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <return>
/// a #GdkFrameClock, or %NULL
///  if @context does not have an attached frame clock.
/// </return>

	public static MentorLake.Gdk.GdkFrameClockHandle GetFrameClock(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_frame_clock(context);
	}

/// <summary>
/// <para>
/// Returns the sides where rendered elements connect visually with others.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <return>
/// the junction sides
/// </return>

	public static MentorLake.Gtk.GtkJunctionSides GetJunctionSides(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_junction_sides(context);
	}

/// <summary>
/// <para>
/// Gets the margin for a given state as a #GtkBorder.
/// See gtk_style_property_get() and #GTK_STYLE_PROPERTY_MARGIN
/// for details.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="state">
/// state to retrieve the border for
/// </param>
/// <param name="margin">
/// return value for the margin settings
/// </param>

	public static T GetMargin<T>(this T context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder margin) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_margin(context, state, out margin);
		return context;
	}

/// <summary>
/// <para>
/// Gets the padding for a given state as a #GtkBorder.
/// See gtk_style_context_get() and #GTK_STYLE_PROPERTY_PADDING
/// for details.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="state">
/// state to retrieve the padding for
/// </param>
/// <param name="padding">
/// return value for the padding settings
/// </param>

	public static T GetPadding<T>(this T context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder padding) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_padding(context, state, out padding);
		return context;
	}

/// <summary>
/// <para>
/// Gets the parent context set via gtk_style_context_set_parent().
/// See that function for details.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <return>
/// the parent context or %NULL
/// </return>

	public static MentorLake.Gtk.GtkStyleContextHandle GetParent(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_parent(context);
	}

/// <summary>
/// <para>
/// Returns the widget path used for style matching.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <return>
/// A #GtkWidgetPath
/// </return>

	public static MentorLake.Gtk.GtkWidgetPathHandle GetPath(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_path(context);
	}

/// <summary>
/// <para>
/// Gets a style property from @context for the given state.
/// </para>
/// <para>
/// Note that not all CSS properties that are supported by GTK+ can be
/// retrieved in this way, since they may not be representable as #GValue.
/// GTK+ defines macros for a number of properties that can be used
/// with this function.
/// </para>
/// <para>
/// Note that passing a state other than the current state of @context
/// is not recommended unless the style context has been saved with
/// gtk_style_context_save().
/// </para>
/// <para>
/// When @value is no longer needed, g_value_unset() must be called
/// to free any allocated memory.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="property">
/// style property name
/// </param>
/// <param name="state">
/// state to retrieve the property value for
/// </param>
/// <param name="value">
/// return location for the style property value
/// </param>

	public static T GetProperty<T>(this T context, string property, MentorLake.Gtk.GtkStateFlags state, out MentorLake.GObject.GValue value) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_property(context, property, state, out value);
		return context;
	}

/// <summary>
/// <para>
/// Returns the scale used for assets.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <return>
/// the scale
/// </return>

	public static int GetScale(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_scale(context);
	}

/// <summary>
/// <para>
/// Returns the #GdkScreen to which @context is attached.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <return>
/// a #GdkScreen.
/// </return>

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_screen(context);
	}

/// <summary>
/// <para>
/// Queries the location in the CSS where @property was defined for the
/// current @context. Note that the state to be queried is taken from
/// gtk_style_context_get_state().
/// </para>
/// <para>
/// If the location is not available, %NULL will be returned. The
/// location might not be available for various reasons, such as the
/// property being overridden, @property not naming a supported CSS
/// property or tracking of definitions being disabled for performance
/// reasons.
/// </para>
/// <para>
/// Shorthand CSS properties cannot be queried for a location and will
/// always return %NULL.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="property">
/// style property name
/// </param>
/// <return>
/// %NULL or the section where a value
/// for @property was defined
/// </return>

	public static MentorLake.Gtk.GtkCssSectionHandle GetSection(this MentorLake.Gtk.GtkStyleContextHandle context, string property)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_section(context, property);
	}

/// <summary>
/// <para>
/// Returns the state used for style matching.
/// </para>
/// <para>
/// This method should only be used to retrieve the #GtkStateFlags
/// to pass to #GtkStyleContext methods, like gtk_style_context_get_padding().
/// If you need to retrieve the current state of a #GtkWidget, use
/// gtk_widget_get_state_flags().
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <return>
/// the state flags
/// </return>

	public static MentorLake.Gtk.GtkStateFlags GetState(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_get_state(context);
	}

/// <summary>
/// <para>
/// Retrieves several widget style properties from @context according to the
/// current style.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="@__arglist">
/// property name /return value pairs, followed by %NULL
/// </param>

	public static T GetStyle<T>(this T context, IntPtr @__arglist) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_style(context, @__arglist);
		return context;
	}

/// <summary>
/// <para>
/// Gets the value for a widget style property.
/// </para>
/// <para>
/// When @value is no longer needed, g_value_unset() must be called
/// to free any allocated memory.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="property_name">
/// the name of the widget style property
/// </param>
/// <param name="value">
/// Return location for the property value
/// </param>

	public static T GetStyleProperty<T>(this T context, string property_name, out MentorLake.GObject.GValue value) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_style_property(context, property_name, out value);
		return context;
	}

/// <summary>
/// <para>
/// Retrieves several widget style properties from @context according to the
/// current style.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="args">
/// va_list of property name/return location pairs, followed by %NULL
/// </param>

	public static T GetStyleValist<T>(this T context, IntPtr args) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_style_valist(context, args);
		return context;
	}

/// <summary>
/// <para>
/// Retrieves several style property values from @context for a given state.
/// </para>
/// <para>
/// See gtk_style_context_get_property() for details.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="state">
/// state to retrieve the property values for
/// </param>
/// <param name="args">
/// va_list of property name/return location pairs, followed by %NULL
/// </param>

	public static T GetValist<T>(this T context, MentorLake.Gtk.GtkStateFlags state, IntPtr args) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_get_valist(context, state, args);
		return context;
	}

/// <summary>
/// <para>
/// Returns %TRUE if @context currently has defined the
/// given class name.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="class_name">
/// a class name
/// </param>
/// <return>
/// %TRUE if @context has @class_name defined
/// </return>

	public static bool HasClass(this MentorLake.Gtk.GtkStyleContextHandle context, string class_name)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_has_class(context, class_name);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @context has the region defined.
/// If @flags_return is not %NULL, it is set to the flags
/// affecting the region.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="region_name">
/// a region name
/// </param>
/// <param name="flags_return">
/// return location for region flags
/// </param>
/// <return>
/// %TRUE if region is defined
/// </return>

	public static bool HasRegion(this MentorLake.Gtk.GtkStyleContextHandle context, string region_name, out MentorLake.Gtk.GtkRegionFlags flags_return)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_has_region(context, region_name, out flags_return);
	}

/// <summary>
/// <para>
/// Invalidates @context style information, so it will be reconstructed
/// again. It is useful if you modify the @context and need the new
/// information immediately.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext.
/// </param>

	public static T Invalidate<T>(this T context) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_invalidate(context);
		return context;
	}

/// <summary>
/// <para>
/// Returns the list of classes currently defined in @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <return>
/// a #GList of
///          strings with the currently defined classes. The contents
///          of the list are owned by GTK+, but you must free the list
///          itself with g_list_free() when you are done with it.
/// </return>

	public static MentorLake.GLib.GListHandle ListClasses(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_list_classes(context);
	}

/// <summary>
/// <para>
/// Returns the list of regions currently defined in @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <return>
/// a #GList of
///          strings with the currently defined regions. The contents
///          of the list are owned by GTK+, but you must free the list
///          itself with g_list_free() when you are done with it.
/// </return>

	public static MentorLake.GLib.GListHandle ListRegions(this MentorLake.Gtk.GtkStyleContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_list_regions(context);
	}

/// <summary>
/// <para>
/// Looks up and resolves a color name in the @context color map.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="color_name">
/// color name to lookup
/// </param>
/// <param name="color">
/// Return location for the looked up color
/// </param>
/// <return>
/// %TRUE if @color_name was found and resolved, %FALSE otherwise
/// </return>

	public static bool LookupColor(this MentorLake.Gtk.GtkStyleContextHandle context, string color_name, out MentorLake.Gdk.GdkRGBA color)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_lookup_color(context, color_name, out color);
	}

/// <summary>
/// <para>
/// Looks up @stock_id in the icon factories associated to @context and
/// the default icon factory, returning an icon set if found, otherwise
/// %NULL.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="stock_id">
/// an icon name
/// </param>
/// <return>
/// The looked up %GtkIconSet, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkIconSetHandle LookupIconSet(this MentorLake.Gtk.GtkStyleContextHandle context, string stock_id)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_lookup_icon_set(context, stock_id);
	}

/// <summary>
/// <para>
/// Notifies a state change on @context, so if the current style makes use
/// of transition animations, one will be started so all rendered elements
/// under @region_id are animated for state @state being set to value
/// @state_value.
/// </para>
/// <para>
/// The @window parameter is used in order to invalidate the rendered area
/// as the animation runs, so make sure it is the same window that is being
/// rendered on by the gtk_render_*() functions.
/// </para>
/// <para>
/// If @region_id is %NULL, all rendered elements using @context will be
/// affected by this state transition.
/// </para>
/// <para>
/// As a practical example, a #GtkButton notifying a state transition on
/// the prelight state:
/// |[ <!-- language="C" -->
/// gtk_style_context_notify_state_change (context,
///                                        gtk_widget_get_window (widget),
///                                        NULL,
///                                        GTK_STATE_PRELIGHT,
///                                        button->in_button);
/// ]|
/// </para>
/// <para>
/// Can be handled in the CSS file like this:
/// |[ <!-- language="CSS" -->
/// button {
///     background-color: #f00
/// }
/// </para>
/// <para>
/// button:hover {
///     background-color: #fff;
///     transition: 200ms linear
/// }
/// ]|
/// </para>
/// <para>
/// This combination will animate the button background from red to white
/// if a pointer enters the button, and back to red if the pointer leaves
/// the button.
/// </para>
/// <para>
/// Note that @state is used when finding the transition parameters, which
/// is why the style places the transition under the :hover pseudo-class.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="region_id">
/// animatable region to notify on, or %NULL.
///     See gtk_style_context_push_animatable_region()
/// </param>
/// <param name="state">
/// state to trigger transition for
/// </param>
/// <param name="state_value">
/// %TRUE if @state is the state we are changing to,
///     %FALSE if we are changing away from it
/// </param>

	public static T NotifyStateChange<T>(this T context, MentorLake.Gdk.GdkWindowHandle window, IntPtr region_id, MentorLake.Gtk.GtkStateType state, bool state_value) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_notify_state_change(context, window, region_id, state, state_value);
		return context;
	}

/// <summary>
/// <para>
/// Pops an animatable region from @context.
/// See gtk_style_context_push_animatable_region().
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>

	public static T PopAnimatableRegion<T>(this T context) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_pop_animatable_region(context);
		return context;
	}

/// <summary>
/// <para>
/// Pushes an animatable region, so all further gtk_render_*() calls between
/// this call and the following gtk_style_context_pop_animatable_region()
/// will potentially show transition animations for this region if
/// gtk_style_context_notify_state_change() is called for a given state,
/// and the current theme/style defines transition animations for state
/// changes.
/// </para>
/// <para>
/// The @region_id used must be unique in @context so the themes
/// can uniquely identify rendered elements subject to a state transition.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="region_id">
/// unique identifier for the animatable region
/// </param>

	public static T PushAnimatableRegion<T>(this T context, IntPtr region_id) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_push_animatable_region(context, region_id);
		return context;
	}

/// <summary>
/// <para>
/// Removes @class_name from @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="class_name">
/// class name to remove
/// </param>

	public static T RemoveClass<T>(this T context, string class_name) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_remove_class(context, class_name);
		return context;
	}

/// <summary>
/// <para>
/// Removes @provider from the style providers list in @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="provider">
/// a #GtkStyleProvider
/// </param>

	public static T RemoveProvider<T>(this T context, MentorLake.Gtk.GtkStyleProviderHandle provider) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_remove_provider(context, provider);
		return context;
	}

/// <summary>
/// <para>
/// Removes a region from @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="region_name">
/// region name to unset
/// </param>

	public static T RemoveRegion<T>(this T context, string region_name) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_remove_region(context, region_name);
		return context;
	}

/// <summary>
/// <para>
/// Restores @context state to a previous stage.
/// See gtk_style_context_save().
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>

	public static T Restore<T>(this T context) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_restore(context);
		return context;
	}

/// <summary>
/// <para>
/// Saves the @context state, so temporary modifications done through
/// gtk_style_context_add_class(), gtk_style_context_remove_class(),
/// gtk_style_context_set_state(), etc. can quickly be reverted
/// in one go through gtk_style_context_restore().
/// </para>
/// <para>
/// The matching call to gtk_style_context_restore() must be done
/// before GTK returns to the main loop.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>

	public static T Save<T>(this T context) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_save(context);
		return context;
	}

/// <summary>
/// <para>
/// This function is analogous to gdk_window_scroll(), and
/// should be called together with it so the invalidation
/// areas for any ongoing animation are scrolled together
/// with it.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="window">
/// a #GdkWindow used previously in
///          gtk_style_context_notify_state_change()
/// </param>
/// <param name="dx">
/// Amount to scroll in the X axis
/// </param>
/// <param name="dy">
/// Amount to scroll in the Y axis
/// </param>

	public static T ScrollAnimations<T>(this T context, MentorLake.Gdk.GdkWindowHandle window, int dx, int dy) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_scroll_animations(context, window, dx, dy);
		return context;
	}

/// <summary>
/// <para>
/// Sets the background of @window to the background pattern or
/// color specified in @context for its current state.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="window">
/// a #GdkWindow
/// </param>

	public static T SetBackground<T>(this T context, MentorLake.Gdk.GdkWindowHandle window) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_background(context, window);
		return context;
	}

/// <summary>
/// <para>
/// Sets the reading direction for rendering purposes.
/// </para>
/// <para>
/// If you are using a #GtkStyleContext returned from
/// gtk_widget_get_style_context(), you do not need to
/// call this yourself.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="direction">
/// the new direction.
/// </param>

	public static T SetDirection<T>(this T context, MentorLake.Gtk.GtkTextDirection direction) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_direction(context, direction);
		return context;
	}

/// <summary>
/// <para>
/// Attaches @context to the given frame clock.
/// </para>
/// <para>
/// The frame clock is used for the timing of animations.
/// </para>
/// <para>
/// If you are using a #GtkStyleContext returned from
/// gtk_widget_get_style_context(), you do not need to
/// call this yourself.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkFrameClock
/// </param>
/// <param name="frame_clock">
/// a #GdkFrameClock
/// </param>

	public static T SetFrameClock<T>(this T context, MentorLake.Gdk.GdkFrameClockHandle frame_clock) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_frame_clock(context, frame_clock);
		return context;
	}

/// <summary>
/// <para>
/// Sets the sides where rendered elements (mostly through
/// gtk_render_frame()) will visually connect with other visual elements.
/// </para>
/// <para>
/// This is merely a hint that may or may not be honored
/// by themes.
/// </para>
/// <para>
/// Container widgets are expected to set junction hints as appropriate
/// for their children, so it should not normally be necessary to call
/// this function manually.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="sides">
/// sides where rendered elements are visually connected to
///     other elements
/// </param>

	public static T SetJunctionSides<T>(this T context, MentorLake.Gtk.GtkJunctionSides sides) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_junction_sides(context, sides);
		return context;
	}

/// <summary>
/// <para>
/// Sets the parent style context for @context. The parent style
/// context is used to implement
/// [inheritance](http://www.w3.org/TR/css3-cascade/#inheritance)
/// of properties.
/// </para>
/// <para>
/// If you are using a #GtkStyleContext returned from
/// gtk_widget_get_style_context(), the parent will be set for you.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="parent">
/// the new parent or %NULL
/// </param>

	public static T SetParent<T>(this T context, MentorLake.Gtk.GtkStyleContextHandle parent) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_parent(context, parent);
		return context;
	}

/// <summary>
/// <para>
/// Sets the #GtkWidgetPath used for style matching. As a
/// consequence, the style will be regenerated to match
/// the new given path.
/// </para>
/// <para>
/// If you are using a #GtkStyleContext returned from
/// gtk_widget_get_style_context(), you do not need to call
/// this yourself.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="path">
/// a #GtkWidgetPath
/// </param>

	public static T SetPath<T>(this T context, MentorLake.Gtk.GtkWidgetPathHandle path) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_path(context, path);
		return context;
	}

/// <summary>
/// <para>
/// Sets the scale to use when getting image assets for the style.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="scale">
/// scale
/// </param>

	public static T SetScale<T>(this T context, int scale) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_scale(context, scale);
		return context;
	}

/// <summary>
/// <para>
/// Attaches @context to the given screen.
/// </para>
/// <para>
/// The screen is used to add style information from “global” style
/// providers, such as the screen’s #GtkSettings instance.
/// </para>
/// <para>
/// If you are using a #GtkStyleContext returned from
/// gtk_widget_get_style_context(), you do not need to
/// call this yourself.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="screen">
/// a #GdkScreen
/// </param>

	public static T SetScreen<T>(this T context, MentorLake.Gdk.GdkScreenHandle screen) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_screen(context, screen);
		return context;
	}

/// <summary>
/// <para>
/// Sets the state to be used for style matching.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="flags">
/// state to represent
/// </param>

	public static T SetState<T>(this T context, MentorLake.Gtk.GtkStateFlags flags) where T : GtkStyleContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		GtkStyleContextHandleExterns.gtk_style_context_set_state(context, flags);
		return context;
	}

/// <summary>
/// <para>
/// Returns %TRUE if there is a transition animation running for the
/// current region (see gtk_style_context_push_animatable_region()).
/// </para>
/// <para>
/// If @progress is not %NULL, the animation progress will be returned
/// there, 0.0 means the state is closest to being unset, while 1.0 means
/// it’s closest to being set. This means transition animation will
/// run from 0 to 1 when @state is being set and from 1 to 0 when
/// it’s being unset.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="state">
/// a widget state
/// </param>
/// <param name="progress">
/// return location for the transition progress
/// </param>
/// <return>
/// %TRUE if there is a running transition animation for @state.
/// </return>

	public static bool StateIsRunning(this MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateType state, out double progress)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_state_is_running(context, state, out progress);
	}

/// <summary>
/// <para>
/// Converts the style context into a string representation.
/// </para>
/// <para>
/// The string representation always includes information about
/// the name, state, id, visibility and style classes of the CSS
/// node that is backing @context. Depending on the flags, more
/// information may be included.
/// </para>
/// <para>
/// This function is intended for testing and debugging of the
/// CSS implementation in GTK+. There are no guarantees about
/// the format of the returned string, it may change.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <param name="flags">
/// Flags that determine what to print
/// </param>
/// <return>
/// a newly allocated string representing @context
/// </return>

	public static string ToString(this MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStyleContextPrintFlags flags)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkStyleContextHandle)");
		return GtkStyleContextHandleExterns.gtk_style_context_to_string(context, flags);
	}

}

internal class GtkStyleContextHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))]
	internal static extern MentorLake.Gtk.GtkStyleContextHandle gtk_style_context_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_add_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string class_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_add_provider([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider, uint priority);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_add_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string region_name, MentorLake.Gtk.GtkRegionFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_cancel_animations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, IntPtr region_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_background_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder border);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_border_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gdk.GdkRGBA color);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextDirection gtk_style_context_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle gtk_style_context_get_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))]
	internal static extern MentorLake.Gdk.GdkFrameClockHandle gtk_style_context_get_frame_clock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkJunctionSides gtk_style_context_get_junction_sides([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, out MentorLake.Gtk.GtkBorder padding);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))]
	internal static extern MentorLake.Gtk.GtkStyleContextHandle gtk_style_context_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_style_context_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string property, MentorLake.Gtk.GtkStateFlags state, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_style_context_get_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))]
	internal static extern MentorLake.Gdk.GdkScreenHandle gtk_style_context_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCssSectionHandle>))]
	internal static extern MentorLake.Gtk.GtkCssSectionHandle gtk_style_context_get_section([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string property);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStateFlags gtk_style_context_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_style_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string property_name, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_style_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, IntPtr args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags state, IntPtr args);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_context_has_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string class_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_context_has_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string region_name, out MentorLake.Gtk.GtkRegionFlags flags_return);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_invalidate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_style_context_list_classes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_style_context_list_regions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_context_lookup_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string color_name, out MentorLake.Gdk.GdkRGBA color);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconSetHandle>))]
	internal static extern MentorLake.Gtk.GtkIconSetHandle gtk_style_context_lookup_icon_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_notify_state_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, IntPtr region_id, MentorLake.Gtk.GtkStateType state, bool state_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_pop_animatable_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_push_animatable_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, IntPtr region_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_remove_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string class_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_remove_provider([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_remove_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, string region_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_restore([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_save([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_scroll_animations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, int dx, int dy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_background([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkTextDirection direction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_frame_clock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkFrameClockHandle>))] MentorLake.Gdk.GdkFrameClockHandle frame_clock);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_junction_sides([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkJunctionSides sides);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, int scale);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_set_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_style_context_state_is_running([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStateType state, out double progress);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_style_context_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context, MentorLake.Gtk.GtkStyleContextPrintFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_add_provider_for_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider, uint priority);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_remove_provider_for_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleProviderHandleImpl>))] MentorLake.Gtk.GtkStyleProviderHandle provider);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_style_context_reset_widgets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

}
