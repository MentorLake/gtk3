namespace MentorLake.Vulkan;

public class VkBlendFactorHandle : BaseSafeHandle
{
}


public static class VkBlendFactorExtensions
{

	public static VkBlendFactor Dereference(this VkBlendFactorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBlendFactor>(x.DangerousGetHandle());
}
internal class VkBlendFactorExterns
{
}

public struct VkBlendFactor
{
}
