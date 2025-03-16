namespace MentorLake.Vulkan;

public class VkCompareOpHandle : BaseSafeHandle
{
}


public static class VkCompareOpExtensions
{

	public static VkCompareOp Dereference(this VkCompareOpHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCompareOp>(x.DangerousGetHandle());
}
internal class VkCompareOpExterns
{
}

public struct VkCompareOp
{
}
