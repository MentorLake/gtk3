namespace MentorLake.Vulkan;

public class VkBlockMatchWindowCompareModeQCOMHandle : BaseSafeHandle
{
}


public static class VkBlockMatchWindowCompareModeQCOMExtensions
{

	public static VkBlockMatchWindowCompareModeQCOM Dereference(this VkBlockMatchWindowCompareModeQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBlockMatchWindowCompareModeQCOM>(x.DangerousGetHandle());
}
internal class VkBlockMatchWindowCompareModeQCOMExterns
{
}

public struct VkBlockMatchWindowCompareModeQCOM
{
}
