
namespace Interfase_Computer_Disk
{
    interface IRemoveableDisk
    {
        bool HasDisk { get; }

        void Insert();
        void Reject();
    }
}
