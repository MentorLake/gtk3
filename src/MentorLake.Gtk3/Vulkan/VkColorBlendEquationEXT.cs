namespace MentorLake.Vulkan;

public class VkColorBlendEquationEXTHandle : BaseSafeHandle
{
}


public static class VkColorBlendEquationEXTExtensions
{

	public static VkColorBlendEquationEXT Dereference(this VkColorBlendEquationEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkColorBlendEquationEXT>(x.DangerousGetHandle());
}
internal class VkColorBlendEquationEXTExterns
{
}

public struct VkColorBlendEquationEXT
{
}
