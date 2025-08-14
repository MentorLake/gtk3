namespace MentorLake.Vulkan;


public class VkAccessFlags2KHRHandle : BaseSafeHandle
{
}


public static class VkAccessFlags2KHRExtensions
{

	public static VkAccessFlags2KHR Dereference(this VkAccessFlags2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccessFlags2KHR>(x.DangerousGetHandle());
}
internal class VkAccessFlags2KHRExterns
{
}


public struct VkAccessFlags2KHR
{
}
