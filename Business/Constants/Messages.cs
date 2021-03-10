using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string DealerNotAdded = "Satıcı eklenemedi";
        public static string DealerAdded = "Satıcı eklendi";
        public static string DealerDeleted = "Satıcı silindi";
        public static string DealerNotDeleted = "Satıcı silinemedi";
        public static string DealerUpdated = "Satıcı güncellendi";
        public static string DealerNotUpdated = "Satıcı güncellenemedi";
        public static string DealerListed = "Satıcılar listelendi";
        public static string DealerNotListed = "Satıcılar listelenemedi";
        public static string DealerGeted = "Satıcı getirildi";
        public static string DealerNotGeted = "Satıcı getirilemedi";
        public static string DealerDetailsGetSuccess = "Satıcı ayrıntılı listesi getirildi";
        public static string DealerDetailsGetError = "Satıcı ayrıntılı listesi getirilemedi";

        public static string StatusNotAdded = "Durum eklenemedi";
        public static string StatusAdded = "Durum eklendi";
        public static string StatusDeleted = "Durum silindi";
        public static string StatusNotDeleted = "Durum silinemedi";
        public static string StatusUpdated = "Durum güncellendi";
        public static string StatusNotUpdated = "Durum güncellenemedi";
        public static string StatusListed = "Durumlar listelendi";
        public static string StatusNotListed = "Durumlar listelenemedi";
        public static string StatusGeted = "Durum getirildi";
        public static string StatusNotGeted = "Durum getirilemedi";
        public static string StatusDetailsGetSuccess = "Durum ayrıntılı listesi getirildi";
        public static string StatusDetailsGetError = "Durum ayrıntılı listesi getirilemedi";

        public static string PacketNotAdded = "Paket eklenemedi";
        public static string PacketAdded = "Paket eklendi";
        public static string PacketDeleted = "Paket silindi";
        public static string PacketNotDeleted = "Paket silinemedi";
        public static string PacketUpdated = "Paket güncellendi";
        public static string PacketNotUpdated = "Paket güncellenemedi";
        public static string PacketListed = "Paketler listelendi";
        public static string PacketNotListed = "Paketler listelenemedi";
        public static string PacketGeted = "Paket getirildi";
        public static string PacketNotGeted = "Paket getirilemedi";
        public static string PacketDetailsGetSuccess = "Paket ayrıntılı listesi getirildi";
        public static string PacketDetailsGetError = "Paket ayrıntılı listesi getirilemedi";


        public static string MaintenanceTime = "Bakım zamanı";
        internal static string DealerLimitIsOver = "Satıcı limiti aşıldı.";
        public static string DealerNameExists = "Aynı isimli satıcı daha önceden eklenmiş";
    }
}
