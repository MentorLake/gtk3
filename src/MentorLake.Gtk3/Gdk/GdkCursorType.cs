namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Predefined cursors.
/// </para>
/// <para>
/// Note that these IDs are directly taken from the X cursor font, and many
/// of these cursors are either not useful, or are not available on other platforms.
/// </para>
/// <para>
/// The recommended way to create cursors is to use gdk_cursor_new_from_name().
/// </para>
/// </summary>

[Flags]
public enum GdkCursorType
{
/// <summary>
/// <para>
/// ![](X_cursor.png)
/// </para>
/// </summary>

	GDK_X_CURSOR = 0,
/// <summary>
/// <para>
/// ![](arrow.png)
/// </para>
/// </summary>

	GDK_ARROW = 2,
/// <summary>
/// <para>
/// ![](based_arrow_down.png)
/// </para>
/// </summary>

	GDK_BASED_ARROW_DOWN = 4,
/// <summary>
/// <para>
/// ![](based_arrow_up.png)
/// </para>
/// </summary>

	GDK_BASED_ARROW_UP = 6,
/// <summary>
/// <para>
/// ![](boat.png)
/// </para>
/// </summary>

	GDK_BOAT = 8,
/// <summary>
/// <para>
/// ![](bogosity.png)
/// </para>
/// </summary>

	GDK_BOGOSITY = 10,
/// <summary>
/// <para>
/// ![](bottom_left_corner.png)
/// </para>
/// </summary>

	GDK_BOTTOM_LEFT_CORNER = 12,
/// <summary>
/// <para>
/// ![](bottom_right_corner.png)
/// </para>
/// </summary>

	GDK_BOTTOM_RIGHT_CORNER = 14,
/// <summary>
/// <para>
/// ![](bottom_side.png)
/// </para>
/// </summary>

	GDK_BOTTOM_SIDE = 16,
/// <summary>
/// <para>
/// ![](bottom_tee.png)
/// </para>
/// </summary>

	GDK_BOTTOM_TEE = 18,
/// <summary>
/// <para>
/// ![](box_spiral.png)
/// </para>
/// </summary>

	GDK_BOX_SPIRAL = 20,
/// <summary>
/// <para>
/// ![](center_ptr.png)
/// </para>
/// </summary>

	GDK_CENTER_PTR = 22,
/// <summary>
/// <para>
/// ![](circle.png)
/// </para>
/// </summary>

	GDK_CIRCLE = 24,
/// <summary>
/// <para>
/// ![](clock.png)
/// </para>
/// </summary>

	GDK_CLOCK = 26,
/// <summary>
/// <para>
/// ![](coffee_mug.png)
/// </para>
/// </summary>

	GDK_COFFEE_MUG = 28,
/// <summary>
/// <para>
/// ![](cross.png)
/// </para>
/// </summary>

	GDK_CROSS = 30,
/// <summary>
/// <para>
/// ![](cross_reverse.png)
/// </para>
/// </summary>

	GDK_CROSS_REVERSE = 32,
/// <summary>
/// <para>
/// ![](crosshair.png)
/// </para>
/// </summary>

	GDK_CROSSHAIR = 34,
/// <summary>
/// <para>
/// ![](diamond_cross.png)
/// </para>
/// </summary>

	GDK_DIAMOND_CROSS = 36,
/// <summary>
/// <para>
/// ![](dot.png)
/// </para>
/// </summary>

	GDK_DOT = 38,
/// <summary>
/// <para>
/// ![](dotbox.png)
/// </para>
/// </summary>

	GDK_DOTBOX = 40,
/// <summary>
/// <para>
/// ![](double_arrow.png)
/// </para>
/// </summary>

	GDK_DOUBLE_ARROW = 42,
/// <summary>
/// <para>
/// ![](draft_large.png)
/// </para>
/// </summary>

	GDK_DRAFT_LARGE = 44,
/// <summary>
/// <para>
/// ![](draft_small.png)
/// </para>
/// </summary>

