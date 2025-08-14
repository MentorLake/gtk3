namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Used in #GdkDragContext to indicate the protocol according to
/// which DND is done.
/// </para>
/// </summary>

[Flags]
public enum GdkDragProtocol
{
/// <summary>
/// <para>
/// no protocol.
/// </para>
/// </summary>

	GDK_DRAG_PROTO_NONE = 0,
/// <summary>
/// <para>
/// The Motif DND protocol. No longer supported
/// </para>
/// </summary>

	GDK_DRAG_PROTO_MOTIF = 1,
/// <summary>
/// <para>
/// The Xdnd protocol.
/// </para>
/// </summary>

	GDK_DRAG_PROTO_XDND = 2,
/// <summary>
/// <para>
/// An extension to the Xdnd protocol for
///  unclaimed root window drops.
/// </para>
/// </summary>

	GDK_DRAG_PROTO_ROOTWIN = 3,
/// <summary>
/// <para>
/// The simple WM_DROPFILES protocol.
/// </para>
/// </summary>

	GDK_DRAG_PROTO_WIN32_DROPFILES = 4,
/// <summary>
/// <para>
/// The complex OLE2 DND protocol (not implemented).
/// </para>
/// </summary>

	GDK_DRAG_PROTO_OLE2 = 5,
/// <summary>
/// <para>
/// Intra-application DND.
/// </para>
/// </summary>

	GDK_DRAG_PROTO_LOCAL = 6,
/// <summary>
/// <para>
/// Wayland DND protocol.
/// </para>
/// </summary>

	GDK_DRAG_PROTO_WAYLAND = 7
}
