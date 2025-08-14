namespace MentorLake.Vulkan;


public class VkFormatProperties3KHRHandle : BaseSafeHandle
{
}


public static class VkFormatProperties3KHRExtensions
{

	public static VkFormatProperties3KHR Dereference(this VkFormatProperties3KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFormatProperties3KHR>(x.DangerousGetHandle());
}
internal class VkFormatProperties3KHRExterns
{
}


public struct VkFormatProperties3KHR
{
}
