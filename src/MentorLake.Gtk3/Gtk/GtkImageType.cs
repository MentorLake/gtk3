namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes the image data representation used by a #GtkImage. If you
/// want to get the image from the widget, you can only get the
/// currently-stored representation. e.g.  if the
/// gtk_image_get_storage_type() returns #GTK_IMAGE_PIXBUF, then you can
/// call gtk_image_get_pixbuf() but not gtk_image_get_stock().  For empty
/// images, you can request any storage type (call any of the "get"
/// functions), but they will all return %NULL values.
/// </para>
/// </summary>

[Flags]
public enum GtkImageType
{
/// <summary>
/// <para>
/// there is no image displayed by the widget
/// </para>
/// </summary>

	GTK_IMAGE_EMPTY = 0,
/// <summary>
/// <para>
/// the widget contains a #GdkPixbuf
/// </para>
/// </summary>

	GTK_IMAGE_PIXBUF = 1,
/// <summary>
/// <para>
/// the widget contains a [stock item name][gtkstock]
/// </para>
/// </summary>

	GTK_IMAGE_STOCK = 2,
/// <summary>
/// <para>
/// the widget contains a #GtkIconSet
/// </para>
/// </summary>

	GTK_IMAGE_ICON_SET = 3,
/// <summary>
/// <para>
/// the widget contains a #GdkPixbufAnimation
/// </para>
/// </summary>

	GTK_IMAGE_ANIMATION = 4,
/// <summary>
/// <para>
/// the widget contains a named icon.
///  This image type was added in GTK+ 2.6
/// </para>
/// </summary>

	GTK_IMAGE_ICON_NAME = 5,
/// <summary>
/// <para>
/// the widget contains a #GIcon.
///  This image type was added in GTK+ 2.14
/// </para>
/// </summary>

	GTK_IMAGE_GICON = 6,
/// <summary>
/// <para>
/// the widget contains a #cairo_surface_t.
///  This image type was added in GTK+ 3.10
/// </para>
/// </summary>

	GTK_IMAGE_SURFACE = 7
}
