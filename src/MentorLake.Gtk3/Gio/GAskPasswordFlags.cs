namespace MentorLake.Gio;

[Flags]
public enum GAskPasswordFlags : long
{
	G_ASK_PASSWORD_NEED_PASSWORD = 1,
	G_ASK_PASSWORD_NEED_USERNAME = 2,
	G_ASK_PASSWORD_NEED_DOMAIN = 4,
	G_ASK_PASSWORD_SAVING_SUPPORTED = 8,
	G_ASK_PASSWORD_ANONYMOUS_SUPPORTED = 16,
	G_ASK_PASSWORD_TCRYPT = 32
}
