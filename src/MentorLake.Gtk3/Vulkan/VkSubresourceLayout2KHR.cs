namespace MentorLake.Vulkan;


public class VkSubresourceLayout2KHRHandle : BaseSafeHandle
{
}


public static class VkSubresourceLayout2KHRExtensions
{

	public static VkSubresourceLayout2KHR Dereference(this VkSubresourceLayout2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubresourceLayout2KHR>(x.DangerousGetHandle());
}
internal class VkSubresourceLayout2KHRExterns
{
}


public struct VkSubresourceLayout2KHR
{
}
