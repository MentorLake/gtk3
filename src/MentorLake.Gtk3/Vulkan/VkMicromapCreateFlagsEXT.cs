namespace MentorLake.Vulkan;

public class VkMicromapCreateFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkMicromapCreateFlagsEXTExtensions
{

	public static VkMicromapCreateFlagsEXT Dereference(this VkMicromapCreateFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMicromapCreateFlagsEXT>(x.DangerousGetHandle());
}
internal class VkMicromapCreateFlagsEXTExterns
{
}

public struct VkMicromapCreateFlagsEXT
{
}
