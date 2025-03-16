namespace MentorLake.Vulkan;

public class VkOffset3DHandle : BaseSafeHandle
{
}


public static class VkOffset3DExtensions
{

	public static VkOffset3D Dereference(this VkOffset3DHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOffset3D>(x.DangerousGetHandle());
}
internal class VkOffset3DExterns
{
}

public struct VkOffset3D
{
}
