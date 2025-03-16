namespace MentorLake.Vulkan;

public class VkValidationFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkValidationFlagsEXTExtensions
{

	public static VkValidationFlagsEXT Dereference(this VkValidationFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkValidationFlagsEXT>(x.DangerousGetHandle());
}
internal class VkValidationFlagsEXTExterns
{
}

public struct VkValidationFlagsEXT
{
}
