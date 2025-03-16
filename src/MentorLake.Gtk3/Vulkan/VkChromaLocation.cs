namespace MentorLake.Vulkan;

public class VkChromaLocationHandle : BaseSafeHandle
{
}


public static class VkChromaLocationExtensions
{

	public static VkChromaLocation Dereference(this VkChromaLocationHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkChromaLocation>(x.DangerousGetHandle());
}
internal class VkChromaLocationExterns
{
}

public struct VkChromaLocation
{
}
