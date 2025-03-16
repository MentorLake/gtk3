namespace MentorLake.Vulkan;

public class VkBlendOpHandle : BaseSafeHandle
{
}


public static class VkBlendOpExtensions
{

	public static VkBlendOp Dereference(this VkBlendOpHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBlendOp>(x.DangerousGetHandle());
}
internal class VkBlendOpExterns
{
}

public struct VkBlendOp
{
}
