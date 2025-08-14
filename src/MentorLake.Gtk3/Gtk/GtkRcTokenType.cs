namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkRcTokenType enumeration represents the tokens
/// in the RC file. It is exposed so that theme engines
/// can reuse these tokens when parsing the theme-engine
/// specific portions of a RC file.
/// </para>
/// </summary>

[Flags]
public enum GtkRcTokenType
{
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_INVALID = 270,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_INCLUDE = 271,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_NORMAL = 272,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_ACTIVE = 273,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_PRELIGHT = 274,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_SELECTED = 275,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_INSENSITIVE = 276,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_FG = 277,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_BG = 278,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_TEXT = 279,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_BASE = 280,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_XTHICKNESS = 281,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_YTHICKNESS = 282,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_FONT = 283,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_FONTSET = 284,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_FONT_NAME = 285,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_BG_PIXMAP = 286,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_PIXMAP_PATH = 287,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_STYLE = 288,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_BINDING = 289,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_BIND = 290,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_WIDGET = 291,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_WIDGET_CLASS = 292,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_CLASS = 293,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_LOWEST = 294,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_GTK = 295,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_APPLICATION = 296,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_THEME = 297,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_RC = 298,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_HIGHEST = 299,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_ENGINE = 300,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_MODULE_PATH = 301,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_IM_MODULE_PATH = 302,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_IM_MODULE_FILE = 303,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_STOCK = 304,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_LTR = 305,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_RTL = 306,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_COLOR = 307,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_UNBIND = 308,
/// <summary>
/// <para>
/// Deprecated
/// </para>
/// </summary>

	GTK_RC_TOKEN_LAST = 309
}
