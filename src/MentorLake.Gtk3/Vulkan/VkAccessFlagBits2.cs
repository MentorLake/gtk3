namespace MentorLake.Vulkan;


public class VkAccessFlagBits2Handle : BaseSafeHandle
{
}


public static class VkAccessFlagBits2Extensions
{

	public static VkAccessFlagBits2 Dereference(this VkAccessFlagBits2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccessFlagBits2>(x.DangerousGetHandle());
}
internal class VkAccessFlagBits2Externs
{
}


public struct VkAccessFlagBits2
{
}
