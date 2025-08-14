namespace MentorLake.Vulkan;


public class VkMicromapCreateFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkMicromapCreateFlagBitsEXTExtensions
{

	public static VkMicromapCreateFlagBitsEXT Dereference(this VkMicromapCreateFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMicromapCreateFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkMicromapCreateFlagBitsEXTExterns
{
}


public struct VkMicromapCreateFlagBitsEXT
{
}