	GDK_DRAFT_SMALL = 46,
/// <summary>
/// <para>
/// ![](draped_box.png)
/// </para>
/// </summary>

	GDK_DRAPED_BOX = 48,
/// <summary>
/// <para>
/// ![](exchange.png)
/// </para>
/// </summary>

	GDK_EXCHANGE = 50,
/// <summary>
/// <para>
/// ![](fleur.png)
/// </para>
/// </summary>

	GDK_FLEUR = 52,
/// <summary>
/// <para>
/// ![](gobbler.png)
/// </para>
/// </summary>

	GDK_GOBBLER = 54,
/// <summary>
/// <para>
/// ![](gumby.png)
/// </para>
/// </summary>

	GDK_GUMBY = 56,
/// <summary>
/// <para>
/// ![](hand1.png)
/// </para>
/// </summary>

	GDK_HAND1 = 58,
/// <summary>
/// <para>
/// ![](hand2.png)
/// </para>
/// </summary>

	GDK_HAND2 = 60,
/// <summary>
/// <para>
/// ![](heart.png)
/// </para>
/// </summary>

	GDK_HEART = 62,
/// <summary>
/// <para>
/// ![](icon.png)
/// </para>
/// </summary>

	GDK_ICON = 64,
/// <summary>
/// <para>
/// ![](iron_cross.png)
/// </para>
/// </summary>

	GDK_IRON_CROSS = 66,
/// <summary>
/// <para>
/// ![](left_ptr.png)
/// </para>
/// </summary>

	GDK_LEFT_PTR = 68,
/// <summary>
/// <para>
/// ![](left_side.png)
/// </para>
/// </summary>

	GDK_LEFT_SIDE = 70,
/// <summary>
/// <para>
/// ![](left_tee.png)
/// </para>
/// </summary>

	GDK_LEFT_TEE = 72,
/// <summary>
/// <para>
/// ![](leftbutton.png)
/// </para>
/// </summary>

	GDK_LEFTBUTTON = 74,
/// <summary>
/// <para>
/// ![](ll_angle.png)
/// </para>
/// </summary>

	GDK_LL_ANGLE = 76,
/// <summary>
/// <para>
/// ![](lr_angle.png)
/// </para>
/// </summary>

	GDK_LR_ANGLE = 78,
/// <summary>
/// <para>
/// ![](man.png)
/// </para>
/// </summary>

	GDK_MAN = 80,
/// <summary>
/// <para>
/// ![](middlebutton.png)
/// </para>
/// </summary>

	GDK_MIDDLEBUTTON = 82,
/// <summary>
/// <para>
/// ![](mouse.png)
/// </para>
/// </summary>

	GDK_MOUSE = 84,
/// <summary>
/// <para>
/// ![](pencil.png)
/// </para>
/// </summary>

	GDK_PENCIL = 86,
/// <summary>
/// <para>
/// ![](pirate.png)
/// </para>
/// </summary>

	GDK_PIRATE = 88,
/// <summary>
/// <para>
/// ![](plus.png)
/// </para>
/// </summary>

	GDK_PLUS = 90,
/// <summary>
/// <para>
/// ![](question_arrow.png)
/// </para>
/// </summary>

	GDK_QUESTION_ARROW = 92,
/// <summary>
/// <para>
/// ![](right_ptr.png)
/// </para>
/// </summary>

	GDK_RIGHT_PTR = 94,
/// <summary>
/// <para>
/// ![](right_side.png)
/// </para>
/// </summary>

	GDK_RIGHT_SIDE = 96,
/// <summary>
/// <para>
/// ![](right_tee.png)
/// </para>
/// </summary>

	GDK_RIGHT_TEE = 98,
/// <summary>
/// <para>
/// ![](rightbutton.png)
/// </para>
/// </summary>

	GDK_RIGHTBUTTON = 100,
/// <summary>
/// <para>
/// ![](rtl_logo.png)
/// </para>
/// </summary>

	GDK_RTL_LOGO = 102,
/// <summary>
/// <para>
/// ![](sailboat.png)
/// </para>
/// </summary>

