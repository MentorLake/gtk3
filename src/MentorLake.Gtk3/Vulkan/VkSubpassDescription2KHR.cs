namespace MentorLake.Vulkan;


public class VkSubpassDescription2KHRHandle : BaseSafeHandle
{
}


public static class VkSubpassDescription2KHRExtensions
{

	public static VkSubpassDescription2KHR Dereference(this VkSubpassDescription2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubpassDescription2KHR>(x.DangerousGetHandle());
}
internal class VkSubpassDescription2KHRExterns
{
}


public struct VkSubpassDescription2KHR
{
}
