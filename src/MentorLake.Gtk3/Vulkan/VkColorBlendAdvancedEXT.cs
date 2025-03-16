namespace MentorLake.Vulkan;

public class VkColorBlendAdvancedEXTHandle : BaseSafeHandle
{
}


public static class VkColorBlendAdvancedEXTExtensions
{

	public static VkColorBlendAdvancedEXT Dereference(this VkColorBlendAdvancedEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkColorBlendAdvancedEXT>(x.DangerousGetHandle());
}
internal class VkColorBlendAdvancedEXTExterns
{
}

public struct VkColorBlendAdvancedEXT
{
}