	GDK_SAILBOAT = 104,
/// <summary>
/// <para>
/// ![](sb_down_arrow.png)
/// </para>
/// </summary>

	GDK_SB_DOWN_ARROW = 106,
/// <summary>
/// <para>
/// ![](sb_h_double_arrow.png)
/// </para>
/// </summary>

	GDK_SB_H_DOUBLE_ARROW = 108,
/// <summary>
/// <para>
/// ![](sb_left_arrow.png)
/// </para>
/// </summary>

	GDK_SB_LEFT_ARROW = 110,
/// <summary>
/// <para>
/// ![](sb_right_arrow.png)
/// </para>
/// </summary>

	GDK_SB_RIGHT_ARROW = 112,
/// <summary>
/// <para>
/// ![](sb_up_arrow.png)
/// </para>
/// </summary>

	GDK_SB_UP_ARROW = 114,
/// <summary>
/// <para>
/// ![](sb_v_double_arrow.png)
/// </para>
/// </summary>

	GDK_SB_V_DOUBLE_ARROW = 116,
/// <summary>
/// <para>
/// ![](shuttle.png)
/// </para>
/// </summary>

	GDK_SHUTTLE = 118,
/// <summary>
/// <para>
/// ![](sizing.png)
/// </para>
/// </summary>

	GDK_SIZING = 120,
/// <summary>
/// <para>
/// ![](spider.png)
/// </para>
/// </summary>

	GDK_SPIDER = 122,
/// <summary>
/// <para>
/// ![](spraycan.png)
/// </para>
/// </summary>

	GDK_SPRAYCAN = 124,
/// <summary>
/// <para>
/// ![](star.png)
/// </para>
/// </summary>

	GDK_STAR = 126,
/// <summary>
/// <para>
/// ![](target.png)
/// </para>
/// </summary>

	GDK_TARGET = 128,
/// <summary>
/// <para>
/// ![](tcross.png)
/// </para>
/// </summary>

	GDK_TCROSS = 130,
/// <summary>
/// <para>
/// ![](top_left_arrow.png)
/// </para>
/// </summary>

	GDK_TOP_LEFT_ARROW = 132,
/// <summary>
/// <para>
/// ![](top_left_corner.png)
/// </para>
/// </summary>

	GDK_TOP_LEFT_CORNER = 134,
/// <summary>
/// <para>
/// ![](top_right_corner.png)
/// </para>
/// </summary>

	GDK_TOP_RIGHT_CORNER = 136,
/// <summary>
/// <para>
/// ![](top_side.png)
/// </para>
/// </summary>

	GDK_TOP_SIDE = 138,
/// <summary>
/// <para>
/// ![](top_tee.png)
/// </para>
/// </summary>

	GDK_TOP_TEE = 140,
/// <summary>
/// <para>
/// ![](trek.png)
/// </para>
/// </summary>

	GDK_TREK = 142,
/// <summary>
/// <para>
/// ![](ul_angle.png)
/// </para>
/// </summary>

	GDK_UL_ANGLE = 144,
/// <summary>
/// <para>
/// ![](umbrella.png)
/// </para>
/// </summary>

	GDK_UMBRELLA = 146,
/// <summary>
/// <para>
/// ![](ur_angle.png)
/// </para>
/// </summary>

	GDK_UR_ANGLE = 148,
/// <summary>
/// <para>
/// ![](watch.png)
/// </para>
/// </summary>

	GDK_WATCH = 150,
/// <summary>
/// <para>
/// ![](xterm.png)
/// </para>
/// </summary>

	GDK_XTERM = 152,
/// <summary>
/// <para>
/// last cursor type
/// </para>
/// </summary>

	GDK_LAST_CURSOR = 153,
/// <summary>
/// <para>
/// Blank cursor. Since 2.16
/// </para>
/// </summary>

	GDK_BLANK_CURSOR = -2,
/// <summary>
/// <para>
/// type of cursors constructed with
///   gdk_cursor_new_from_pixbuf()
/// </para>
/// </summary>

	GDK_CURSOR_IS_PIXMAP = -1
}
