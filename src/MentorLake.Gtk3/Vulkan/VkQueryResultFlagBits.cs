namespace MentorLake.Vulkan;

public class VkQueryResultFlagBitsHandle : BaseSafeHandle
{
}


public static class VkQueryResultFlagBitsExtensions
{

	public static VkQueryResultFlagBits Dereference(this VkQueryResultFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryResultFlagBits>(x.DangerousGetHandle());
}
internal class VkQueryResultFlagBitsExterns
{
}

public struct VkQueryResultFlagBits
{
}
