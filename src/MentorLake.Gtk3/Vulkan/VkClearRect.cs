namespace MentorLake.Vulkan;

public class VkClearRectHandle : BaseSafeHandle
{
}


public static class VkClearRectExtensions
{

	public static VkClearRect Dereference(this VkClearRectHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkClearRect>(x.DangerousGetHandle());
}
internal class VkClearRectExterns
{
}

public struct VkClearRect
{
}
