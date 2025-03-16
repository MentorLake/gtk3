namespace MentorLake.Vulkan;

public class VkImageBlit2KHRHandle : BaseSafeHandle
{
}


public static class VkImageBlit2KHRExtensions
{

	public static VkImageBlit2KHR Dereference(this VkImageBlit2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageBlit2KHR>(x.DangerousGetHandle());
}
internal class VkImageBlit2KHRExterns
{
}

public struct VkImageBlit2KHR
{
}
