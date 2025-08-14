namespace MentorLake.Vulkan;


public class VkClearColorValueHandle : BaseSafeHandle
{
}


public static class VkClearColorValueExtensions
{

	public static VkClearColorValue Dereference(this VkClearColorValueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkClearColorValue>(x.DangerousGetHandle());
}
internal class VkClearColorValueExterns
{
}


public struct VkClearColorValue
{
}
