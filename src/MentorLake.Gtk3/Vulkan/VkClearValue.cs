namespace MentorLake.Vulkan;

public class VkClearValueHandle : BaseSafeHandle
{
}


public static class VkClearValueExtensions
{

	public static VkClearValue Dereference(this VkClearValueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkClearValue>(x.DangerousGetHandle());
}
internal class VkClearValueExterns
{
}

public struct VkClearValue
{
}
