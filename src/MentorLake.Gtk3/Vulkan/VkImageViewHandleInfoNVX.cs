namespace MentorLake.Vulkan;


public class VkImageViewHandleInfoNVXHandle : BaseSafeHandle
{
}


public static class VkImageViewHandleInfoNVXExtensions
{

	public static VkImageViewHandleInfoNVX Dereference(this VkImageViewHandleInfoNVXHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageViewHandleInfoNVX>(x.DangerousGetHandle());
}
internal class VkImageViewHandleInfoNVXExterns
{
}


public struct VkImageViewHandleInfoNVX
{
}
