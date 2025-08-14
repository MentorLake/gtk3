namespace MentorLake.Vulkan;


public class VkAccessFlagBits2KHRHandle : BaseSafeHandle
{
}


public static class VkAccessFlagBits2KHRExtensions
{

	public static VkAccessFlagBits2KHR Dereference(this VkAccessFlagBits2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccessFlagBits2KHR>(x.DangerousGetHandle());
}
internal class VkAccessFlagBits2KHRExterns
{
}


public struct VkAccessFlagBits2KHR
{
}
