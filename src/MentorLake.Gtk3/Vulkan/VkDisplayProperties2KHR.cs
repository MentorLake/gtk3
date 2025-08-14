namespace MentorLake.Vulkan;


public class VkDisplayProperties2KHRHandle : BaseSafeHandle
{
}


public static class VkDisplayProperties2KHRExtensions
{

	public static VkDisplayProperties2KHR Dereference(this VkDisplayProperties2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayProperties2KHR>(x.DangerousGetHandle());
}
internal class VkDisplayProperties2KHRExterns
{
}


public struct VkDisplayProperties2KHR
{
}
